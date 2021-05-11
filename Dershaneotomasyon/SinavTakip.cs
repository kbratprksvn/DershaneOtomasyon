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
using System.Collections;
using System.Drawing;
using System.Drawing.Printing;
namespace Dershaneotomasyon
{
    public partial class SinavTakip : Form
    {
        public SinavTakip()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-DOFFVC1\\SQLEXPRESS;Initial Catalog=Dershaneotomasyon;Integrated Security=True;";
        SqlConnection con = new SqlConnection(conString);
        SqlCommand cmd;
        SqlDataReader dr;
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            OdevSinavtakip ostfrm = new OdevSinavtakip();
            ostfrm.Show();
            this.Hide();

        }

        private void SinavTakip_Load(object sender, EventArgs e)
        {
            birincisinavpanel.Visible = true;
            sozelpanel.Visible = false;
            esitagirlikpanel.Visible = false;
            sayisalpanel.Visible = false;
            gyapbtn.Visible = false;
            sozelbtn.Visible = false;
            sayisalbtn.Visible = false;
        }

        private void birincisinavrb_CheckedChanged(object sender, EventArgs e)
        {
            birincisinavpanel.Visible = true;
            sozelpanel.Visible = false;
            esitagirlikpanel.Visible = false;
            sayisalpanel.Visible = false;
            kayitolbtn.Visible = true;
            gyapbtn.Visible = false;
            sozelbtn.Visible = false;
            sayisalbtn.Visible = false;
            Otctxt.Text = "";
            Oaditxt.Text = "";
            Osoyaditxt.Text = "";
            Bdogrutxt.Text = "";
            Byanlistxt.Text = "";
            Bnetxt.Text = "";
            Bpuantxt.Text = "";
            sozelpuantxt.Text = "";
            sozeldogrutxt.Text = "";
            sozelyanlistxt.Text = "";
            sozelnetxt.Text = "";
            EAPuan.Text = "";
            EADogru.Text = "";
            EAYanlis.Text = "";
            EANet.Text = "";
            gyapbtn.Visible = false;


        }

        private void birincisinavrb_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void birincisinavpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sözelrb_CheckedChanged(object sender, EventArgs e)
        {
            sozelpanel.Visible = true;
            birincisinavpanel.Visible = false;
            esitagirlikpanel.Visible = false;
            sayisalpanel.Visible = false;
            sozelbtn.Visible = true;
            gyapbtn.Visible = false;
            kayitolbtn.Visible = false;
            sayisalbtn.Visible = false;
            Otctxt.Text = "";
            Oaditxt.Text = "";
            Osoyaditxt.Text = "";
            Bdogrutxt.Text = "";
            Byanlistxt.Text = "";
            Bnetxt.Text = "";
            Bpuantxt.Text = "";
            sozelpuantxt.Text = "";
            sozeldogrutxt.Text = "";
            sozelyanlistxt.Text = "";
            sozelnetxt.Text = "";
            EAPuan.Text = "";
            EADogru.Text = "";
            EAYanlis.Text = "";
            EANet.Text = "";
        }

        private void esitagirlikrb_CheckedChanged(object sender, EventArgs e)
        {
            esitagirlikpanel.Visible = true;
            birincisinavpanel.Visible = false;
            sozelpanel.Visible = false;
            sayisalpanel.Visible = false;
            gyapbtn.Visible = true;
            kayitolbtn.Visible = false;
            sozelbtn.Visible = false;
            sayisalbtn.Visible = false;
            Otctxt.Text = "";
            Oaditxt.Text = "";
            Osoyaditxt.Text = "";
            Bdogrutxt.Text = "";
            Byanlistxt.Text = "";
            Bnetxt.Text = "";
            Bpuantxt.Text = "";
            sozelpuantxt.Text = "";
            sozeldogrutxt.Text = "";
            sozelyanlistxt.Text = "";
            sozelnetxt.Text = "";
            EAPuan.Text = "";
            EADogru.Text = "";
            EAYanlis.Text = "";
            EANet.Text = "";


        }

        private void sayisalrb_CheckedChanged(object sender, EventArgs e)
        {
            sayisalpanel.Visible = true;
            birincisinavpanel.Visible = false;
            sozelpanel.Visible = false;
            esitagirlikpanel.Visible = false;
            gyapbtn.Visible = false;
            kayitolbtn.Visible = false;
            sozelbtn.Visible = false;
            sayisalbtn.Visible = true;
            Otctxt.Text = "";
            Oaditxt.Text = "";
            Osoyaditxt.Text = "";
            Bdogrutxt.Text = "";
            Byanlistxt.Text = "";
            Bnetxt.Text = "";
            Bpuantxt.Text = "";
            sozelpuantxt.Text = "";
            sozeldogrutxt.Text = "";
            sozelyanlistxt.Text = "";
            sozelnetxt.Text = "";
            EAPuan.Text = "";
            EADogru.Text = "";
            EAYanlis.Text = "";
            EANet.Text = "";


        }

