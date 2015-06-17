namespace FishingNative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SteamLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordEmailLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordEmailTextBox = new System.Windows.Forms.TextBox();
            this.CSGOImagePanel = new System.Windows.Forms.Panel();
            this.SteamLogoPanel = new System.Windows.Forms.Panel();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.FinalButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SteamLabel
            // 
            this.SteamLabel.AutoSize = true;
            this.SteamLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SteamLabel.Location = new System.Drawing.Point(226, 18);
            this.SteamLabel.Name = "SteamLabel";
            this.SteamLabel.Size = new System.Drawing.Size(63, 23);
            this.SteamLabel.TabIndex = 1;
            this.SteamLabel.Text = "Steam";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CSGOImagePanel);
            this.MainPanel.Controls.Add(this.PasswordEmailTextBox);
            this.MainPanel.Controls.Add(this.EmailTextBox);
            this.MainPanel.Controls.Add(this.PasswordTextBox);
            this.MainPanel.Controls.Add(this.LoginTextBox);
            this.MainPanel.Controls.Add(this.PasswordEmailLabel);
            this.MainPanel.Controls.Add(this.EmailLabel);
            this.MainPanel.Controls.Add(this.PasswordLabel);
            this.MainPanel.Controls.Add(this.LoginLabel);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(200, 307);
            this.MainPanel.TabIndex = 2;
           
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(15, 33);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(36, 14);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login";
            
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(15, 60);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(58, 14);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
           
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(15, 87);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 14);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "E-mail";
            // 
            // PasswordEmailLabel
            // 
            this.PasswordEmailLabel.AutoSize = true;
            this.PasswordEmailLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordEmailLabel.Location = new System.Drawing.Point(15, 114);
            this.PasswordEmailLabel.Name = "PasswordEmailLabel";
            this.PasswordEmailLabel.Size = new System.Drawing.Size(58, 14);
            this.PasswordEmailLabel.TabIndex = 3;
            this.PasswordEmailLabel.Text = "Password";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.LoginTextBox.Location = new System.Drawing.Point(86, 26);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 21);
            this.LoginTextBox.TabIndex = 4;
            this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(86, 53);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 21);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.EmailTextBox.Location = new System.Drawing.Point(86, 80);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 21);
            this.EmailTextBox.TabIndex = 6;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // PasswordEmailTextBox
            // 
            this.PasswordEmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasswordEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordEmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PasswordEmailTextBox.Location = new System.Drawing.Point(86, 107);
            this.PasswordEmailTextBox.Name = "PasswordEmailTextBox";
            this.PasswordEmailTextBox.Size = new System.Drawing.Size(100, 21);
            this.PasswordEmailTextBox.TabIndex = 7;
            this.PasswordEmailTextBox.UseSystemPasswordChar = true;
            this.PasswordEmailTextBox.TextChanged += new System.EventHandler(this.PasswordEmailBox_TextChanged);
            // 
            // CSGOImagePanel
            // 
            this.CSGOImagePanel.BackgroundImage = global::CSGOLottery.Properties.Resources.logoCS;
            this.CSGOImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CSGOImagePanel.Location = new System.Drawing.Point(3, 166);
            this.CSGOImagePanel.Name = "CSGOImagePanel";
            this.CSGOImagePanel.Size = new System.Drawing.Size(200, 138);
            this.CSGOImagePanel.TabIndex = 3;
            // 
            // SteamLogoPanel
            // 
            this.SteamLogoPanel.BackgroundImage = global::CSGOLottery.Properties.Resources.steam;
            this.SteamLogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SteamLogoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SteamLogoPanel.Location = new System.Drawing.Point(287, 12);
            this.SteamLogoPanel.Name = "SteamLogoPanel";
            this.SteamLogoPanel.Size = new System.Drawing.Size(43, 35);
            this.SteamLogoPanel.TabIndex = 0;
            
            this.SteamLogoPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // ProgressBar
            // 
            this.ProgressBar.ForeColor = System.Drawing.Color.DarkGray;
            this.ProgressBar.Location = new System.Drawing.Point(12, 361);
            this.ProgressBar.MarqueeAnimationSpeed = 50;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(188, 23);
            this.ProgressBar.Step = 20;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 3;
            this.ProgressBar.Visible = false;
            // 
            // FinalButton
            // 
            this.FinalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinalButton.Enabled = false;
            this.FinalButton.FlatAppearance.BorderSize = 0;
            this.FinalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FinalButton.Location = new System.Drawing.Point(255, 361);
            this.FinalButton.Name = "FinalButton";
            this.FinalButton.Size = new System.Drawing.Size(75, 23);
            this.FinalButton.TabIndex = 4;
            this.FinalButton.Text = "Get Items!";
            this.FinalButton.UseVisualStyleBackColor = true;
            this.FinalButton.Click += new System.EventHandler(this.FinalButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(12, 344);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(46, 14);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(336, 396);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.FinalButton);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SteamLabel);
            this.Controls.Add(this.SteamLogoPanel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Text = "CS:GO Items Lottery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SteamLogoPanel;
        private System.Windows.Forms.Label SteamLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox PasswordEmailTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label PasswordEmailLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Panel CSGOImagePanel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button FinalButton;
        private System.Windows.Forms.Label StatusLabel;
    }
}

