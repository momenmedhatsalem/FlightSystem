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

namespace FlightSystem
{
    public partial class AddAirCraftForm : Form
    {

        public AddAirCraftForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string AircraftName= textBox2.Text;
            string Manufacturer= textBox3.Text;
            string Model= textBox4.Text;
            int Capacity = int.Parse(maskedTextBox1.Text);

            string query = "INSERT INTO Aircraft (AircraftName, Manufacturer, Capacity, Model) VALUES (@AircraftName, @Manufacturer, @Capacity, @Model)";

            using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                // command.Parameters.AddWithValue("@AircraftID", AircraftID);
                command.Parameters.AddWithValue("@AircraftName", AircraftName);
                command.Parameters.AddWithValue("@Manufacturer", Manufacturer);
                command.Parameters.AddWithValue("@Model", Model);
                command.Parameters.AddWithValue("@Capacity", Capacity);


                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " row(s) inserted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting data: " + ex.Message);
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddAirCraftForm_Load(object sender, EventArgs e)
        {

        }
    }
}
