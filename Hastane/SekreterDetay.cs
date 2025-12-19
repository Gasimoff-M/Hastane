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
    public partial class SekreterDetay : Form
    {
        public SekreterDetay()
        {
            InitializeComponent();
        }

        public string TCnumara;

        SqlBaglanti bgl = new SqlBaglanti();



        private void SekreterDetay_Load(object sender, EventArgs e)
        {


            label2.Text = TCnumara;

            //Ad ve Soyad Çekme
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Table_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", label2.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                label3.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();


            //Branşları DataGridView'e Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Brans", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları DataGridView'e Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans From Table_Doktor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşları ComboBox'a Aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Table_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Table_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values (@r1, @r2, @r3, @r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();


            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Table_Doktor Where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Duyuru (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Enabled = false; // Form1'i devre dışı bırak
            DoktorPaneli fr = new DoktorPaneli();
            fr.FormClosed += (s, args) => this.Enabled = true; // Form2 kapanınca tekrar etkinleştir
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Enabled = false; // Form1'i devre dışı bırak
            BransPanel bp = new BransPanel();
            bp.FormClosed += (s, args) => this.Enabled = true; // Form2 kapanınca tekrar etkinleştir
            bp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Enabled = false; // Form1'i devre dışı bırak
            RandevuListesi rl = new RandevuListesi();
            rl.FormClosed += (s, args) => this.Enabled = true; // Form2 kapanınca tekrar etkinleştir
            rl.Show();
        }

        private void SekreterDetay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Branşları DataGridView'e Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Brans", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları DataGridView'e Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans From Table_Doktor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
    }
}
