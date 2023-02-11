namespace Example_21_1
{
    partial class Form1
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
            this.radioButtonSystem = new System.Windows.Forms.RadioButton();
            this.radioButtonFile = new System.Windows.Forms.RadioButton();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.listBoxSystem = new System.Windows.Forms.ListBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonSystem
            // 
            this.radioButtonSystem.AutoSize = true;
            this.radioButtonSystem.Checked = true;
            this.radioButtonSystem.Location = new System.Drawing.Point(12, 12);
            this.radioButtonSystem.Name = "radioButtonSystem";
            this.radioButtonSystem.Size = new System.Drawing.Size(98, 17);
            this.radioButtonSystem.TabIndex = 0;
            this.radioButtonSystem.TabStop = true;
            this.radioButtonSystem.Text = "System Sounds";
            this.radioButtonSystem.UseVisualStyleBackColor = true;
            this.radioButtonSystem.CheckedChanged += new System.EventHandler(this.radioButtonSystem_CheckedChanged);
            // 
            // radioButtonFile
            // 
            this.radioButtonFile.AutoSize = true;
            this.radioButtonFile.Location = new System.Drawing.Point(240, 12);
            this.radioButtonFile.Name = "radioButtonFile";
            this.radioButtonFile.Size = new System.Drawing.Size(80, 17);
            this.radioButtonFile.TabIndex = 2;
            this.radioButtonFile.Text = "File Sounds";
            this.radioButtonFile.UseVisualStyleBackColor = true;
            this.radioButtonFile.CheckedChanged += new System.EventHandler(this.radioButtonFile_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Enabled = false;
            this.btnBrowse.Location = new System.Drawing.Point(240, 35);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(92, 26);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // listBoxSystem
            // 
            this.listBoxSystem.FormattingEnabled = true;
            this.listBoxSystem.Location = new System.Drawing.Point(12, 35);
            this.listBoxSystem.Name = "listBoxSystem";
            this.listBoxSystem.ScrollAlwaysVisible = true;
            this.listBoxSystem.Size = new System.Drawing.Size(166, 95);
            this.listBoxSystem.TabIndex = 1;
            // 
            // lblPath
            // 
            this.lblPath.BackColor = System.Drawing.Color.LightGray;
            this.lblPath.Enabled = false;
            this.lblPath.Location = new System.Drawing.Point(245, 72);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(174, 58);
            this.lblPath.TabIndex = 4;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 160);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(407, 26);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 198);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.listBoxSystem);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.radioButtonFile);
            this.Controls.Add(this.radioButtonSystem);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Example 21-1 (Sound Player)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonSystem;
        private System.Windows.Forms.RadioButton radioButtonFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox listBoxSystem;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnPlay;
    }
}

