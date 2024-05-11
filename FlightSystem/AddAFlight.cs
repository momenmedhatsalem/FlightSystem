using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FlightSystem.Program;

namespace FlightSystem
{
    public partial class AddAFlight : Form
    {

        public AddAFlight()
        {
            InitializeComponent();
        }

        private void AddAFlight_Load(object sender, EventArgs e)
        {
            try
            {
                // Populate comboBox1 with aircraft IDs
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    string aircraftQuery = "SELECT AIRCRAFTID, AircraftName FROM Aircraft";

                    using (SqlCommand aircraftCommand = new SqlCommand(aircraftQuery, connection))
                    {
                        using (SqlDataReader aircraftReader = aircraftCommand.ExecuteReader())
                        {
                            while (aircraftReader.Read())
                            {
                                string aircraftId = aircraftReader["AIRCRAFTID"].ToString();
                                string aircraftName = aircraftReader["AIRCRAFTNAME"].ToString();
                                comboBox1.Items.Add((new KeyValuePair<string, string>(aircraftId, aircraftName)));
                            }
                        }
                    }
                }

                // Populate comboBox2 and comboBox3 with airport IDs and names
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    string airportQuery = "SELECT AirportID, AirportName FROM Airport";

                    using (SqlCommand airportCommand = new SqlCommand(airportQuery, connection))
                    {
                        using (SqlDataReader airportReader = airportCommand.ExecuteReader())
                        {
                            while (airportReader.Read())
                            {
                                string airportId = airportReader["AirportID"].ToString();
                                string airportName = airportReader["AirportName"].ToString();
                                comboBox2.Items.Add(new KeyValuePair<string, string>(airportId, airportName));
                                comboBox3.Items.Add(new KeyValuePair<string, string>(airportId, airportName));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the selected aircraft ID from comboBox1
                KeyValuePair<string, string> selectedAircraft = (KeyValuePair<string, string>)comboBox1.SelectedItem;
                string selectedAircraftId = selectedAircraft.Key;

                string query = "SELECT Capacity FROM Aircraft WHERE AIRCRAFTID = @AircraftId";

                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AircraftId", selectedAircraftId);

                        // Execute the command and retrieve the capacity
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            // Display the capacity in textBox1
                            textBox1.Text = result.ToString();
                        }
                        else
                        {
                            textBox1.Text = "Capacity not found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!validateInfo())
                {return;}
            try
            {
                KeyValuePair<string, string> selectedAircraftId = (KeyValuePair<string, string>)comboBox1.SelectedItem;
                KeyValuePair<string, string> departureAirport = (KeyValuePair<string, string>)comboBox2.SelectedItem;
                KeyValuePair<string, string> destinationAirport = (KeyValuePair<string, string>)comboBox3.SelectedItem;
                string availableSeats = textBox1.Text;
                DateTime departureDate = dateTimePicker1.Value;
                DateTime arrivalDate = dateTimePicker2.Value;

                // Query to insert data into the Flight table
                string query = @"
            INSERT INTO [SCHEMA_1].[FLIGHT] (AIR_AIRCRAFTID, DEPARTURE_AIRPORTID2, ARRIVAL_AIRPORTID2, AVAIABLESEATS, ARRIVALDATE, DEPARTUREDATE)
            VALUES (@AircraftId, @DepartureAirportId, @DestinationAirportId, @AvailableSeats, @ArrivalDate, @DepartureDate)";

                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AircraftId", Int32.Parse(selectedAircraftId.Key));
                        command.Parameters.AddWithValue("@DepartureAirportId", Int32.Parse(departureAirport.Key));
                        command.Parameters.AddWithValue("@DestinationAirportId", Int32.Parse(destinationAirport.Key));
                        command.Parameters.AddWithValue("@AvailableSeats", Int32.Parse(availableSeats));
                        command.Parameters.AddWithValue("@DepartureDate", departureDate);
                        command.Parameters.AddWithValue("@ArrivalDate", arrivalDate);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Flight added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add flight!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        private bool validateInfo()
        {
            // Check if aircraft is selected
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an aircraft.");
                return false;
            }

            // Check if departure airport is selected
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a departure airport.");
                return false;
            }

            // Check if arrival airport is selected
            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please select an arrival airport.");
                return false;
            }

            // Check if available seats is provided
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter the available seats.");
                return false;
            }

            // Check if departure date is selected
            if (dateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Departure date cannot be in the past.");
                return false;
            }

            // Check if arrival date is selected and after departure date
            if (dateTimePicker2.Value.Date <= dateTimePicker1.Value.Date)
            {
                MessageBox.Show("Arrival date must be after departure date.");
                return false;
            }

            // If all checks pass, return true
            return true;
        }

    }


}

