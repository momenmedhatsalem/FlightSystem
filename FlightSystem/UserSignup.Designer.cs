namespace FlightSystem
{
    partial class UserSignup
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
            this.rootPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.confirmpassBox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.confirmpassLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.adminForwardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.questionLabel = new System.Windows.Forms.Label();
            this.adminSignupBtn = new System.Windows.Forms.Button();
            this.rootPanel.SuspendLayout();
            this.adminForwardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootPanel
            // 
            this.rootPanel.ColumnCount = 2;
            this.rootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootPanel.Controls.Add(this.fnameBox, 0, 2);
            this.rootPanel.Controls.Add(this.lnameBox, 1, 2);
            this.rootPanel.Controls.Add(this.emailBox, 0, 4);
            this.rootPanel.Controls.Add(this.phoneBox, 0, 6);
            this.rootPanel.Controls.Add(this.passBox, 0, 8);
            this.rootPanel.Controls.Add(this.confirmpassBox, 1, 8);
            this.rootPanel.Controls.Add(this.headerLabel, 0, 0);
            this.rootPanel.Controls.Add(this.firstnameLabel, 0, 1);
            this.rootPanel.Controls.Add(this.lastnameLabel, 1, 1);
            this.rootPanel.Controls.Add(this.emailLabel, 0, 3);
            this.rootPanel.Controls.Add(this.phoneLabel, 0, 5);
            this.rootPanel.Controls.Add(this.passLabel, 0, 7);
            this.rootPanel.Controls.Add(this.confirmpassLabel, 1, 7);
            this.rootPanel.Controls.Add(this.submitBtn, 0, 9);
            this.rootPanel.Controls.Add(this.adminForwardPanel, 0, 10);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPanel.Location = new System.Drawing.Point(10, 0);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.rootPanel.RowCount = 11;
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rootPanel.Size = new System.Drawing.Size(464, 361);
            this.rootPanel.TabIndex = 0;
            this.rootPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rootPanel_Paint);
            // 
            // fnameBox
            // 
            this.fnameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameBox.Location = new System.Drawing.Point(18, 103);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(211, 24);
            this.fnameBox.TabIndex = 7;
            this.fnameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // lnameBox
            // 
            this.lnameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameBox.Location = new System.Drawing.Point(235, 103);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(211, 24);
            this.lnameBox.TabIndex = 8;
            this.lnameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // emailBox
            // 
            this.rootPanel.SetColumnSpan(this.emailBox, 2);
            this.emailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(18, 150);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(428, 24);
            this.emailBox.TabIndex = 9;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // phoneBox
            // 
            this.rootPanel.SetColumnSpan(this.phoneBox, 2);
            this.phoneBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(18, 197);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(428, 24);
            this.phoneBox.TabIndex = 10;
            this.phoneBox.TextChanged += new System.EventHandler(this.phoneBox_TextChanged);
            // 
            // passBox
            // 
            this.passBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(18, 244);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(211, 24);
            this.passBox.TabIndex = 11;
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // confirmpassBox
            // 
            this.confirmpassBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmpassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpassBox.Location = new System.Drawing.Point(235, 244);
            this.confirmpassBox.Name = "confirmpassBox";
            this.confirmpassBox.Size = new System.Drawing.Size(211, 24);
            this.confirmpassBox.TabIndex = 12;
            this.confirmpassBox.UseSystemPasswordChar = true;
            this.confirmpassBox.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerLabel.AutoSize = true;
            this.rootPanel.SetColumnSpan(this.headerLabel, 2);
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(161, 27);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(141, 25);
            this.headerLabel.TabIndex = 13;
            this.headerLabel.Text = "User Signup";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.firstnameLabel.Location = new System.Drawing.Point(18, 83);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(55, 13);
            this.firstnameLabel.TabIndex = 14;
            this.firstnameLabel.Text = "First name";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.lastnameLabel.Location = new System.Drawing.Point(235, 83);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastnameLabel.TabIndex = 15;
            this.lastnameLabel.Text = "Last name";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.DimGray;
            this.emailLabel.Location = new System.Drawing.Point(18, 130);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.ForeColor = System.Drawing.Color.DimGray;
            this.phoneLabel.Location = new System.Drawing.Point(18, 177);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 18;
            this.phoneLabel.Text = "Phone";
            // 
            // passLabel
            // 
            this.passLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passLabel.AutoSize = true;
            this.passLabel.ForeColor = System.Drawing.Color.DimGray;
            this.passLabel.Location = new System.Drawing.Point(18, 224);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(53, 13);
            this.passLabel.TabIndex = 20;
            this.passLabel.Text = "Password";
            // 
            // confirmpassLabel
            // 
            this.confirmpassLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmpassLabel.AutoSize = true;
            this.confirmpassLabel.ForeColor = System.Drawing.Color.DimGray;
            this.confirmpassLabel.Location = new System.Drawing.Point(235, 224);
            this.confirmpassLabel.Name = "confirmpassLabel";
            this.confirmpassLabel.Size = new System.Drawing.Size(90, 13);
            this.confirmpassLabel.TabIndex = 19;
            this.confirmpassLabel.Text = "Confirm password";
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rootPanel.SetColumnSpan(this.submitBtn, 2);
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.Enabled = false;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(178, 283);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Padding = new System.Windows.Forms.Padding(3);
            this.submitBtn.Size = new System.Drawing.Size(108, 30);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Clicked);
            // 
            // adminForwardPanel
            // 
            this.adminForwardPanel.BackColor = System.Drawing.Color.Transparent;
            this.adminForwardPanel.Controls.Add(this.questionLabel);
            this.adminForwardPanel.Controls.Add(this.adminSignupBtn);
            this.adminForwardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminForwardPanel.Location = new System.Drawing.Point(18, 331);
            this.adminForwardPanel.Name = "adminForwardPanel";
            this.adminForwardPanel.Size = new System.Drawing.Size(211, 27);
            this.adminForwardPanel.TabIndex = 22;
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(3, 7);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(95, 13);
            this.questionLabel.TabIndex = 23;
            this.questionLabel.Text = "Are you an admin?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adminSignupBtn
            // 
            this.adminSignupBtn.BackColor = System.Drawing.Color.Transparent;
            this.adminSignupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminSignupBtn.FlatAppearance.BorderSize = 0;
            this.adminSignupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminSignupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminSignupBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.adminSignupBtn.Location = new System.Drawing.Point(104, 3);
            this.adminSignupBtn.Name = "adminSignupBtn";
            this.adminSignupBtn.Size = new System.Drawing.Size(95, 22);
            this.adminSignupBtn.TabIndex = 14;
            this.adminSignupBtn.Text = "Signup as admin";
            this.adminSignupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminSignupBtn.UseVisualStyleBackColor = false;
            this.adminSignupBtn.Click += new System.EventHandler(this.adminSignupBtn_Click);
            // 
            // UserSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.rootPanel);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "UserSignup";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User signup";
            this.rootPanel.ResumeLayout(false);
            this.rootPanel.PerformLayout();
            this.adminForwardPanel.ResumeLayout(false);
            this.adminForwardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rootPanel;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox confirmpassBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label confirmpassLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.FlowLayoutPanel adminForwardPanel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button adminSignupBtn;
    }
}