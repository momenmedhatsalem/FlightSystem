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

                // Arrival and Depature Arport ( Name & ID )
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    string airportQuery = "SELECT AirportID, AirportName FROM Airport";

                    using (SqlCommand airportCommand = new SqlCommand(airportQuery, connection))
                    {
                        using (SqlDataReader airportReader = airportCommand.ExecuteReader())
                        {
                            if(airportReader.HasRows){
                                while (airportReader.Read())
                                {
                                    string AirportId = airportReader["AirportID"].ToString();
                                    string AirportName = airportReader["AirportName"].ToString();
                                    ArrivalIDs.Items.Add(new KeyValuePair<string, string>(AirportId, AirportName));
                                    DepatureIDs.Items.Add(new KeyValuePair<string, string>(AirportId, AirportName));
                                }
                            }
                        }
                    }
                }

                
                /*Get the id to get the name of the airport to set it */
                int ArrivalAirportID = 0 , DepatureAirportID  = 0; // initial value


                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    string FlightDataQuery = "SELECT * FROM SCHEMA_1.FLIGHT " +
                                            " WHERE FLIGHTID = @FightID";

                    using (SqlCommand FlightCommand = new SqlCommand(FlightDataQuery, connection))
                    {
                        FlightCommand.Parameters.AddWithValue("@FightID", this.FlightID);
                        using (SqlDataReader FlightReader = FlightCommand.ExecuteReader())
                        {
                            if (FlightReader.HasRows)
                            {
                                while (FlightReader.Read())
                                {
                                    ArrivalAirportID = (int) FlightReader["ARRIVAL_AIRPORTID2"]; 
                                    DepatureAirportID = (int)FlightReader["DEPARTURE_AIRPORTID2"];
                                    ArrivalDate.Text = (FlightReader["ARRIVALDATE"].ToString());
                                    DepatureDate.Text = (FlightReader["DEPARTUREDATE"].ToString());
                                    AvailableSeats.Text =  FlightReader["AVAIABLESEATS"].ToString();
                                }
                            }
                        }
                    }
                }
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    string AirportNameAndIDQuery = "SELECT AIRPORTID, AIRPORTNAME" +
                                                    " FROM AIRPORT" +
                                                    " WHERE AIRPORTID = @ArrivalID OR AIRPORTID = @DepatureID";

                    using (SqlCommand AirportCommand = new SqlCommand(AirportNameAndIDQuery, connection))
                    {
                        AirportCommand.Parameters.AddWithValue("@ArrivalID", ArrivalAirportID);
                        AirportCommand.Parameters.AddWithValue("@DepatureID", DepatureAirportID);

                        using (SqlDataReader AirportReader = AirportCommand.ExecuteReader())
                        {
                            while (AirportReader.Read())
                            {
                                int airportID = (int) AirportReader["AIRPORTID"];
                                string airportName = AirportReader["AIRPORTNAME"].ToString();

                                if (airportID == ArrivalAirportID)
                                {
                                    ArrivalIDs.Text = airportID + " - " + airportName;
                                }
                                    if (airportID == DepatureAirportID)
                                {
                                    DepatureIDs.Text = airportID + " - " + airportName;
                                }
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

        private void Update_Data(object sender, EventArgs e)
        {
           if(DataStatus()) {
                try
                {
                    // Get The Data From The Window Form
                    string part = "" , DepText = DepatureIDs.Text;
                    for(int i = 0; i < DepText.Length; i++)
                    {
                        if (DepText[i] > '0' && DepText[i] <= '9')
                        {
                            while (DepText[i] > '0' && DepText[i] <= '9')
                            {
                                part += DepText[i];
                                i++;
                            }
                            break;
                        }
                    }
                    
                    
                    string part1 = "", ArrText = ArrivalIDs.Text;
                    for (int i = 0; i < ArrText.Length; i++)
                    {
                        if (ArrText[i] > '0' && ArrText[i] <= '9')
                        {
                            while (ArrText[i] > '0' && ArrText[i] <= '9')
                            {
                                part1 += ArrText[i];
                                i++;
                            }
                            break;
                        }
                    }

                    int Depature = int.Parse(part);
                    int Arrival = int.Parse(part1);
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
        private bool DataStatus()
        {
            DateTime today = DateTime.Today; 

            DateTime departure = DepatureDate.Value.Date; 
            DateTime arrival = ArrivalDate.Value.Date;

            if (today > departure || today > arrival)
            {
                MessageBox.Show("Oops! the day at least should be to day :( \ntoday date is: "+ today);
                return false;
            }
            if( departure  > arrival)
            {
                MessageBox.Show("Oops! the depature date should be before arrival date :(");
                return false;
            }
            if(AvailableSeats.Text == "" || AvailableSeats.Text == "0")
            {
                MessageBox.Show("Oops! Avilable Seats at least one seat :(");
                return false;
            }
            if(CheckIfDepatureDiffertoArrival(DepatureIDs.Text, ArrivalIDs.Text))
            {
                MessageBox.Show("Oops! The Depature and Arrivale Airport Should be Different :)");
                return false;
            }else
            {
                return true;
            }
            
        }
        private bool CheckIfDepatureDiffertoArrival(string Depater , string Arrival)
        {
            return Depater.Equals(Arrival);
        }
    }
}
