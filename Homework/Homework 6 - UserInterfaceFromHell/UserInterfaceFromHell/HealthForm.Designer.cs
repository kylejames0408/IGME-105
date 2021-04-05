namespace UserInterfaceFromHell
{
    partial class HealthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboWeight = new System.Windows.Forms.ComboBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelActivity = new System.Windows.Forms.Label();
            this.comboActivity = new System.Windows.Forms.ComboBox();
            this.numericMonth = new System.Windows.Forms.NumericUpDown();
            this.groupBirthday = new System.Windows.Forms.GroupBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.labelDay = new System.Windows.Forms.Label();
            this.numericDay = new System.Windows.Forms.NumericUpDown();
            this.labelMonth = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonth)).BeginInit();
            this.groupBirthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDay)).BeginInit();
            this.SuspendLayout();
            // 
            // comboWeight
            // 
            this.comboWeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWeight.FormattingEnabled = true;
            this.comboWeight.Location = new System.Drawing.Point(343, 116);
            this.comboWeight.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboWeight.Name = "comboWeight";
            this.comboWeight.Size = new System.Drawing.Size(316, 39);
            this.comboWeight.TabIndex = 0;
            this.comboWeight.SelectedIndexChanged += new System.EventHandler(this.ComboSelectedIndexChanged);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(26, 514);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(1489, 112);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Please Fill Out Some Base Information";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(205, 123);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(112, 32);
            this.labelWeight.TabIndex = 2;
            this.labelWeight.Text = "Weight:";
            // 
            // labelActivity
            // 
            this.labelActivity.AutoSize = true;
            this.labelActivity.Location = new System.Drawing.Point(1415, 927);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(190, 32);
            this.labelActivity.TabIndex = 4;
            this.labelActivity.Text = "Activity Level:";
            // 
            // comboActivity
            // 
            this.comboActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboActivity.FormattingEnabled = true;
            this.comboActivity.Items.AddRange(new object[] {
            "Not Very Active",
            "Lightly Active",
            "Active",
            "Very Active"});
            this.comboActivity.Location = new System.Drawing.Point(1635, 924);
            this.comboActivity.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboActivity.Name = "comboActivity";
            this.comboActivity.Size = new System.Drawing.Size(316, 39);
            this.comboActivity.TabIndex = 3;
            this.comboActivity.SelectedValueChanged += new System.EventHandler(this.ComboSelectedIndexChanged);
            // 
            // numericMonth
            // 
            this.numericMonth.Location = new System.Drawing.Point(111, 37);
            this.numericMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMonth.Name = "numericMonth";
            this.numericMonth.ReadOnly = true;
            this.numericMonth.Size = new System.Drawing.Size(200, 38);
            this.numericMonth.TabIndex = 5;
            this.numericMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMonth.ValueChanged += new System.EventHandler(this.CounterValueChanged);
            // 
            // groupBirthday
            // 
            this.groupBirthday.Controls.Add(this.labelYear);
            this.groupBirthday.Controls.Add(this.numericYear);
            this.groupBirthday.Controls.Add(this.labelDay);
            this.groupBirthday.Controls.Add(this.numericDay);
            this.groupBirthday.Controls.Add(this.labelMonth);
            this.groupBirthday.Controls.Add(this.numericMonth);
            this.groupBirthday.Location = new System.Drawing.Point(193, 718);
            this.groupBirthday.Name = "groupBirthday";
            this.groupBirthday.Size = new System.Drawing.Size(317, 240);
            this.groupBirthday.TabIndex = 6;
            this.groupBirthday.TabStop = false;
            this.groupBirthday.Text = "Birthday";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(6, 178);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(83, 32);
            this.labelYear.TabIndex = 10;
            this.labelYear.Text = "Year:";
            // 
            // numericYear
            // 
            this.numericYear.Location = new System.Drawing.Point(111, 172);
            this.numericYear.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.ReadOnly = true;
            this.numericYear.Size = new System.Drawing.Size(200, 38);
            this.numericYear.TabIndex = 9;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(6, 107);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(73, 32);
            this.labelDay.TabIndex = 8;
            this.labelDay.Text = "Day:";
            // 
            // numericDay
            // 
            this.numericDay.Location = new System.Drawing.Point(111, 101);
            this.numericDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDay.Name = "numericDay";
            this.numericDay.ReadOnly = true;
            this.numericDay.Size = new System.Drawing.Size(200, 38);
            this.numericDay.TabIndex = 7;
            this.numericDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDay.ValueChanged += new System.EventHandler(this.CounterValueChanged);
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(6, 43);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(102, 32);
            this.labelMonth.TabIndex = 6;
            this.labelMonth.Text = "Month:";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(1150, 45);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(800, 457);
            this.buttonConfirm.TabIndex = 7;
            this.buttonConfirm.Text = "CONFIRM";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // HealthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.ControlBox = false;
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.groupBirthday);
            this.Controls.Add(this.labelActivity);
            this.Controls.Add(this.comboActivity);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.comboWeight);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "HealthForm";
            this.Text = "Health Form";
            this.Load += new System.EventHandler(this.HealthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMonth)).EndInit();
            this.groupBirthday.ResumeLayout(false);
            this.groupBirthday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboWeight;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelActivity;
        private System.Windows.Forms.ComboBox comboActivity;
        private System.Windows.Forms.NumericUpDown numericMonth;
        private System.Windows.Forms.GroupBox groupBirthday;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.NumericUpDown numericDay;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Button buttonConfirm;
    }
}