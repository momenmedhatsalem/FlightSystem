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
            this.button1 = new System.Windows.Forms.Button();
            this.ArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.DepatureDate = new System.Windows.Forms.DateTimePicker();
            this.ArrivalIDs = new System.Windows.Forms.ComboBox();
            this.DepatureIDs = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AvailableSeats = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(301, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(488, 86);
            this.button1.TabIndex = 25;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Save_Changes_Button);
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.Location = new System.Drawing.Point(372, 255);
            this.ArrivalDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.Size = new System.Drawing.Size(200, 22);
            this.ArrivalDate.TabIndex = 23;
            // 
            // DepatureDate
            // 
            this.DepatureDate.Location = new System.Drawing.Point(372, 206);
            this.DepatureDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DepatureDate.Name = "DepatureDate";
            this.DepatureDate.Size = new System.Drawing.Size(200, 22);
            this.DepatureDate.TabIndex = 22;
            this.DepatureDate.ValueChanged += new System.EventHandler(this.DepatureDate_ValueChanged);
            // 
            // ArrivalIDs
            // 
            this.ArrivalIDs.FormattingEnabled = true;
            this.ArrivalIDs.Location = new System.Drawing.Point(396, 156);
            this.ArrivalIDs.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ArrivalIDs.Name = "ArrivalIDs";
            this.ArrivalIDs.Size = new System.Drawing.Size(121, 24);
            this.ArrivalIDs.TabIndex = 21;
            this.ArrivalIDs.SelectedIndexChanged += new System.EventHandler(this.ArrivalIDs_SelectedIndexChanged);
            // 
            // DepatureIDs
            // 
            this.DepatureIDs.FormattingEnabled = true;
            this.DepatureIDs.Location = new System.Drawing.Point(396, 96);
            this.DepatureIDs.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DepatureIDs.Name = "DepatureIDs";
            this.DepatureIDs.Size = new System.Drawing.Size(121, 24);
            this.DepatureIDs.TabIndex = 20;
            this.DepatureIDs.SelectedIndexChanged += new System.EventHandler(this.DispatureAirport);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Arrival Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Departure Date";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Available Seats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Departure Airport ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Arrival Airport ID";
            // 
            // AvailableSeats
            // 
            this.AvailableSeats.Location = new System.Drawing.Point(372, 304);
            this.AvailableSeats.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AvailableSeats.Name = "AvailableSeats";
            this.AvailableSeats.Size = new System.Drawing.Size(76, 22);
            this.AvailableSeats.TabIndex = 29;
            this.AvailableSeats.TextChanged += new System.EventHandler(this.AvailableSeats_TextChanged);
            // 
            // EditFlight_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditFlight_Info";
            this.Text = "EditFlight";
            this.Load += new System.EventHandler(this.EditFlight_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker ArrivalDate;
        private System.Windows.Forms.DateTimePicker DepatureDate;
        private System.Windows.Forms.ComboBox ArrivalIDs;
        private System.Windows.Forms.ComboBox DepatureIDs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AvailableSeats;
    }
}