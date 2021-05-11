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
    public partial class makbuzlar : Form
    {
        public makbuzlar()
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
            OgrenciMakbuzOdeme oofrm = new OgrenciMakbuzOdeme();
            oofrm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PersonelMaasOdeme pmofrm = new PersonelMaasOdeme();
            pmofrm.Show();
        }
    }
}
