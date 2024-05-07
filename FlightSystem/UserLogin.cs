using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSystem
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            
        }

// Events
        
 

        private void emailBox_Leave(object sender, EventArgs e)
        {
            if (Matches(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", this.emailBox.Text))
            {
                this.emailBox.BackColor = Color.LightGreen;
            }
            else
            {
                this.emailBox.BackColor = Color.OrangeRed;
            }
            this.checkState();
        }



        private void pass_Leave(object sender, EventArgs e)
        {
            if (this.passBox.Text.Length != 0)
            {
                this.passBox.BackColor = Color.LightGreen;
            }
            else
            {
                this.passBox.BackColor = Color.OrangeRed;
            }
            this.checkState();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Connection
            string connString = "Server=OMC-MEDHAT;Database=Flight;Integrated Security=True";

            // SQl Query
            string query = "SELECT COUNT(*) FROM [user] WHERE email = @mail AND password = @password";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                // Creating command
                using (SqlCommand sqlcmd = new SqlCommand(query, connection))
                {
                    // Giving values to parameters
                    sqlcmd.Parameters.AddWithValue("@mail", this.emailBox.Text.ToLower().Trim());
                    sqlcmd.Parameters.AddWithValue("@password", this.passwordHash());

                    try
                    {
                        connection.Open();

                        // Execute the query and get the count
                        int count = (int)sqlcmd.ExecuteScalar();

                        // Check if a user with the provided email and password exists
                        if (count > 0)
                        {
                            // User authenticated
                            MessageBox.Show("Login successful.", "Success");
                            // Add code to navigate to the next form or perform other actions after successful login
                            UserSignup f = new UserSignup();
                            f.Show();

                            this.Hide();


                        }
                        else
                        {
                            // User not found or password incorrect
                            MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }


        // Funcs
        private string passwordHash()
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute hash from password bytes
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(this.passBox.Text));

                // Convert byte array to a hexadecimal string
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool validateInfo()
        {
            // email validation
            using (SqlConnection connection = new SqlConnection("Server=OMC-MEDHAT;Database=Flight;Integrated Security=True"))
            {
                // Create SqlCommand with query and connection
                using (SqlCommand command = new SqlCommand("SELECT * FROM [user] where email=@email", connection))
                {
                    command.Parameters.AddWithValue("email", this.emailBox.Text.ToLower().Trim());

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if there are rows
                        if (reader.HasRows)
                        {
                            MessageBox.Show("This mail is already in use", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private bool Matches(string pattern, string text)
        {
            // Create a Regex object
            Regex regex = new Regex(pattern);

            // Use the Regex.IsMatch method to check if the email matches the pattern
            return regex.IsMatch(text);
        }

        private void checkState()
        {


            if (this.passBox.BackColor == Color.LightGreen && this.emailBox.BackColor == Color.LightGreen) this.submitBtn.Enabled = true;
            else this.submitBtn.Enabled = false;
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            if (this.passBox.Text.Length != 0)
            {
                this.passBox.BackColor = Color.LightGreen;
            }
            else
            {
                this.passBox.BackColor = Color.OrangeRed;
            }
            this.checkState();
        }
    }
}
