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
            //Application.Run(new AdminHome());
            // Create test data
            int departure = 4;
            int destination = 5;
            DateTime departureDate = DateTime.Now.Date;
            DateTime returnDate = DateTime.Now.Date.AddDays(7);
            int numberOfPassengers = 2;
            string flightClass = "Business";
            bool Return = false;
            // Create an instance of FlightSelection form with test data
            FlightSelection flightSelectionForm = new FlightSelection(departure, destination, departureDate, returnDate, numberOfPassengers, flightClass, Return);
            Application.Run(flightSelectionForm);
        }
        public static class AppGlobals
        {
            public static int UserId { get; set; } = 2;
            public static string connString { get; set; } = "Server=DESKTOP-IG4DDK3;Database=FlightDB;Integrated Security=True";
        }

    }
}
