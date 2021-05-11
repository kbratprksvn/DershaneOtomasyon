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
    public partial class Kayitol : Form
    {
        public Kayitol()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-DOFFVC1\\SQLEXPRESS;Initial Catalog=Dershaneotomasyon;Integrated Security=True;";
        SqlConnection baglanti = new SqlConnection(conString);
        private void button1_Click(object sender, EventArgs e)
        {
            giristc.Text = "";
            kaditxt.Text = "";
            kmailtxt.Text = "";
            ksoyaditxt.Text = "";
            kdogumyeritxt.Text = "";
            kgorevitxt.Text = "";
            girissifre.Text = "";
            dateTimePicker1.Text = "";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Kayitol_Load(object sender, EventArgs e)
        {

        }

        private void giristc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
            if (giristc.TextLength == 11) //Karakter sayısı kısıtlama 11 den fazla rakam girilmiyor
            {
                e.Handled = true;
            }
        }

        private void kayitolbtn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    baglanti.Open();
                    string kayit = "insert into Kayitoll(Tcno,Adi,Soyadi,Mail,Dogumtarihi,Dogumyeri,Gorevi,Sifre) values (@Tcno,@Adi,@Soyadi,@Mail,@Dogumtarihi,@Dogumyeri,@Gorevi,@Sifre)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@Tcno", giristc.Text);
                    komut.Parameters.AddWithValue("@Adi", kaditxt.Text);
                    komut.Parameters.AddWithValue("@Soyadi", ksoyaditxt.Text);
                    komut.Parameters.AddWithValue("@Mail", kmailtxt.Text);
                    komut.Parameters.AddWithValue("@Dogumtarihi", dateTimePicker1.Value);
                    komut.Parameters.AddWithValue("@Dogumyeri", kdogumyeritxt.Text);
                    komut.Parameters.AddWithValue("@Gorevi", kgorevitxt.Text);
                    komut.Parameters.AddWithValue("@Sifre", girissifre.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show(" Kayıt İşlemi Gerçekleşti.");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
        }

        private void sifremiunuttumlbl_Click(object sender, EventArgs e)
        {
            Girisyap gfrm = new Girisyap();
            gfrm.Show();
            this.Hide();
        }

        private void giristc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}