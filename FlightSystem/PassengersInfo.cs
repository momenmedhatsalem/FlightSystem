using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static FlightSystem.Program;

namespace FlightSystem
{
    public partial class PassengersInfo : Form
    {
        private int numberOfPassengers;
        private int firstFlightId;
        private int lastFlightId;
        
        public PassengersInfo(int numberOfPassengers, int firstFlightId, int secondFlightId)
        {
            InitializeComponent();
            this.numberOfPassengers = numberOfPassengers;
            this.firstFlightId = firstFlightId;
            this.lastFlightId = secondFlightId; 
            CreatePassengerInputBoxes();
        }

        private void CreatePassengerInputBoxes()
        {
            System.Console.WriteLine(firstFlightId);
            // Create input boxes for each passenger
            for (int i = 0; i < numberOfPassengers; i++)
            {
                Label lblPassenger = new Label();
                lblPassenger.Text = $"Passenger {i + 1}:";
                lblPassenger.Location = new System.Drawing.Point(30, 30 + i * 130); // Adjusted position

                Label lblFirstName = new Label();
                lblFirstName.Text = "First Name:";
                lblFirstName.Location = new System.Drawing.Point(50, 60 + i * 130); // Adjusted position

                TextBox txtFirstName = new TextBox();
                txtFirstName.Name = $"txtFirstName{i + 1}";
                txtFirstName.Location = new System.Drawing.Point(150, 60 + i * 130); // Adjusted position

                Label lblLastName = new Label();
                lblLastName.Text = "Last Name:";
                lblLastName.Location = new System.Drawing.Point(50, 90 + i * 130); // Adjusted position

                TextBox txtLastName = new TextBox();
                txtLastName.Name = $"txtLastName{i + 1}";
                txtLastName.Location = new System.Drawing.Point(150, 90 + i * 130); // Adjusted position

                Label lblPhone = new Label();
                lblPhone.Text = "Phone Number:";
                lblPhone.Location = new System.Drawing.Point(50, 120 + i * 130); // Adjusted position

                TextBox txtPhone = new TextBox();
                txtPhone.Name = $"txtPhone{i + 1}";
                txtPhone.Location = new System.Drawing.Point(150, 120 + i * 130); // Adjusted position

                // Add controls to form
                this.Controls.Add(lblPassenger);
                this.Controls.Add(lblFirstName);
                this.Controls.Add(txtFirstName);
                this.Controls.Add(lblLastName);
                this.Controls.Add(txtLastName);
                this.Controls.Add(lblPhone);
                this.Controls.Add(txtPhone);
            }
        }


        private void PassengersInfo_Load(object sender, EventArgs e)
        {
            // Populate the first passenger box with current user's data
            PopulateCurrentUser();
        }

        private void PopulateCurrentUser()
        {
            // Connect to SQL Server and retrieve current user's data
            string query = "SELECT FirstName, LastName, Phone FROM [user] WHERE UserId = @UserId";
            using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", AppGlobals.UserId); // Assuming you have a global variable to store UserId
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Fill in the first passenger's information with current user's data
                    ((TextBox)this.Controls[$"txtFirstName1"]).Text = reader["FirstName"].ToString();
                    ((TextBox)this.Controls[$"txtLastName1"]).Text = reader["LastName"].ToString();
                    ((TextBox)this.Controls[$"txtPhone1"]).Text = reader["Phone"].ToString();
                }
                else
                {
                    MessageBox.Show("User data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInfo())
            {
                return;
            }
            // Create a new booking for the current user
            string insertBookingQuery = "INSERT INTO BOOKING (USE_USERID, BOOKINGSTATUS, BOOKINGTIME) VALUES (@UserId, 'Confirmed', GETDATE()); SELECT SCOPE_IDENTITY();";
            int bookingId;
            using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
            {
                SqlCommand command = new SqlCommand(insertBookingQuery, connection);
                command.Parameters.AddWithValue("@UserId", AppGlobals.UserId);
                connection.Open();
                bookingId = Convert.ToInt32(command.ExecuteScalar());
            }

            // Create passengers for each flight
            string insertPassengerQuery = "INSERT INTO PASSENGER (FirstName, LastName, Phone) VALUES (@FirstName, @LastName, @Phone); SELECT SCOPE_IDENTITY();";
            string insertBoardingQuery = "INSERT INTO BOARDING (FLI_FLIGHTID, PAS_PASSENGERID) VALUES (@FlightId, @PassengerId)";
            for (int i = 0; i < numberOfPassengers; i++)
            {
                int passengerId;
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    SqlCommand command = new SqlCommand(insertPassengerQuery, connection);
                    command.Parameters.AddWithValue("@FirstName", ((TextBox)this.Controls[$"txtFirstName{i + 1}"]).Text);
                    command.Parameters.AddWithValue("@LastName", ((TextBox)this.Controls[$"txtLastName{i + 1}"]).Text);
                    command.Parameters.AddWithValue("@Phone", ((TextBox)this.Controls[$"txtPhone{i + 1}"]).Text);
                    connection.Open();
                    passengerId = Convert.ToInt32(command.ExecuteScalar());
                }

                // Add passenger to first flight
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    SqlCommand command = new SqlCommand(insertBoardingQuery, connection);
                    command.Parameters.AddWithValue("@FlightId", firstFlightId);
                    command.Parameters.AddWithValue("@PassengerId", passengerId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // If there is a return flight, add passenger to it as well
                if (lastFlightId != 0)
                {
                    using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                    {
                        SqlCommand command = new SqlCommand(insertBoardingQuery, connection);
                        command.Parameters.AddWithValue("@FlightId", lastFlightId);
                        command.Parameters.AddWithValue("@PassengerId", passengerId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Booking and passengers created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool ValidateInfo()
        {
            for (int i = 0; i < numberOfPassengers; i++)
            {
                TextBox txtFirstName = (TextBox)this.Controls[$"txtFirstName{i + 1}"];
                if (string.IsNullOrEmpty(txtFirstName.Text))
                {
                    MessageBox.Show($"Please enter the first name for Passenger {i + 1}.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                TextBox txtLastName = (TextBox)this.Controls[$"txtLastName{i + 1}"];
                if (string.IsNullOrEmpty(txtLastName.Text))
                {
                    MessageBox.Show($"Please enter the last name for Passenger {i + 1}.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                TextBox txtPhone = (TextBox)this.Controls[$"txtPhone{i + 1}"];
                if (string.IsNullOrEmpty(txtPhone.Text))
                {
                    MessageBox.Show($"Please enter the phone number for Passenger {i + 1}.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }


    }
}
