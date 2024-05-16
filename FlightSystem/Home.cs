using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FlightSystem.Program;

namespace FlightSystem
{
    public partial class Home : Form
    {

        private DataRow userRow = null;
        public Home()
        {
            InitializeComponent();
            this.toggleSideMenu();
            this.authorizeUser();
        }

        private void toggleSideMenu()
        {
            if (this.menuPanel.Width >= 200)
            {
                this.menuPanel.Width = 80;
                this.logo.Visible = false;
                this.menuBtn.Dock = DockStyle.Fill;

                foreach (Button btn in this.menuPanel.Controls.OfType<Button>())
                {
                    btn.Text = "";
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    btn.Padding = new Padding(0);
                }
            }
            else
            {
                this.menuPanel.Width = 200;
                this.logo.Visible = true;
                this.menuBtn.Dock = DockStyle.Right;

                foreach (Button btn in this.menuPanel.Controls.OfType<Button>())
                {
                    btn.Text = btn.Tag.ToString();
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                }

                // Padding
                this.bookingBtn.Padding = new System.Windows.Forms.Padding(10, 0, 60, 0);
                this.updateInfoBtn.Padding = new System.Windows.Forms.Padding(10, 0, 30, 0);
                this.reportButton.Padding = new System.Windows.Forms.Padding(10, 0, 66, 0);
                this.profileBtn.Padding = new System.Windows.Forms.Padding(10, 0, 66, 0);
                this.signoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 82, 0);
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            toggleSideMenu();
        }

        private void authorizeUser()
        {
            // Work from here
            if (AppGlobals.UserId != 0)
            {
                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    // Create SqlCommand with query and connection
                    using (SqlCommand command = new SqlCommand("SELECT * FROM [user] where userid=@id", connection))
                    {
                        command.Parameters.AddWithValue("id", AppGlobals.UserId);

                        connection.Open();

                        // Create a DataTable to store the results
                        DataTable dataTable = new DataTable();

                        // Use SqlDataAdapter to fill the DataTable with data from the query
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                        userRow = dataTable.Rows[0];
                    }
                }
                this.userstatusLabel.Text = $"You have been logged in as {userRow[2]} {userRow[3]}";
                this.loginBtn.Visible = false;
                this.signupBtn.Visible = false;
            }
            else
            {
                this.userstatusLabel.Text = "You're NOT logged in\r\nPlease consider logging in or signing up for a new account";
                this.loginBtn.Visible = true;
                this.signupBtn.Visible = true;
                this.updateInfoBtn.Hide();
            }
        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            if (AppGlobals.UserId == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("You're already logged out Ya Maaan !!", "Logout");
            }
            else
            {
                AppGlobals.UserId = 0;
                SystemSounds.Beep.Play();
                MessageBox.Show("You have logged out successfully Ya Brooo !", "Logout");
                this.authorizeUser();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            UserLogin login = new UserLogin();
            login.Show();

            this.Hide();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            UserSignup signup = new UserSignup();
            signup.Show();
            this.Hide();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            if (AppGlobals.UserId == 0)
            {
                MessageBox.Show("You have to login first to show your profile", "Authentication error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if ((bool)userRow[4])
            {
                // Admin
                AdminHome admin = new AdminHome();
                admin.Show();

                this.Hide();
            }
            else
            {
                // User
                BookingManagement user = new BookingManagement();
                user.Show();

                this.Hide();
            }
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            if (AppGlobals.UserId == 0)
            {
                MessageBox.Show("You have to login first to book flights", "Authentication error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Booking booking = new Booking();
                booking.Show();

                Console.WriteLine("Hello");
                this.Hide();
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void updateInfoBtn_Click(object sender, EventArgs e)
        {
            UpdateUser win = new UpdateUser();
            win.Show();
        }
    }
}
