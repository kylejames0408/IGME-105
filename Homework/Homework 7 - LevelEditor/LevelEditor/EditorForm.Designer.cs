namespace LevelEditor
{
    partial class EditorForm
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
            this.groupTiles = new System.Windows.Forms.GroupBox();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonBrown = new System.Windows.Forms.Button();
            this.buttonGray = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.groupCurrent = new System.Windows.Forms.GroupBox();
            this.pictureCurrent = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupMap = new System.Windows.Forms.GroupBox();
            this.groupTiles.SuspendLayout();
            this.groupCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupTiles
            // 
            this.groupTiles.Controls.Add(this.buttonBlack);
            this.groupTiles.Controls.Add(this.buttonBlue);
            this.groupTiles.Controls.Add(this.buttonRed);
            this.groupTiles.Controls.Add(this.buttonBrown);
            this.groupTiles.Controls.Add(this.buttonGray);
            this.groupTiles.Controls.Add(this.buttonGreen);
            this.groupTiles.Location = new System.Drawing.Point(12, 12);
            this.groupTiles.Name = "groupTiles";
            this.groupTiles.Size = new System.Drawing.Size(120, 189);
            this.groupTiles.TabIndex = 0;
            this.groupTiles.TabStop = false;
            this.groupTiles.Text = "Tile Selector";
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.Location = new System.Drawing.Point(64, 131);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(50, 50);
            this.buttonBlack.TabIndex = 6;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.PenColorSelection);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonBlue.Location = new System.Drawing.Point(6, 131);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(50, 50);
            this.buttonBlue.TabIndex = 5;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.PenColorSelection);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(64, 75);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(50, 50);
            this.buttonRed.TabIndex = 4;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.PenColorSelection);
            // 
            // buttonBrown
            // 
            this.buttonBrown.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonBrown.Location = new System.Drawing.Point(6, 75);
            this.buttonBrown.Name = "buttonBrown";
            this.buttonBrown.Size = new System.Drawing.Size(50, 50);
            this.buttonBrown.TabIndex = 3;
            this.buttonBrown.UseVisualStyleBackColor = false;
            this.buttonBrown.Click += new System.EventHandler(this.PenColorSelection);
            // 
            // buttonGray
            // 
            this.buttonGray.BackColor = System.Drawing.Color.Silver;
            this.buttonGray.Location = new System.Drawing.Point(64, 19);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.Size = new System.Drawing.Size(50, 50);
            this.buttonGray.TabIndex = 2;
            this.buttonGray.UseVisualStyleBackColor = false;
            this.buttonGray.Click += new System.EventHandler(this.PenColorSelection);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Location = new System.Drawing.Point(6, 19);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(50, 50);
            this.buttonGreen.TabIndex = 1;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.PenColorSelection);
            // 
            // groupCurrent
            // 
            this.groupCurrent.Controls.Add(this.pictureCurrent);
            this.groupCurrent.Location = new System.Drawing.Point(13, 208);
            this.groupCurrent.Name = "groupCurrent";
            this.groupCurrent.Size = new System.Drawing.Size(120, 120);
            this.groupCurrent.TabIndex = 6;
            this.groupCurrent.TabStop = false;
            this.groupCurrent.Text = "Current Tile";
            // 
            // pictureCurrent
            // 
            this.pictureCurrent.Location = new System.Drawing.Point(25, 28);
            this.pictureCurrent.Name = "pictureCurrent";
            this.pictureCurrent.Size = new System.Drawing.Size(70, 70);
            this.pictureCurrent.TabIndex = 0;
            this.pictureCurrent.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(18, 334);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(108, 100);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(18, 512);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(108, 100);
            this.buttonLoad.TabIndex = 8;
            this.buttonLoad.Text = "Load File";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupMap
            // 
            this.groupMap.Location = new System.Drawing.Point(138, 12);
            this.groupMap.Name = "groupMap";
            this.groupMap.Size = new System.Drawing.Size(600, 600);
            this.groupMap.TabIndex = 9;
            this.groupMap.TabStop = false;
            this.groupMap.Text = "Map";
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 619);
            this.Controls.Add(this.groupMap);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupCurrent);
            this.Controls.Add(this.groupTiles);
            this.Name = "EditorForm";
            this.Text = "Level Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorForm_FormClosing);
            this.Load += new System.EventHandler(this.EditorForm_Load);
            this.groupTiles.ResumeLayout(false);
            this.groupCurrent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCurrent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTiles;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonBrown;
        private System.Windows.Forms.Button buttonGray;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.GroupBox groupCurrent;
        private System.Windows.Forms.PictureBox pictureCurrent;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupMap;
    }
}