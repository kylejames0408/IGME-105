namespace MultipleForms
{
    partial class GameForm
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
            this.textGuess = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.progressCountdown = new System.Windows.Forms.ProgressBar();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.labelTimeBar = new System.Windows.Forms.Label();
            this.labelGuess = new System.Windows.Forms.Label();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.groupStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // textGuess
            // 
            this.textGuess.Location = new System.Drawing.Point(179, 24);
            this.textGuess.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textGuess.Name = "textGuess";
            this.textGuess.Size = new System.Drawing.Size(401, 38);
            this.textGuess.TabIndex = 0;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(24, 150);
            this.labelOutput.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(206, 32);
            this.labelOutput.TabIndex = 1;
            this.labelOutput.Text = "Current Guess:";
            // 
            // progressCountdown
            // 
            this.progressCountdown.Location = new System.Drawing.Point(128, 45);
            this.progressCountdown.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.progressCountdown.Name = "progressCountdown";
            this.progressCountdown.Size = new System.Drawing.Size(787, 55);
            this.progressCountdown.TabIndex = 2;
            this.progressCountdown.Value = 100;
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.labelTimeBar);
            this.groupStatus.Controls.Add(this.labelOutput);
            this.groupStatus.Controls.Add(this.progressCountdown);
            this.groupStatus.Location = new System.Drawing.Point(32, 86);
            this.groupStatus.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupStatus.Size = new System.Drawing.Size(931, 210);
            this.groupStatus.TabIndex = 3;
            this.groupStatus.TabStop = false;
            this.groupStatus.Text = "Status";
            // 
            // labelTimeBar
            // 
            this.labelTimeBar.AutoSize = true;
            this.labelTimeBar.Location = new System.Drawing.Point(24, 45);
            this.labelTimeBar.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTimeBar.Name = "labelTimeBar";
            this.labelTimeBar.Size = new System.Drawing.Size(86, 32);
            this.labelTimeBar.TabIndex = 5;
            this.labelTimeBar.Text = "Time:";
            // 
            // labelGuess
            // 
            this.labelGuess.AutoSize = true;
            this.labelGuess.Location = new System.Drawing.Point(56, 31);
            this.labelGuess.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelGuess.Name = "labelGuess";
            this.labelGuess.Size = new System.Drawing.Size(105, 32);
            this.labelGuess.TabIndex = 4;
            this.labelGuess.Text = "Guess:";
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(641, 19);
            this.buttonGuess.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(200, 55);
            this.buttonGuess.TabIndex = 5;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 324);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.labelGuess);
            this.Controls.Add(this.groupStatus);
            this.Controls.Add(this.textGuess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "High-Low Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textGuess;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.ProgressBar progressCountdown;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.GroupBox groupStatus;
        private System.Windows.Forms.Label labelTimeBar;
        private System.Windows.Forms.Label labelGuess;
        private System.Windows.Forms.Button buttonGuess;
    }
}