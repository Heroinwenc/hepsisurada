using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hepsisurada
{
    public partial class Form1 : Form
    {
    Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        int sepet, fiyat = 0, toplamfiyat;
        
        private void button1_Click(object sender, EventArgs e)
        {
            sepet++;
            label1.Text = "Sepet: " + sepet;
            form2.listBox1.Items.Add(label2.Text);
            toplamfiyat= fiyat + 1500;
            label11.Text = "Toplam Tutar: " + toplamfiyat + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sepet++;
            label1.Text = "Sepet: " + sepet;
            form2.listBox1.Items.Add(label3.Text);
            toplamfiyat = fiyat + 20000;
            label11.Text = "Toplam Tutar: " + toplamfiyat + "TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sepet++;
            label1.Text = "Sepet: " + sepet;
            form2.listBox1.Items.Add(label4.Text);
            toplamfiyat = fiyat + 659;
            label11.Text = "Toplam Tutar: " + toplamfiyat + "TL";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sepet++;
            label1.Text = "Sepet: " + sepet;
            form2.listBox1.Items.Add(label5.Text);
            toplamfiyat = fiyat + 900;
            label11.Text = "Toplam Tutar: " + toplamfiyat + "TL";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yiğit Bilgisayar Kingston Hyperx Fury Blue 2gb 1600mhz Ddr3 Ram (hx316c10f/8)", "Ram Özellikleri");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AMD Ryzen 5 1600 R5 1600 3.2 GHz Altı Çekirdekli On İki Konu 65W CPU İşlemci YD1600BBM6IAE Soket AM4 FAN YOK.", "Amd Ryzen 5 İşlemci Özellikleri");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("11 Profesyonel Spor Modu: Açık koşu, Açık bisiklet, Kapalı bisiklete binme, Yürüyüş, Yüzme, Eliptik bandı, Koşu bandı, İp atlama, Yoga, Kürek Makinesi, Ücretsiz eğitim", "Xiaomi Mi Band 5 Özellikleri");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgisayarınızdaki verileri güvenle depolayabileceğiniz, yüksek veri okuma ve yazma hızlarına sahip, uygun fiyatlı bir SSD (Solid State Drive) edinmeyi planlıyorsanız, Hikvision 240GB SSD Disk SATA 3 HS-SSD-C100/240G, gereksinimlerinize çözüm getiriyor. Hem taşınabilir hem de masaüstü bilgisayarınıza, SATA arayüzünden bağlayarak kullanabileceğiniz ürün, teknik özellikleriyle kendi sınıfının sağlaması gereken standartları fazlasıyla karşılıyor. Dayanıklı fiziksel yapısı ve tamamen elektronik bileşenlerden oluşan iç donanımıyla dış koşullardan herhangi bir şekilde etkilenmeyen cihaz, gündelik kullanım için ideal SSD modelleri içerisinde yer alıyor.", "Hikvision 240GB SSD Özellikleri");
        }
    }
}