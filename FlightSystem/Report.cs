using System;
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
            this.dataGrid.Rows[0].Cells[0].Value = "Most visited citeis";
            this.dataGrid.Rows[1].Cells[0].Value = "Most used aircrafts";
            this.dataGrid.Rows[2].Cells[0].Value = "Most used airports";
            
        }

        private void pushData()
        {
            // Fetch most visited cities and aircrafts and airports and push them

        }
    }

}
