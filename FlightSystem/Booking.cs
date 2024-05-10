﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace FlightSystem
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
            rdioOneWay.Checked = true;
            

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightDataSet.AIRPORT' table. You can move, or remove it, as needed.

            // Connection string
            string connString = "Server=OMC-MEDHAT;Database=Flight;Integrated Security=True";

            // SQL query to fetch AirportName and AirportID
            string query = "SELECT AirportName, AirportID FROM Airport";

            // Establish connection and execute query
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Load data into comboBox1 and comboBox2
                while (reader.Read())
                {
                    string airportName = reader["AirportName"].ToString();
                    int airportID = Convert.ToInt32(reader["AirportID"]);

                    // Add data to comboBox1
                    comboBoxDeparture.Items.Add(new KeyValuePair<string, int>(airportName, airportID));

                    // Add data to comboBox2
                    comboBoxDestination.Items.Add(new KeyValuePair<string, int>(airportName, airportID));
                }
                comboBoxDeparture.DisplayMember = "Key";
                comboBoxDeparture.ValueMember = "Value";
                comboBoxDestination.DisplayMember = "Key";
                comboBoxDestination.ValueMember = "Value";
                // Close data reader and connection
                reader.Close();
                connection.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item in comboBoxDeparture
            KeyValuePair<string, int> selectedDeparture = (KeyValuePair<string, int>)comboBoxDeparture.SelectedItem;

   
        }

        private void comboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item in comboBoxDestination

        }




        private void button1_Click(object sender, EventArgs e)
        {
            // Validate information first
            if (!validateInfo())
            {
                
                return;
            }

            // If all information is completed, proceed
            string departure = comboBoxDeparture.SelectedItem.ToString();
            string destination = comboBoxDestination.SelectedItem.ToString();
            DateTime departureDate = dateTimePicker1.Value;
            DateTime returnDate = dateTimePicker2.Value;
            int numberOfPassengers = Convert.ToInt32(numberOfPassengersBox.SelectedItem);
            string flightClass = flightClassBox.SelectedItem.ToString();
            bool Return = rdioTwoWay.Checked;

            FlightSelection f = new FlightSelection(departure, destination,
                departureDate, returnDate,
                numberOfPassengers, flightClass, Return);
            f.Show();
            this.Hide();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioBooking_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool validateInfo()
        {
            // Check if departure is selected
            if (comboBoxDeparture.SelectedItem == null)
            {
                MessageBox.Show("Please select a departure location.");
                return false;
            }

            // Check if destination is selected
            if (comboBoxDestination.SelectedItem == null)
            {
                MessageBox.Show("Please select a destination location.");
                return false;
            }

            // Check if departure date is selected
            if (dateTimePicker1.Value == null)
            {
                MessageBox.Show("Please select a departure date.");
                return false;
            }

            // Check if return date is selected
            if (dateTimePicker2.Value == null)
            {
                MessageBox.Show("Please select a return date.");
                return false;
            }

            // Check if number of passengers is selected
            if (numberOfPassengersBox.SelectedItem == null)
            {
                MessageBox.Show("Please select the number of passengers.");
                return false;
            }

            // Check if flight class is selected
            if (flightClassBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a flight class.");
                return false;
            }

            // If all checks pass, return true
            return true;
        }

    }
}
