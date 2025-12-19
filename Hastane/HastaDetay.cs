using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Hastane
{
    public partial class HastaDetay : Form
    {
        public HastaDetay()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public string tc;

        private void HastaDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;

            // Ad ve Soyad çekme
            SqlCommand komut = new SqlCommand("Select HastaAd , HastaSoyad from Table_Hasta where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];

            }
            bgl.baglanti().Close();

            // Randevu Listesi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Randevular where HastaTc =" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Branş Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Table_Brans ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyad From Table_Doktor where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Randevular  where RandevuBrans = '" + cmbBrans.Text + "'" + " and RandevuDoktor = '" + cmbDoktor.Text + "' and RandevuDurum = 0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Enabled = false; // Form1'i devre dışı bırak
            HastaDüzenle fr = new HastaDüzenle();
            fr.FormClosed += (s, args) => this.Enabled = true; // Form2 kapanınca tekrar etkinleştir
            fr.tcno = lblTc.Text;
            fr.Show();

            
           

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtİd.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtİd.Text))
            {
                MessageBox.Show("Randevu Seçin");
            }
            else
            {
                SqlCommand komut = new SqlCommand("Update Table_Randevular set RandevuDurum=1, HastaTC=@p1,HastaSikayet=@p2 where Randevuİd=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", lblTc.Text);
                komut.Parameters.AddWithValue("@p2", rchSikayet.Text);
                komut.Parameters.AddWithValue("@p3", txtİd.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Randevu Alınmıştır");
            }
        }

        private void HastaDetay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
