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
        private const string connString = "Server=DESKTOP-B78KPU7;Database=FlightDB;Integrated Security=True";

        private void LoadAircraftIDs(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string query = "SELECT AIRCRAFTID FROM AIRCRAFT";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string airportID = reader["AIRCRAFTID"].ToString();
                                AirportIDs.Items.Add(airportID);

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

        private void check_Ids(object sender, EventArgs e)
        {
            if(AirportIDs.SelectedIndex == -1)
            {
                MessageBox.Show("Oops! Looks like you missed to select airport id");
               
            }

            
        }

        private void Show_AircraftData(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = "SELECT   AIRCRAFTNAME , MANUFACTURER , MODEL , CAPACITY " +
                                   "FROM AIRCRAFT " +
                                   "WHERE AIRCRAFTID = @AircraftID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AircraftID", AircraftID);
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
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void UpdateValues()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string aircraftName = AircraftName.Text;
                    string model = Model.Text;
                    string manufacturer = Manufacturer.Text;
                    int capacity;
                    capacity = int.Parse(Capacity.Text);
                    string query = "UPDATE AIRCRAFT " +
                                    "SET AIRCRAFTNAME = @aircraftName , MANUFACTURER =@manufacturer , MODEL =@model , CAPACITY=@capacity " +
                                    "WHERE AIRCRAFTID =@AircraftID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AIRCRAFTNAME", aircraftName);
                        command.Parameters.AddWithValue("@MANUFACTURER", manufacturer);
                        command.Parameters.AddWithValue("@MODEL", model);
                        command.Parameters.AddWithValue("@CAPACITY", capacity);
                        command.Parameters.AddWithValue("@AircraftID", AircraftID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Rows updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated.");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        private void Check_Status(object sender, EventArgs e)
        {


            if(AircraftName.Text == "")
            {
                MessageBox.Show("Oops! Looks like you missed to fill The Aircraft name");
            } else if(Manufacturer.Text == "")
            {
                MessageBox.Show("Oops! Looks like you missed to fill The Manufacturer name");
            }
            else if(Model.Text == "")
            {
                MessageBox.Show("Oops! Looks like you missed to fill The Model name");
            }
            else if(Capacity.Text == "")
            {
                MessageBox.Show("Oops! Looks like you missed to fill The Capacity name");
            }
            else
            {
                int capacity;
                capacity = int.Parse(Capacity.Text);
                if(capacity < 0) {
                    MessageBox.Show("Oops! Looks like you enter a value less than 1 which is not available");
                }
            }
            UpdateValues();
        }
        private void EditAircraft_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
