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
    public partial class EditFlight : Form
    {

        public EditFlight()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.EditFlight_Load);
        }

        private void EditFlight_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();

                    string query = @"SELECT 
                                F.FLIGHTID, 
                                CONCAT(F.FLIGHTID, ' - ', Airp.AirportName, ' to ', Airpo.AirportName,' | ', F.DepartureDate,' | ', F.ArrivalDate) AS FlightInfo
                            FROM 
                                SCHEMA_1.FLIGHT F
                            INNER JOIN 
                                AIRPORT Airp ON F.Departure_AirportiD2 = Airp.AIRPORTID
                            INNER JOIN 
                                AIRPORT Airpo ON F.Arrival_AirportID2 = Airpo.AIRPORTID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string flightInfo = reader["FlightInfo"].ToString();
                                comboBox1.Items.Add(flightInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select Flight ID first");
            }
            else
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                string flightId = selectedItem.Split(' ')[0]; // Assuming Flight ID is the first part before a space
                EditFlight_Info next = new EditFlight_Info(flightId);
                next.Show();
                this.Hide();
            }
        }

        private void EditFlight_Load_1(object sender, EventArgs e)
        {

        }
    }
}
