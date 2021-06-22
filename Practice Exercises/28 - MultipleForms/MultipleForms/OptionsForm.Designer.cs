namespace MultipleForms
{
    partial class OptionsForm
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textLowEnd = new System.Windows.Forms.TextBox();
            this.textHighEnd = new System.Windows.Forms.TextBox();
            this.textTime = new System.Windows.Forms.TextBox();
            this.labelLow = new System.Windows.Forms.Label();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            this.groupOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(189, 324);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(200, 55);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // textLowEnd
            // 
            this.textLowEnd.Location = new System.Drawing.Point(251, 45);
            this.textLowEnd.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textLowEnd.Name = "textLowEnd";
            this.textLowEnd.Size = new System.Drawing.Size(260, 38);
            this.textLowEnd.TabIndex = 1;
            this.textLowEnd.Text = "0";
            // 
            // textHighEnd
            // 
            this.textHighEnd.Location = new System.Drawing.Point(251, 131);
            this.textHighEnd.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textHighEnd.Name = "textHighEnd";
            this.textHighEnd.Size = new System.Drawing.Size(260, 38);
            this.textHighEnd.TabIndex = 2;
            this.textHighEnd.Text = "100";
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(251, 219);
            this.textTime.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(260, 38);
            this.textTime.TabIndex = 3;
            this.textTime.Text = "10";
            // 
            // labelLow
            // 
            this.labelLow.AutoSize = true;
            this.labelLow.Location = new System.Drawing.Point(16, 52);
            this.labelLow.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(182, 32);
            this.labelLow.TabIndex = 4;
            this.labelLow.Text = "Low Number:";
            // 
            // groupOptions
            // 
            this.groupOptions.Controls.Add(this.labelTime);
            this.groupOptions.Controls.Add(this.labelHigh);
            this.groupOptions.Controls.Add(this.textTime);
            this.groupOptions.Controls.Add(this.textLowEnd);
            this.groupOptions.Controls.Add(this.labelLow);
            this.groupOptions.Controls.Add(this.textHighEnd);
            this.groupOptions.Location = new System.Drawing.Point(32, 29);
            this.groupOptions.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupOptions.Size = new System.Drawing.Size(533, 281);
            this.groupOptions.TabIndex = 5;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "High-Low Game Options";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(16, 227);
            this.labelTime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(206, 32);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "Time to Guess:";
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Location = new System.Drawing.Point(16, 138);
            this.labelHigh.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(189, 32);
            this.labelHigh.TabIndex = 6;
            this.labelHigh.Text = "High Number:";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 396);
            this.Controls.Add(this.groupOptions);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "High-Low Game";
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textLowEnd;
        private System.Windows.Forms.TextBox textHighEnd;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelHigh;
    }
}

