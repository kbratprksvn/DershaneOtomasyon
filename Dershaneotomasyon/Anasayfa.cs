using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dershaneotomasyon
{
    public partial class Anasayfaname : Form
    {
        public Anasayfaname()
        {
            InitializeComponent();
        }

        private void Anasayfapcok_Click(object sender, EventArgs e)
        {
            Ogrencibilgileri obfrm = new Ogrencibilgileri();
            obfrm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Anasayfapb_Click(object sender, EventArgs e)
        {
            Ogrencikayit ofrm = new Ogrencikayit();
            ofrm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Ogrencikayit ofrm = new Ogrencikayit();
            ofrm.Show();
            this.Hide();
        }

        private void Anasayfaname_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Personelkayit pfrm = new Personelkayit();
            pfrm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Personelbilgileri pbfrm = new Personelbilgileri();
            pbfrm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Velikayit vkfrm = new Velikayit();
            vkfrm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Velibilgilendirme vbfrm = new Velibilgilendirme();
            vbfrm.Show();
            this.Hide();
        }

        private void Anasayfapcot_Click(object sender, EventArgs e)
        {
            OdevSinavtakip osfrn = new OdevSinavtakip();
            osfrn.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            makbuzlar odemelerfrm = new makbuzlar();
            odemelerfrm.Show();
            this.Hide();
        }
    }
}
