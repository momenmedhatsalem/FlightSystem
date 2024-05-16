namespace FlightSystem
{
    partial class AdminHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddAirCraftbtn = new System.Windows.Forms.Button();
            this.UpdateAirCraftbtn = new System.Windows.Forms.Button();
            this.AddFlightBtn = new System.Windows.Forms.Button();
            this.UpdateFlightBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Admin!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddAirCraftbtn
            // 
            this.AddAirCraftbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddAirCraftbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAirCraftbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddAirCraftbtn.Location = new System.Drawing.Point(97, 118);
            this.AddAirCraftbtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddAirCraftbtn.Name = "AddAirCraftbtn";
            this.AddAirCraftbtn.Size = new System.Drawing.Size(124, 50);
            this.AddAirCraftbtn.TabIndex = 1;
            this.AddAirCraftbtn.Text = "Add Aircraft";
            this.AddAirCraftbtn.UseVisualStyleBackColor = false;
            this.AddAirCraftbtn.Click += new System.EventHandler(this.AddAirCraftbtn_Click);
            // 
            // UpdateAirCraftbtn
            // 
            this.UpdateAirCraftbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateAirCraftbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAirCraftbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateAirCraftbtn.Location = new System.Drawing.Point(97, 207);
            this.UpdateAirCraftbtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateAirCraftbtn.Name = "UpdateAirCraftbtn";
            this.UpdateAirCraftbtn.Size = new System.Drawing.Size(124, 50);
            this.UpdateAirCraftbtn.TabIndex = 2;
            this.UpdateAirCraftbtn.Text = "Update Aircraft";
            this.UpdateAirCraftbtn.UseVisualStyleBackColor = false;
            this.UpdateAirCraftbtn.Click += new System.EventHandler(this.UpdateAirCraftbtn_Click);
            // 
            // AddFlightBtn
            // 
            this.AddFlightBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddFlightBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFlightBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddFlightBtn.Location = new System.Drawing.Point(370, 118);
            this.AddFlightBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddFlightBtn.Name = "AddFlightBtn";
            this.AddFlightBtn.Size = new System.Drawing.Size(124, 50);
            this.AddFlightBtn.TabIndex = 3;
            this.AddFlightBtn.Text = "Add Flight";
            this.AddFlightBtn.UseVisualStyleBackColor = false;
            this.AddFlightBtn.Click += new System.EventHandler(this.AddFlightBtn_Click);
            // 
            // UpdateFlightBtn
            // 
            this.UpdateFlightBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateFlightBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateFlightBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateFlightBtn.Location = new System.Drawing.Point(370, 207);
            this.UpdateFlightBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateFlightBtn.Name = "UpdateFlightBtn";
            this.UpdateFlightBtn.Size = new System.Drawing.Size(124, 50);
            this.UpdateFlightBtn.TabIndex = 4;
            this.UpdateFlightBtn.Text = "Update Flight";
            this.UpdateFlightBtn.UseVisualStyleBackColor = false;
            this.UpdateFlightBtn.Click += new System.EventHandler(this.UpdateFlightBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "Back to Home";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.UpdateFlightBtn);
            this.Controls.Add(this.AddFlightBtn);
            this.Controls.Add(this.UpdateAirCraftbtn);
            this.Controls.Add(this.AddAirCraftbtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAirCraftbtn;
        private System.Windows.Forms.Button UpdateAirCraftbtn;
        private System.Windows.Forms.Button AddFlightBtn;
        private System.Windows.Forms.Button UpdateFlightBtn;
        private System.Windows.Forms.Button button3;
    }
}