        private void sayisalpanel_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void esitagirlikpanel_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void sayisalpanel_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void sayisalpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void kayitolbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string kayit = "insert into Bsinavkayit(Otc,Oadi,Osoyadi,Bpuan,Bdogru,Byanlis,Bnet) values (@Otc,@Oadi,@Osoyadi,@Bpuan,@Bdogru,@Byanlis,@Bnet)";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@Otc", Otctxt.Text);
                komut.Parameters.AddWithValue("@Oadi", Oaditxt.Text);
                komut.Parameters.AddWithValue("@Osoyadi", Osoyaditxt.Text);
                komut.Parameters.AddWithValue("@Bpuan", Bpuantxt.Text);
                komut.Parameters.AddWithValue("@Bdogru", Bdogrutxt.Text);
                komut.Parameters.AddWithValue("@Byanlis", Byanlistxt.Text);
                komut.Parameters.AddWithValue("@Bnet", Bnetxt.Text);
                komut.ExecuteNonQuery();
                verilerigoster("Select * from Bsinavkayit");
                con.Close();
                MessageBox.Show("Sınav Bilgileri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void sozelpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string kayit = "insert into SoSinavKayit(Otc,Oadi,Osoyadi,SoPuan,SoDogru,SoYanlis,SoNet) values (@Otc,@Oadi,@Osoyadi,@SoPuan,@SoDogru,@SoYanlis,@SoNet)";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@Otc", Otctxt.Text);
                komut.Parameters.AddWithValue("@Oadi", Oaditxt.Text);
                komut.Parameters.AddWithValue("@Osoyadi", Osoyaditxt.Text);
                komut.Parameters.AddWithValue("@SoPuan", sozelpuantxt.Text);
                komut.Parameters.AddWithValue("@SoDogru", sozeldogrutxt.Text);
                komut.Parameters.AddWithValue("@SoYanlis", sozelyanlistxt.Text);
                komut.Parameters.AddWithValue("@SoNet", sozelnetxt.Text);
                komut.ExecuteNonQuery();
                verilerigoster("Select * from SoSinavKayit");
                con.Close();
                MessageBox.Show("Sınav Bilgileri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void esitagirlikpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gyapbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string kayit = "insert into EASinavKayit(Otc,Oadi,Osoyadi,EAPuan,EADogru,EAYanlis,EANet) values (@Otc,@Oadi,@Osoyadi,@EAPuan,@EADogru,@EAYanlis,@EANet)";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@Otc", Otctxt.Text);
                komut.Parameters.AddWithValue("@Oadi", Oaditxt.Text);
                komut.Parameters.AddWithValue("@Osoyadi", Osoyaditxt.Text);
                komut.Parameters.AddWithValue("@EAPuan", EAPuan.Text);
                komut.Parameters.AddWithValue("@EADogru", EADogru.Text);
                komut.Parameters.AddWithValue("@EAYanlis", EAYanlis.Text);
                komut.Parameters.AddWithValue("@EANet", EANet.Text);
                komut.ExecuteNonQuery();
                verilerigoster("Select * from EASinavKayit");
                con.Close();
                MessageBox.Show("Sınav Bilgileri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void sayisalbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string kayit = "insert into SaSinavKayit(Otc,Oadi,Osoyadi,SaPuan,SaDogru,SaYanlis,SaNet) values (@Otc,@Oadi,@Osoyadi,@SaPuan,@SaDogru,@SaYanlis,@SaNet)";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@Otc", Otctxt.Text);
                komut.Parameters.AddWithValue("@Oadi", Oaditxt.Text);
                komut.Parameters.AddWithValue("@Osoyadi", Osoyaditxt.Text);
                komut.Parameters.AddWithValue("@SaPuan", sayisalpuantxt.Text);
                komut.Parameters.AddWithValue("@SaDogru", sayisaldogrutxt.Text);
                komut.Parameters.AddWithValue("@SaYanlis", sayisalyanlistxt.Text);
                komut.Parameters.AddWithValue("@SaNet", sayisalnettxt.Text);
                komut.ExecuteNonQuery();
                verilerigoster("Select * from SaSinavKayit");
                con.Close();
                MessageBox.Show("Sınav Bilgileri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //e.Graphics.DrawString(Otctxt.Text, new Font("türü", 54, FontStyle.Bold), Brushes.Black, new Point(50, 50));
            //e.Graphics.DrawString(Oaditxt.Text, new Font("türü", 54, FontStyle.Bold), Brushes.Black, new Point(50, 50));
            //e.Graphics.DrawString(Osoyaditxt.Text, new Font("türü", 54, FontStyle.Bold), Brushes.Black, new Point(50, 50));
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
    }
}

