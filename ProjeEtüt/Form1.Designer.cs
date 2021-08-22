namespace ProjeEtüt
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEtutOlustur = new System.Windows.Forms.Button();
            this.maskSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbOgretmenListe = new System.Windows.Forms.ComboBox();
            this.cmbDersListe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEtutID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOgrenciID = new System.Windows.Forms.TextBox();
            this.btnEtutVer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFotograf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.txtOgrMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOgrSinif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.btnOgretmenEkle = new System.Windows.Forms.Button();
            this.txtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOgretmenAd = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEtutGuncelle = new System.Windows.Forms.Button();
            this.lblEtutDurum = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtEtutIDGuncelle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnEtutOlustur);
            this.groupBox1.Controls.Add(this.maskSaat);
            this.groupBox1.Controls.Add(this.maskTarih);
            this.groupBox1.Controls.Add(this.cmbOgretmenListe);
            this.groupBox1.Controls.Add(this.cmbDersListe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnEtutOlustur
            // 
            this.btnEtutOlustur.Location = new System.Drawing.Point(119, 181);
            this.btnEtutOlustur.Name = "btnEtutOlustur";
            this.btnEtutOlustur.Size = new System.Drawing.Size(211, 29);
            this.btnEtutOlustur.TabIndex = 11;
            this.btnEtutOlustur.Text = "Etüt Oluştur";
            this.btnEtutOlustur.UseVisualStyleBackColor = true;
            this.btnEtutOlustur.Click += new System.EventHandler(this.btnEtutOlustur_Click);
            // 
            // maskSaat
            // 
            this.maskSaat.Location = new System.Drawing.Point(120, 141);
            this.maskSaat.Mask = "00:00";
            this.maskSaat.Name = "maskSaat";
            this.maskSaat.Size = new System.Drawing.Size(210, 30);
            this.maskSaat.TabIndex = 7;
            this.maskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskTarih
            // 
            this.maskTarih.Location = new System.Drawing.Point(120, 104);
            this.maskTarih.Mask = "00/00/0000";
            this.maskTarih.Name = "maskTarih";
            this.maskTarih.Size = new System.Drawing.Size(210, 30);
            this.maskTarih.TabIndex = 6;
            this.maskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbOgretmenListe
            // 
            this.cmbOgretmenListe.FormattingEnabled = true;
            this.cmbOgretmenListe.Location = new System.Drawing.Point(119, 66);
            this.cmbOgretmenListe.Name = "cmbOgretmenListe";
            this.cmbOgretmenListe.Size = new System.Drawing.Size(211, 31);
            this.cmbOgretmenListe.TabIndex = 5;
            // 
            // cmbDersListe
            // 
            this.cmbDersListe.FormattingEnabled = true;
            this.cmbDersListe.Location = new System.Drawing.Point(120, 29);
            this.cmbDersListe.Name = "cmbDersListe";
            this.cmbDersListe.Size = new System.Drawing.Size(211, 31);
            this.cmbDersListe.TabIndex = 4;
            this.cmbDersListe.SelectedIndexChanged += new System.EventHandler(this.cmbDersListe_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğretmen :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1379, 325);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1373, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.txtEtutID);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtOgrenciID);
            this.groupBox3.Controls.Add(this.btnEtutVer);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(365, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 134);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // txtEtutID
            // 
            this.txtEtutID.Enabled = false;
            this.txtEtutID.Location = new System.Drawing.Point(90, 29);
            this.txtEtutID.Name = "txtEtutID";
            this.txtEtutID.Size = new System.Drawing.Size(180, 30);
            this.txtEtutID.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Etüt ID :";
            // 
            // txtOgrenciID
            // 
            this.txtOgrenciID.Location = new System.Drawing.Point(90, 65);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new System.Drawing.Size(180, 30);
            this.txtOgrenciID.TabIndex = 12;
            // 
            // btnEtutVer
            // 
            this.btnEtutVer.Location = new System.Drawing.Point(90, 101);
            this.btnEtutVer.Name = "btnEtutVer";
            this.btnEtutVer.Size = new System.Drawing.Size(180, 29);
            this.btnEtutVer.TabIndex = 9;
            this.btnEtutVer.Text = "Etüt Ver";
            this.btnEtutVer.UseVisualStyleBackColor = true;
            this.btnEtutVer.Click += new System.EventHandler(this.btnEtutVer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Öğrenci :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.btnDersEkle);
            this.groupBox4.Controls.Add(this.txtDersAd);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(365, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 141);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ders Ekle";
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(98, 66);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(170, 29);
            this.btnDersEkle.TabIndex = 18;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(98, 30);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(170, 30);
            this.txtDersAd.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 23);
            this.label13.TabIndex = 23;
            this.label13.Text = "Ders Adı :";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox5.Controls.Add(this.btnFotograf);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.maskOgrTelefon);
            this.groupBox5.Controls.Add(this.btnOgrenciEkle);
            this.groupBox5.Controls.Add(this.txtOgrMail);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtOgrSinif);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtOgrSoyad);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtOgrAd);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(647, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(463, 281);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Öğrenci Ekle";
            // 
            // btnFotograf
            // 
            this.btnFotograf.Location = new System.Drawing.Point(275, 199);
            this.btnFotograf.Name = "btnFotograf";
            this.btnFotograf.Size = new System.Drawing.Size(180, 29);
            this.btnFotograf.TabIndex = 24;
            this.btnFotograf.Text = "Fotoğraf Yükle";
            this.btnFotograf.UseVisualStyleBackColor = true;
            this.btnFotograf.Click += new System.EventHandler(this.btnFotograf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(275, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // maskOgrTelefon
            // 
            this.maskOgrTelefon.Location = new System.Drawing.Point(90, 130);
            this.maskOgrTelefon.Mask = "(999) 000-0000";
            this.maskOgrTelefon.Name = "maskOgrTelefon";
            this.maskOgrTelefon.Size = new System.Drawing.Size(180, 30);
            this.maskOgrTelefon.TabIndex = 12;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(90, 199);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(180, 29);
            this.btnOgrenciEkle.TabIndex = 15;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // txtOgrMail
            // 
            this.txtOgrMail.Location = new System.Drawing.Point(90, 163);
            this.txtOgrMail.Name = "txtOgrMail";
            this.txtOgrMail.Size = new System.Drawing.Size(180, 30);
            this.txtOgrMail.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Mail :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Telefon :";
            // 
            // txtOgrSinif
            // 
            this.txtOgrSinif.Location = new System.Drawing.Point(90, 96);
            this.txtOgrSinif.Name = "txtOgrSinif";
            this.txtOgrSinif.Size = new System.Drawing.Size(180, 30);
            this.txtOgrSinif.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sınıf :";
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(90, 63);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(180, 30);
            this.txtOgrSoyad.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Soyad :";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(90, 30);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(180, 30);
            this.txtOgrAd.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ad :";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.cmbBrans);
            this.groupBox6.Controls.Add(this.btnOgretmenEkle);
            this.groupBox6.Controls.Add(this.txtOgretmenSoyad);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.txtOgretmenAd);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Location = new System.Drawing.Point(1116, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(276, 160);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Öğretmen Ekle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 23);
            this.label12.TabIndex = 17;
            this.label12.Text = "Branş :";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(90, 91);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(180, 31);
            this.cmbBrans.TabIndex = 12;
            // 
            // btnOgretmenEkle
            // 
            this.btnOgretmenEkle.Location = new System.Drawing.Point(90, 126);
            this.btnOgretmenEkle.Name = "btnOgretmenEkle";
            this.btnOgretmenEkle.Size = new System.Drawing.Size(180, 29);
            this.btnOgretmenEkle.TabIndex = 15;
            this.btnOgretmenEkle.Text = "Öğretmen Ekle";
            this.btnOgretmenEkle.UseVisualStyleBackColor = true;
            this.btnOgretmenEkle.Click += new System.EventHandler(this.btnOgretmenEkle_Click);
            // 
            // txtOgretmenSoyad
            // 
            this.txtOgretmenSoyad.Location = new System.Drawing.Point(90, 58);
            this.txtOgretmenSoyad.Name = "txtOgretmenSoyad";
            this.txtOgretmenSoyad.Size = new System.Drawing.Size(180, 30);
            this.txtOgretmenSoyad.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 23);
            this.label15.TabIndex = 15;
            this.label15.Text = "Soyad :";
            // 
            // txtOgretmenAd
            // 
            this.txtOgretmenAd.Location = new System.Drawing.Point(90, 25);
            this.txtOgretmenAd.Name = "txtOgretmenAd";
            this.txtOgretmenAd.Size = new System.Drawing.Size(180, 30);
            this.txtOgretmenAd.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 23);
            this.label16.TabIndex = 13;
            this.label16.Text = "Ad :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEtutGuncelle
            // 
            this.btnEtutGuncelle.Location = new System.Drawing.Point(35, 82);
            this.btnEtutGuncelle.Name = "btnEtutGuncelle";
            this.btnEtutGuncelle.Size = new System.Drawing.Size(211, 29);
            this.btnEtutGuncelle.TabIndex = 27;
            this.btnEtutGuncelle.Text = "Etüt Güncelle";
            this.btnEtutGuncelle.UseVisualStyleBackColor = true;
            this.btnEtutGuncelle.Click += new System.EventHandler(this.btnEtutGuncelle_Click);
            // 
            // lblEtutDurum
            // 
            this.lblEtutDurum.AutoSize = true;
            this.lblEtutDurum.Location = new System.Drawing.Point(116, 56);
            this.lblEtutDurum.Name = "lblEtutDurum";
            this.lblEtutDurum.Size = new System.Drawing.Size(41, 23);
            this.lblEtutDurum.TabIndex = 24;
            this.lblEtutDurum.Text = "Null";
            this.lblEtutDurum.Visible = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtEtutIDGuncelle);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.radioButton2);
            this.groupBox7.Controls.Add(this.radioButton1);
            this.groupBox7.Controls.Add(this.btnEtutGuncelle);
            this.groupBox7.Controls.Add(this.lblEtutDurum);
            this.groupBox7.Location = new System.Drawing.Point(1116, 174);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(276, 120);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Etüt Güncelle";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(184, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 27);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "BOŞ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 56);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 27);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DOLU";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtEtutIDGuncelle
            // 
            this.txtEtutIDGuncelle.Enabled = false;
            this.txtEtutIDGuncelle.Location = new System.Drawing.Point(90, 23);
            this.txtEtutIDGuncelle.Name = "txtEtutIDGuncelle";
            this.txtEtutIDGuncelle.Size = new System.Drawing.Size(180, 30);
            this.txtEtutIDGuncelle.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 23);
            this.label14.TabIndex = 15;
            this.label14.Text = "Etüt ID :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1406, 629);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEtutOlustur;
        private System.Windows.Forms.MaskedTextBox maskSaat;
        private System.Windows.Forms.MaskedTextBox maskTarih;
        private System.Windows.Forms.ComboBox cmbOgretmenListe;
        private System.Windows.Forms.ComboBox cmbDersListe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEtutVer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOgrenciID;
        private System.Windows.Forms.TextBox txtEtutID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox maskOgrTelefon;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.TextBox txtOgrMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOgrSinif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnOgretmenEkle;
        private System.Windows.Forms.TextBox txtOgretmenSoyad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOgretmenAd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnFotograf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEtutGuncelle;
        private System.Windows.Forms.Label lblEtutDurum;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtEtutIDGuncelle;
        private System.Windows.Forms.Label label14;
    }
}

