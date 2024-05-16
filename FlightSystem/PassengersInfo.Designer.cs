namespace FlightSystem
{
    partial class PassengersInfo
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
            this.bookFlightbtn = new System.Windows.Forms.Button();
            this.passengerInfolbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookFlightbtn
            // 
            this.bookFlightbtn.Location = new System.Drawing.Point(506, 338);
            this.bookFlightbtn.Name = "bookFlightbtn";
            this.bookFlightbtn.Size = new System.Drawing.Size(97, 37);
            this.bookFlightbtn.TabIndex = 0;
            this.bookFlightbtn.Text = "Book Flight";
            this.bookFlightbtn.UseVisualStyleBackColor = true;
            this.bookFlightbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // passengerInfolbl
            // 
            this.passengerInfolbl.AutoSize = true;
            this.passengerInfolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passengerInfolbl.Location = new System.Drawing.Point(12, -2);
            this.passengerInfolbl.Name = "passengerInfolbl";
            this.passengerInfolbl.Size = new System.Drawing.Size(299, 26);
            this.passengerInfolbl.TabIndex = 1;
            this.passengerInfolbl.Text = "Please Enter Passengers info";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "Back to Home";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PassengersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.passengerInfolbl);
            this.Controls.Add(this.bookFlightbtn);
            this.Name = "PassengersInfo";
            this.Text = "PassengersInfo";
            this.Load += new System.EventHandler(this.PassengersInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bookFlightbtn;
        private System.Windows.Forms.Label passengerInfolbl;
        private System.Windows.Forms.Button button3;
    }
}