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
        KeyValuePair<string, int> selectedFlight;
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
                comboBox1.Items.Add("First");
                comboBox1.Items.Add("Economy");
                comboBox1.Items.Add("Business");
                // Populate comboBox1 with aircraft IDs
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    string Query = @"
                        SELECT 
							F.DEPARTURE_AIRPORTID2, F.ARRIVAL_AIRPORTID2, F.DEPARTUREDATE, F.ARRIVALDATE, T.TICKETCLASS, B.BOOKINGID
						FROM
							SCHEMA_1.FLIGHT F  
						INNER JOIN 
                            RESERVES R ON F.FLIGHTID = R.FLI_FLIGHTID
						INNER JOIN 
                            BOOKING B ON R.BOO_BOOKINGID = B.BOOKINGID
						INNER JOIN
							TICKET T ON B.BOOKINGID = T.BOO_BOOKINGID
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
                                string row = Reader["DEPARTURE_AIRPORTID2"].ToString() + "\t";
                                row += Reader["ARRIVAL_AIRPORTID2"].ToString() + "\t";
                                row += Reader["DEPARTUREDATE"].ToString() + "\t";
                                row += Reader["ARRIVALDATE"].ToString() + "\t";
                                row += Reader["TICKETCLASS"].ToString();

                                comboBox2.Items.Add(new KeyValuePair<string, int>(row, Convert.ToInt32(Reader["BOOKINGID"])).Key);
                                Console.WriteLine(row);
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
            if(comboBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Select a Flight first");
                return;
            }
            if(comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Seelct a class first");
                return;
            }
            selectedFlight = (KeyValuePair<string, int>)comboBox2.SelectedItem;
            int id = selectedFlight.Value;
            string ticketClass = comboBox1.SelectedValue.ToString();
            try
            {
                // Populate comboBox1 with aircraft IDs
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    string Query = @"
                        UPDATE TICKET
								SET TICKETCLASS = @ticketClass
								WHERE BOO_BOOKINGID = @id;";

                    using (SqlCommand Command = new SqlCommand(Query, connection))

                    {
                        Command.Parameters.AddWithValue("tickectClass", ticketClass);
                        Command.Parameters.AddWithValue("id", id);
                        int affectedRows = Command.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("The Class Has Been Updated Successfully");
                            comboBox1.Items.Clear();
                            comboBox2.Items.Clear();
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
            if (comboBox1.SelectedIndex < 0)
            selectedFlight = (KeyValuePair<string, int>)comboBox2.SelectedItem;
            int id = selectedFlight.Value;
            try
            {
                // Populate comboBox1 with aircraft IDs
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    string Query = @"
                        DELETE FROM TICKET
							WHERE BOO_BOOKINGID = @id;";

                    using (SqlCommand Command = new SqlCommand(Query, connection))

                    {
                        Command.Parameters.AddWithValue("id", id);

                    }

                     Query = @"
                         DELETE FROM RESERVERS
							WHERE BOO_BOOKINGID = @id;";

                    using (SqlCommand Command = new SqlCommand(Query, connection))

                    {
                        Command.Parameters.AddWithValue("id", id);
                    }

                     Query = @"
                        DELETE FROM BOOKING
							WHERE BOOKINGID = @id;";

                    using (SqlCommand Command = new SqlCommand(Query, connection))

                    {
                        Command.Parameters.AddWithValue("id", id);
                        int affectedRows = Command.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("The Flight Has Been Deleted Successfully");
                            comboBox1.Items.Clear();
                            comboBox2.Items.Clear();
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
            this.Close();
        }
    }
}
