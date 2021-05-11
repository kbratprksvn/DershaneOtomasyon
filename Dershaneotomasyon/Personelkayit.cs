using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dershaneotomasyon
{
    public partial class Personelkayit : Form
    {
        public Personelkayit()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-DOFFVC1\\SQLEXPRESS;Initial Catalog=Dershaneotomasyon;Integrated Security=True;";
        SqlConnection baglanti = new SqlConnection(conString);
        private void label10_Click(object sender, EventArgs e)
        {
            Anasayfaname afrm = new Anasayfaname();
            afrm.Show();
            this.Hide();
        }

        private void Personelkayit_Load(object sender, EventArgs e)
        {

        }

        private void kayitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string kayit = "insert into Personelkayit(Ptc,Padi,Psoyadi,Pdali,Pgorevi,Pmail,Ptel,Pmaas) values (@Ptc,@Padi,@Psoyadi,@Pdali,@Pgorevi,@Pmail,@Ptel,@Pmaas)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@Ptc", Ptctxt.Text);
                komut.Parameters.AddWithValue("@Padi", Paditxt.Text);
                komut.Parameters.AddWithValue("@Psoyadi", Psoyaditxt.Text);
                komut.Parameters.AddWithValue("@Pdali", Pdalitxt.Text);
                komut.Parameters.AddWithValue("@Pgorevi", Pgorevitxt.Text);
                komut.Parameters.AddWithValue("@Pmail", Pmailtxt.Text);
                komut.Parameters.AddWithValue("@Ptel", Pteltxt.Text);
                komut.Parameters.AddWithValue("@Pmaas", Pmaastxt.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Personel Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            Ptctxt.Text = "";
            Paditxt.Text = "";
            Psoyaditxt.Text = "";
            Pdalitxt.Text = "";
            Pgorevitxt.Text = "";
            Pmailtxt.Text = "";
            Pteltxt.Text = "";
            Pmaastxt.Text = "";
            Presim.Image = null;
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Resim Seç";
            fd.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";
            if(fd.ShowDialog()==DialogResult.OK)
            {
                this.Presim.Image = new Bitmap(fd.OpenFile());
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kayitbtn_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
