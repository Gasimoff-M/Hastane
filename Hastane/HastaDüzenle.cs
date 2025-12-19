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
    public partial class HastaDüzenle : Form
    {
        public HastaDüzenle()
        {
            InitializeComponent();
        }

        public string tcno;

        SqlBaglanti bgl = new SqlBaglanti();

        private void HastaDüzenle_Load(object sender, EventArgs e)
        {
            mskTCno.Text = tcno;
            SqlCommand komut = new SqlCommand("Select * From Table_Hasta where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTCno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTel.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                cmbCinsiyyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

     


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Table_Hasta set HastaAD=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskTel.Text);
            komut2.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbCinsiyyet.Text);
            komut2.Parameters.AddWithValue("@p6", mskTCno.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Hasta bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
        }
    }
}
