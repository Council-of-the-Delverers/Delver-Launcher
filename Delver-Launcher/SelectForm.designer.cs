namespace Delver_Launcher
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.delverRadio = new System.Windows.Forms.RadioButton();
            this.delvEditRadio = new System.Windows.Forms.RadioButton();
            this.okBtn = new System.Windows.Forms.Button();
            this.rememberBox = new System.Windows.Forms.CheckBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.wwwLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.subredditLabel = new System.Windows.Forms.Label();
            this.discordLabel = new System.Windows.Forms.Label();
            this.gearLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.workshopLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // delverRadio
            // 
            this.delverRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delverRadio.AutoSize = true;
            this.delverRadio.Enabled = false;
            this.delverRadio.Location = new System.Drawing.Point(12, 29);
            this.delverRadio.Name = "delverRadio";
            this.delverRadio.Size = new System.Drawing.Size(101, 21);
            this.delverRadio.TabIndex = 0;
            this.delverRadio.TabStop = true;
            this.delverRadio.Text = "Play Delver";
            this.toolTip1.SetToolTip(this.delverRadio, "The base game");
            this.delverRadio.UseVisualStyleBackColor = true;
            this.delverRadio.CheckedChanged += new System.EventHandler(this.delverRadio_CheckedChanged);
            // 
            // delvEditRadio
            // 
            this.delvEditRadio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delvEditRadio.AutoSize = true;
            this.delvEditRadio.Enabled = false;
            this.delvEditRadio.Location = new System.Drawing.Point(12, 56);
            this.delvEditRadio.Name = "delvEditRadio";
            this.delvEditRadio.Size = new System.Drawing.Size(112, 21);
            this.delvEditRadio.TabIndex = 1;
            this.delvEditRadio.TabStop = true;
            this.delvEditRadio.Text = "Play DelvEdit";
            this.toolTip1.SetToolTip(this.delvEditRadio, "The level editor");
            this.delvEditRadio.UseVisualStyleBackColor = true;
            this.delvEditRadio.CheckedChanged += new System.EventHandler(this.delvEditRadio_CheckedChanged);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Enabled = false;
            this.okBtn.Location = new System.Drawing.Point(164, 124);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(84, 29);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "Play";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // rememberBox
            // 
            this.rememberBox.AutoSize = true;
            this.rememberBox.Location = new System.Drawing.Point(12, 83);
            this.rememberBox.Name = "rememberBox";
            this.rememberBox.Size = new System.Drawing.Size(144, 21);
            this.rememberBox.TabIndex = 2;
            this.rememberBox.Text = "Remember choice";
            this.toolTip1.SetToolTip(this.rememberBox, "Always launch the same");
            this.rememberBox.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Location = new System.Drawing.Point(254, 124);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(84, 29);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Cancel";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // wwwLabel
            // 
            this.wwwLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wwwLabel.AutoSize = true;
            this.wwwLabel.Location = new System.Drawing.Point(36, 130);
            this.wwwLabel.Name = "wwwLabel";
            this.wwwLabel.Size = new System.Drawing.Size(122, 17);
            this.wwwLabel.TabIndex = 7;
            this.wwwLabel.Text = "Launcher by CotD";
            this.toolTip1.SetToolTip(this.wwwLabel, "Click to visit website");
            this.wwwLabel.Click += new System.EventHandler(this.wwwLabel_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitLabel.AutoSize = true;
            this.exitLabel.Location = new System.Drawing.Point(321, 9);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(17, 17);
            this.exitLabel.TabIndex = 5;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(9, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(49, 17);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Delver";
            // 
            // aboutLabel
            // 
            this.aboutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Location = new System.Drawing.Point(299, 9);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(16, 17);
            this.aboutLabel.TabIndex = 8;
            this.aboutLabel.Text = "?";
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            // 
            // subredditLabel
            // 
            this.subredditLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subredditLabel.AutoSize = true;
            this.subredditLabel.Location = new System.Drawing.Point(106, 18);
            this.subredditLabel.Name = "subredditLabel";
            this.subredditLabel.Size = new System.Drawing.Size(62, 17);
            this.subredditLabel.TabIndex = 9;
            this.subredditLabel.Text = "/r/Delver";
            this.subredditLabel.Click += new System.EventHandler(this.subredditLabel_Click);
            // 
            // discordLabel
            // 
            this.discordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discordLabel.AutoSize = true;
            this.discordLabel.Location = new System.Drawing.Point(50, 35);
            this.discordLabel.Name = "discordLabel";
            this.discordLabel.Size = new System.Drawing.Size(118, 17);
            this.discordLabel.TabIndex = 10;
            this.discordLabel.Text = "Unofficial Discord";
            this.discordLabel.Click += new System.EventHandler(this.discordLabel_Click);
            // 
            // gearLabel
            // 
            this.gearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gearLabel.AutoSize = true;
            this.gearLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gearLabel.Location = new System.Drawing.Point(271, 11);
            this.gearLabel.Name = "gearLabel";
            this.gearLabel.Size = new System.Drawing.Size(22, 15);
            this.gearLabel.TabIndex = 11;
            this.gearLabel.Text = "";
            this.gearLabel.Click += new System.EventHandler(this.gearLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.workshopLabel);
            this.groupBox1.Controls.Add(this.subredditLabel);
            this.groupBox1.Controls.Add(this.discordLabel);
            this.groupBox1.Location = new System.Drawing.Point(164, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Links";
            // 
            // workshopLabel
            // 
            this.workshopLabel.AutoSize = true;
            this.workshopLabel.Location = new System.Drawing.Point(96, 52);
            this.workshopLabel.Name = "workshopLabel";
            this.workshopLabel.Size = new System.Drawing.Size(72, 17);
            this.workshopLabel.TabIndex = 11;
            this.workshopLabel.Text = "Workshop";
            this.workshopLabel.Click += new System.EventHandler(this.workshopLabel_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 165);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gearLabel);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.wwwLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.rememberBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.delvEditRadio);
            this.Controls.Add(this.delverRadio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delver Launcher";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton delverRadio;
        private System.Windows.Forms.RadioButton delvEditRadio;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.CheckBox rememberBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label wwwLabel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label subredditLabel;
        private System.Windows.Forms.Label discordLabel;
        private System.Windows.Forms.Label gearLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label workshopLabel;
    }
}