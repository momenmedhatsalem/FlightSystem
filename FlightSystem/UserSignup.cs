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
    public partial class UserSignup : Form
    {
        public UserSignup()
        {
            InitializeComponent();
        }

// Events
        
        private void fnameBox_Leave(object sender, EventArgs e)
        {
            if (Matches("^[a-zA-Z'-]+$", this.fnameBox.Text))
            {
                this.fnameBox.BackColor = Color.LightGreen;
            }
            else
            {
                this.fnameBox.BackColor = Color.OrangeRed;
            }
            this.checkState();
        }

        private void lnameBox_Leave(object sender, EventArgs e)
        {
            if (Matches("^[a-zA-Z'-]+$", this.lnameBox.Text))
            {
                this.lnameBox.BackColor = Color.LightGreen;
            }
            else
            {
                this.lnameBox.BackColor = Color.OrangeRed;
            }
            this.checkState();
        }

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

        private void phoneBox_Leave(object sender, EventArgs e)
        {
            if (Matches(@"^\+2\d{11}$", this.phoneBox.Text))
            {
                this.phoneBox.BackColor = Color.LightGreen;
            }
            else
            {
                this.phoneBox.BackColor = Color.OrangeRed;
            }
            this.checkState();
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (this.passBox.Text == this.confirmpassBox.Text && this.passBox.Text.Length != 0)
            {
                this.passBox.BackColor = this.confirmpassBox.BackColor = Color.LightGreen;
            }
            else
            {
                this.passBox.BackColor = this.confirmpassBox.BackColor = Color.OrangeRed;
            }
            this.checkState();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (validateInfo())
            {
                // Connection
                string connString = "Server=WINDOWS;Database=FlightDB;Integrated Security=True";

                // SQl Query
                string query = $"Insert into [user] (email, firstname, lastname, password, phone, isadmin) values (@mail, @fname, @lname, @password, @phone, 0);";

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    // Creating command
                    using (SqlCommand sqlcmd = new SqlCommand(query, connection))
                    {
                        // Giving values to parameters
                        sqlcmd.Parameters.AddWithValue("mail", this.emailBox.Text.ToLower().Trim());
                        sqlcmd.Parameters.AddWithValue("fname", this.fnameBox.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("lname", this.lnameBox.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("password", this.passwordHash());
                        sqlcmd.Parameters.AddWithValue("phone", this.phoneBox.Text.Trim());

                        try
                        {
                            connection.Open();

                            // Execute query
                            sqlcmd.ExecuteNonQuery();

                            // Acknowledgement
                            SystemSounds.Beep.Play();
                            MessageBox.Show($"User {this.fnameBox.Text} has been created successfully.", "Success");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            using (SqlConnection connection = new SqlConnection("Server=WINDOWS;Database=FlightDB;Integrated Security=True"))
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
            int cnt = 0;
            if (this.fnameBox.BackColor == Color.LightGreen) cnt++;
            if (this.lnameBox.BackColor == Color.LightGreen) cnt++;
            if (this.emailBox.BackColor == Color.LightGreen) cnt++;
            if (this.phoneBox.BackColor == Color.LightGreen) cnt++;
            if (this.passBox.BackColor == Color.LightGreen) cnt++;

            if (cnt == 5) this.submitBtn.Enabled = true;
            else this.submitBtn.Enabled = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
