namespace FlightSystem
{
    partial class Booking
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
            this.lbl_booking = new System.Windows.Forms.Label();
            this.comboBoxDeparture = new System.Windows.Forms.ComboBox();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.numberOfPassengersBox = new System.Windows.Forms.ComboBox();
            this.flightClassBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdioOneWay = new System.Windows.Forms.RadioButton();
            this.rdioTwoWay = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_booking
            // 
            this.lbl_booking.AutoSize = true;
            this.lbl_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_booking.Location = new System.Drawing.Point(30, 28);
            this.lbl_booking.Name = "lbl_booking";
            this.lbl_booking.Size = new System.Drawing.Size(172, 31);
            this.lbl_booking.TabIndex = 0;
            this.lbl_booking.Text = "Book a Flight";
            this.lbl_booking.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxDeparture
            // 
            this.comboBoxDeparture.FormattingEnabled = true;
            this.comboBoxDeparture.Location = new System.Drawing.Point(50, 81);
            this.comboBoxDeparture.Name = "comboBoxDeparture";
            this.comboBoxDeparture.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeparture.TabIndex = 1;
            this.comboBoxDeparture.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeparture_SelectedIndexChanged);
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(50, 122);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDestination.TabIndex = 2;
            this.comboBoxDestination.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestination_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(204, 123);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // numberOfPassengersBox
            // 
            this.numberOfPassengersBox.FormattingEnabled = true;
            this.numberOfPassengersBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.numberOfPassengersBox.Location = new System.Drawing.Point(50, 245);
            this.numberOfPassengersBox.Name = "numberOfPassengersBox";
            this.numberOfPassengersBox.Size = new System.Drawing.Size(121, 21);
            this.numberOfPassengersBox.Sorted = true;
            this.numberOfPassengersBox.TabIndex = 5;
            this.numberOfPassengersBox.Text = "Passengers";
            // 
            // flightClassBox
            // 
            this.flightClassBox.FormattingEnabled = true;
            this.flightClassBox.Items.AddRange(new object[] {
            "Business",
            "Economy",
            "First"});
            this.flightClassBox.Location = new System.Drawing.Point(50, 272);
            this.flightClassBox.Name = "flightClassBox";
            this.flightClassBox.Size = new System.Drawing.Size(121, 21);
            this.flightClassBox.Sorted = true;
            this.flightClassBox.TabIndex = 6;
            this.flightClassBox.Text = "Class";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search Flights";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdioOneWay
            // 
            this.rdioOneWay.AutoSize = true;
            this.rdioOneWay.Location = new System.Drawing.Point(240, 249);
            this.rdioOneWay.Name = "rdioOneWay";
            this.rdioOneWay.Size = new System.Drawing.Size(70, 17);
            this.rdioOneWay.TabIndex = 8;
            this.rdioOneWay.TabStop = true;
            this.rdioOneWay.Text = "One Way";
            this.rdioOneWay.UseVisualStyleBackColor = true;
            this.rdioOneWay.CheckedChanged += new System.EventHandler(this.radioBooking_CheckedChanged);
            // 
            // rdioTwoWay
            // 
            this.rdioTwoWay.AutoSize = true;
            this.rdioTwoWay.Location = new System.Drawing.Point(240, 272);
            this.rdioTwoWay.Name = "rdioTwoWay";
            this.rdioTwoWay.Size = new System.Drawing.Size(57, 17);
            this.rdioTwoWay.TabIndex = 9;
            this.rdioTwoWay.TabStop = true;
            this.rdioTwoWay.Text = "Return";
            this.rdioTwoWay.UseVisualStyleBackColor = true;
            this.rdioTwoWay.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.rdioTwoWay);
            this.Controls.Add(this.rdioOneWay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flightClassBox);
            this.Controls.Add(this.numberOfPassengersBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxDestination);
            this.Controls.Add(this.comboBoxDeparture);
            this.Controls.Add(this.lbl_booking);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_booking;
        private System.Windows.Forms.ComboBox comboBoxDeparture;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox numberOfPassengersBox;
        private System.Windows.Forms.ComboBox flightClassBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdioOneWay;
        private System.Windows.Forms.RadioButton rdioTwoWay;
    }
}

