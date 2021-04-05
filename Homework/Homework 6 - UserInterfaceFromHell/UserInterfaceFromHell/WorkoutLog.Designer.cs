namespace UserInterfaceFromHell
{
    partial class WorkoutLog
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
            this.checkCardio = new System.Windows.Forms.CheckBox();
            this.checkStrength = new System.Windows.Forms.CheckBox();
            this.groupWorkouts = new System.Windows.Forms.GroupBox();
            this.textSWorkouts = new System.Windows.Forms.TextBox();
            this.groupSWorkouts = new System.Windows.Forms.GroupBox();
            this.groupCWorkouts = new System.Windows.Forms.GroupBox();
            this.textCWorkouts = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.timerEpilepsy = new System.Windows.Forms.Timer(this.components);
            this.groupWorkouts.SuspendLayout();
            this.groupSWorkouts.SuspendLayout();
            this.groupCWorkouts.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(2, 853);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(1054, 223);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Workout Log";
            // 
            // checkCardio
            // 
            this.checkCardio.AutoSize = true;
            this.checkCardio.Location = new System.Drawing.Point(6, 37);
            this.checkCardio.Name = "checkCardio";
            this.checkCardio.Size = new System.Drawing.Size(137, 36);
            this.checkCardio.TabIndex = 1;
            this.checkCardio.Text = "Cardio";
            this.checkCardio.UseVisualStyleBackColor = true;
            this.checkCardio.CheckStateChanged += new System.EventHandler(this.checkCardio_CheckStateChanged);
            // 
            // checkStrength
            // 
            this.checkStrength.AutoSize = true;
            this.checkStrength.Location = new System.Drawing.Point(6, 102);
            this.checkStrength.Name = "checkStrength";
            this.checkStrength.Size = new System.Drawing.Size(161, 36);
            this.checkStrength.TabIndex = 2;
            this.checkStrength.Text = "Strength";
            this.checkStrength.UseVisualStyleBackColor = true;
            this.checkStrength.CheckStateChanged += new System.EventHandler(this.checkStrength_CheckStateChanged);
            // 
            // groupWorkouts
            // 
            this.groupWorkouts.Controls.Add(this.checkCardio);
            this.groupWorkouts.Controls.Add(this.checkStrength);
            this.groupWorkouts.Location = new System.Drawing.Point(40, 36);
            this.groupWorkouts.Name = "groupWorkouts";
            this.groupWorkouts.Size = new System.Drawing.Size(208, 162);
            this.groupWorkouts.TabIndex = 3;
            this.groupWorkouts.TabStop = false;
            this.groupWorkouts.Text = "Workouts";
            // 
            // textSWorkouts
            // 
            this.textSWorkouts.Location = new System.Drawing.Point(6, 50);
            this.textSWorkouts.Multiline = true;
            this.textSWorkouts.Name = "textSWorkouts";
            this.textSWorkouts.Size = new System.Drawing.Size(775, 808);
            this.textSWorkouts.TabIndex = 4;
            // 
            // groupSWorkouts
            // 
            this.groupSWorkouts.Controls.Add(this.textSWorkouts);
            this.groupSWorkouts.Location = new System.Drawing.Point(254, 36);
            this.groupSWorkouts.Name = "groupSWorkouts";
            this.groupSWorkouts.Size = new System.Drawing.Size(802, 864);
            this.groupSWorkouts.TabIndex = 5;
            this.groupSWorkouts.TabStop = false;
            this.groupSWorkouts.Text = "Strength Workouts";
            this.groupSWorkouts.Visible = false;
            // 
            // groupCWorkouts
            // 
            this.groupCWorkouts.Controls.Add(this.textCWorkouts);
            this.groupCWorkouts.Location = new System.Drawing.Point(1062, 36);
            this.groupCWorkouts.Name = "groupCWorkouts";
            this.groupCWorkouts.Size = new System.Drawing.Size(802, 864);
            this.groupCWorkouts.TabIndex = 6;
            this.groupCWorkouts.TabStop = false;
            this.groupCWorkouts.Text = "Cardio Workouts";
            this.groupCWorkouts.Visible = false;
            // 
            // textCWorkouts
            // 
            this.textCWorkouts.Location = new System.Drawing.Point(6, 50);
            this.textCWorkouts.Multiline = true;
            this.textCWorkouts.Name = "textCWorkouts";
            this.textCWorkouts.Size = new System.Drawing.Size(775, 808);
            this.textCWorkouts.TabIndex = 4;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(1870, 36);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(251, 1025);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // timerEpilepsy
            // 
            this.timerEpilepsy.Interval = 1;
            this.timerEpilepsy.Tick += new System.EventHandler(this.timerEpilepsy_Tick);
            // 
            // WorkoutLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupCWorkouts);
            this.Controls.Add(this.groupSWorkouts);
            this.Controls.Add(this.groupWorkouts);
            this.Controls.Add(this.labelHeader);
            this.Name = "WorkoutLog";
            this.Text = "Workout Log";
            this.Load += new System.EventHandler(this.WorkoutLog_Load);
            this.groupWorkouts.ResumeLayout(false);
            this.groupWorkouts.PerformLayout();
            this.groupSWorkouts.ResumeLayout(false);
            this.groupSWorkouts.PerformLayout();
            this.groupCWorkouts.ResumeLayout(false);
            this.groupCWorkouts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.CheckBox checkCardio;
        private System.Windows.Forms.CheckBox checkStrength;
        private System.Windows.Forms.GroupBox groupWorkouts;
        private System.Windows.Forms.TextBox textSWorkouts;
        private System.Windows.Forms.GroupBox groupSWorkouts;
        private System.Windows.Forms.GroupBox groupCWorkouts;
        private System.Windows.Forms.TextBox textCWorkouts;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Timer timerEpilepsy;
    }
}