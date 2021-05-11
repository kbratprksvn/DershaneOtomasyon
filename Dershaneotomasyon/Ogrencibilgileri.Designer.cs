namespace Dershaneotomasyon
{
    partial class Ogrencibilgileri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrencibilgileri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Otctxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Obolumutxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Osoyaditxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Oaditxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Oevadresitxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Oteltxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Omailtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Osinifitxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Otc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obolumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osinifi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Omail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oevadresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ofoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnara = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 39);
            this.panel1.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 26);
            this.label9.TabIndex = 26;
            this.label9.Text = "KT DERSHANESİ";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(12, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(51, 39);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(754, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(261, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "TC NO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Otctxt
            // 
            this.Otctxt.Location = new System.Drawing.Point(342, 59);
            this.Otctxt.MaxLength = 11;
            this.Otctxt.Name = "Otctxt";
            this.Otctxt.Size = new System.Drawing.Size(150, 20);
            this.Otctxt.TabIndex = 43;
            this.Otctxt.TextChanged += new System.EventHandler(this.Otctxt_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(418, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 36);
            this.button1.TabIndex = 61;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.DarkGray;
            this.btnguncelle.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnguncelle.FlatAppearance.BorderSize = 3;
            this.btnguncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnguncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ForeColor = System.Drawing.Color.Black;
            this.btnguncelle.Location = new System.Drawing.Point(237, 97);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(152, 36);
            this.btnguncelle.TabIndex = 60;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.kayitolbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(117, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 69;
            this.label1.Text = "BÖLÜMÜ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Obolumutxt
            // 
            this.Obolumutxt.Location = new System.Drawing.Point(220, 244);
            this.Obolumutxt.Name = "Obolumutxt";
            this.Obolumutxt.Size = new System.Drawing.Size(150, 20);
            this.Obolumutxt.TabIndex = 68;
            this.Obolumutxt.TextChanged += new System.EventHandler(this.Obolumutxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(117, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 67;
            this.label4.Text = "SOYADI:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Osoyaditxt
            // 
            this.Osoyaditxt.Location = new System.Drawing.Point(220, 206);
            this.Osoyaditxt.Name = "Osoyaditxt";
            this.Osoyaditxt.Size = new System.Drawing.Size(150, 20);
            this.Osoyaditxt.TabIndex = 66;
            this.Osoyaditxt.TextChanged += new System.EventHandler(this.Osoyaditxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(117, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 65;
            this.label3.Text = "ADI:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Oaditxt
            // 
            this.Oaditxt.Location = new System.Drawing.Point(220, 171);
            this.Oaditxt.Name = "Oaditxt";
            this.Oaditxt.Size = new System.Drawing.Size(150, 20);
            this.Oaditxt.TabIndex = 64;
            this.Oaditxt.TextChanged += new System.EventHandler(this.Oaditxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(421, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 77;
            this.label6.Text = "EV ADRESİ:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Oevadresitxt
            // 
            this.Oevadresitxt.Location = new System.Drawing.Point(524, 265);
            this.Oevadresitxt.Name = "Oevadresitxt";
            this.Oevadresitxt.Size = new System.Drawing.Size(150, 20);
            this.Oevadresitxt.TabIndex = 76;
            this.Oevadresitxt.TextChanged += new System.EventHandler(this.Oevadresitxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(421, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 75;
            this.label7.Text = "TEL:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Oteltxt
            // 
            this.Oteltxt.Location = new System.Drawing.Point(524, 227);
            this.Oteltxt.Name = "Oteltxt";
            this.Oteltxt.Size = new System.Drawing.Size(150, 20);
            this.Oteltxt.TabIndex = 74;
            this.Oteltxt.TextChanged += new System.EventHandler(this.Oteltxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(421, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 73;
            this.label8.Text = "MAİL:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Omailtxt
            // 
            this.Omailtxt.Location = new System.Drawing.Point(524, 190);
            this.Omailtxt.Name = "Omailtxt";
            this.Omailtxt.Size = new System.Drawing.Size(150, 20);
            this.Omailtxt.TabIndex = 72;
            this.Omailtxt.TextChanged += new System.EventHandler(this.Omailtxt_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(421, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 71;
            this.label10.Text = "SINIFI:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Osinifitxt
            // 
            this.Osinifitxt.Location = new System.Drawing.Point(524, 155);
            this.Osinifitxt.MaxLength = 11;
            this.Osinifitxt.Name = "Osinifitxt";
            this.Osinifitxt.Size = new System.Drawing.Size(150, 20);
            this.Osinifitxt.TabIndex = 70;
            this.Osinifitxt.TextChanged += new System.EventHandler(this.Osinifitxt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(649, 479);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 17);
            this.label11.TabIndex = 78;
            this.label11.Text = " ANASAYFAYA DÖN";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Otc,
            this.Oadi,
            this.Osoyadi,
            this.Obolumu,
            this.Osinifi,
            this.Omail,
            this.Otel,
            this.Oevadresi,
            this.Ofoto});
            this.dataGridView1.Location = new System.Drawing.Point(29, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 178);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Otc
            // 
            this.Otc.DataPropertyName = "Otc";
            this.Otc.HeaderText = "Öğrenci Tc";
            this.Otc.Name = "Otc";
            // 
            // Oadi
            // 
            this.Oadi.DataPropertyName = "Oadi";
            this.Oadi.HeaderText = "Adı";
            this.Oadi.Name = "Oadi";
            // 
            // Osoyadi
            // 
            this.Osoyadi.DataPropertyName = "Osoyadi";
            this.Osoyadi.HeaderText = "Soyadı";
            this.Osoyadi.Name = "Osoyadi";
            // 
            // Obolumu
            // 
            this.Obolumu.DataPropertyName = "Obolumu";
            this.Obolumu.HeaderText = "Bölümü";
            this.Obolumu.Name = "Obolumu";
            // 
            // Osinifi
            // 
            this.Osinifi.DataPropertyName = "Osinifi";
            this.Osinifi.HeaderText = "Sınıfı";
            this.Osinifi.Name = "Osinifi";
            // 
            // Omail
            // 
            this.Omail.DataPropertyName = "Omail";
            this.Omail.HeaderText = "Mail";
            this.Omail.Name = "Omail";
            // 
            // Otel
            // 
            this.Otel.DataPropertyName = "Otel";
            this.Otel.HeaderText = "Telefon Numarası";
            this.Otel.Name = "Otel";
            // 
            // Oevadresi
            // 
            this.Oevadresi.DataPropertyName = "Oevadresi";
            this.Oevadresi.HeaderText = "Ev Adresi";
            this.Oevadresi.Name = "Oevadresi";
            // 
            // Ofoto
            // 
            this.Ofoto.DataPropertyName = "Ofoto";
            this.Ofoto.HeaderText = "FotografKlasörü";
            this.Ofoto.Name = "Ofoto";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkGray;
            this.btnara.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnara.FlatAppearance.BorderSize = 3;
            this.btnara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnara.ForeColor = System.Drawing.Color.Black;
            this.btnara.Location = new System.Drawing.Point(498, 50);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(56, 41);
            this.btnara.TabIndex = 80;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Ogrencibilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(808, 505);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Oevadresitxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Oteltxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Omailtxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Osinifitxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Obolumutxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Osoyaditxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Oaditxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Otctxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ogrencibilgileri";
            this.Text = "Ogrencibilgileri";
            this.Load += new System.EventHandler(this.Ogrencibilgileri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Otctxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Obolumutxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Osoyaditxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Oaditxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Oevadresitxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Oteltxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Omailtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Osinifitxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obolumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osinifi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Omail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oevadresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ofoto;
    }
}