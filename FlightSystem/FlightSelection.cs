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
namespace FlightSystem
{
    public partial class FlightSelection : Form
    {
        public FlightSelection(int departure, int destination,
            DateTime departureDate, DateTime returnDate,
            int numberOfPassengers, string flightClass, bool Return)
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlightSelection_Load(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=OMC-MEDHAT;Database=Flight;Integrated Security=True";

                // Populate comboBox1 with aircraft IDs
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    string Query = "SELECT Airp.AirportName AS departure, Airpo.AirportName AS destination, F.DEPARTUREDATE, F.ARRIVALDATE " +
                                   "FROM SCHEMA_1.FLIGHT F" +
                                   "INNER JOIN   AIRPORT Airp ON F.Departure_AirportiD2 = Airp.AIRPORTID" +
                                   "INNER JOIN   AIRPORT Airpo ON F.Arrival_AirportID2 = Airpo.AIRPORTID" +
                                   "WHERE Airp.AirportName = @departure AND Airpo.AirportName = @destination AND  AVAIABLESEATS >= @numberOfPassengers AND DEPARTUREDATE = @departureDate";

                    using (SqlCommand Command = new SqlCommand(Query, connection))
                    {
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                string row = Reader["departure"].ToString() + "\t";
                                row += Reader["destination"].ToString() + "\t";
                                row += Reader["DEPARTUREDATE"].ToString() + "\t";
                                row += Reader["ARRIVALDATE"].ToString();
                                comboBox1.Items.Add(row);
                            }
                        }
                    }
                    //if (Return)
                    {
                        Query = "SELECT Airp.AirportName AS departure, Airpo.AirportName AS destination, F.DEPARTUREDATE, F.ARRIVALDATE " +
                                      "FROM SCHEMA_1.FLIGHT F" +
                                      "INNER JOIN   AIRPORT Airp ON F.Departure_AirportiD2 = Airp.AIRPORTID" +
                                      "INNER JOIN   AIRPORT Airpo ON F.Arrival_AirportID2 = Airpo.AIRPORTID" +
                                      "WHERE Airp.AirportName = @destination AND Airpo.AirportName = @departure AND  AVAIABLESEATS >= @numberOfPassengers AND DEPARTUREDATE = @returnDate";

                        using (SqlCommand Command = new SqlCommand(Query, connection))
                        {
                            using (SqlDataReader Reader = Command.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    string row = Reader["departure"].ToString() + "\t";
                                    row += Reader["destination"].ToString() + "\t";
                                    row += Reader["DEPARTUREDATE"].ToString() + "\t";
                                    row += Reader["ARRIVALDATE"].ToString();
                                    comboBox1.Items.Add(row);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}


