namespace GUICreationAndEvents
{
    partial class GUICreationAndEvents
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUICreationAndEvents));
            this.labelRules = new System.Windows.Forms.Label();
            this.progressBarCountdown = new System.Windows.Forms.ProgressBar();
            this.buttonGameControl = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelTimeLabel = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxWires = new System.Windows.Forms.GroupBox();
            this.buttonFifthWire = new System.Windows.Forms.Button();
            this.buttonFourthWire = new System.Windows.Forms.Button();
            this.buttonThirdWire = new System.Windows.Forms.Button();
            this.buttonSecondWire = new System.Windows.Forms.Button();
            this.buttonFirstWire = new System.Windows.Forms.Button();
            this.timerBomb = new System.Windows.Forms.Timer(this.components);
            this.groupBoxRules = new System.Windows.Forms.GroupBox();
            this.groupBoxWires.SuspendLayout();
            this.groupBoxRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRules
            // 
            this.labelRules.AutoSize = true;
            this.labelRules.Location = new System.Drawing.Point(16, 38);
            this.labelRules.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelRules.Name = "labelRules";
            this.labelRules.Size = new System.Drawing.Size(880, 128);
            this.labelRules.TabIndex = 0;
            this.labelRules.Text = resources.GetString("labelRules.Text");
            // 
            // progressBarCountdown
            // 
            this.progressBarCountdown.Location = new System.Drawing.Point(456, 759);
            this.progressBarCountdown.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.progressBarCountdown.Name = "progressBarCountdown";
            this.progressBarCountdown.Size = new System.Drawing.Size(1325, 93);
            this.progressBarCountdown.TabIndex = 1;
            // 
            // buttonGameControl
            // 
            this.buttonGameControl.Location = new System.Drawing.Point(891, 255);
            this.buttonGameControl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonGameControl.Name = "buttonGameControl";
            this.buttonGameControl.Size = new System.Drawing.Size(285, 93);
            this.buttonGameControl.TabIndex = 2;
            this.buttonGameControl.Text = "Start Game";
            this.buttonGameControl.UseVisualStyleBackColor = true;
            this.buttonGameControl.Click += new System.EventHandler(this.ButtonGameControl_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(155, 949);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(1940, 90);
            this.textBoxResult.TabIndex = 3;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTimeLabel
            // 
            this.labelTimeLabel.AutoSize = true;
            this.labelTimeLabel.Location = new System.Drawing.Point(304, 773);
            this.labelTimeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTimeLabel.Name = "labelTimeLabel";
            this.labelTimeLabel.Size = new System.Drawing.Size(136, 64);
            this.labelTimeLabel.TabIndex = 4;
            this.labelTimeLabel.Text = "Progress:\r\nTime: 0";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(32, 949);
            this.labelResult.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(104, 32);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Result:";
            // 
            // groupBoxWires
            // 
            this.groupBoxWires.Controls.Add(this.buttonFifthWire);
            this.groupBoxWires.Controls.Add(this.buttonFourthWire);
            this.groupBoxWires.Controls.Add(this.buttonThirdWire);
            this.groupBoxWires.Controls.Add(this.buttonSecondWire);
            this.groupBoxWires.Controls.Add(this.buttonFirstWire);
            this.groupBoxWires.Location = new System.Drawing.Point(776, 362);
            this.groupBoxWires.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxWires.Name = "groupBoxWires";
            this.groupBoxWires.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxWires.Size = new System.Drawing.Size(533, 339);
            this.groupBoxWires.TabIndex = 6;
            this.groupBoxWires.TabStop = false;
            this.groupBoxWires.Text = "Bomb Wires";
            // 
            // buttonFifthWire
            // 
            this.buttonFifthWire.Enabled = false;
            this.buttonFifthWire.Location = new System.Drawing.Point(0, 286);
            this.buttonFifthWire.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonFifthWire.Name = "buttonFifthWire";
            this.buttonFifthWire.Size = new System.Drawing.Size(533, 24);
            this.buttonFifthWire.TabIndex = 11;
            this.buttonFifthWire.UseVisualStyleBackColor = true;
            this.buttonFifthWire.Click += new System.EventHandler(this.ButtonCutWire);
            // 
            // buttonFourthWire
            // 
            this.buttonFourthWire.Enabled = false;
            this.buttonFourthWire.Location = new System.Drawing.Point(0, 227);
            this.buttonFourthWire.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonFourthWire.Name = "buttonFourthWire";
            this.buttonFourthWire.Size = new System.Drawing.Size(533, 24);
            this.buttonFourthWire.TabIndex = 10;
            this.buttonFourthWire.UseVisualStyleBackColor = true;
            this.buttonFourthWire.Click += new System.EventHandler(this.ButtonCutWire);
            // 
            // buttonThirdWire
            // 
            this.buttonThirdWire.Enabled = false;
            this.buttonThirdWire.Location = new System.Drawing.Point(0, 165);
            this.buttonThirdWire.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonThirdWire.Name = "buttonThirdWire";
            this.buttonThirdWire.Size = new System.Drawing.Size(533, 24);
            this.buttonThirdWire.TabIndex = 9;
            this.buttonThirdWire.UseVisualStyleBackColor = true;
            this.buttonThirdWire.Click += new System.EventHandler(this.ButtonCutWire);
            // 
            // buttonSecondWire
            // 
            this.buttonSecondWire.Enabled = false;
            this.buttonSecondWire.Location = new System.Drawing.Point(0, 105);
            this.buttonSecondWire.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSecondWire.Name = "buttonSecondWire";
            this.buttonSecondWire.Size = new System.Drawing.Size(533, 24);
            this.buttonSecondWire.TabIndex = 8;
            this.buttonSecondWire.UseVisualStyleBackColor = true;
            this.buttonSecondWire.Click += new System.EventHandler(this.ButtonCutWire);
            // 
            // buttonFirstWire
            // 
            this.buttonFirstWire.Enabled = false;
            this.buttonFirstWire.Location = new System.Drawing.Point(0, 45);
            this.buttonFirstWire.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonFirstWire.Name = "buttonFirstWire";
            this.buttonFirstWire.Size = new System.Drawing.Size(533, 24);
            this.buttonFirstWire.TabIndex = 7;
            this.buttonFirstWire.UseVisualStyleBackColor = true;
            this.buttonFirstWire.Click += new System.EventHandler(this.ButtonCutWire);
            // 
            // timerBomb
            // 
            this.timerBomb.Tick += new System.EventHandler(this.TimerBomb_Tick);
            // 
            // groupBoxRules
            // 
            this.groupBoxRules.Controls.Add(this.labelRules);
            this.groupBoxRules.Location = new System.Drawing.Point(32, 29);
            this.groupBoxRules.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxRules.Name = "groupBoxRules";
            this.groupBoxRules.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxRules.Size = new System.Drawing.Size(912, 212);
            this.groupBoxRules.TabIndex = 7;
            this.groupBoxRules.TabStop = false;
            this.groupBoxRules.Text = "Rules";
            // 
            // GUICreationAndEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2129, 1111);
            this.Controls.Add(this.buttonGameControl);
            this.Controls.Add(this.groupBoxRules);
            this.Controls.Add(this.groupBoxWires);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelTimeLabel);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.progressBarCountdown);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "GUICreationAndEvents";
            this.Text = "GUI Creation & Events";
            this.Load += new System.EventHandler(this.GUICreationAndEvents_Load);
            this.groupBoxWires.ResumeLayout(false);
            this.groupBoxRules.ResumeLayout(false);
            this.groupBoxRules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRules;
        private System.Windows.Forms.ProgressBar progressBarCountdown;
        private System.Windows.Forms.Button buttonGameControl;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelTimeLabel;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox groupBoxWires;
        private System.Windows.Forms.Button buttonFifthWire;
        private System.Windows.Forms.Button buttonFourthWire;
        private System.Windows.Forms.Button buttonThirdWire;
        private System.Windows.Forms.Button buttonSecondWire;
        private System.Windows.Forms.Button buttonFirstWire;
        private System.Windows.Forms.Timer timerBomb;
        private System.Windows.Forms.GroupBox groupBoxRules;
    }
}

