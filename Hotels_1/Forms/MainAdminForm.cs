using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulation;

namespace Hotels_1.Forms
{
    public partial class MainAdminForm : Form
    {
        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void bronButton(object sender, EventArgs e)
        {
            this.Hide();
            Otchet Otchet = new Otchet();
            Otchet.Show();
        }

        private void userButton(object sender, EventArgs e)
        {
            this.Hide();
            users users = new users();
            users.Show();
        }

        private void simButton(object sender, EventArgs e)
        {
            this.Hide();
            Simulat simulation = new Simulat();
            simulation.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otchet Otchet = new Otchet();
            Otchet.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            users users = new users();
            users.Show();
        }

        private void uslugiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            otchuslug otchuslug = new otchuslug();
            otchuslug.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}