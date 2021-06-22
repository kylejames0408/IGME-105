using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LevelEditor
{
    public partial class EditorForm : Form
    {
        // Fields
        private bool saved;
        private int boxSize;
        private int height;
        private int width;
        private string fileName;
        private Color color;
        private List<PictureBox> pictureBoxes;

        // Constructors
        /// <summary>
        /// Constructs the editor.
        /// </summary>
        /// <param name="mainForm">The main form.</param>
        public EditorForm(int height, int width, string fileName = null)
        {
            // Initialize fields
            saved = true;
            this.height = height;
            this.width = width;
            this.fileName = fileName;
            pictureBoxes = new List<PictureBox>();

            // NOTES:
            // Top Left Boundary - X:145, Y:30
            // Top Right Boundary - X:730, Y:30 [Subtract width of box to get location for x]
            // Bottom Right Boundary - X:730, Y:605 [Subtract width/height of box to get location for x/y]
            // Bottom Left Boundary - X: 145, Y:605 [Subtract height of box to get location for y]

            // Get size for boxes
            boxSize = 575 / height;

            // Creates map area for drawing
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Create a new picture box
                    PictureBox pictureBox = new PictureBox();

                    // Set the properties of the box
                    pictureBox.Name = $"x{x}y{y}";
                    pictureBox.Size = new Size(boxSize, boxSize);
                    pictureBox.Location = new Point(x * boxSize + 145, y * boxSize + 30);
                    pictureBox.MouseDown += MouseDownCheck;
                    pictureBox.MouseEnter += PaintMap;

                    // Add the picture box to the controls
                    this.Controls.Add(pictureBox);

                    // Add the picture box to storage
                    pictureBoxes.Add(pictureBox);
                }
            }

            // Initialize the form
            InitializeComponent();
        }

        // Methods
        /// <summary>
        /// Sets up the form when it loads.
        /// </summary>
        private void EditorForm_Load(object sender, EventArgs e)
        {
            // Set default color
            color = Color.Green;
            pictureCurrent.BackColor = color;

            // Resize group box for aesthetic
            groupMap.Height = boxSize * height + 25;
            groupMap.Width = boxSize * height + 15;

            // Resize width for aesthetic
            this.Width = groupMap.Width + 160;

            // Try to load (if given a file name)
            MapLoad();
        }

        /// <summary>
        /// Changes the color for the user to draw with.
        /// </summary>
        public void PenColorSelection(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                // Set pen color to clicked button
                color = ((Button)sender).BackColor;

                // Show user selected color
                pictureCurrent.BackColor = ((Button)sender).BackColor;
            }
        }

        /// <summary>
        /// Checks if the mouse is down in a picture box.
        /// </summary>
        public void MouseDownCheck(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                // Create a temporary variable to improve readability
                PictureBox pictureBox = ((PictureBox)sender);

                // Change background color to current color
                pictureBox.BackColor = color;

                // Disable capture property
                pictureBox.Capture = false;

                // Change save state
                saved = false;

                // Update title to reflect save state
                if (this.Text[this.Text.Length - 1] != '*')
                {
                    this.Text += "*";
                }
            }
        }

        /// <summary>
        /// Draws on the picture boxes with the current color.
        /// </summary>
        public void PaintMap(object sender, EventArgs e)
        {
            // If the mouse is down
            if (EditorForm.MouseButtons.HasFlag(MouseButtons.Left))
            {
                // If the sender is a part of the map
                if (sender is PictureBox)
                {
                    // Create a temporary variable to improve readability
                    PictureBox pictureBox = ((PictureBox)sender);

                    // Change background color to current color
                    pictureBox.BackColor = color;
                }
            }
        }

        /// <summary>
        /// Prompts the user to save a file.
        /// </summary>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Declare temporary variables
            SaveFileDialog saveFileDialog;

            // Initialize temporary variables
            saveFileDialog = new SaveFileDialog();

            // Title the dialog
            saveFileDialog.Title = "Save a level file.";

            // Filter files
            saveFileDialog.Filter = "Level Files | *.level";

            // Show the dialog & get result
            DialogResult result = saveFileDialog.ShowDialog();

            // Save the file once title and location is selected
            if (result == DialogResult.OK)
            {
                // Declare variables for the writer
                FileStream outStream = null;
                StreamWriter output = null;

                try
                {
                    // Initialize writer
                    outStream = File.OpenWrite(saveFileDialog.FileName);
                    output = new StreamWriter(outStream);

                    // Write some data
                    output.WriteLine($"{height},{width}");

                    for (int i = 0; i < height * width; i++)
                    {
                        output.WriteLine(pictureBoxes[i].BackColor.ToArgb());
                    }

                    this.Text = $"Level Editor - {saveFileDialog.FileName}";

                    // Alert a successful save
                    MessageBox.Show(
                        "File saved successfully",
                        "File Saved",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    saved = true;
                }
                catch
                {
                    // Alert an unsuccessful save
                    MessageBox.Show(
                        "Corrupted file!",
                        "Error Saving File",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    if (output != null)
                    {
                        // Close the stream
                        output.Close();
                    }
                    else if (outStream != null)
                    {
                        // File opening may have failed
                        outStream.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Prompts the user to load a files.
        /// </summary>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // Declare temporary variables
            OpenFileDialog openFileDialog;

            // Initialize temporary variables
            openFileDialog = new OpenFileDialog();

            // Title the dialog
            openFileDialog.Title = "Open a level file.";

            // Filter files
            openFileDialog.Filter = "Level Files | *.level";

            // Show the dialog & get result
            DialogResult result = openFileDialog.ShowDialog();

            // If they load a file, open the editor form
            if (result == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }

            // Call the load function
            MapLoad();

            // It was loaded from a saved file
            saved = true;
        }

        /// <summary>
        /// Loads the files into the map.
        /// </summary>
        private void MapLoad()
        {
            if (fileName != null)
            {
                // Load in player data
                FileStream inStream = null;
                StreamReader input = null;

                try
                {
                    // Open file for reading
                    inStream = File.OpenRead(fileName);
                    input = new StreamReader(inStream);

                    // Read first lines for width and height data
                    String line = input.ReadLine();
                    String[] mapDetails = line.Split(',');
                    int loadHeight = int.Parse(mapDetails[0]);
                    int loadWidth = int.Parse(mapDetails[1]);

                    // Load new canvas if size does not match
                    if (loadHeight != height || loadWidth != width)
                    {
                        // Close stream
                        if (input != null)
                        {
                            // Close the stream
                            input.Close();
                        }
                        else if (inStream != null)
                        {
                            // File opening may have failed
                            inStream.Close();
                        }

                        // Close form
                        this.Close();

                        // Create new form
                        EditorForm editorForm = new EditorForm(loadHeight, loadWidth, fileName);
                        editorForm.Show();
                        return;
                    }

                    // Array for colors
                    List<int> colorData = new List<int>(loadHeight * loadWidth);

                    // Read remaining lines and add to list
                    line = null;
                    while ((line = input.ReadLine()) != null)
                    {
                        colorData.Add(int.Parse(line));
                    }

                    // Paint the loaded file
                    for (int i = 0; i < colorData.Count; i++)
                    {
                        pictureBoxes[i].BackColor = Color.FromArgb(colorData[i]);
                    }

                    this.Text = $"Level Editor - {fileName}";

                    // Alert a successful load
                    MessageBox.Show(
                        "File loaded successfully",
                        "File Loaded",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch
                {
                    // Alert an unsuccessful load
                    MessageBox.Show(
                        "Corrupted file!",
                        "Error Loading File",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    if (input != null)
                    {
                        // Close the stream
                        input.Close();
                    }
                    else if (inStream != null)
                    {
                        // File opening may have failed
                        inStream.Close();
                    }
                }
            }
        }

        /// <summary>
        /// On form closing, check to see if the user saved.
        /// </summary>
        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If the form isn't saved, prevent immediate closing
            if (!saved)
            {
                // Prompt with message
                DialogResult result = MessageBox.Show(
                    "There are unsaved changes. Are you sure you want to quit?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                // If they choose to save, don't close the window
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
