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
    public partial class Personelbilgileri : Form
    {
        public Personelbilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DOFFVC1\\SQLEXPRESS;Initial Catalog=Dershaneotomasyon;Integrated Security=True");
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
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

        private void btnara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from Personelkayit where Ptc=@Ptc";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("Ptc", Ptctxt.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Ptctxt.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            Paditxt.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            Psoyaditxt.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            Pdalitxt.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            Pgorevitxt.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            Pmailtxt.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            Pteltxt.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            Pmaastxt.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Personelkayit where Ptc=@Ptc", baglanti);
            komut.Parameters.AddWithValue("@Ptc", Ptctxt.Text);
            komut.ExecuteNonQuery();
            verilerigoster("select * from Personelkayit");
            baglanti.Close();
            Ptctxt.Clear();
            Paditxt.Clear();
            Psoyaditxt.Clear();
            Pdalitxt.Clear();
            Pgorevitxt.Clear();
            Pmailtxt.Clear();
            Pteltxt.Clear();
            Pmaastxt.Clear();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
  
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Personelkayit set  Padi='" + Paditxt.Text + "', Psoyadi='" + Psoyaditxt.Text + "', Pdali='" + Pdalitxt.Text + "',Pgorevi='" + Pgorevitxt.Text + "', Pmail='" + Pmailtxt.Text + "',Ptel='" + Pteltxt.Text + "',Pmaas='" + Pmaastxt.Text + "' where Ptc='" + Ptctxt.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                verilerigoster("select * from Personelkayit");
                baglanti.Close();
            
        }

        private void Personelbilgileri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from Personelkayit";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenalan = dataGridView2.SelectedCells[0].RowIndex;
            string Ptc = dataGridView2.Rows[secilenalan].Cells[0].ToString();
            string Padi = dataGridView2.Rows[secilenalan].Cells[1].ToString();
            string Psoyadi = dataGridView2.Rows[secilenalan].Cells[2].ToString();
            string Pdali = dataGridView2.Rows[secilenalan].Cells[3].ToString();
            string Pgorevi = dataGridView2.Rows[secilenalan].Cells[4].ToString();
            string Pmail = dataGridView2.Rows[secilenalan].Cells[5].ToString();
            string Ptel = dataGridView2.Rows[secilenalan].Cells[6].ToString();
            string Pmaas = dataGridView2.Rows[secilenalan].Cells[7].ToString();
            Ptctxt.Text = Ptc;
            Paditxt.Text = Padi;
            Psoyaditxt.Text = Psoyadi;
            Pdalitxt.Text = Pdali;
            Pgorevitxt.Text = Pgorevi;
            Pmailtxt.Text = Pmail;
            Pteltxt.Text = Ptel;
            Pmaastxt.Text = Pmaas;
        }
    }
}
