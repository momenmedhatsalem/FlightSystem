﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new UserLogin());
            //Application.Run(new AdminHome());
            // Create test data
            int departure = 5;
            int destination = 4;
            DateTime departureDate = DateTime.Now.Date;
            DateTime returnDate = DateTime.Now.Date.AddDays(7);
            int numberOfPassengers = 2;
            string flightClass = "Business";
            bool Return = false;
            // Create an instance of FlightSelection form with test data
            EditFlight f = new EditFlight();
            FlightSelection flightSelectionForm = new FlightSelection(departure, destination, departureDate, returnDate, numberOfPassengers, flightClass, Return);
            Application.Run(flightSelectionForm);
        }
        public static class AppGlobals
        {
            public static int UserId { get; set; } = 2;
            public static string connString { get; set; } = "Server=OMC-MEDHAT;Database=Flight;Integrated Security=True";
        }

    }
}
