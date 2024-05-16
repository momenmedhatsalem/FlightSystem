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
    public partial class BookingManagement : Form
    {

        string[] selectedclass;
        int[] ids;

        public BookingManagement()
        {
            InitializeComponent();
        }

        private void BookingManagement_Load(object s, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            try
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                selectedclass = new string[] {};
                ids = new int[] {};
                comboBox1.Items.Add("First");
                comboBox1.Items.Add("Economy");
                comboBox1.Items.Add("Business");
                // Populate comboBox1 with aircraft IDs
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    string Query = @"
                        SELECT 
							Airp.AirportName AS departure, Airpo.AirportName AS destination, F.DEPARTUREDATE, F.ARRIVALDATE, T.TICKETCLASS, B.BOOKINGID, F.FLIGHTID, PASSENGER.FIRSTNAME
						FROM
							SCHEMA_1.FLIGHT F  
						INNER JOIN 
                            RESERVES R ON F.FLIGHTID = R.FLI_FLIGHTID
                        INNER JOIN 
                            AIRPORT Airp ON F.Departure_AirportiD2 = Airp.AIRPORTID
                        INNER JOIN 
                            AIRPORT Airpo ON F.Arrival_AirportID2 = Airpo.AIRPORTID
						INNER JOIN 
                            BOOKING B ON R.BOO_BOOKINGID = B.BOOKINGID
						INNER JOIN
							TICKET T ON B.BOOKINGID = T.BOO_BOOKINGID
						INNER JOIN 
                            BOARDING ON BOARDING.FLI_FLIGHTID = F.FLIGHTID 
						INNER JOIN 
                            PASSENGER ON BOARDING.PAS_PASSENGERID = PASSENGER.PASSENGERID
						INNER JOIN
							""USER"" U ON B.USE_USERID = U.USERID
								WHERE U.USERID = @userId";

                    using (SqlCommand Command = new SqlCommand(Query, connection))

                    {
                        Command.Parameters.AddWithValue("userId", AppGlobals.UserId);

                        //Command.Parameters.AddWithValue("userId", userId);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            while (Reader.Read())
                            {
                                string row = Reader["departure"].ToString() + " - \t";
                                row += Reader["destination"].ToString() + " - \t";
                                row += Reader["DEPARTUREDATE"].ToString() + " - \t";
                                row += Reader["ARRIVALDATE"].ToString() + " - \t";
                                row += Reader["TICKETCLASS"].ToString() + " - \t";
                                row += Reader["FIRSTNAME"].ToString();

                                comboBox2.Items.Add(new KeyValuePair<string, int>(row, Convert.ToInt32(Reader["BOOKINGID"])));
                                Console.WriteLine(Convert.ToInt32(Reader["BOOKINGID"]));
                                ids.Append(Convert.ToInt32(Reader["FLIGHTID"]));
                                selectedclass.Append(Reader["TICKETCLASS"].ToString());
                            }
                            comboBox2.DisplayMember = "Key";
                            comboBox2.ValueMember = "Value";
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
            if (comboBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Select a Flight first");
                return;
            }
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Select a class first");
                return;
            }

            try
            {
                // Retrieve selected flight
                KeyValuePair<string, int> selectedFlight = (KeyValuePair<string, int>)comboBox2.SelectedItem;
                int id = selectedFlight.Value;
                Console.WriteLine("id ",id);
                // Retrieve selected ticket class
                string ticketClass = comboBox1.SelectedItem.ToString();

                // Update ticket class in the database
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    string Query = @"
                UPDATE TICKET
                SET TICKETCLASS = @ticketClass
                WHERE BOO_BOOKINGID = @id;";

                    using (SqlCommand Command = new SqlCommand(Query, connection))
                    {
                        Command.Parameters.AddWithValue("@ticketClass", ticketClass);
                        Command.Parameters.AddWithValue("@id", id);
                        int affectedRows = Command.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("The Class Has Been Updated Successfully");
                            refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Select a Flight first");
                return;
            }

            // Retrieve selected flight
            KeyValuePair<string, int> selectedFlight = (KeyValuePair<string, int>)comboBox2.SelectedItem;
            int id = selectedFlight.Value;

            try
            {
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    // Delete related records from TICKET table
                    string Query = @"DELETE FROM TICKET WHERE BOO_BOOKINGID = @id;";
                    using (SqlCommand Command = new SqlCommand(Query, connection))
                    {
                        Command.Parameters.AddWithValue("@id", id);
                        Command.ExecuteNonQuery();
                    }

                    // Delete related records from RESERVERS table
                    Query = @"DELETE FROM RESERVES WHERE BOO_BOOKINGID = @id;";
                    using (SqlCommand Command = new SqlCommand(Query, connection))
                    {
                        Command.Parameters.AddWithValue("@id", id);
                        Command.ExecuteNonQuery();
                    }

                    // Delete related records from BOARDING table
                    Query = @"DELETE FROM BOARDING WHERE FLI_FLIGHTID = @id;";
                    using (SqlCommand Command = new SqlCommand(Query, connection))
                    {
                        Command.Parameters.AddWithValue("@id", id);
                        Command.ExecuteNonQuery();
                    }

                    // Delete record from BOOKING table
                    Query = @"DELETE FROM BOOKING WHERE BOOKINGID = @id;";
                    using (SqlCommand Command = new SqlCommand(Query, connection))
                    {
                        Command.Parameters.AddWithValue("@id", id);
                        int affectedRows = Command.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("The Flight Has Been Deleted Successfully");
                            refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                // Assuming your comboBox items are KeyValuePair<string, int>
                KeyValuePair<string, int> selectedItem = (KeyValuePair<string, int>)comboBox2.SelectedItem;

                // Extract the ticket class from the selected item
                string selectedTicketClass = GetTicketClassFromSelectedItem(selectedItem);
                Console.WriteLine(selectedTicketClass);
                // Set the selected item in comboBox1 to match the flight class selected in comboBox2
                comboBox1.SelectedItem = selectedTicketClass;
            }
        }

        private string GetTicketClassFromSelectedItem(KeyValuePair<string, int> selectedItem)
        {
            // Assuming the ticket class is separated by ' - ' and is at the last position in the string
            string[] parts = selectedItem.Key.Split(new string[] { " - \t" }, StringSplitOptions.None);
            return parts[parts.Length - 2].Trim(); // Trim to remove any leading or trailing whitespaces
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
