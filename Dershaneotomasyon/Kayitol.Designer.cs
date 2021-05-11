namespace Dershaneotomasyon
{
    partial class Kayitol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayitol));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kaditxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.giristc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kmailtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ksoyaditxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kdogumyeritxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kgorevitxt = new System.Windows.Forms.TextBox();
            this.kayitolbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.girissifre = new System.Windows.Forms.TextBox();
            this.sifremiunuttumlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 39);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(754, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(49, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "ADI:";
            // 
            // kaditxt
            // 
            this.kaditxt.Location = new System.Drawing.Point(152, 130);
            this.kaditxt.Name = "kaditxt";
            this.kaditxt.Size = new System.Drawing.Size(150, 20);
            this.kaditxt.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "TC NO:";
            // 
            // giristc
            // 
            this.giristc.Location = new System.Drawing.Point(152, 75);
            this.giristc.MaxLength = 11;
            this.giristc.Name = "giristc";
            this.giristc.Size = new System.Drawing.Size(150, 20);
            this.giristc.TabIndex = 32;
            this.giristc.TextChanged += new System.EventHandler(this.giristc_TextChanged);
            this.giristc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.giristc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "MAİL:";
            // 
            // kmailtxt
            // 
            this.kmailtxt.Location = new System.Drawing.Point(152, 236);
            this.kmailtxt.Name = "kmailtxt";
            this.kmailtxt.Size = new System.Drawing.Size(150, 20);
            this.kmailtxt.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(49, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "SOYADI:";
            // 
            // ksoyaditxt
            // 
            this.ksoyaditxt.Location = new System.Drawing.Point(152, 181);
            this.ksoyaditxt.Name = "ksoyaditxt";
            this.ksoyaditxt.Size = new System.Drawing.Size(150, 20);
            this.ksoyaditxt.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(421, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "DOĞUM YERİ:";
            // 
            // kdogumyeritxt
            // 
            this.kdogumyeritxt.Location = new System.Drawing.Point(545, 130);
            this.kdogumyeritxt.Name = "kdogumyeritxt";
            this.kdogumyeritxt.Size = new System.Drawing.Size(150, 20);
            this.kdogumyeritxt.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(407, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "DOĞUM TARİHİ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(442, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "GÖREVİ:";
            // 
            // kgorevitxt
            // 
            this.kgorevitxt.Location = new System.Drawing.Point(545, 183);
            this.kgorevitxt.Name = "kgorevitxt";
            this.kgorevitxt.Size = new System.Drawing.Size(150, 20);
            this.kgorevitxt.TabIndex = 45;
            // 
            // kayitolbtn
            // 
            this.kayitolbtn.BackColor = System.Drawing.Color.DarkGray;
            this.kayitolbtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.kayitolbtn.FlatAppearance.BorderSize = 3;
            this.kayitolbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.kayitolbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitolbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitolbtn.ForeColor = System.Drawing.Color.Black;
            this.kayitolbtn.Location = new System.Drawing.Point(250, 305);
            this.kayitolbtn.Name = "kayitolbtn";
            this.kayitolbtn.Size = new System.Drawing.Size(99, 57);
            this.kayitolbtn.TabIndex = 47;
            this.kayitolbtn.Text = "KAYIT OL";
            this.kayitolbtn.UseVisualStyleBackColor = false;
            this.kayitolbtn.Click += new System.EventHandler(this.kayitolbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(411, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 57);
            this.button1.TabIndex = 48;
            this.button1.Text = "TEMİZLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(545, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(442, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "ŞİFRE:";
            // 
            // girissifre
            // 
            this.girissifre.Location = new System.Drawing.Point(545, 234);
            this.girissifre.Name = "girissifre";
            this.girissifre.Size = new System.Drawing.Size(150, 20);
            this.girissifre.TabIndex = 50;
            // 
            // sifremiunuttumlbl
            // 
            this.sifremiunuttumlbl.AutoSize = true;
            this.sifremiunuttumlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifremiunuttumlbl.ForeColor = System.Drawing.Color.Black;
            this.sifremiunuttumlbl.Location = new System.Drawing.Point(692, 472);
            this.sifremiunuttumlbl.Name = "sifremiunuttumlbl";
            this.sifremiunuttumlbl.Size = new System.Drawing.Size(91, 19);
            this.sifremiunuttumlbl.TabIndex = 52;
            this.sifremiunuttumlbl.Text = "GİRİŞ YAP!";
            this.sifremiunuttumlbl.Click += new System.EventHandler(this.sifremiunuttumlbl_Click);
            // 
            // Kayitol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(808, 500);
            this.Controls.Add(this.sifremiunuttumlbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.girissifre);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kayitolbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kgorevitxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kdogumyeritxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kmailtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ksoyaditxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kaditxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.giristc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kayitol";
            this.Text = "Kayitol";
            this.Load += new System.EventHandler(this.Kayitol_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kaditxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox giristc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kmailtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ksoyaditxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kdogumyeritxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kgorevitxt;
        private System.Windows.Forms.Button kayitolbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox girissifre;
        private System.Windows.Forms.Label sifremiunuttumlbl;
    }
}