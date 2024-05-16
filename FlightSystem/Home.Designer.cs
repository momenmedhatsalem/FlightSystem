namespace FlightSystem
{
    partial class Home
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
            this.bookingBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.updateInfoBtn = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.signoutBtn = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.menuBtn = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.userstatusLabel = new System.Windows.Forms.Label();
            this.signupBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingBtn
            // 
            this.bookingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bookingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingBtn.FlatAppearance.BorderSize = 0;
            this.bookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingBtn.ForeColor = System.Drawing.Color.White;
            this.bookingBtn.Image = global::FlightSystem.Resource1.ticket;
            this.bookingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingBtn.Location = new System.Drawing.Point(3, 136);
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.Padding = new System.Windows.Forms.Padding(10, 0, 60, 0);
            this.bookingBtn.Size = new System.Drawing.Size(194, 44);
            this.bookingBtn.TabIndex = 4;
            this.bookingBtn.Tag = "Booking";
            this.bookingBtn.Text = "Booking";
            this.bookingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookingBtn.UseVisualStyleBackColor = true;
            this.bookingBtn.Click += new System.EventHandler(this.bookingBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Image = global::FlightSystem.Resource1.profile;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(3, 369);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Padding = new System.Windows.Forms.Padding(10, 0, 66, 0);
            this.profileBtn.Size = new System.Drawing.Size(194, 44);
            this.profileBtn.TabIndex = 7;
            this.profileBtn.Tag = "Profile";
            this.profileBtn.Text = "Profile";
            this.profileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.menuPanel.ColumnCount = 1;
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuPanel.Controls.Add(this.updateInfoBtn, 0, 4);
            this.menuPanel.Controls.Add(this.reportButton, 0, 3);
            this.menuPanel.Controls.Add(this.signoutBtn, 0, 7);
            this.menuPanel.Controls.Add(this.logoPanel, 0, 0);
            this.menuPanel.Controls.Add(this.profileBtn, 0, 6);
            this.menuPanel.Controls.Add(this.bookingBtn, 0, 2);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RowCount = 8;
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.menuPanel.Size = new System.Drawing.Size(200, 466);
            this.menuPanel.TabIndex = 3;
            // 
            // updateInfoBtn
            // 
            this.updateInfoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.updateInfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateInfoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateInfoBtn.FlatAppearance.BorderSize = 0;
            this.updateInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateInfoBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateInfoBtn.ForeColor = System.Drawing.Color.White;
            this.updateInfoBtn.Image = global::FlightSystem.Resource1.edit;
            this.updateInfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateInfoBtn.Location = new System.Drawing.Point(3, 236);
            this.updateInfoBtn.Name = "updateInfoBtn";
            this.updateInfoBtn.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
            this.updateInfoBtn.Size = new System.Drawing.Size(194, 44);
            this.updateInfoBtn.TabIndex = 10;
            this.updateInfoBtn.Tag = "Update Info";
            this.updateInfoBtn.Text = "Update Info";
            this.updateInfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateInfoBtn.UseVisualStyleBackColor = true;
            this.updateInfoBtn.Click += new System.EventHandler(this.updateInfoBtn_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportButton.FlatAppearance.BorderSize = 0;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.ForeColor = System.Drawing.Color.White;
            this.reportButton.Image = global::FlightSystem.Resource1.report;
            this.reportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportButton.Location = new System.Drawing.Point(3, 186);
            this.reportButton.Name = "reportButton";
            this.reportButton.Padding = new System.Windows.Forms.Padding(10, 0, 66, 0);
            this.reportButton.Size = new System.Drawing.Size(194, 44);
            this.reportButton.TabIndex = 9;
            this.reportButton.Tag = "Report";
            this.reportButton.Text = "Report";
            this.reportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // signoutBtn
            // 
            this.signoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.signoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signoutBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signoutBtn.FlatAppearance.BorderSize = 0;
            this.signoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signoutBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutBtn.ForeColor = System.Drawing.Color.White;
            this.signoutBtn.Image = global::FlightSystem.Resource1.signout;
            this.signoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signoutBtn.Location = new System.Drawing.Point(3, 419);
            this.signoutBtn.Name = "signoutBtn";
            this.signoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 82, 0);
            this.signoutBtn.Size = new System.Drawing.Size(194, 44);
            this.signoutBtn.TabIndex = 9;
            this.signoutBtn.Tag = "Exit";
            this.signoutBtn.Text = "Exit";
            this.signoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signoutBtn.UseVisualStyleBackColor = true;
            this.signoutBtn.Click += new System.EventHandler(this.signoutBtn_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.logo);
            this.logoPanel.Controls.Add(this.menuBtn);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPanel.Location = new System.Drawing.Point(3, 3);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(194, 44);
            this.logoPanel.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::FlightSystem.Resource1.log;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(50, 44);
            this.logo.TabIndex = 0;
            // 
            // menuBtn
            // 
            this.menuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Image = global::FlightSystem.Resource1.menu;
            this.menuBtn.Location = new System.Drawing.Point(124, 0);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(70, 44);
            this.menuBtn.TabIndex = 1;
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // homePanel
            // 
            this.homePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePanel.BackColor = System.Drawing.Color.White;
            this.homePanel.Controls.Add(this.userstatusLabel);
            this.homePanel.Controls.Add(this.signupBtn);
            this.homePanel.Controls.Add(this.loginBtn);
            this.homePanel.Controls.Add(this.welcomeLabel);
            this.homePanel.Location = new System.Drawing.Point(135, 71);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(563, 330);
            this.homePanel.TabIndex = 7;
            // 
            // userstatusLabel
            // 
            this.userstatusLabel.AutoSize = true;
            this.userstatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userstatusLabel.Location = new System.Drawing.Point(60, 141);
            this.userstatusLabel.MaximumSize = new System.Drawing.Size(450, 0);
            this.userstatusLabel.Name = "userstatusLabel";
            this.userstatusLabel.Size = new System.Drawing.Size(416, 40);
            this.userstatusLabel.TabIndex = 10;
            this.userstatusLabel.Text = "You\'re NOT logged in\r\nPlease consider logging in or signing up for a new account";
            this.userstatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(309, 227);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(97, 33);
            this.signupBtn.TabIndex = 9;
            this.signupBtn.Text = "Signup";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(125, 227);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(97, 33);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(128, 68);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(288, 37);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "Welcome Back 👋";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(742, 466);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.homePanel);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button bookingBtn;
        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label userstatusLabel;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button signoutBtn;
        private System.Windows.Forms.Button updateInfoBtn;
    }
}