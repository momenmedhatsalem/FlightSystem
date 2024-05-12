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
using static FlightSystem.Program;
using System.Reflection;

namespace FlightSystem
{
    public partial class FlightSelection : Form

    {
        private int departure;
        private int destination;
        private int numberOfPassengers;
        private bool Return;
        private DateTime departureDate;
        private DateTime returnDate;
        private int[] id;
        public FlightSelection(int departure, int destination,
            DateTime departureDate, DateTime returnDate,
            int numberOfPassengers, string flightClass, bool Return)
        {
            this.departure = departure;
            this.destination = destination;
            this.numberOfPassengers = numberOfPassengers;
            this.Return = Return;
            this.departureDate = departureDate;
            this.returnDate = returnDate;
            Console.WriteLine("Departure: " + this.departure);
            Console.WriteLine("Destination: " + this.destination);
            Console.WriteLine("Number of Passengers: " + this.numberOfPassengers);
            Console.WriteLine("Return: " + this.Return);
            Console.WriteLine("Departure Date: " + this.departureDate);
            Console.WriteLine("Return Date: " + this.returnDate);

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
                // Populate comboBox1 with aircraft IDs
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    string Query = @"
                            SELECT 
								Airp.AirportName AS departure, Airpo.AirportName AS destination, F.DEPARTUREDATE, F.ARRIVALDATE, F.FLIGHTID
                            FROM 
                                SCHEMA_1.FLIGHT F
                            INNER JOIN 
                                AIRPORT Airp ON F.Departure_AirportiD2 = Airp.AIRPORTID
                            INNER JOIN 
                                AIRPORT Airpo ON F.Arrival_AirportID2 = Airpo.AIRPORTID
                            WHERE
								Airp.AIRPORTID = @departure AND Airpo.AIRPORTID = @destination AND  
                                AVAIABLESEATS >= @numberOfPassengers  AND ABS(DATEDIFF(day, DEPARTUREDATE, @departureDate)) <= 3";

                    using (SqlCommand Command = new SqlCommand(Query, connection))

                    {
                        Command.Parameters.AddWithValue("departure", departure);
                        Command.Parameters.AddWithValue("destination", destination);
                        Command.Parameters.AddWithValue("numberOfPassengers", numberOfPassengers);
                        Command.Parameters.AddWithValue("departureDate", departureDate);
                        Command.Parameters.AddWithValue("returnDate", returnDate);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            
                            while (Reader.Read())
                            {
                                string row = Reader["departure"].ToString() + "\t";
                                row += Reader["destination"].ToString() + "\t";
                                row += Reader["DEPARTUREDATE"].ToString() + "\t";
                                row += Reader["ARRIVALDATE"].ToString();
                               
                                comboBox1.Items.Add(new KeyValuePair<string, int>(row, Convert.ToInt32(Reader["FLIGHTID"])));
                                Console.WriteLine(row);
                            }
                            comboBox1.DisplayMember = "Key";
                            comboBox1.ValueMember = "Value";
                        }
                    }
                }
                if (Return)
                {
                    // Populate comboBox1 with aircraft IDs
                    using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                    {
                        connection.Open();

                        string Query = @"
                            SELECT 
								Airp.AirportName AS departure, Airpo.AirportName AS destination, F.DEPARTUREDATE, F.ARRIVALDATE
                            FROM 
                                SCHEMA_1.FLIGHT F
                            INNER JOIN 
                                AIRPORT Airp ON F.Departure_AirportiD2 = Airp.AIRPORTID
                            INNER JOIN 
                                AIRPORT Airpo ON F.Arrival_AirportID2 = Airpo.AIRPORTID
                            WHERE
								Airp.AIRPORTID = @destination AND Airpo.AIRPORTID = @departure AND  
                                AVAIABLESEATS >= @numberOfPassengers AND F.DEPARTUREDATE = @returnDate";

                        using (SqlCommand Command = new SqlCommand(Query, connection))

                        {
                            Command.Parameters.AddWithValue("departure", departure);
                            Command.Parameters.AddWithValue("destination", destination);
                            Command.Parameters.AddWithValue("numberOfPassengers", numberOfPassengers);
                            Command.Parameters.AddWithValue("departureDate", departureDate);
                            Command.Parameters.AddWithValue("returnDate", returnDate);
                            using (SqlDataReader Reader = Command.ExecuteReader())
                            {

                                while (Reader.Read())
                                {
                                    id.Append((int)Reader["I"]);
                                    string row = Reader["departure"].ToString() + "\t";
                                    row += Reader["destination"].ToString() + "\t";
                                    row += Reader["DEPARTUREDATE"].ToString() + "\t";
                                    row += Reader["ARRIVALDATE"].ToString();
                                    comboBox1.Items.Add(row);
                                    Console.WriteLine(row);
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
            KeyValuePair<string, int> selectedDepartureFlight = (KeyValuePair<string, int>)comboBox1.SelectedItem;
            PassengersInfo p = new PassengersInfo(numberOfPassengers, selectedDepartureFlight.Value, 0);
            p.Show();
            this.Hide();
        }
    }
}


/**/

//if (Return)
/*{
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
}*/
//Create a DataTable to store the results
/*DataTable dataTable = new DataTable();

// Use SqlDataAdapter to fill the DataTable with data from the query
using (SqlDataAdapter adapter = new SqlDataAdapter(Command))
{
    adapter.Fill(dataTable);
}
DataRow userRow = dataTable.Rows[0];
Console.WriteLine(userRow.ToString());*/