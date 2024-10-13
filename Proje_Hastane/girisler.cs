using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class girisler : Form
    {
        public girisler()
        {
            InitializeComponent();
        }

        private void btnHastaGirisi_Click(object sender, EventArgs e)
        {
            HastaGiris fr = new HastaGiris();
            fr.Show();
            this.Hide();
        }

        private void btnDoktorGirisi_Click(object sender, EventArgs e)
        {
            DoktorGiriscs fr = new DoktorGiriscs();
            fr.Show();
            this.Hide();
        }

        private void btnSekreterGirisi_Click(object sender, EventArgs e)
        {
            SekreterGiris fr = new SekreterGiris();
            fr.Show();
            this.Hide();
        }
    }
}
