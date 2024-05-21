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
        private Random random;

        public PassengersInfo(int numberOfPassengers, int firstFlightId, int secondFlightId)
        {
            InitializeComponent();
            this.numberOfPassengers = numberOfPassengers;
            this.firstFlightId = firstFlightId;
            this.lastFlightId = secondFlightId; 
            CreatePassengerInputBoxes();
            random = new Random();
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
            try
            {
                int randomNumber = random.Next(1, 100001);

                // Use a single connection and a transaction
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Create a new booking for the current user
                            string insertBookingQuery = "INSERT INTO BOOKING (USE_USERID, BOOKINGSTATUS, BOOKINGTIME) VALUES (@UserId, 'Confirmed', GETDATE()); SELECT SCOPE_IDENTITY();";
                            SqlCommand command = new SqlCommand(insertBookingQuery, connection, transaction);
                            command.Parameters.AddWithValue("@UserId", AppGlobals.UserId);
                            int bookingId = Convert.ToInt32(command.ExecuteScalar());

                            string insertReservesQuery = "INSERT INTO RESERVES (BOO_BOOKINGID, FLI_FLIGHTID) VALUES (@BookingId, @FlightId)";

                            // Reserve the flight for the first flight
                            command = new SqlCommand(insertReservesQuery, connection, transaction);
                            command.Parameters.AddWithValue("@BookingId", bookingId);
                            command.Parameters.AddWithValue("@FlightId", firstFlightId);
                            command.ExecuteNonQuery();

                            // If there is a return flight, reserve it
                            if (lastFlightId != 0)
                            {
                                command.Parameters["@FlightId"].Value = lastFlightId;
                                command.ExecuteNonQuery();
                            }

                            // Generate ticket for the first flight
                            string insertTicketQuery = "INSERT INTO TICKET (BOO_BOOKINGID, SEATNUMBER, TICKETCLASS) VALUES (@BookingId, @SeatNumber, @TicketClass)";
                            command = new SqlCommand(insertTicketQuery, connection, transaction);
                            command.Parameters.AddWithValue("@BookingId", bookingId);
                            command.Parameters.AddWithValue("@SeatNumber", randomNumber); // Assuming seat numbers start from 1
                            command.Parameters.AddWithValue("@TicketClass", "Economy"); // Assuming ticket class is fixed for now
                            command.ExecuteNonQuery();

                            // Create passengers and add them to the boarding list for each flight
                            string insertPassengerQuery = "INSERT INTO PASSENGER (FirstName, LastName, Phone) VALUES (@FirstName, @LastName, @Phone); SELECT SCOPE_IDENTITY();";
                            string insertBoardingQuery = "INSERT INTO BOARDING (FLI_FLIGHTID, PAS_PASSENGERID) VALUES (@FlightId, @PassengerId)";

                            for (int i = 0; i < numberOfPassengers; i++)
                            {
                                command = new SqlCommand(insertPassengerQuery, connection, transaction);
                                command.Parameters.AddWithValue("@FirstName", ((TextBox)this.Controls[$"txtFirstName{i + 1}"]).Text);
                                command.Parameters.AddWithValue("@LastName", ((TextBox)this.Controls[$"txtLastName{i + 1}"]).Text);
                                command.Parameters.AddWithValue("@Phone", ((TextBox)this.Controls[$"txtPhone{i + 1}"]).Text);
                                int passengerId = Convert.ToInt32(command.ExecuteScalar());

                                // Add passenger to the boarding list for the first flight
                                command = new SqlCommand(insertBoardingQuery, connection, transaction);
                                command.Parameters.AddWithValue("@FlightId", firstFlightId);
                                command.Parameters.AddWithValue("@PassengerId", passengerId);
                                command.ExecuteNonQuery();

                                // If there is a return flight, add passenger to the boarding list
                                if (lastFlightId != 0)
                                {
                                    command.Parameters["@FlightId"].Value = lastFlightId;
                                    command.ExecuteNonQuery();
                                }
                            }

                            // Commit the transaction
                            transaction.Commit();

                            MessageBox.Show("Booking, passengers, tickets, reservations, and boarding records created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Home h = new Home();
                            h.Show();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction in case of error
                            transaction.Rollback();
                            MessageBox.Show("Error: " + ex.Message);
                            Booking b = new Booking();
                            b.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Booking b = new Booking();
                b.Show();
                this.Hide();
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
