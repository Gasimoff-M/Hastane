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
    public partial class DoktorDetay : Form
    {
        public DoktorDetay()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public string TC;

        private void DoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;

            //Ad ve Soyad Çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Table_Doktor Where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAd.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Randevular Where RandevuDoktor='" + lblAd.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false; // Form1'i devre dışı bırak
            DoktorDüzenle dd = new DoktorDüzenle();
            dd.FormClosed += (s, args) => this.Enabled = true; // Form2 kapanınca tekrar etkinleştir
            dd.TC = lblTC.Text;
            dd.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Enabled = false; // Form1'i devre dışı bırak
            Duyurular duyuru = new Duyurular();
            duyuru.FormClosed += (s, args) => this.Enabled = true; // Form2 kapanınca tekrar etkinleştir
            duyuru.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void DoktorDetay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
