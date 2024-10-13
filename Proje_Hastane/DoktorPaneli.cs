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
    public partial class DoktorPaneli : Form
    {
        public DoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void DoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            bgl.baglanti().Close();
            //bransları combobx a koyma : 
            SqlCommand komut3 = new SqlCommand("select * from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                brans.Items.Add(dr3[1].ToString());
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar(DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values(@p1,@p2,@p3,@p4,@p5); ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",ad.Text);
            komut.Parameters.AddWithValue("@p2",soyad.Text);
            komut.Parameters.AddWithValue("@p3", brans.Text);
            komut.Parameters.AddWithValue("@p4", tc.Text);
            komut.Parameters.AddWithValue("@p5", sifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ekleme İşlemi Başarılı.");
            this.Hide();
            DoktorPaneli fr = new DoktorPaneli();
            fr.Show();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("delete from Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", tc.Text);
            komut4.ExecuteNonQuery();
            this.Hide();
            DoktorPaneli fr = new DoktorPaneli();
            MessageBox.Show("Silme İşlemi Başarılı");
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut5 = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTC=@p4", bgl.baglanti());
            komut5.Parameters.AddWithValue("@p1", ad.Text);
            komut5.Parameters.AddWithValue("@p2", soyad.Text);
            komut5.Parameters.AddWithValue("@p3", brans.Text);
            komut5.Parameters.AddWithValue("@p4", tc.Text);
            komut5.Parameters.AddWithValue("@p5", sifre.Text);
            komut5.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ekleme İşlemi Başarılı.");
            this.Hide();
            DoktorPaneli fr = new DoktorPaneli();
            fr.Show();
        }
    }
}
