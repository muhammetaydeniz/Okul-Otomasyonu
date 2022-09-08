using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonu
{
    public partial class ogrencisayfasi : Form
    {
        public ogrencisayfasi()
        {
            InitializeComponent();
        }

        private void notListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciNotlar fr = new FrmOgrenciNotlar();
            
            fr.Show();
        }

        private void ogrencisayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
