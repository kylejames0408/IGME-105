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
    public partial class FoodLog : Form
    {
        // Fields
        StartPage startPage;

        public FoodLog(StartPage startPage)
        {
            // Initialize fields
            this.startPage = startPage;

            // Initialize Form
            InitializeComponent();
        }

        /// <summary>
        /// Check the information on the form and close it if it's all there.
        /// </summary>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if ((radioLess.Checked || radio2000.Checked || radioMore.Checked) && 
                textBCalories.Text != "" && 
                textLCalories.Text != "" && 
                textDCalories.Text != "" && 
                textSCalories.Text != "")
            {
                this.Hide();
            }
            else
            {
                pictureStupid.Visible = true;
            }
        }

        /// <summary>
        /// Check if epilepsy is enabled.
        /// </summary>
        private void FoodLog_Load(object sender, EventArgs e)
        {
            if (startPage.Epilepsy)
            {
                timerEpilepsy.Start();
            }
        }

        /// <summary>
        /// Epilepsy timer.
        /// </summary>
        private void timerEpilepsy_Tick(object sender, EventArgs e)
        {
            this.BackColor = startPage.BackColor;
        }

        /// <summary>
        /// Hide the Caloric goal (assume the user checked it right the first time)
        /// </summary>
        private void RadioCheckedChanged(object sender, EventArgs e)
        {
            groupCaloricGoal.Hide();
        }
    }
}
