namespace FlightSystem
{
    partial class EditAircraft_Info
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
            this.Capacity = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.TextBox();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.AircraftName = new System.Windows.Forms.TextBox();
            this.Aircrafts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Capacity
            // 
            this.Capacity.Location = new System.Drawing.Point(189, 279);
            this.Capacity.Margin = new System.Windows.Forms.Padding(2);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(134, 20);
            this.Capacity.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(562, 350);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Manufacturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Aircraft Name";
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(189, 205);
            this.Model.Margin = new System.Windows.Forms.Padding(2);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(134, 20);
            this.Model.TabIndex = 15;
            // 
            // Manufacturer
            // 
            this.Manufacturer.Location = new System.Drawing.Point(189, 130);
            this.Manufacturer.Margin = new System.Windows.Forms.Padding(2);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(134, 20);
            this.Manufacturer.TabIndex = 14;
            // 
            // AircraftName
            // 
            this.AircraftName.Location = new System.Drawing.Point(189, 78);
            this.AircraftName.Margin = new System.Windows.Forms.Padding(2);
            this.AircraftName.Name = "AircraftName";
            this.AircraftName.Size = new System.Drawing.Size(134, 20);
            this.AircraftName.TabIndex = 13;
            // 
            // Aircrafts
            // 
            this.Aircrafts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aircrafts.FormattingEnabled = true;
            this.Aircrafts.Location = new System.Drawing.Point(189, 26);
            this.Aircrafts.Name = "Aircrafts";
            this.Aircrafts.Size = new System.Drawing.Size(154, 25);
            this.Aircrafts.TabIndex = 22;
            this.Aircrafts.SelectedIndexChanged += new System.EventHandler(this.Aircrafts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select Aircraft";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditAircraft_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aircrafts);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.AircraftName);
            this.Name = "EditAircraft_Info";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditAircraft_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Capacity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.TextBox AircraftName;
        private System.Windows.Forms.ComboBox Aircrafts;
        private System.Windows.Forms.Label label1;
    }
}