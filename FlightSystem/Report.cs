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
        private System.Windows.Forms.Label[] records;
        public Report()
        {
            InitializeComponent();
            InitializeCards();
        }

        private void InitializeCards()
        {
            records = new System.Windows.Forms.Label[6];

            // Adding labels
            this.addLabel(this.panel1, 0);
            this.addLabel(this.panel2, 1);
            this.addLabel(this.panel3, 2);
            this.addLabel(this.panel4, 3);
            this.addLabel(this.panel5, 4);
            this.addLabel(this.panel6, 5);

            // Data
            pushData();
            
        }

        private void addLabel(System.Windows.Forms.Panel panel, int i)
        {
            records[i] = new System.Windows.Forms.Label();
            this.records[i].Dock = System.Windows.Forms.DockStyle.Fill;
            this.records[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.records[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.records[i].Location = new System.Drawing.Point(5, 5);
            this.records[i].Name = "record" + i;
            this.records[i].Size = new System.Drawing.Size(181, 18);
            this.records[i].TabIndex = 0;
            this.records[i].Text = "0";
            this.records[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            panel.Controls.Add(records[i]);
        }

        // Don't forget to close reader
        private void pushData()
        {
            // Queries
            string[] queries = new string[6];
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
            queries[3] = @"
                select cast(count(aircraftid) AS NVARCHAR(10))
                from dbo.AIRCRAFT;
            ";
            queries[4] = @"
                select cast(count(AIRPORT.AIRPORTID) AS NVARCHAR(10))
                from dbo.AIRPORT;
            ";
            queries[5] = @"
                SELECT CAST(COUNT(SCHEMA_1.FLIGHT.FLIGHTID) AS NVARCHAR(10))
                FROM SCHEMA_1.FLIGHT
                WHERE CAST(DEPARTUREDATE AS DATE) >= CAST(GETDATE() AS DATE);
            ";
            using (SqlConnection connection = new SqlConnection(AppGlobals.connString))
            {
                connection.Open();
                for (int i = 0; i < 6; ++i)
                {
                    // Create SqlCommand with query and connection
                    using (SqlCommand command = new SqlCommand(queries[i], connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            this.records[i].Text = reader.GetString(0);
                        }
                        else
                        {
                            this.records[i].Text = "No record";
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
