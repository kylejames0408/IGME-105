using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class GameForm : Form
    {
        // Fields
        private int number;
        private int time;

        /// <summary>
        /// Construct the game form.
        /// </summary>
        /// <param name="optionsForm">The form that inserts the settings for the game.</param>
        public GameForm(OptionsForm optionsForm)
        {
            // Initialize fields
            number = optionsForm.Number;
            time = optionsForm.Time;

            // Initialize the form
            InitializeComponent();
        }

        // Methods
        /// <summary>
        /// Set up the game, and start the game, when the form loads.
        /// </summary>
        private void GameForm_Load(object sender, EventArgs e)
        {
            progressCountdown.Maximum = time;
            progressCountdown.Value = time;
            timerGame.Start();
        }

        /// <summary>
        /// A timer that ticks every second and keeps track of the time for the game.
        /// </summary>
        private void timerGame_Tick(object sender, EventArgs e)
        {
            progressCountdown.Value--;
            if (progressCountdown.Value == 0)
            {
                timerGame.Stop();
                buttonGuess.Enabled = false;
                textGuess.Enabled = false;
                labelOutput.Text = $"Current Guess: GAME OVER! The number was {number}";
                Message($"GAME OVER! The number was {number}", "GAME OVER!");
            }
        }

        /// <summary>
        /// When the guess button is clicked, check the user's guess to see if it's the answer.
        /// </summary>
        private void buttonGuess_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textGuess.Text, out int guess))
            {
                labelOutput.Text = $"Current Guess: That was not a valid guess";
                return;
            }

            if (guess < number)
            {
                labelOutput.Text = $"Current Guess: Less than the number";
            }
            else if (guess > number)
            {
                labelOutput.Text = $"Current Guess: Greater than the number";
            }
            else
            {
                timerGame.Stop();
                buttonGuess.Enabled = false;
                textGuess.Enabled = false;
                labelOutput.Text = $"Current Guess: Correct! {progressCountdown.Value} seconds remain";
                Message($"Correct! {progressCountdown.Value} seconds remain", "Winner!");
            }
        }
        /// <summary>
        /// Creates a message box with a given message and status.
        /// </summary>
        /// <param name="message">The body of the message box.</param>
        /// <param name="status">The header of the message box.</param>
        public void Message(string message, string status)
        {
            DialogResult result = MessageBox.Show(
                message,
                status,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (result.Equals(DialogResult.OK))
            {
                this.Close();
            }
        }
    }
}
