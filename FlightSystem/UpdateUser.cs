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
using static FlightSystem.Program;

namespace FlightSystem
{
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
            // Pre-fill the input fields with data from the current logged-in user
            if (AppGlobals.UserId != 0)
            {
                string connString = "Server=OMC-MEDHAT;Database=Flight;Integrated Security=True";
                string query = "SELECT email, firstname, lastname, phone FROM [user] WHERE UserId = @userId";

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", AppGlobals.UserId);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Set the text properties of the input fields
                            emailBox.Text = reader["email"].ToString();
                            fnameBox.Text = reader["firstname"].ToString();
                            lnameBox.Text = reader["lastname"].ToString();
                            phoneBox.Text = reader["phone"].ToString();
                        }
                        reader.Close();
                    }
                }
            }
        }

// Events
        
        private void nameBox_Change(object sender, EventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if (Matches("^[a-zA-Z'-]+$", this.fnameBox.Text))
            {
                obj.BackColor = Color.LightGreen;
            }
            else
            {
                obj.BackColor = Color.OrangeRed;
            }
            this.checkState();
        }

        private void emailBox_Change(object sender, EventArgs e)
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

        private void phoneBox_Change(object sender, EventArgs e)
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

        private void pass_Change(object sender, EventArgs e)
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
                string connString2 = "Server=OMC-MEDHAT;Database=Flight;Integrated Security=True";

                // SQL Query to update the user's record
                string updateQuery = $"UPDATE [user] SET email = @mail, firstname = @fname, lastname = @lname, phone = @phone WHERE UserId = @userId AND password = @password";

                using (SqlConnection connection = new SqlConnection(connString2))
                {
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                    {
                        // Giving values to parameters
                        updateCmd.Parameters.AddWithValue("@userId", AppGlobals.UserId);
                        updateCmd.Parameters.AddWithValue("@mail", this.emailBox.Text.ToLower().Trim());
                        updateCmd.Parameters.AddWithValue("@fname", this.fnameBox.Text.Trim());
                        updateCmd.Parameters.AddWithValue("@lname", this.lnameBox.Text.Trim());
                        updateCmd.Parameters.AddWithValue("@phone", this.phoneBox.Text.Trim());
                        updateCmd.Parameters.AddWithValue("@password", this.passwordHash()); // Assuming this is the current password

                        try
                        {
                            connection.Open();

                            // Execute update query
                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Acknowledgement
                                SystemSounds.Beep.Play();
                                MessageBox.Show($"User {this.fnameBox.Text} has been updated successfully.", "Success");
                            }
                            else
                            {
                                // No rows updated, show error
                                MessageBox.Show("Failed to update user details. Please check if the provided password is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private bool Matches(string pattern, string text)
        {
            // Create a Regex object
            Regex regex = new Regex(pattern);

            // Use the Regex.IsMatch method to check if the email matches the pattern
            return regex.IsMatch(text);
        }

        private void checkState()
        {


            if (this.passBox.BackColor == Color.LightGreen && this.emailBox.BackColor == Color.LightGreen && this.fnameBox.BackColor == Color.LightGreen
                && this.lnameBox.BackColor == Color.LightGreen
                && this.phoneBox.BackColor == Color.LightGreen) this.submitBtn.Enabled = true;
            else this.submitBtn.Enabled = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }

        private void UpdateUser_Load_1(object sender, EventArgs e)
        {

        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void passLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
