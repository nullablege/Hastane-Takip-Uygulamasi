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
    public partial class HastaDetay : Form
    {
        public HastaDetay()
        {
            InitializeComponent();
        }
        public string hastaTc;
        sqlbaglanti bgl = new sqlbaglanti();

        private void HastaDetay_Load(object sender, EventArgs e)
        {
            // Public olan TC Değişkenine göre ad soyad çekme : 
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hastaTc);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            string hastaAd = dr["HastaAd"] + " " + dr["HastaSoyad"];
            tc.Text = hastaTc;
            adsoyad.Text = hastaAd;
            bgl.baglanti().Close();
            //Randevu Geçmişi :     
            DataTable dt = new DataTable();
            using (SqlConnection conn = bgl.baglanti())  // bağlantıyı using içinde açıyoruz
            {
                // Parametreli sorgu kullanmak
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE HastaTC = @hastaTc", conn);
                da.SelectCommand.Parameters.AddWithValue("@hastaTc", Convert.ToInt64(hastaTc));
                da.Fill(dt);  // Veriyi DataTable'a doldur
            }
            dataGridView1.DataSource = dt;

            // Branşları çekme
            using (SqlConnection conn2 = bgl.baglanti())  // Yeni bir bağlantı
            {
                SqlCommand komut2 = new SqlCommand("SELECT BransAd FROM Tbl_Branslar", conn2);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    comboBox1.Items.Add(dr2[0]);  // Branş adlarını comboBox'a ekle
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string secilen = comboBox1.SelectedItem.ToString();
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", secilen);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox2.Items.Add(dr3[0]+" " + dr3[1]);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='"+comboBox1.Text+ "' and RandevuDoktor ='"+comboBox2.Text+"' and RandevuDurum='False'", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BilgiDuzenle fr = new BilgiDuzenle();
            fr.tcno = hastaTc;
            fr.Show();
        }
        public string randevuId;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            randevuId = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Randevular set RandevuDurum='True',HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hastaTc);
            komut.Parameters.AddWithValue("@p2", richTextBox1.Text);
            komut.Parameters.AddWithValue("@p3", randevuId);
            komut.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + comboBox1.Text + "' and RandevuDoktor ='" + comboBox2.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }
}
