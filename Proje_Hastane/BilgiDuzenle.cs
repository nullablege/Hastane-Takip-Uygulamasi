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

namespace Proje_Hastane
{
    public partial class BilgiDuzenle : Form
    {
        public BilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tcno;
        sqlbaglanti bgl = new sqlbaglanti();
        private void BilgiDuzenle_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = tcno;
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",tcno);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) {
                ad.Text = dr[1].ToString();
                soyad.Text = dr[2].ToString();
                maskedTextBox1.Text = dr[3].ToString();
                maskedTextBox2.Text = dr[4].ToString();
                sifre.Text = dr[5].ToString();
                comboBox1.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar Set HastaAd=@p1,HastaSoyad=@p2,HastaTC=@p3,HastaTelefon=@p4,HastaSifre=@p5,HastaCinsiyet=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", ad.Text);
            komut2.Parameters.AddWithValue("@p2", soyad.Text);
            komut2.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut2.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
            komut2.Parameters.AddWithValue("@p5", sifre.Text);
            komut2.Parameters.AddWithValue("@p6", comboBox1.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Guncelleme basarili.");
            this.Hide();
        }
    }
}
