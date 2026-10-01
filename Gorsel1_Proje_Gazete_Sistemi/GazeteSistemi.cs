using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel1_Proje_Gazete_Sistemi
{
    public partial class GazeteSistemi : Form
    {
        public GazeteSistemi()
        {
            InitializeComponent();
        }

        private void GazeteSistemi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
         
        private void tsbtn_Haber_Click(object sender, EventArgs e)
        {
            HaberIslemleri haber_frm = new HaberIslemleri();
            haber_frm.MdiParent = this;
            haber_frm.Show();
        }

        private void tsbtn_Personel_Click(object sender, EventArgs e)
        {
            PersonelIslemleri personel_frm = new PersonelIslemleri();
            personel_frm.MdiParent = this;
            personel_frm.Show();
        }

        private void tsbtn_Abone_Click(object sender, EventArgs e)
        {
            AboneIslemleri abone_frm = new AboneIslemleri();
            abone_frm.MdiParent = this;
            abone_frm.Show();
        }

        private void tsbtn_Yorum_Click(object sender, EventArgs e)
        {
            YorumIslemleri yorum_frm = new YorumIslemleri();
            yorum_frm.MdiParent = this;
            yorum_frm.Show();
        }

        private void tsbtn_GazeteSayisi_Click(object sender, EventArgs e)
        {
            GazeteSayisiIslemleri gazeteSayisi_frm = new GazeteSayisiIslemleri();
            gazeteSayisi_frm.MdiParent = this;
            gazeteSayisi_frm.Show();
        }

        private void tsbtn_Personel1_Click(object sender, EventArgs e)
        {
            PersonelIslemleri personel1_frm = new PersonelIslemleri();
            personel1_frm.MdiParent = this;
            personel1_frm.Show();

        }
    }
}
