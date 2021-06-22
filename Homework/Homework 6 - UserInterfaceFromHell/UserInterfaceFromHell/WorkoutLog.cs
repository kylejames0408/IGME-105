using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceFromHell
{
    public partial class WorkoutLog : Form
    {
        // Fields
        StartPage startPage;

        public WorkoutLog(StartPage startPage)
        {
            // Initialize fields
            this.startPage = startPage;

            // Initialzie form
            InitializeComponent();
        }

        /// <summary>
        /// If cardio is checked (or unchecked) change the visibility of the section.
        /// </summary>
        private void checkCardio_CheckStateChanged(object sender, EventArgs e)
        {
            // Reverse the check to mess with the user
            if (checkCardio.Checked)
            {
                groupCWorkouts.Visible = false;
            }
            else
            {
                groupCWorkouts.Visible = true;
            }
        }

        /// <summary>
        /// When the form loads, check for epilepsy status.
        /// </summary>
        private void WorkoutLog_Load(object sender, EventArgs e)
        {
            if (startPage.Epilepsy)
            {
                timerEpilepsy.Start();
            }
        }

        /// <summary>
        /// Rapidly changed background color.
        /// </summary>
        private void timerEpilepsy_Tick(object sender, EventArgs e)
        {
            this.BackColor = startPage.BackColor;
        }

        /// <summary>
        /// If strength is checked (or unchecked) change the visibility of the section.
        /// </summary>
        private void checkStrength_CheckStateChanged(object sender, EventArgs e)
        {
            // Reverse the check to mess with the user
            if (checkStrength.Checked == true)
            {
                groupSWorkouts.Visible = false;
            }
            else
            {
                groupSWorkouts.Visible = true;
            }
        }

        /// <summary>
        /// Hide the form when clicked (if conditions are met).
        /// </summary>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
