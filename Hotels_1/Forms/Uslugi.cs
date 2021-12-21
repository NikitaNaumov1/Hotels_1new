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
    public partial class Uslugi : Form
    {
        Function f = new Function();
        public Uslugi()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
      

        private void poluch_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string rndId = rnd.Next(1000, 99999).ToString();

            if (f.uslugi(name.Text, phone.Text, adress.Text, bussines.Text, premium.Text, bar.Text, konf.Text, kater.Text, pit3.Text, pit2.Text))
            {
                this.DialogResult = DialogResult.No;
            }
            else
            {
                this.DialogResult = DialogResult.Yes;
            }
            MessageBox.Show("Услуги оформлены");
        }

        private void bussines_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
