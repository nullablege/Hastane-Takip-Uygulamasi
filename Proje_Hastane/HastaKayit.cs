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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje_Hastane
{
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", ad.Text);
            komut.Parameters.AddWithValue("@p2", soyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p5", sifre.Text);
            komut.Parameters.AddWithValue("@p6", comboBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşti."+sifre.Text,"Başarılı !");
        }
    }
}
