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
using System.Data.Common;


namespace Proje_Hastane
{
    public partial class DoktorDetay : Form
    {
        public DoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        public string doktortc;
        private void DoktorDetay_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", doktortc);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                tc.Text = dr[4].ToString();
                adsoyad.Text = dr[1] + " " + dr[2];
            }

            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDoktor='" + dr[1] + " " + dr[2] + "'", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int secilen = dataGridView1.SelectedCells[0].RowIndex;
            //richTextBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Duyurular fr = new Duyurular();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            girisler fr = new girisler();
            fr.Show();
            MessageBox.Show("Başarıyla Çıkış Yaptınız.");
        }
    }
}
