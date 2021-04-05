namespace LevelEditor
{
    partial class MainForm
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
            this.groupCreateNewMap = new System.Windows.Forms.GroupBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupCreateNewMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCreateNewMap
            // 
            this.groupCreateNewMap.Controls.Add(this.buttonCreate);
            this.groupCreateNewMap.Controls.Add(this.textHeight);
            this.groupCreateNewMap.Controls.Add(this.textWidth);
            this.groupCreateNewMap.Controls.Add(this.labelHeight);
            this.groupCreateNewMap.Controls.Add(this.labelWidth);
            this.groupCreateNewMap.Location = new System.Drawing.Point(12, 83);
            this.groupCreateNewMap.Name = "groupCreateNewMap";
            this.groupCreateNewMap.Size = new System.Drawing.Size(210, 162);
            this.groupCreateNewMap.TabIndex = 0;
            this.groupCreateNewMap.TabStop = false;
            this.groupCreateNewMap.Text = "Create New Map";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(6, 29);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(73, 13);
            this.labelWidth.TabIndex = 1;
            this.labelWidth.Text = "Width (in tiles)";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(6, 61);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(76, 13);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Height (in tiles)";
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(85, 26);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(119, 20);
            this.textWidth.TabIndex = 4;
            this.textWidth.Text = "20";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(85, 58);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(119, 20);
            this.textHeight.TabIndex = 5;
            this.textHeight.Text = "20";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(9, 86);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(195, 65);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Create Map";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(210, 65);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load Map";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 251);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.groupCreateNewMap);
            this.Name = "MainForm";
            this.Text = "Level Editor";
            this.groupCreateNewMap.ResumeLayout(false);
            this.groupCreateNewMap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCreateNewMap;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Button buttonLoad;
    }
}

