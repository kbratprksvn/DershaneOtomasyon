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
    public partial class Girisyap : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Girisyap()
        {
            InitializeComponent();
        }
        
        //static string conString = "Data Source=DESKTOP-DOFFVC1\\SQLEXPRESS;Initial Catalog=Dershaneotomasyon;Integrated Security=True;";
        //SqlConnection baglanti = new SqlConnection(conString);
        private void button1_Click(object sender, EventArgs e)
        {
            Kayitol kfrm = new Kayitol();
            kfrm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sifremiunuttumlbl_Click(object sender, EventArgs e)
        {
            Sifremiunuttum sufrm = new Sifremiunuttum();
            sufrm.Show();
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

        private void gyapbtn_Click(object sender, EventArgs e)
        {
            string user = giristc.Text;
            string pass = girissifre.Text;
            con = new SqlConnection("Data Source=DESKTOP-DOFFVC1\\SQLEXPRESS;Initial Catalog=Dershaneotomasyon;Integrated Security=True;");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Kayitoll where Tcno='" + giristc.Text + "' AND sifre='" + girissifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                Anasayfaname Afrm = new Anasayfaname();
                Afrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                giristc.Text = "";
                girissifre.Text = "";
            }
            con.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                girissifre.PasswordChar = '\0';
            }
            else
            {
                girissifre.PasswordChar = '*';
            }
        }
    }
}
