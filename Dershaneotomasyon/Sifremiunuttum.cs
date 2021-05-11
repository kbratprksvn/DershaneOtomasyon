using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Dershaneotomasyon
{
    public partial class Sifremiunuttum : Form
    {
        

        public Sifremiunuttum()
        {
            InitializeComponent();
           
        }
        static string conString = "Data Source=DESKTOP-DOFFVC1\\SQLEXPRESS;Initial Catalog=Dershaneotomasyon;Integrated Security=True;";
        SqlConnection con = new SqlConnection(conString);
        SqlCommand cmd;
        SqlDataReader dr;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Kayitoll where Tcno='" + giristc.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                try
                {
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    string mailadresin = ("kubobeto@gmail.com");
                    string mailsifren = ("beto.123456");
                    string smptsrvr = "smtp.gmail.com"; // outlook, hotmail için gerek smtp
                    string kime = (dr["Mail"].ToString());
                    string konu = ("Parola Hatırlatma");
                    string yazi = ("Sayın " + dr["Adi"].ToString() + " " + dr["Soyadi"].ToString() + "\nParolanız = " + dr["Sifre"].ToString());  // metin

                    smtpserver.Credentials = new NetworkCredential(mailadresin, mailsifren);
                    smtpserver.Port = 587;
                    smtpserver.Host = smptsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yazi;
                    smtpserver.Send(mail);
                    MessageBox.Show("Şifreniz Mail Adresinize Gönderildi.");
                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
                con.Close();
            }
        }
    }
}

