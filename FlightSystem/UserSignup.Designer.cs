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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.confirmpassBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.headerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fullnameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.phoneLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.passLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.submitBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.fnameBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lnameBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.phoneBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.passBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.confirmpassBox, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 314);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.headerLabel, 3);
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(186, 37);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(141, 25);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "User Signup";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.Location = new System.Drawing.Point(18, 100);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(94, 42);
            this.fullnameLabel.TabIndex = 1;
            this.fullnameLabel.Text = "Full name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(18, 142);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(94, 42);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(18, 184);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(94, 42);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Phone";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(18, 226);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(94, 42);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Password";
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.submitBtn, 3);
            this.submitBtn.Enabled = false;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(182, 278);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(150, 25);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // fnameBox
            // 
            this.fnameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameBox.Location = new System.Drawing.Point(118, 103);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(186, 24);
            this.fnameBox.TabIndex = 7;
            this.fnameBox.Leave += new System.EventHandler(this.fnameBox_Leave);
            // 
            // lnameBox
            // 
            this.lnameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameBox.Location = new System.Drawing.Point(310, 103);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(186, 24);
            this.lnameBox.TabIndex = 8;
            this.lnameBox.Leave += new System.EventHandler(this.lnameBox_Leave);
            // 
            // emailBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.emailBox, 2);
            this.emailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(118, 145);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(378, 24);
            this.emailBox.TabIndex = 9;
            this.emailBox.Leave += new System.EventHandler(this.emailBox_Leave);
            // 
            // phoneBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.phoneBox, 2);
            this.phoneBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(118, 187);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(378, 24);
            this.phoneBox.TabIndex = 10;
            this.phoneBox.Leave += new System.EventHandler(this.phoneBox_Leave);
            // 
            // passBox
            // 
            this.passBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(118, 229);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(186, 24);
            this.passBox.TabIndex = 11;
            this.passBox.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // confirmpassBox
            // 
            this.confirmpassBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmpassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpassBox.Location = new System.Drawing.Point(310, 229);
            this.confirmpassBox.Name = "confirmpassBox";
            this.confirmpassBox.PasswordChar = '*';
            this.confirmpassBox.Size = new System.Drawing.Size(186, 24);
            this.confirmpassBox.TabIndex = 12;
            this.confirmpassBox.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // UserSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 314);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 298);
            this.Name = "UserSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox confirmpassBox;
    }
}