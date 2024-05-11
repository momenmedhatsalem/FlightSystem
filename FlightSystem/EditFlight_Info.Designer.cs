namespace FlightSystem
{
    partial class EditFlight_Info
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
            this.AvailableSeats = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.DepatureDate = new System.Windows.Forms.DateTimePicker();
            this.ArrivalIDs = new System.Windows.Forms.ComboBox();
            this.DepatureIDs = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AvailableSeats
            // 
            this.AvailableSeats.Location = new System.Drawing.Point(341, 228);
            this.AvailableSeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvailableSeats.Name = "AvailableSeats";
            this.AvailableSeats.Size = new System.Drawing.Size(58, 20);
            this.AvailableSeats.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(146, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Arrival Airport ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Departure Airport ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 70);
            this.button1.TabIndex = 37;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Update_Data);
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.Location = new System.Drawing.Point(341, 188);
            this.ArrivalDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.Size = new System.Drawing.Size(151, 20);
            this.ArrivalDate.TabIndex = 36;
            // 
            // DepatureDate
            // 
            this.DepatureDate.Location = new System.Drawing.Point(341, 148);
            this.DepatureDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepatureDate.Name = "DepatureDate";
            this.DepatureDate.Size = new System.Drawing.Size(151, 20);
            this.DepatureDate.TabIndex = 35;
            // 
            // ArrivalIDs
            // 
            this.ArrivalIDs.FormattingEnabled = true;
            this.ArrivalIDs.Location = new System.Drawing.Point(359, 108);
            this.ArrivalIDs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArrivalIDs.Name = "ArrivalIDs";
            this.ArrivalIDs.Size = new System.Drawing.Size(92, 21);
            this.ArrivalIDs.TabIndex = 34;
            // 
            // DepatureIDs
            // 
            this.DepatureIDs.FormattingEnabled = true;
            this.DepatureIDs.Location = new System.Drawing.Point(359, 59);
            this.DepatureIDs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepatureIDs.Name = "DepatureIDs";
            this.DepatureIDs.Size = new System.Drawing.Size(92, 21);
            this.DepatureIDs.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Arrival Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Departure Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Available Seats";
            // 
            // EditFlight_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AvailableSeats);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ArrivalDate);
            this.Controls.Add(this.DepatureDate);
            this.Controls.Add(this.ArrivalIDs);
            this.Controls.Add(this.DepatureIDs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "EditFlight_Info";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditFlight_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AvailableSeats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker ArrivalDate;
        private System.Windows.Forms.DateTimePicker DepatureDate;
        private System.Windows.Forms.ComboBox ArrivalIDs;
        private System.Windows.Forms.ComboBox DepatureIDs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}