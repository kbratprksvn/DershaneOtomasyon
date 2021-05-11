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

using System.Net.Mail;
using System.Net;
using System.Collections;

namespace Dershaneotomasyon
{
    public partial class Odevtakip : Form
    {

        public Odevtakip()
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
            dataGridView4.DataSource = ds.Tables[0];
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

        private void Odevtakip_Load(object sender, EventArgs e)
        {

        }

        private void kayitolbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string kayit = "insert into Odevtakip(Otc,Oadi,Osoyadi,Obolumu,Osinifi,Odevaldigiders,Odevverilistarihi,Odevteslimtarihi,Vmail) values (@Otc,@Oadi,@Osoyadi,@Obolumu,@Osinifi,@Odevaldigiders,@Odevverilistarihi,@Odevteslimtarihi,@Vmail)";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@Otc", Otctxt.Text);
                komut.Parameters.AddWithValue("@Oadi", Oaditxt.Text);
                komut.Parameters.AddWithValue("@Osoyadi", Osoyaditxt.Text);
                komut.Parameters.AddWithValue("@Obolumu", Obolumutxt.Text);
                komut.Parameters.AddWithValue("@Osinifi", Osinifitxt.Text);
                komut.Parameters.AddWithValue("@Odevaldigiders", aldigiderstxt.Text);
                komut.Parameters.AddWithValue("@Odevverilistarihi", ovttxt.Value);
                komut.Parameters.AddWithValue("@Odevteslimtarihi", otttxt.Value);
                komut.Parameters.AddWithValue("@Vmail", Vmailtxt.Text);
                komut.ExecuteNonQuery();
                verilerigoster("Select * from Odevtakip");
                con.Close();
                MessageBox.Show("Ödev Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Odevtakip where Otc='" + Otctxt.Text + "'";
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
                    string kime = (dr["Vmail"].ToString());
                    string konu = ("Ödev bilgilendirme");
                    string yazi = ("Sayın Veli öğrencimiz    " + dr["Oadi"].ToString() + " " + dr["Osoyadi"].ToString() + " " + dr["Odevverilistarihi"].ToString() + "Tarihinde ödev verilmiştir");
                    smtpserver.Credentials = new NetworkCredential(mailadresin, mailsifren);
                    smtpserver.Port = 587;
                    smtpserver.Host = smptsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yazi;
                    smtpserver.Send(mail);
                    MessageBox.Show("Ödev bilgi maili gönderildi.");
                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
            con.Close();
        }

        private void ovttxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Otctxt.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            Oaditxt.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            Osoyaditxt.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            Obolumutxt.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            Osinifitxt.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            aldigiderstxt.Text = dataGridView4.CurrentRow.Cells[5].Value.ToString();
            ovttxt.Text = dataGridView4.CurrentRow.Cells[6].Value.ToString();
            otttxt.Text = dataGridView4.CurrentRow.Cells[7].Value.ToString();
            Vmailtxt.Text = dataGridView4.CurrentRow.Cells[8].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenalan = dataGridView4.SelectedCells[0].RowIndex;
            string Otc = dataGridView4.Rows[secilenalan].Cells[0].ToString();
            string Oadi = dataGridView4.Rows[secilenalan].Cells[1].ToString();
            string Osoyadi = dataGridView4.Rows[secilenalan].Cells[2].ToString();
            string Obolumu = dataGridView4.Rows[secilenalan].Cells[3].ToString();
            string Osinifi = dataGridView4.Rows[secilenalan].Cells[4].ToString();
            string Odevaldigiders = dataGridView4.Rows[secilenalan].Cells[5].ToString();
            string Odevverilistarihi = dataGridView4.Rows[secilenalan].Cells[6].ToString();
            string Odevteslimtarihi = dataGridView4.Rows[secilenalan].Cells[7].ToString();
            string Vmail = dataGridView4.Rows[secilenalan].Cells[8].ToString();
            Otctxt.Text = Otc;
            Oaditxt.Text = Oadi;
            Osoyaditxt.Text = Osoyadi;
            Obolumutxt.Text = Obolumu;
            Osinifitxt.Text = Osinifi;
            aldigiderstxt.Text = Odevaldigiders;
            ovttxt.Text = Odevverilistarihi;
            otttxt.Text = Odevteslimtarihi;
            Vmailtxt.Text = Vmail;
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * from Odevtakip");
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pdiyalog.ShowDialog();
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();

        }
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
        private void pyazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView4.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 15;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dataGridView4.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView4.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("Ödev Bilgilendirme", new Font(dataGridView4.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Ödev Bilgilendirme", new Font(dataGridView4.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(dataGridView4.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dataGridView4.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Ödev Bilgilendirme", new Font(new Font(dataGridView4.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView4.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView4.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
