using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FlightSystem.Program;

namespace FlightSystem
{
    public partial class AdminHome : Form
    {

        public AdminHome()
        {
            InitializeComponent();
            this.Load += AdminHome_Load;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            int UserId = Program.AppGlobals.UserId;
            if (UserId != 0)
            {
                string query = "SELECT FirstName FROM [USER] WHERE UserId = @UserId";

                using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", UserId);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string firstName = result.ToString();
                        label1.Text = $"Welcome, {firstName}!";
                    }
                }
            }
            else
            {
                label1.Text = "You Are NOT Authorized To Access This Page !";
            }
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddAirCraftbtn_Click(object sender, EventArgs e)
        {
            AddAirCraftForm newForm = new AddAirCraftForm();
            newForm.Show();
            this.Hide();
        }

        private void UpdateAirCraftbtn_Click(object sender, EventArgs e)
        {
            EditAircraft_Info newForm = new EditAircraft_Info();
            newForm.Show();
            this.Hide();
        }

        private void AddFlightBtn_Click(object sender, EventArgs e)
        {
            AddAFlight newForm = new AddAFlight();
            newForm.Show();
            this.Hide();
        }

        private void UpdateFlightBtn_Click(object sender, EventArgs e)
        {
            EditFlight newForm = new EditFlight();
            newForm.Show();
            this.Hide();
        }

        private void AdminHome_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }


}

