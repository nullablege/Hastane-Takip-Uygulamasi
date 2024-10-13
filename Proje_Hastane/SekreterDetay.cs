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
    public partial class SekreterDetay : Form
    {
        public SekreterDetay()
        {
            InitializeComponent();
        }
        public string sekretertc;
        sqlbaglanti bgl = new sqlbaglanti();
        private void SekreterDetay_Load(object sender, EventArgs e)
        {
            tc.Text = sekretertc;
            //ad soyad
            SqlCommand komut = new SqlCommand("select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", sekretertc);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                adsoyad.Text = dr[0].ToString();
            }
            else
            {
                MessageBox.Show("Bir hatayla karşılaşıldı", "hata");
            }
            bgl.baglanti().Close();
            //Branşlar : 
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglanti().Close();
            //Doktorlar : 
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            bgl.baglanti().Close();
            //bransları combobx a koyma : 
            SqlCommand komut3 = new SqlCommand("select * from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                randevubrans.Items.Add(dr3[1].ToString());
            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@r1,@r2,@r3,@r4)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@r1", randevutarih.Text);
            komut2.Parameters.AddWithValue("@r2", randevusaat.Text);
            komut2.Parameters.AddWithValue("@r3", randevubrans.Text);
            komut2.Parameters.AddWithValue("@r4", randevudoktor.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu ! ");
        }

        private void randevubrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            randevudoktor.Items.Clear();
            SqlCommand komut4 = new SqlCommand("select * from Tbl_Doktorlar where DoktorBrans = @e1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@e1",randevubrans.SelectedItem);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                randevudoktor.Items.Add(dr4[1] + " " + dr4[2]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut5 = new SqlCommand("insert into Tbl_Duyurular(Duyuru) values(@p1)", bgl.baglanti());
            komut5.Parameters.AddWithValue("@p1",richTextBox1.Text);
            komut5.ExecuteNonQuery();
            MessageBox.Show("Duyuru başarıyla eklendi");
            richTextBox1.Text = "";
            bgl.baglanti().Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DoktorPaneli fr = new DoktorPaneli();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Brans fr = new Brans();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RandevuListesi fr = new RandevuListesi();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Duyurular fr = new Duyurular();
            fr.Show();
        }
    }
}
