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

namespace FlightSystem
{
    public partial class EditFlight : Form
    {
        private const string connString = "Server=OMC-MEDHAT;Database=Flight;Integrated Security=True";

        public EditFlight()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.EditFlight_Load);
        }

        private void EditFlight_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    string query = "SELECT FLIGHTID FROM SCHEMA_1.FLIGHT";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string flightId = reader["FLIGHTID"].ToString();
                                comboBox1.Items.Add(flightId);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EditFlight_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select Flight ID first");
            }
            else
            {
                EditFlight_Info next = new EditFlight_Info(comboBox1.Text);
                next.Show();
            }
        }
    }
}
