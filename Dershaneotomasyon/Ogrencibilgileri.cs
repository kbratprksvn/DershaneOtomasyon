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
    public partial class Ogrencibilgileri : Form
    {
        public Ogrencibilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti =  new SqlConnection("Data Source=DESKTOP-DOFFVC1\\SQLEXPRESS;Initial Catalog=Dershaneotomasyon;Integrated Security=True");
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Ogrencikayit where Otc=@Otc", baglanti);
            komut.Parameters.AddWithValue("@Otc", Otctxt.Text);
            komut.ExecuteNonQuery();
            verilerigoster("select * from Ogrencikayit");
            baglanti.Close();
            Otctxt.Clear();
            Oaditxt.Clear();
            Osoyaditxt.Clear();
            Obolumutxt.Clear();
            Osinifitxt.Clear();
            Omailtxt.Clear();
            Oteltxt.Clear();
            Oevadresitxt.Clear();
        }
        private void Ogrencibilgileri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from Ogrencikayit";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void label11_Click(object sender, EventArgs e)
        {
            Anasayfaname afrm = new Anasayfaname();
            afrm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kayitolbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Ogrencikayit set Oadi='" + Oaditxt.Text + "', Osoyadi='" + Osoyaditxt.Text + "', Obolumu='" + Obolumutxt.Text + "',Osinifi='" + Osinifitxt.Text + "', Omail='" + Omailtxt.Text + "',Otel='" + Oteltxt.Text + "',Oevadresi='" + Oevadresitxt.Text + "' where Otc='" + Otctxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("select * from Ogrecikayit");
            baglanti.Close();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Otctxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Oaditxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Osoyaditxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Obolumutxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Osinifitxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Omailtxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Oteltxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Oevadresitxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            
        }



        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from Ogrencikayit where Otc=@Otc";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@Otc", Otctxt.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenalan = dataGridView1.SelectedCells[0].RowIndex;
            string Otc = dataGridView1.Rows[secilenalan].Cells[0].ToString();
            string Oadi = dataGridView1.Rows[secilenalan].Cells[1].ToString();
            string Osoyadi = dataGridView1.Rows[secilenalan].Cells[2].ToString();
            string Obolumu = dataGridView1.Rows[secilenalan].Cells[3].ToString();
            string Osinifi = dataGridView1.Rows[secilenalan].Cells[4].ToString();
            string Omail = dataGridView1.Rows[secilenalan].Cells[5].ToString();
            string Otel = dataGridView1.Rows[secilenalan].Cells[6].ToString();
            string Oevadresi = dataGridView1.Rows[secilenalan].Cells[7].ToString();
            Otctxt.Text = Otc;
            Oaditxt.Text = Oadi;
            Osoyaditxt.Text = Osoyadi;
            Obolumutxt.Text = Obolumu;
            Osinifitxt.Text = Osinifi;
            Omailtxt.Text = Omail;
            Oteltxt.Text = Otel;
            Oevadresitxt.Text = Oevadresi;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Oevadresitxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Oteltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Omailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Osinifitxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Obolumutxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Osoyaditxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Oaditxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Otctxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
