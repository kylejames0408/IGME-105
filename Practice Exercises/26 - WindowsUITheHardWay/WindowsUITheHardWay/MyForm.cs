using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsUITheHardWay
{
    class MyForm : Form
    {
        // Constructors
        public MyForm()
        {
            // Change some properties of the window
            this.Size = new Size(515, 540);
            this.Text = "Jingle, Jangle, Jingle";

            // Create one hundred buttons
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.Location = new Point(i * 50, j * 50);
                    button.BackColor = Color.LightGreen;
                    button.Text = ":)";

                    button.MouseEnter += Button_MouseEnter;
                    button.MouseLeave += Button_MouseLeave;

                    this.Controls.Add(button);
                }
            }
        }

        /// <summary>
        /// Performs actions when the mouse leaves the button.
        /// </summary>
        /// <param name="sender">The button.</param>
        /// <param name="e">The event.</param>
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                // Cast sender to button
                Button button = (Button)sender;

                // Change color
                button.BackColor = Color.LightGreen;

                // Change text
                button.Text = ":)";
            }
        }

        /// <summary>
        /// Performs actions when the mouse enters the button.
        /// </summary>
        /// <param name="sender">The button.</param>
        /// <param name="e">The event.</param>
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                // Cast sender to button
                Button button = (Button)sender;

                // Change color
                button.BackColor = Color.Firebrick;

                // Change text
                button.Text = ":(";
            }
        }
    }
}
