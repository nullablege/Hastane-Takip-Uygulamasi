using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proje_Hastane
{
    public partial class Brans : Form
    {
        public Brans()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void Brans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            //MessageBox.Show(secilen.ToString());
            bransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            bransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Branslar(BransAd) values(@p1)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",bransad.Text);
            komut1.ExecuteNonQuery();
            MessageBox.Show("Ekleme işlemi başarılı.");
            Brans fr = new Brans();
            this.Hide();
            fr.Show();
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("delete from Tbl_Branslar where Bransid=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",bransid.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Silme işlemi başarılı.");
            Brans fr = new Brans();
            this.Hide();
            fr.Show();
            bgl.baglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update Tbl_Branslar set BransAd=@p1 where Bransid=@p2 ", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", bransad.Text);
            komut3.Parameters.AddWithValue("@p2", bransid.Text);
            komut3.ExecuteNonQuery();
            MessageBox.Show("Güncelleme işlemi başarılı.");
            Brans fr = new Brans();
            this.Hide();
            fr.Show();
            bgl.baglanti().Close();
        }
    }
}
