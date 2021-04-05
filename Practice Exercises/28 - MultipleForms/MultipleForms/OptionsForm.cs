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
    public partial class OptionsForm : Form
    {
        // Fields
        private int lowNumber;
        private int highNumber;
        private int time;
        private int number;
        private Random rng;

        // Properties
        /// <summary>
        /// Gets the lower bound number.
        /// </summary>
        public int LowNumber { get { return lowNumber; } }
        
        /// <summary>
        /// Gets the higher bound number.
        /// </summary>
        public int HighNumber { get { return highNumber; } }

        /// <summary>
        /// Gets the time allowed to guess.
        /// </summary>
        public int Time { get { return time; } }

        /// <summary>
        /// Gets the number to guess.
        /// </summary>
        public int Number { get { return number; } }

        // Constructors
        /// <summary>
        /// Constructs an Options Form.
        /// </summary>
        /// <param name="rng">The random number generator.</param>
        public OptionsForm(Random rng)
        {
            // Initialize fields
            this.rng = rng;

            // Initialize the form
            InitializeComponent();
        }

        // Methods
        /// <summary>
        /// Start the game when the Start button is clicked (if there are no errors).
        /// </summary>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // Error check all boxes
            bool isValid = int.TryParse(textLowEnd.Text, out lowNumber);

            if (!isValid)
            {
                ErrorMessageBox("The Low Number is not a valid integer.");
                return;
            }

            isValid = int.TryParse(textHighEnd.Text, out highNumber);

            if (!isValid || highNumber <= lowNumber)
            {
                ErrorMessageBox("The High Number is not a valid integer.");
                return;
            }

            isValid = int.TryParse(textTime.Text, out time);

            if (!isValid || time < 1)
            {
                ErrorMessageBox("The Time to Guess is not a valid integer.");
                return;
            }

            // If all boxes are valid, start the game
            number = rng.Next(lowNumber, highNumber + 1);

            GameForm game = new GameForm(this);

            game.ShowDialog();
        }

        /// <summary>
        /// Show an error box with a paricular error message.
        /// </summary>
        /// <param name="problem">The specified problem that created an error.</param>
        private void ErrorMessageBox(string problem)
        {
            MessageBox.Show(
                problem,
                "Error!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);
        }
    }
}
