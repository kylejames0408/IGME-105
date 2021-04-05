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
    public partial class MainForm : Form
    {
        // Fields
        private int mapHeight;
        private int mapWidth;

        // Properties
        /// <summary>
        /// Gets the user-entered height of the map.
        /// </summary>
        public int MapHeight { get { return mapHeight; } }

        /// <summary>
        /// Gets the user-entered width of the map.
        /// </summary>
        public int MapWidth { get { return mapWidth; } }

        // Constructors
        /// <summary>
        /// Constructs the main form.
        /// </summary>
        public MainForm()
        {
            // Initialize the fields
            mapHeight = 0;
            mapWidth = 0;

            // Initializes the form
            InitializeComponent();
        }

        // Methods
        /// <summary>
        /// Creates a new map for the user to draw on.
        /// </summary>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            // Declare temporary variables
            string errorHeight;
            string errorWidth;

            // Initialize temporary variables
            errorHeight = null;
            errorWidth = null;

            // Check height to see if it's an integer
            if (!int.TryParse(textHeight.Text, out mapHeight))
            {
                errorHeight = "- Height was not an integer.";
            }

            // Check width to see if it's an integer
            if (!int.TryParse(textWidth.Text, out mapWidth))
            {
                errorWidth = "- Width was not an integer.";
            }

            // Check height to see if it's within the range
            if (errorHeight == null)
            {
                if (mapHeight < 10)
                {
                    errorHeight = "- Height was too small. Minimum is 10";
                }
                else if (mapHeight > 30)
                {
                    errorHeight = "- Height was too large. Maximum is 30";
                }
            }

            // Check width to see if it's within the range
            if (errorWidth == null)
            {
                if (mapWidth < 10)
                {
                    errorWidth = "- Width was too small. Minimum is 10";
                }
                else if (mapWidth > 30)
                {
                    errorWidth = "- Width was too large. Maximum is 30";
                }
            }

            // If there are errors, present them to the user
            if (errorHeight != null || errorWidth != null)
            {
                MessageBox.Show(
                    $"Errors:\n{errorWidth}\n{errorHeight}",
                    "Error creating map",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // If there are no errors, create the map
            EditorForm editorForm = new EditorForm(mapHeight, mapWidth);

            editorForm.ShowDialog();
        }

        /// <summary>
        /// Prompts the user with a file dialog to select an existing map file.
        /// </summary>
        private void ButtonLoad_Click(object sender, EventArgs e)
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
                // Load in player data
                FileStream inStream = null;
                StreamReader input = null;

                try
                {
                    // Open file for reading
                    inStream = File.OpenRead(openFileDialog.FileName);
                    input = new StreamReader(inStream);

                    // Read first lines for width and height data
                    String line = input.ReadLine();
                    String[] mapDetails = line.Split(',');
                    mapHeight = int.Parse(mapDetails[0]);
                    mapWidth = int.Parse(mapDetails[1]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading in data: {ex.Message}");
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

                EditorForm editorForm = new EditorForm(mapHeight, mapWidth, openFileDialog.FileName);

                editorForm.ShowDialog();
            }
        }
    }
}
