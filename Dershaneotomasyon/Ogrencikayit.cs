using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dershaneotomasyon
{
    public partial class Ogrencikayit : Form
    {
        public Ogrencikayit()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-DOFFVC1\\SQLEXPRESS;Initial Catalog=Dershaneotomasyon;Integrated Security=True;";
        SqlConnection baglanti = new SqlConnection(conString);
     
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Anasayfaname afrm = new Anasayfaname();
            afrm.Show();
            this.Hide();
        }

        private void giristc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) //rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }

        private void Ogrencikayit_Load(object sender, EventArgs e)
        {

        }

        private void kayitolbtn_Click(object sender, EventArgs e)
        {
            try
            {
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into Ogrencikayit(Otc,Oadi,Osoyadi,Obolumu,Osinifi,Omail,Otel,Oevadresi) values (@Otc,@Oadi,@Osoyadi,@Obolumu,@Osinifi,@Omail,@Otel,@Oevadresi)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@Otc", Otctxt.Text);
                komut.Parameters.AddWithValue("@Oadi", Oaditxt.Text);
                komut.Parameters.AddWithValue("@Osoyadi", Osoyaditxt.Text);
                komut.Parameters.AddWithValue("@Obolumu", Obolumutxt.Text);
                komut.Parameters.AddWithValue("@Osinifi", Osinifitxt.Text);
                komut.Parameters.AddWithValue("@Omail", Omailtxt.Text);
                komut.Parameters.AddWithValue("@Otel", Oteltxt.Text);
                komut.Parameters.AddWithValue("@Oevadresi", Oevadresitxt.Text);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("Öğrenci Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otctxt.Text = "";
            Oaditxt.Text = "";
            Osoyaditxt.Text = "";
            Obolumutxt.Text = "";
            Osinifitxt.Text = "";
            Omailtxt.Text = "";
            Oteltxt.Text = "";
            Oevadresitxt.Text = "";
            Oresim.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Resim Seç";
            fd.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.Oresim.Image = new Bitmap(fd.OpenFile());
            }
        }
    }
}
