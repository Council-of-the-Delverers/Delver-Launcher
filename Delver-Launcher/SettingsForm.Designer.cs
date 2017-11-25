namespace Delver_Launcher
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.duBtn = new System.Windows.Forms.Button();
            this.dmcBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // duBtn
            // 
            this.duBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.duBtn.Location = new System.Drawing.Point(12, 12);
            this.duBtn.Name = "duBtn";
            this.duBtn.Size = new System.Drawing.Size(123, 43);
            this.duBtn.TabIndex = 0;
            this.duBtn.Text = "Install Delver-Unlimited";
            this.duBtn.UseVisualStyleBackColor = true;
            // 
            // dmcBtn
            // 
            this.dmcBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dmcBtn.Location = new System.Drawing.Point(141, 12);
            this.dmcBtn.Name = "dmcBtn";
            this.dmcBtn.Size = new System.Drawing.Size(123, 43);
            this.dmcBtn.TabIndex = 1;
            this.dmcBtn.Text = "Install DMC-core";
            this.dmcBtn.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(331, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 43);
            this.progressBar1.TabIndex = 3;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitBtn.Location = new System.Drawing.Point(270, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(55, 43);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 67);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dmcBtn);
            this.Controls.Add(this.duBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button duBtn;
        private System.Windows.Forms.Button dmcBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button exitBtn;
    }
}