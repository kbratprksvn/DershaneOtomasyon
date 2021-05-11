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
    public partial class Velikayit : Form
    {
        public Velikayit()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-DOFFVC1\\SQLEXPRESS;Initial Catalog=Dershaneotomasyon;Integrated Security=True;";
        SqlConnection baglanti = new SqlConnection(conString);

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

        private void Velikayit_Load(object sender, EventArgs e)
        {

        }

        private void kayitolbtn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string kayit = "insert into Velikayit(Vadi,Vsoyadi,Visadresi,Vevadresi,Vmail,Vtel,Vtc,Votc) values (@Vadi,@Vsoyadi,@Visadresi,@Vevadresi,@Vmail,@Vtel,@Vtc,@Votc)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
               
                komut.Parameters.AddWithValue("@Vadi", Vaditxt.Text);
                komut.Parameters.AddWithValue("@Vsoyadi", Vsoyaditxt.Text);
                komut.Parameters.AddWithValue("@Visadresi", Visadresitxt.Text);
                komut.Parameters.AddWithValue("@Vevadresi", Vevadresitxt.Text);
                komut.Parameters.AddWithValue("@Vmail", Vmailtxt.Text);
                komut.Parameters.AddWithValue("@Vtel", Vteltxt.Text);
                komut.Parameters.AddWithValue("@Vtc", Vtctxt.Text);
                komut.Parameters.AddWithValue("@Votc", Votctxt.Text);  
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Veli Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vaditxt.Text = "";
            Vsoyaditxt.Text = "";
            Vtctxt.Text = "";
            Votctxt.Text = "";
            Visadresitxt.Text = "";
            Vevadresitxt.Text = "";
            Vteltxt.Text = "";
            Vmailtxt.Text = "";
        }

        private void Vtctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vtctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
            if (Vtctxt.TextLength == 11) //Karakter sayısı kısıtlama 11 den fazla rakam girilmiyor
            {
                e.Handled = true;
            }
        }

        private void Vteltxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
