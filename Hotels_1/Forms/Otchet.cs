using Hotels_1.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotels_1.Forms
{
    public partial class Otchet : Form
    {
        Function sql = new Function();
        public Otchet()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
             users users = new users();
            users.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        

        

        private void Otchet_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.AllBronirovanie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            otchuslug otchuslug = new otchuslug();
            otchuslug.Show();
        }
    }
}
