using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace hepsisurada
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Başarı İle Tamamlandı!","HepsiŞurada");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = "İşlem Saati: " + DateTime.Now.ToLongTimeString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Başarı İle Tamamlandı!","HepsiŞurada");
        }

        private void fiyatlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
