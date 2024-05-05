﻿using System;
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
        }

        private void EditFlight_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    string query = "SELECT FLIGHTID FROM Flight";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string aircraftId = reader["FLIGHTID"].ToString();
                                comboBox1.Items.Add(aircraftId);
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

        private void EditFlight_Load_1(object sender, EventArgs e)
        {

        }
    }
}
