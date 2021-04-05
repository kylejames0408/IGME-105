namespace UserInterfaceFromHell
{
    partial class StartPage
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.timerEpilepsy = new System.Windows.Forms.Timer(this.components);
            this.buttonLogWorkout = new System.Windows.Forms.Button();
            this.buttonLogFood = new System.Windows.Forms.Button();
            this.buttonSaveLog = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.labelTicPos1 = new System.Windows.Forms.Label();
            this.labelTicPos4 = new System.Windows.Forms.Label();
            this.labelTicPos5 = new System.Windows.Forms.Label();
            this.labelTicPos2 = new System.Windows.Forms.Label();
            this.labelTicPos3 = new System.Windows.Forms.Label();
            this.labelTicPos6 = new System.Windows.Forms.Label();
            this.labelTicPos7 = new System.Windows.Forms.Label();
            this.labelTicPos8 = new System.Windows.Forms.Label();
            this.labelTicPos9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(32, 21);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(1929, 334);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Fitness Tracker";
            this.labelHeader.MouseHover += new System.EventHandler(this.labelHeader_MouseHover);
            // 
            // timerEpilepsy
            // 
            this.timerEpilepsy.Interval = 1;
            this.timerEpilepsy.Tick += new System.EventHandler(this.TimerEpilepsy_Tick);
            // 
            // buttonLogWorkout
            // 
            this.buttonLogWorkout.Location = new System.Drawing.Point(741, 298);
            this.buttonLogWorkout.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonLogWorkout.Name = "buttonLogWorkout";
            this.buttonLogWorkout.Size = new System.Drawing.Size(56, 746);
            this.buttonLogWorkout.TabIndex = 1;
            this.buttonLogWorkout.Text = "Log Workout";
            this.buttonLogWorkout.UseVisualStyleBackColor = true;
            this.buttonLogWorkout.Click += new System.EventHandler(this.buttonLogWorkout_Click);
            // 
            // buttonLogFood
            // 
            this.buttonLogFood.Location = new System.Drawing.Point(1211, 298);
            this.buttonLogFood.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonLogFood.Name = "buttonLogFood";
            this.buttonLogFood.Size = new System.Drawing.Size(56, 746);
            this.buttonLogFood.TabIndex = 2;
            this.buttonLogFood.Text = "Log Food";
            this.buttonLogFood.UseVisualStyleBackColor = true;
            this.buttonLogFood.Click += new System.EventHandler(this.buttonLogFood_Click);
            // 
            // buttonSaveLog
            // 
            this.buttonSaveLog.Location = new System.Drawing.Point(35, 482);
            this.buttonSaveLog.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSaveLog.Name = "buttonSaveLog";
            this.buttonSaveLog.Size = new System.Drawing.Size(2067, 55);
            this.buttonSaveLog.TabIndex = 3;
            this.buttonSaveLog.Text = "Save Log";
            this.buttonSaveLog.UseVisualStyleBackColor = true;
            this.buttonSaveLog.Click += new System.EventHandler(this.buttonSaveLog_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(35, 830);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(2067, 55);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(32, 21);
            this.buttonX.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(93, 76);
            this.buttonX.TabIndex = 5;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.ButtonX_Click);
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(141, 21);
            this.buttonO.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(93, 76);
            this.buttonO.TabIndex = 6;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.ButtonO_Click);
            // 
            // labelTicPos1
            // 
            this.labelTicPos1.AutoSize = true;
            this.labelTicPos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicPos1.Location = new System.Drawing.Point(368, 343);
            this.labelTicPos1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTicPos1.Name = "labelTicPos1";
            this.labelTicPos1.Size = new System.Drawing.Size(0, 105);
            this.labelTicPos1.TabIndex = 7;
            // 
            // labelTicPos4
            // 
            this.labelTicPos4.AutoSize = true;
            this.labelTicPos4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicPos4.Location = new System.Drawing.Point(368, 632);
            this.labelTicPos4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTicPos4.Name = "labelTicPos4";
            this.labelTicPos4.Size = new System.Drawing.Size(0, 105);
            this.labelTicPos4.TabIndex = 8;
            // 
            // labelTicPos5
            // 
            this.labelTicPos5.AutoSize = true;
            this.labelTicPos5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicPos5.Location = new System.Drawing.Point(957, 632);
            this.labelTicPos5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTicPos5.Name = "labelTicPos5";
            this.labelTicPos5.Size = new System.Drawing.Size(0, 105);
            this.labelTicPos5.TabIndex = 9;
            // 
            // labelTicPos2
            // 
            this.labelTicPos2.AutoSize = true;
            this.labelTicPos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicPos2.Location = new System.Drawing.Point(957, 343);
            this.labelTicPos2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTicPos2.Name = "labelTicPos2";
            this.labelTicPos2.Size = new System.Drawing.Size(0, 105);
            this.labelTicPos2.TabIndex = 9;
            // 
            // labelTicPos3
            // 
            this.labelTicPos3.AutoSize = true;
            this.labelTicPos3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicPos3.Location = new System.Drawing.Point(1557, 343);
            this.labelTicPos3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTicPos3.Name = "labelTicPos3";
            this.labelTicPos3.Size = new System.Drawing.Size(0, 105);
            this.labelTicPos3.TabIndex = 10;
            // 
            // labelTicPos6
            // 
            this.labelTicPos6.AutoSize = true;
            this.labelTicPos6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicPos6.Location = new System.Drawing.Point(1557, 632);
            this.labelTicPos6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTicPos6.Name = "labelTicPos6";
            this.labelTicPos6.Size = new System.Drawing.Size(0, 105);
            this.labelTicPos6.TabIndex = 11;
            // 
            // labelTicPos7
            // 
            this.labelTicPos7.AutoSize = true;
            this.labelTicPos7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicPos7.Location = new System.Drawing.Point(368, 944);
            this.labelTicPos7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTicPos7.Name = "labelTicPos7";
            this.labelTicPos7.Size = new System.Drawing.Size(0, 105);
            this.labelTicPos7.TabIndex = 8;
            // 
            // labelTicPos8
            // 
            this.labelTicPos8.AutoSize = true;
            this.labelTicPos8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicPos8.Location = new System.Drawing.Point(957, 944);
            this.labelTicPos8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTicPos8.Name = "labelTicPos8";
            this.labelTicPos8.Size = new System.Drawing.Size(0, 105);
            this.labelTicPos8.TabIndex = 9;
            // 
            // labelTicPos9
            // 
            this.labelTicPos9.AutoSize = true;
            this.labelTicPos9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicPos9.Location = new System.Drawing.Point(1557, 944);
            this.labelTicPos9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTicPos9.Name = "labelTicPos9";
            this.labelTicPos9.Size = new System.Drawing.Size(0, 105);
            this.labelTicPos9.TabIndex = 11;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.ControlBox = false;
            this.Controls.Add(this.labelTicPos3);
            this.Controls.Add(this.labelTicPos9);
            this.Controls.Add(this.labelTicPos6);
            this.Controls.Add(this.labelTicPos2);
            this.Controls.Add(this.labelTicPos8);
            this.Controls.Add(this.labelTicPos5);
            this.Controls.Add(this.labelTicPos7);
            this.Controls.Add(this.labelTicPos4);
            this.Controls.Add(this.labelTicPos1);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonSaveLog);
            this.Controls.Add(this.buttonLogFood);
            this.Controls.Add(this.buttonLogWorkout);
            this.Controls.Add(this.labelHeader);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "StartPage";
            this.Text = "Fitness Tracker - Home";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Timer timerEpilepsy;
        private System.Windows.Forms.Button buttonLogWorkout;
        private System.Windows.Forms.Button buttonLogFood;
        private System.Windows.Forms.Button buttonSaveLog;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Label labelTicPos1;
        private System.Windows.Forms.Label labelTicPos4;
        private System.Windows.Forms.Label labelTicPos5;
        private System.Windows.Forms.Label labelTicPos2;
        private System.Windows.Forms.Label labelTicPos3;
        private System.Windows.Forms.Label labelTicPos6;
        private System.Windows.Forms.Label labelTicPos7;
        private System.Windows.Forms.Label labelTicPos8;
        private System.Windows.Forms.Label labelTicPos9;
    }
}

