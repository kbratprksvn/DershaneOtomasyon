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
    public partial class OdevSinavtakip : Form
    {
        public OdevSinavtakip()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Anasayfaname afrm = new Anasayfaname();
            afrm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Odevtakip odev = new Odevtakip();
            odev.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SinavTakip stfrm = new SinavTakip();
            stfrm.Show();
            this.Hide();
        }
    }
}
