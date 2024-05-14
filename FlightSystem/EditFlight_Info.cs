using System;
using System.Collections;
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
    public partial class EditFlight_Info : Form
    {
        private int FlightID;
        public EditFlight_Info(string Flight_ID)
        {
            this.FlightID = int.Parse(Flight_ID);
            InitializeComponent();
        }


        private void EditFlight_Info_Load(object sender, EventArgs e)
        {
            try
            {
                // Load airports (name as display text, ID as value)
                // Establish connection and execute query
                // SQL query to fetch AirportName and AirportID
                string query = "SELECT AirportName, AirportID FROM Airport";
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
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
                        
                        DepatureID.Items.Add(new KeyValuePair<string, int>(airportName, airportID));

                        // Add data to comboBox2
                        ArrivalID.Items.Add(new KeyValuePair<string, int>(airportName, airportID));
                    }
                    DepatureID.DisplayMember = "Key";
                    DepatureID.ValueMember = "Value";
                    ArrivalID.DisplayMember = "Key";
                    ArrivalID.ValueMember = "Value";
                    // Close data reader and connection
                    reader.Close();
                    connection.Close();

                }
                    // Get the arrival and departure airport IDs associated with the flight
                    int ArrivalAirportID = 0, DepatureAirportID = 0; // Initial value
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    string FlightDataQuery = "SELECT ARRIVAL_AIRPORTID2, DEPARTURE_AIRPORTID2, ARRIVALDATE, DEPARTUREDATE, AVAIABLESEATS " +
                                             "FROM SCHEMA_1.FLIGHT WHERE FLIGHTID = @FlightID";

                    using (SqlCommand FlightCommand = new SqlCommand(FlightDataQuery, connection))
                    {
                        FlightCommand.Parameters.AddWithValue("@FlightID", this.FlightID);

                        using (SqlDataReader FlightReader = FlightCommand.ExecuteReader())
                        {
                            if (FlightReader.HasRows && FlightReader.Read())
                            {
                                ArrivalAirportID = (int)FlightReader["ARRIVAL_AIRPORTID2"];
                                DepatureAirportID = (int)FlightReader["DEPARTURE_AIRPORTID2"];
                                ArrivalDate.Text = FlightReader["ARRIVALDATE"].ToString();
                                DepatureDate.Text = FlightReader["DEPARTUREDATE"].ToString();
                                AvailableSeats.Text = FlightReader["AVAIABLESEATS"].ToString();
                                System.Console.WriteLine(ArrivalAirportID);
                            }
                        }
                    }
                }

                // Set the selected airports in the combo boxes
                foreach (KeyValuePair<string, int> item in ArrivalID.Items)
                {
                    if (item.Value == ArrivalAirportID)
                    {
                        ArrivalID.SelectedItem = item;
                        System.Console.WriteLine(item.Value);
                        break;
                    }
                }

                foreach (KeyValuePair<string, int> item in DepatureID.Items)
                {
                    if (item.Value == DepatureAirportID)
                    {
                        DepatureID.SelectedItem = item;
                        System.Console.WriteLine(item.Value);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        private bool CheckInfo()
        {
            DateTime today = DateTime.Today;
            DateTime departure = DepatureDate.Value.Date;
            DateTime arrival = ArrivalDate.Value.Date;

            if (today > departure || today > arrival)
            {
                MessageBox.Show("Oops! The departure and arrival dates should be today or later. Today's date is: " + today);
                return false;
            }

            if (departure > arrival)
            {
                MessageBox.Show("Oops! The departure date should be before the arrival date.");
                return false;
            }

            if (string.IsNullOrEmpty(AvailableSeats.Text) || AvailableSeats.Text == "0")
            {
                MessageBox.Show("Oops! At least one seat should be available.");
                return false;
            }

            // Check if departure is selected
            if (DepatureID.SelectedItem == null)
            {
                MessageBox.Show("Please select a departure location.");
                return false;
            }

            // Check if destination is selected
            if (ArrivalID.SelectedItem == null)
            {
                MessageBox.Show("Please select a destination location.");
                return false;
            }
            // Check if departure and destination are the same
            KeyValuePair<string, int> selectedDeparture = (KeyValuePair<string, int>)DepatureID.SelectedItem;
            KeyValuePair<string, int> selectedDestination = (KeyValuePair<string, int>)ArrivalID.SelectedItem;

            if (selectedDeparture.Value == selectedDestination.Value)
            {
                MessageBox.Show("Departure and destination airports cannot be the same.");
                return false;
            }


            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                return;
            }

            try
            {
                KeyValuePair<string, int> selectedDeparture = (KeyValuePair<string, int>)DepatureID.SelectedItem;
                KeyValuePair<string, int> selectedDestination = (KeyValuePair<string, int>)ArrivalID.SelectedItem;
                // Retrieve selected airport IDs from combo boxes
                int Depature = selectedDeparture.Value;
                int Arrival = selectedDestination.Value;


                int Seats = int.Parse(AvailableSeats.Text);
                DateTime departureDate = DepatureDate.Value.Date;
                DateTime arrivalDate = ArrivalDate.Value.Date;

                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();
                    string UpdateQuery = "UPDATE SCHEMA_1.FLIGHT " +
                                         "SET DEPARTURE_AIRPORTID2 = @Depature, ARRIVAL_AIRPORTID2 = @Arrival, " +
                                         "ARRIVALDATE = @arrivalDate, DEPARTUREDATE = @departureDate, " +
                                         "AVAIABLESEATS = @Seats " +
                                         "WHERE FLIGHTID = @FlightID";

                    using (SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, connection))
                    {
                        UpdateCommand.Parameters.AddWithValue("@Depature", Depature);
                        UpdateCommand.Parameters.AddWithValue("@Arrival", Arrival);
                        UpdateCommand.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                        UpdateCommand.Parameters.AddWithValue("@departureDate", departureDate);
                        UpdateCommand.Parameters.AddWithValue("@Seats", Seats);
                        UpdateCommand.Parameters.AddWithValue("@FlightID", FlightID);

                        int affectedRows = UpdateCommand.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("The Flight Date Has Been Updated Successfully :)");
                            EditFlight editFlight = new EditFlight();
                            editFlight.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DepatureIDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AvailableSeats_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
