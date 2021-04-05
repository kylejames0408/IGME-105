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
    public partial class HealthForm : Form
    {
        // Constructors
        /// <summary>
        /// Constructs the health form
        /// </summary>
        public HealthForm()
        {
            InitializeComponent();
        }

        // Methods
        /// <summary>
        /// On the form load, fill the weight combo box.
        /// </summary>
        private void HealthForm_Load(object sender, EventArgs e)
        {
            for (int i = 12; i < 1401; i++)
            {
                comboWeight.Items.Add(i);
            }
        }

        /// <summary>
        /// When a numeric up down value changes, hide the Birthday group box.
        /// </summary>
        private void CounterValueChanged(object sender, EventArgs e)
        {
            groupBirthday.Hide();
        }

        /// <summary>
        /// When a combo box value changes, show the Birthday group box.
        /// </summary>
        private void ComboSelectedIndexChanged(object sender, EventArgs e)
        {
            groupBirthday.Show();
        }

        /// <summary>
        /// Check to see if everything is filled out and fits the obscure requirements and either
        /// provide a message box or close this form.
        /// </summary>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (numericYear.Value >= 1946 && numericYear.Value <= 1964)
            {
                MessageBox.Show("OK BOOMER", "BOOMER ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (numericYear.Value >= 1900)
            {
                MessageBox.Show("You're Too Young!", "Not Of Age", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((comboActivity.SelectedIndex >= 0 && comboActivity.SelectedIndex < 4) && (comboWeight.SelectedIndex >= 0 && comboWeight.SelectedIndex < 1388))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill Out Everything", "Form Not Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
