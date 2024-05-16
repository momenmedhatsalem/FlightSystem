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
            if (!validateInfo()) { return; }
            
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
                    AdminHome a = new AdminHome();
                    a.Show();
                    this.Hide();
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

        private bool validateInfo()
        {
            // Check if Aircraft name is provided
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter the aircraft name.");
                return false;
            }

            // Check if Manufacturer is provided
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter the manufacturer.");
                return false;
            }

            // Check if Model is provided
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please enter the model.");
                return false;
            }

            // Check if Capacity is provided and greater than 0
            if (!int.TryParse(maskedTextBox1.Text, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Please enter a valid capacity greater than 0.");
                return false;
            }

            // If all checks pass, return true
            return true;
        }

    }
}
