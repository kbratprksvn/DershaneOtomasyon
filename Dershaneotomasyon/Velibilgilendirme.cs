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
    public partial class Velibilgilendirme : Form
    {
        public Velibilgilendirme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DOFFVC1\\SQLEXPRESS;Initial Catalog=Dershaneotomasyon;Integrated Security=True");
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Velibilgilendirme_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from Velikayit";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            baglanti.Close();
        }

        private void Votctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Anasayfaname afrm = new Anasayfaname();
            afrm.Show();
            this.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Vtctxt.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();
            Vaditxt.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            Vsoyaditxt.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            Visadresitxt.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            Vevadresitxt.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            Vmailtxt.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            Vteltxt.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            Votctxt.Text = dataGridView3.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenalan = dataGridView3.SelectedCells[0].RowIndex;
            string Vtc = dataGridView3.Rows[secilenalan].Cells[6].ToString();
            string Vadi = dataGridView3.Rows[secilenalan].Cells[0].ToString();
            string Vsoyadi = dataGridView3.Rows[secilenalan].Cells[1].ToString();
            string Visadresi = dataGridView3.Rows[secilenalan].Cells[2].ToString();
            string Vevadresi = dataGridView3.Rows[secilenalan].Cells[3].ToString();
            string Vmail = dataGridView3.Rows[secilenalan].Cells[4].ToString();
            string Vtel = dataGridView3.Rows[secilenalan].Cells[5].ToString();
            string Votc = dataGridView3.Rows[secilenalan].Cells[7].ToString();
            Vtctxt.Text = Vtc;
            Vaditxt.Text = Vadi;
            Vsoyaditxt.Text = Vsoyadi;
            Visadresitxt.Text = Visadresi;
            Vevadresitxt.Text = Vevadresi;
            Vmailtxt.Text = Vmail;
            Vteltxt.Text = Vtel;
            Votctxt.Text = Votc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Velikayit where Vtc=@Vtc", baglanti);
            komut.Parameters.AddWithValue("@Vtc", Vtctxt.Text);
            komut.ExecuteNonQuery();
            verilerigoster("select * from Velikayit");
            baglanti.Close();
            Vtctxt.Clear();
            Vaditxt.Clear();
            Vsoyaditxt.Clear();
            Visadresitxt.Clear();
            Vevadresitxt.Clear();
            Vmailtxt.Clear();
            Vteltxt.Clear();
            Votctxt.Clear();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from Velikayit where Vtc=@Vtc";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("Vtc", Vtctxt.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            baglanti.Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Velikayit set Vadi='" + Vaditxt.Text + "', Vsoyadi='" + Vsoyaditxt.Text + "', Visadresi='" + Visadresitxt.Text + "',Vevadresi='" + Vevadresitxt.Text + "', Vmail='" + Vmailtxt.Text + "',Vtel='" + Vteltxt.Text + "',Votct='" + Votctxt.Text + "' where Vtc='" + Vtctxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("select * from Velikayit");
            baglanti.Close();
        }
    }
}
