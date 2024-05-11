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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Rows.Add(2);

            // Column resize
            this.dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Rows
            this.dataGrid.Rows[0].Cells[0].Value = "Most frequent aircrafts";
            this.dataGrid.Rows[1].Cells[0].Value = "Most frequent airport";
            this.dataGrid.Rows[2].Cells[0].Value = "Most visited citeis";

            // Data
            pushData();
            
        }

        // Don't forget to close reader
        private void pushData()
        {
            // Queries
            string[] queries = new string[3];
            queries[0] = @"
                select top 1 AIRCRAFTNAME
                from dbo.AIRCRAFT left outer join SCHEMA_1.FLIGHT
                on FLIGHT.AIR_AIRCRAFTID = AIRCRAFT.AIRCRAFTID
                group by AIRCRAFTID, AIRCRAFTNAME
                order by count(flightid) desc;
             ";
            queries[1] = @"
                select AIRPORT.AIRPORTNAME
                from AIRPORT
                where AIRPORTID = (
	                select top 1 ID
	                from (
			                select DEPARTURE_AIRPORTID2 as ID, count(PAS_PASSENGERID) as cnt
			                from dbo.BOARDING b inner join SCHEMA_1.FLIGHT f on b.FLI_FLIGHTID = f.FLIGHTID
			                group by DEPARTURE_AIRPORTID2
			                union
			                select ARRIVAL_AIRPORTID2 as ID, count(PAS_PASSENGERID) as cnt
			                from dbo.BOARDING b inner join SCHEMA_1.FLIGHT f on b.FLI_FLIGHTID = f.FLIGHTID
			                group by ARRIVAL_AIRPORTID2
	                ) as result
	                group by ID
	                order by sum(cnt) desc
                );
            ";
            queries[2] = @"
                select AIRPORT.CITY from AIRPORT
                where AIRPORT.AIRPORTID = (
	                select top 1 ARRIVAL_AIRPORTID2
	                from SCHEMA_1.FLIGHT as f inner join dbo.BOARDING as r on f.FLIGHTID = r.FLI_FLIGHTID
	                group by f.ARRIVAL_AIRPORTID2
	                order by count(PAS_PASSENGERID) desc
                );
             ";
            using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
            {
                connection.Open();
                for (int i = 0; i < 3; ++i)
                {
                    // Create SqlCommand with query and connection
                    using (SqlCommand command = new SqlCommand(queries[i], connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            this.dataGrid.Rows[i].Cells[1].Value = reader.GetString(0);
                        }
                        else
                        {
                            this.dataGrid.Rows[i].Cells[1].Value = "No records found";
                        }
                    }
                }
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        
}
