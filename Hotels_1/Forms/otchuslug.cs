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
    public partial class otchuslug : Form
      
    {
        Function sql = new Function();
        public otchuslug()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            users users = new users();
            users.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otchet Otchet = new Otchet();
            Otchet.Show();
        }

        private void buttonSim_Click(object sender, EventArgs e)
        {
        
        }

        private void uslugi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void otchuslug_Load(object sender, EventArgs e)
        {
            uslugi.DataSource = sql.Alluslugi();
        }

    }
}
