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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.toggleSideMenu();
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
                    btn.Padding = new Padding(10, 0, 10, 0);
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            toggleSideMenu();
        }
    }
}
