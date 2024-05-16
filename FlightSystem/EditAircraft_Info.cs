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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static FlightSystem.Program;
using System.Runtime.Remoting.Messaging;

namespace FlightSystem
{
    public partial class EditAircraft_Info : Form
    {
        private int AircraftID;
        public EditAircraft_Info()
        {
            InitializeComponent();
            AircraftID = 5;
            Show_AircraftData(null, null);
            LoadAircraftIDs(null, null); 
            
        }

        public EditAircraft_Info(string AirID)
        {
             int.TryParse(AirID , out AircraftID);
            
            InitializeComponent();
        }
        

        private void LoadAircraftIDs(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();
                    string query = "SELECT * FROM AIRCRAFT";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                string aircraftName = reader["AircraftName"].ToString();
                                int aircraftID = Convert.ToInt32(reader["AircraftID"]);

                                Aircrafts.Items.Add(new KeyValuePair<string, int>(aircraftName, aircraftID));


                            }
                        Aircrafts.DisplayMember = "Key";
                        Aircrafts.ValueMember = "Value";
                        // Close data reader and connection
                        reader.Close();
                        connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void check_Ids(object sender, EventArgs e)
        {
            if(Aircrafts.SelectedIndex == -1)
            {
                MessageBox.Show("Oops! Looks like you missed to select airport id");
               
            }

            
        }

        private void Show_AircraftData(object sender, EventArgs e)
        {

        }


        private bool ValidateInfo()
        {
            if (string.IsNullOrWhiteSpace(AircraftName.Text))
            {
                MessageBox.Show("Oops! Looks like you missed to fill The Aircraft name");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(Manufacturer.Text))
            {
                MessageBox.Show("Oops! Looks like you missed to fill The Manufacturer name");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(Model.Text))
            {
                MessageBox.Show("Oops! Looks like you missed to fill The Model name");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(Capacity.Text))
            {
                MessageBox.Show("Oops! Looks like you missed to fill The Capacity name");
                return false;
            }
            else
            {
                if (!int.TryParse(Capacity.Text, out int capacity) || capacity < 0)
                {
                    MessageBox.Show("Oops! Looks like you entered an invalid or negative capacity value");
                    return false;
                }
            }
            return true;
        }
        private void EditAircraft_Info_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Aircrafts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If all information is completed, proceed
            int aircraftId = 0;
            if (Aircrafts.SelectedItem != null)
            {
                KeyValuePair<string, int> selectedAircraft = (KeyValuePair<string, int>)Aircrafts.SelectedItem;
                aircraftId = selectedAircraft.Value;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    string query = "SELECT * FROM AIRCRAFT WHERE AIRCRAFTID = @AircraftID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AircraftID", aircraftId); // corrected parameter name
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                AircraftName.Text = reader["AIRCRAFTNAME"].ToString();
                                Manufacturer.Text = reader["MANUFACTURER"].ToString();
                                Model.Text = reader["MODEL"].ToString();
                                Capacity.Text = reader["CAPACITY"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("ERROR! Cannot load this aircraft data");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInfo())
            {
                return;
            }
            try
            {
                KeyValuePair<string, int> selectedAircraft = (KeyValuePair<string, int>)Aircrafts.SelectedItem;
                int aircraftId = selectedAircraft.Value;

                string aircraftName = AircraftName.Text;
                string manufacturer = Manufacturer.Text;
                string model = Model.Text;
                int capacity = int.Parse(Capacity.Text);
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    string query = "UPDATE AIRCRAFT " +
                                   "SET AIRCRAFTNAME = @AircraftName, MANUFACTURER = @Manufacturer, MODEL = @Model, CAPACITY = @Capacity " +
                                   "WHERE AIRCRAFTID = @AircraftID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AircraftID", aircraftId);
                        command.Parameters.AddWithValue("@AircraftName", aircraftName);
                        command.Parameters.AddWithValue("@Manufacturer", manufacturer);
                        command.Parameters.AddWithValue("@Model", model);
                        command.Parameters.AddWithValue("@Capacity", capacity);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Aircraft details updated successfully!");
                            AdminHome a = new AdminHome();
                            a.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update aircraft details. No rows affected.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
