using System;
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

            // Create test data
            string departure = "New York";
            string destination = "Los Angeles";
            DateTime departureDate = DateTime.Now.Date;
            DateTime returnDate = DateTime.Now.Date.AddDays(7);
            int numberOfPassengers = 2;
            string flightClass = "Business";
            bool Return = false;
            // Create an instance of FlightSelection form with test data
            FlightSelection flightSelectionForm = new FlightSelection(departure, destination, departureDate, returnDate, numberOfPassengers, flightClass, Return);
            Application.Run(new Home());
        }
        public static class AppGlobals
        {
            public static int UserId { get; set; } = 0;
        }

    }
}
