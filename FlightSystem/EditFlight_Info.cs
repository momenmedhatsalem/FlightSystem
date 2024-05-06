using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlightSystem
{
    public partial class EditFlight_Info : Form
    {
        private int FlightID;
        public EditFlight_Info()
        {
            InitializeComponent();

        }

        public EditFlight_Info(string idx)
        {
            FlightID  = int.Parse(idx);
            this.Load += new System.EventHandler(this.Show_Data);
            InitializeComponent();
        }
        private const string connString = "Server=DESKTOP-B78KPU7;Database=FlightDB;Integrated Security=True";




        /*----------------------------------------------------------------
         numberOFSeats = int.Parse(AvailableSeats.Text); // Convert string to int
         -----------------------------------------------------------------*/

        private void Show_Data(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string query = "SELECT DEPARTURE_AIRPORTID2, ARRIVAL_AIRPORTID2, DEPARTUREDATE, ARRIVALDATE, AVAIABLESEATS " +
                                   "FROM SCHEMA_1.FLIGHT " +
                                   "WHERE FLIGHTID = @FlightIndex ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FlightIndex", FlightID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                string departureAirportID = reader["DEPARTURE_AIRPORTID2"].ToString();
                                string arrivalAirportID = reader["ARRIVAL_AIRPORTID2"].ToString();
                                DateTime departureDate = (DateTime)reader["DEPARTUREDATE"];
                                DateTime arrivalDate = (DateTime)reader["ARRIVALDATE"];
                                int availableSeats = (int)reader["AVAIABLESEATS"];

                                DepatureDate.Value = departureDate;
                                ArrivalDate.Value = arrivalDate;
                                DepatureID.Text = departureAirportID;
                                ArrivalID.Text = arrivalAirportID;
                                AvailableSeats.Text = availableSeats.ToString();
                            }
                        }
                    }
                    query = "SELECT AIRPORTID FROM AIRPORT";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string airportID = reader["AIRPORTID"].ToString();
                                DepatureIDs.Items.Add(airportID);
                                ArrivalIDs.Items.Add(airportID);
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

        private void Save_Changes_Button(object sender, EventArgs e)
        {

            if (check_State())
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        connection.Open();
                        int departureID, ArrivalID, AvailableSeats;
                        departureID = int.Parse(DepatureIDs.SelectedValue.ToString());
                        ArrivalID = int.Parse(ArrivalIDs.SelectedValue.ToString());
                        DateTime depatureDate = DepatureDate.Value;
                        DateTime Arrivaldate = ArrivalDate.Value;
                        AvailableSeats  = int.Parse(this.ArrivalID.Text );

                        string query = "UPDATE SCHEMA_1.FLIGHT " +
                                       "set DEPARTURE_AIRPORTID2 = @departureID, ARRIVAL_AIRPORTID2 =@ArrivalID , DEPARTUREDATE = @depatureDate, " +
                                       " ARRIVALDATE = @ArrivalDate , AVAIABLESEATS = @AvailableSeats " +
                                       
                                       "WHERE FLIGHTID = @FlightIndex ";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@DepartureAirportID", departureID);
                            command.Parameters.AddWithValue("@ArrivalAirportID", ArrivalID);
                            command.Parameters.AddWithValue("@DepartureDate", depatureDate);
                            command.Parameters.AddWithValue("@ArrivalDate", Arrivaldate);
                            command.Parameters.AddWithValue("@AvailableSeats", AvailableSeats);
                            command.Parameters.AddWithValue("@FlightIndex", FlightID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Rows updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No rows were updated.");
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void Check_days()
        {
            DateTime depature = DepatureDate.Value;
            DateTime arrival = ArrivalDate.Value;
            DateTime today = DateTime.Now;
            if (depature < today || arrival < today)
            {
                DepatureDate.CalendarForeColor = Color.OrangeRed;
                ArrivalDate.CalendarForeColor = Color.OrangeRed;
                MessageBox.Show("The Day Should be At lest today");
            }
            else if (depature > arrival)
            {
                ArrivalDate.CalendarForeColor= Color.OrangeRed;
                MessageBox.Show("You select the depature day After arrival day Which is not valid");
            }
        }
        private bool check_State()
        {
            int numberOFSeats;
            numberOFSeats = int.Parse(AvailableSeats.Text); // Convert to int


            if (DepatureIDs.SelectedIndex == -1 || ArrivalIDs.SelectedIndex == -1)
            {
                DepatureIDs.BackColor = Color.OrangeRed;
                ArrivalIDs.BackColor = Color.OrangeRed;
                MessageBox.Show("Arrival and Depature Airport id Should be selected");
                
                return false;
            }else if (AvailableSeats.Text == "")
            {
                AvailableSeats.BackColor = Color.OrangeRed;
                MessageBox.Show("Define the number of seats");
                return false;
            }else if(numberOFSeats == 0)
            {
                AvailableSeats.BackColor= Color.OrangeRed;
                MessageBox.Show("At least the number of seats is: 1");
                return false;
            }
            else if(DepatureIDs.Text == ArrivalIDs.Text ){
                MessageBox.Show("The Depature and Arrival ariportd should be different");
                return false;
            }
            Check_days();
            return true;
        }
        private void EditFlight_Info_Load(object sender, EventArgs e)
        {

        }

        private void DispatureAirport(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
