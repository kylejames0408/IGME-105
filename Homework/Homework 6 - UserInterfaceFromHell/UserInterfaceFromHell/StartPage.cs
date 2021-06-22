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

namespace UserInterfaceFromHell
{
    public partial class StartPage : Form
    {
        // Fields
        private HealthForm healthForm;
        private FoodLog foodLog;
        private WorkoutLog workoutLog;
        private List<Label> ticTacPositions;
        private Random rng;

        // Properties
        /// <summary>
        /// Gets whether or not epilepsy is activated.
        /// </summary>
        public bool Epilepsy { get { return timerEpilepsy.Enabled; } }

        /// <summary>
        /// Constructs the starting page.
        /// </summary>
        public StartPage(Random rng)
        {
            // Initialize the fields
            healthForm = new HealthForm();
            foodLog = new FoodLog(this);
            workoutLog = new WorkoutLog(this);
            ticTacPositions = new List<Label>(9);
            this.rng = rng;

            // Initialize the form
            InitializeComponent();
        }

        // Methods
        /// <summary>
        /// Change colors of the background every tick.
        /// </summary>
        private void TimerEpilepsy_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rng.Next(0, 256), rng.Next(0, 256), rng.Next(0, 256));
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            // Add tic tac positions
            ticTacPositions.Add(labelTicPos1);
            ticTacPositions.Add(labelTicPos2);
            ticTacPositions.Add(labelTicPos3);
            ticTacPositions.Add(labelTicPos4);
            ticTacPositions.Add(labelTicPos5);
            ticTacPositions.Add(labelTicPos6);
            ticTacPositions.Add(labelTicPos7);
            ticTacPositions.Add(labelTicPos8);
            ticTacPositions.Add(labelTicPos9);
            healthForm.ShowDialog();
        }

        /// <summary>
        /// The X button to place Xs in the tic-tac-toe table.
        /// </summary>
        private void ButtonX_Click(object sender, EventArgs e)
        {
            // Add an X to the next available space
            for (int i = 0; i < ticTacPositions.Count; i++)
            {
                if (ticTacPositions[i].Text == "")
                {
                    ticTacPositions[i].Text = "X";
                    break;
                }
            }

            // Check win condition
            if ((labelTicPos1.Text == "X" && labelTicPos2.Text == "X" && labelTicPos3.Text == "X") ||
                (labelTicPos1.Text == "X" && labelTicPos5.Text == "X" && labelTicPos9.Text == "X") ||
                (labelTicPos1.Text == "X" && labelTicPos4.Text == "X" && labelTicPos7.Text == "X") ||
                (labelTicPos2.Text == "X" && labelTicPos5.Text == "X" && labelTicPos8.Text == "X") ||
                (labelTicPos3.Text == "X" && labelTicPos5.Text == "X" && labelTicPos7.Text == "X") ||
                (labelTicPos3.Text == "X" && labelTicPos6.Text == "X" && labelTicPos9.Text == "X") ||
                (labelTicPos4.Text == "X" && labelTicPos5.Text == "X" && labelTicPos6.Text == "X") ||
                (labelTicPos7.Text == "X" && labelTicPos8.Text == "X" && labelTicPos9.Text == "X"))
            {
                timerEpilepsy.Start();
                buttonX.Hide();
                buttonO.Hide();
            }
            else
            {
                bool full = false;
                int count = 0;

                // Check each position to see if it holds something
                for (int i = 0; i < ticTacPositions.Count; i++)
                {
                    if (ticTacPositions[i].Text != "")
                    {
                        count++;
                    }
                }

                // If each position is filled, it is full
                if (count == 9)
                {
                    full = true;
                }

                // If it's full, reset the table
                if (full)
                {
                    for (int i = 0; i < ticTacPositions.Count; i++)
                    {
                        ticTacPositions[i].Text = "";
                    }
                }
            }
        }

        /// <summary>
        /// The O button to place Os in the tic-tac-toe table.
        /// </summary>
        private void ButtonO_Click(object sender, EventArgs e)
        {
            // Add an X to the next available space
            for (int i = 0; i < ticTacPositions.Count; i++)
            {
                if (ticTacPositions[i].Text == "")
                {
                    ticTacPositions[i].Text = "O";
                    break;
                }
            }

            // Check win condition
            if ((labelTicPos1.Text == "O" && labelTicPos2.Text == "O" && labelTicPos3.Text == "O") ||
                (labelTicPos1.Text == "O" && labelTicPos5.Text == "O" && labelTicPos9.Text == "O") ||
                (labelTicPos1.Text == "O" && labelTicPos4.Text == "O" && labelTicPos7.Text == "O") ||
                (labelTicPos2.Text == "O" && labelTicPos5.Text == "O" && labelTicPos8.Text == "O") ||
                (labelTicPos3.Text == "O" && labelTicPos5.Text == "O" && labelTicPos7.Text == "O") ||
                (labelTicPos3.Text == "O" && labelTicPos6.Text == "O" && labelTicPos9.Text == "O") ||
                (labelTicPos4.Text == "O" && labelTicPos5.Text == "O" && labelTicPos6.Text == "O") ||
                (labelTicPos7.Text == "O" && labelTicPos8.Text == "O" && labelTicPos9.Text == "O"))
            {
                timerEpilepsy.Start();
                buttonX.Hide();
                buttonO.Hide();
            }
            else
            {
                bool full = false;
                int count = 0;

                // Check each position to see if it holds something
                for (int i = 0; i < ticTacPositions.Count; i++)
                {
                    if (ticTacPositions[i].Text != "")
                    {
                        count++;
                    }
                }

                // If each position is filled, it is full
                if (count == 9)
                {
                    full = true;
                }

                // If it's full, reset the table
                if (full)
                {
                    for (int i = 0; i < ticTacPositions.Count; i++)
                    {
                        ticTacPositions[i].Text = "";
                    }
                }
            }
        }

        /// <summary>
        /// Changes the color of the text anytime it is moused over.
        /// </summary>
        private void labelHeader_MouseHover(object sender, EventArgs e)
        {
            labelHeader.ForeColor = Color.FromArgb(rng.Next(0, 256), rng.Next(0, 256), rng.Next(0, 256));
        }

        /// <summary>
        /// "Saves" the logs.
        /// </summary>
        private void buttonSaveLog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error saving the log, please view the fitnessLog.txt file for more details",
                "ERROR SAVING",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            // Declare variables for the writer
            FileStream outStream = null;
            StreamWriter output = null;

            try
            {
                // Initialize writer
                outStream = File.OpenWrite("fitnessLog.txt");
                output = new StreamWriter(outStream);

                // Write some data
                output.WriteLine("( ͡° ͜ʖ ͡°)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
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

        /// <summary>
        /// Close this form and open a meme form.
        /// </summary>
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Open the food log.
        /// </summary>
        private void buttonLogFood_Click(object sender, EventArgs e)
        {
            foodLog.Show();
        }

        /// <summary>
        /// Open the workout log.
        /// </summary>
        private void buttonLogWorkout_Click(object sender, EventArgs e)
        {
            workoutLog.Show();
        }
    }
}
