﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSystem
{
    public partial class FlightSelection : Form
    {
        public FlightSelection(string departure, string destination,
            DateTime departureDate, DateTime returnDate,
            int numberOfPassengers, string flightClass)
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlightSelection_Load(object sender, EventArgs e)
        {

        }
    }
}
