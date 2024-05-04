using System;
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

namespace FlightSystem
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
            radioBooking.Checked = true;
            

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

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
