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
using System.IO;

namespace ProjeEtüt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9BQMHRG\SQLEXPRESS;Initial Catalog=DbEtutProje;Integrated Security=True");
        
        void DersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLDERSLER", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDersListe.ValueMember = "DERSID";
            cmbDersListe.DisplayMember = "DERS";
            cmbDersListe.DataSource = dt;
            cmbBrans.ValueMember = "DERSID";
            cmbBrans.DisplayMember = "DERS";
            cmbBrans.DataSource = dt;
        }

        void OgretmenListesi()
        {
            //SqlDataAdapter da = new SqlDataAdapter("Select * from TBLOGRETMEN where BRANSID = "+cmbDersListe.SelectedValue, con);

            //Combobox' un DisplayMember' ine sadece bir parametre ekleyebildiğimiz için aşağıdaki SQL kodunda AD ve SOYAD' ı birleştiren kodu yazdık.

            SqlDataAdapter da = new SqlDataAdapter("Select OGRTID, (AD + ' ' + SOYAD) as 'OGRETMEN' from TBLOGRETMEN where BRANSID = " + cmbDersListe.SelectedValue,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbOgretmenListe.ValueMember = "OGRTID";
            cmbOgretmenListe.DisplayMember = "OGRETMEN";
            cmbOgretmenListe.DataSource = dt;
        }

        void EtutListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select ID, DERS, (TBLOGRETMEN.AD + ' ' + TBLOGRETMEN.SOYAD) as 'OGRETMEN', TARIH, SAAT, DURUM from TBLETUT inner join TBLDERSLER on TBLETUT.DERSID = TBLDERSLER.DERSID inner join TBLOGRETMEN on TBLETUT.OGRETMENID = TBLOGRETMEN.OGRTID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DersListesi();
            EtutListesi();
            DatagridRenklendir();
            cmbBrans.Text = "";
            cmbDersListe.Text = "";
            cmbOgretmenListe.Text = "";
        }

        private void cmbDersListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            OgretmenListesi();
        }

        private void btnEtutOlustur_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into TBLETUT (DERSID, OGRETMENID, TARIH, SAAT) values (@p1, @p2, @p3, @p4)",con);
            cmd.Parameters.AddWithValue("@p1", cmbDersListe.SelectedValue);
            cmd.Parameters.AddWithValue("@p2", cmbOgretmenListe.SelectedValue);
            cmd.Parameters.AddWithValue("@p3", maskTarih.Text);
            cmd.Parameters.AddWithValue("@p4", maskSaat.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Belirlenen tarih ve saate ait etüt eklendi.");
            EtutListesi();
        }

        private void btnEtutVer_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update TBLETUT set OGRENCIID = @p1, DURUM = @p2 where ID = @p3",con);
            cmd.Parameters.AddWithValue("@p1", txtOgrenciID.Text);
            cmd.Parameters.AddWithValue("@p2", "True");
            cmd.Parameters.AddWithValue("@p3", txtEtutID.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Etüt öğrenciye verildi.");
            txtEtutID.Clear();
            txtOgrenciID.Clear();
            EtutListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtEtutID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtEtutIDGuncelle.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            if (bool.Parse(dataGridView1.Rows[secilen].Cells[5].Value.ToString())==true)
            {
                lblEtutDurum.Text = "True";
            }
            else
            {
                lblEtutDurum.Text = "False";
            }
            tikle();
        }

        void tikle()
        {
            if (lblEtutDurum.Text=="True")
            {
                radioButton1.Checked = true;
            }
            else //False
            {
                radioButton2.Checked = true;
            }
        }

        private void btnFotograf_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into TBLOGRENCI (AD, SOYAD, FOTOGRAF, SINIF, TELEFON, MAIL) values (@p1, @p2, @p3, @p4, @p5, @p6)",con);
            cmd.Parameters.AddWithValue("@p1", txtOgrAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            cmd.Parameters.AddWithValue("@p4", txtOgrSinif.Text);
            cmd.Parameters.AddWithValue("@p5", maskOgrTelefon.Text);
            cmd.Parameters.AddWithValue("@p6", txtOgrMail.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Öğrenci sisteme eklendi");
            Temizle();
        }

        void Temizle()
        {
            //Öğrenci
            txtOgrAd.Clear();
            txtOgrSoyad.Clear();
            pictureBox1.Image = null;
            txtOgrSinif.Clear();
            maskOgrTelefon.Clear();
            txtOgrMail.Clear();

            //Öğretmen
            txtOgretmenAd.Clear();
            txtOgretmenSoyad.Clear();
            cmbBrans.Text = "";

            //Ders
            txtDersAd.Clear();
        }

        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into TBLOGRETMEN (AD, SOYAD, BRANSID) values (@p1, @p2, @p3)", con);
            cmd.Parameters.AddWithValue("@p1", txtOgretmenAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtOgretmenSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmbBrans.SelectedValue);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Öğretmen sisteme eklendi");
            Temizle();
        }

        private void btnEtutGuncelle_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true) //radioButton2.Checked=false
            {
                lblEtutDurum.Text = "True";
                EtutGuncelle();
            }
            else //radioButton2.Checked==true (radioButton1.Checked=false)
            {
                lblEtutDurum.Text = "False";
                EtutGuncelle();
            }
        }

        void EtutGuncelle()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update TBLETUT set DURUM = @p1 where ID = @p2", con);
            cmd.Parameters.AddWithValue("@p1", lblEtutDurum.Text);
            cmd.Parameters.AddWithValue("@p2", txtEtutIDGuncelle.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(txtEtutIDGuncelle.Text + " numaralı ID' ye ait ETÜT '" + lblEtutDurum.Text + "' olarak güncellendi.");
            EtutListesi();
        }

        bool durum;

        void MukerrerKontrol()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from TBLDERSLER where DERS = @p1",con);
            cmd.Parameters.AddWithValue("@p1",txtDersAd.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = false; //Bu kayıt zaten var
            }
            else
            {
                durum = true; //Kayıt yok, eklenebilir
            }
            con.Close();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            MukerrerKontrol();
            if (durum == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into TBLDERSLER (DERS) values (@p1)", con);
                cmd.Parameters.AddWithValue("@p1", txtDersAd.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Ders sisteme eklendi");
                Temizle();
            }
            else
            {
                MessageBox.Show(txtDersAd.Text+" isimli ders sistemde zaten var");
            }
        }

        void DatagridRenklendir()
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++) /* DataGridView'in satır sayısından 1 eksik çünkü hep son satırı boş bırakıyor*/
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[5].Value)==true) //i. satır 5. sütundaki değerler true ise
                {
                    renk.BackColor = Color.Red;
                }
                else
                {
                    renk.BackColor = Color.Green;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }
    }
}
