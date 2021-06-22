using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICreationAndEvents
{
    public partial class GUICreationAndEvents : Form
    {
        // Fields
        List<Color> wireColors;
        List<Button> wireButtons;
        Random rng;

        public GUICreationAndEvents(Random rng)
        {
            InitializeComponent();
            wireColors = new List<Color>() { Color.Black, Color.Red, Color.White, Color.Blue, Color.Yellow };
            this.rng = rng;
        }

        private void GUICreationAndEvents_Load(object sender, EventArgs e)
        {
            wireButtons = new List<Button>() { buttonFirstWire, buttonSecondWire, buttonThirdWire, buttonFourthWire, buttonFifthWire };
        }

        private void ButtonGameControl_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            progressBarCountdown.Value = 0;

            // Set the wires
            for (int i = 0; i < wireButtons.Count; i++)
            {
                wireButtons[i].BackColor = wireColors[rng.Next(0,wireColors.Count)];
                wireButtons[i].Enabled = true;
            }

            // Disable the game button and start the timer
            buttonGameControl.Enabled = false;
            timerBomb.Enabled = true;
        }

        private void TimerBomb_Tick(object sender, EventArgs e)
        {
            progressBarCountdown.Increment(1);
            labelTimeLabel.Text = $"Progress:\r\nTime: {progressBarCountdown.Value}";

            if (progressBarCountdown.Value >= progressBarCountdown.Maximum)
            {
                for (int i = 0; i < wireButtons.Count; i++)
                {
                    wireButtons[i].Enabled = true;
                }

                buttonGameControl.Text = "Reset";
                buttonGameControl.Enabled = true;
                timerBomb.Enabled = false;
                textBoxResult.Text = "The bomb has exploded (time ran out)";
            }
        }

        private void ButtonCutWire(object sender, EventArgs e)
        {
            Button lastBlue = null;
            int blueWires = 0;
            string situation = null;

            // Check for red wires
            for (int i = 0; i < wireButtons.Count; i++)
            {
                if (wireButtons[i].BackColor == Color.Red)
                {
                    situation = "red";
                }
            }

            // Check for white wires
            if (situation == null)
            {
                for (int i = 0; i < wireButtons.Count; i++)
                {
                    if (i == wireButtons.Count - 1 && wireButtons[i].BackColor == Color.White)
                    {
                        situation = "white";
                    }
                }
            }

            // Check for blue wires
            if (situation == null)
            {
                for (int i = 0; i < wireButtons.Count; i++)
                {
                    if (wireButtons[i].BackColor == Color.Blue)
                    {
                        blueWires++;
                        lastBlue = wireButtons[i];
                    }
                }

                if (blueWires >= 2)
                {
                    situation = "blue";
                }
            }

            // Check results
            switch (situation)
            {
                case "red":
                    if (sender.Equals(buttonSecondWire))
                    {
                        textBoxResult.Text = "Bomb successfully defused";
                    }
                    else
                    {
                        textBoxResult.Text = "The bomb has exploded";
                    }
                    break;
                case "white":
                    if (sender.Equals(buttonFifthWire))
                    {
                        textBoxResult.Text = "Bomb successfully defused";
                    }
                    else
                    {
                        textBoxResult.Text = "The bomb has exploded";
                    }
                    break;
                case "blue":
                    if (sender.Equals(lastBlue))
                    {
                        textBoxResult.Text = "Bomb successfully defused";
                    }
                    else
                    {
                        textBoxResult.Text = "The bomb has exploded";
                    }
                    break;
                default:
                    if (sender.Equals(buttonFifthWire))
                    {
                        textBoxResult.Text = "Bomb successfully defused";
                    }
                    else
                    {
                        textBoxResult.Text = "The bomb has exploded";
                    }
                    break;
            }

            // Reset game
            for (int i = 0; i < wireButtons.Count; i++)
            {
                wireButtons[i].Enabled = false;
            }
            timerBomb.Enabled = false;
            buttonGameControl.Text = "Reset";
            buttonGameControl.Enabled = true;
        }
    }
}
