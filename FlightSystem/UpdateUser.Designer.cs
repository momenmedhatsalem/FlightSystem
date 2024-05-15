namespace FlightSystem
{
    partial class UpdateUser
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
            this.passBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.confirmpassBox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.passBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.passLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.fnameBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lnameBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.emailBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.phoneBox, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.confirmpassBox, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.headerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.firstnameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lastnameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.phoneLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.confirmLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.submitBtn, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // passBox
            // 
            this.passBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(18, 268);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(211, 24);
            this.passBox.TabIndex = 23;
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.TextChanged += new System.EventHandler(this.pass_Change);
            // 
            // passLabel
            // 
            this.passLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passLabel.AutoSize = true;
            this.passLabel.ForeColor = System.Drawing.Color.DimGray;
            this.passLabel.Location = new System.Drawing.Point(18, 248);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(126, 13);
            this.passLabel.TabIndex = 22;
            this.passLabel.Text = "Enter your new password";
            // 
            // fnameBox
            // 
            this.fnameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameBox.Location = new System.Drawing.Point(18, 103);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(211, 24);
            this.fnameBox.TabIndex = 7;
            this.fnameBox.TextChanged += new System.EventHandler(this.nameBox_Change);
            // 
            // lnameBox
            // 
            this.lnameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameBox.Location = new System.Drawing.Point(235, 103);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(211, 24);
            this.lnameBox.TabIndex = 8;
            this.lnameBox.TextChanged += new System.EventHandler(this.nameBox_Change);
            // 
            // emailBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.emailBox, 2);
            this.emailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(18, 158);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(428, 24);
            this.emailBox.TabIndex = 9;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_Change);
            // 
            // phoneBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.phoneBox, 2);
            this.phoneBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(18, 213);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(428, 24);
            this.phoneBox.TabIndex = 10;
            this.phoneBox.TextChanged += new System.EventHandler(this.phoneBox_Change);
            // 
            // confirmpassBox
            // 
            this.confirmpassBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmpassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpassBox.Location = new System.Drawing.Point(235, 268);
            this.confirmpassBox.Name = "confirmpassBox";
            this.confirmpassBox.Size = new System.Drawing.Size(211, 24);
            this.confirmpassBox.TabIndex = 11;
            this.confirmpassBox.UseSystemPasswordChar = true;
            this.confirmpassBox.TextChanged += new System.EventHandler(this.pass_Change);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.headerLabel, 2);
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(164, 27);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(136, 25);
            this.headerLabel.TabIndex = 13;
            this.headerLabel.Text = "UpdateUser";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
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
            this.emailLabel.Location = new System.Drawing.Point(18, 138);
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
            this.phoneLabel.Location = new System.Drawing.Point(18, 193);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 18;
            this.phoneLabel.Text = "Phone";
            // 
            // confirmLabel
            // 
            this.confirmLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.ForeColor = System.Drawing.Color.DimGray;
            this.confirmLabel.Location = new System.Drawing.Point(235, 248);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(113, 13);
            this.confirmLabel.TabIndex = 20;
            this.confirmLabel.Text = "Confirm new password";
            this.confirmLabel.Click += new System.EventHandler(this.passLabel_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.submitBtn, 2);
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(178, 315);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Padding = new System.Windows.Forms.Padding(3);
            this.submitBtn.Size = new System.Drawing.Size(108, 30);
            this.submitBtn.TabIndex = 21;
            this.submitBtn.Text = "Update";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "UpdateUser";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateUser";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox confirmpassBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passBox;
    }
}