using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel1_Proje_Gazete_Sistemi
{
    public partial class GazeteSayisiIslemleri : Form
    {
        public GazeteSayisiIslemleri()
        {
            InitializeComponent();
        }
        List<GazeteSayisi> gazeteSayilari = new List<GazeteSayisi>();
        int sonGazeteSayisiID;
        private void GazeteSayisiIslemleri_Load(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("gazeteSayisi.ss", Encoding.UTF8);
            string oku = "";

            while ((oku = sr.ReadLine()) != null)
            {
                string[] parca = oku.Split('|');
                GazeteSayisi s = new GazeteSayisi(Convert.ToInt32(parca[0]), Convert.ToInt32(parca[1]), DateTime.Parse(parca[2]), Convert.ToInt32(parca[3]), parca[4]);
                gazeteSayilari.Add(s);
                sonGazeteSayisiID = s.GazeteSayisiID;
            }
            sr.Close();
            dgv_gazeteSayisi.DataSource = gazeteSayilari;

            dgv_gazeteSayisi.DefaultCellStyle.ForeColor = Color.Black;
            dgv_gazeteSayisi.DefaultCellStyle.BackColor = Color.White;
            dgv_gazeteSayisi.RowsDefaultCellStyle.ForeColor = Color.Black;
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int sayi;
            if (int.TryParse(txt_sayiNo.Text, out sayi)==false) 
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz!");
                return;
            }
            int sayfa = int.Parse(txt_sayfaSayisi.Text);

            if (sayfa < 0 || sayfa > 100)
            {
                MessageBox.Show("Sayfa sayısı 0-100 arasında olmalıdır!");
                return;
            }
            DateTime tarih = Convert.ToDateTime(mtx_yayinTarihi.Text);
            if (tarih > DateTime.Now)
            {
                MessageBox.Show("Gelecek bir tarih yazamazsın!");
                return;
            }
            if (txt_manset.Text == "")
            {
                MessageBox.Show("Manşet boş bırakılamaz!");
            }

            foreach (var gs in gazeteSayilari)
            {
                if (gs.SayiNo == sayi) 
                {
                    MessageBox.Show(sayi + ". sayı zaten sistemde kayıtlı!");
                    return;
                }
            }
            sonGazeteSayisiID++;

            GazeteSayisi s = new GazeteSayisi(sonGazeteSayisiID,Convert.ToInt32(txt_sayiNo.Text),DateTime.Parse(mtx_yayinTarihi.Text),Convert.ToInt32(txt_sayfaSayisi.Text),txt_manset.Text);
            gazeteSayilari.Add(s);

            dgv_gazeteSayisi.DataSource = null;
            dgv_gazeteSayisi.DataSource = gazeteSayilari;
        }

        private void GazeteSayisiIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {

            StreamWriter sw = new StreamWriter("gazeteSayisi.ss", false, Encoding.UTF8);

            foreach (var gazeteS in gazeteSayilari)
            {
                sw.WriteLine(gazeteS .GazeteSayisiID+ "|" + gazeteS.SayiNo + "|" + gazeteS.YayinTarihi + "|" + gazeteS.SayfaSayisi + "|" + gazeteS.Manset );
            }
            sw.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_gazeteSayisi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek satırı seçiniz");
                return;
            }

            foreach (var  s in gazeteSayilari)
            {
                if ((int)dgv_gazeteSayisi.SelectedRows[0].Cells["GazeteSayisiID"].Value==s.GazeteSayisiID)
                {
                    gazeteSayilari.Remove(s);
                    break;
                }
            }
            dgv_gazeteSayisi.DataSource = null;
            dgv_gazeteSayisi.DataSource = gazeteSayilari;
        }

        private void dgv_gazeteSayisi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_gazeteSayisi.SelectedRows.Count == 0)
                return;
            txt_sayiNo.Text = dgv_gazeteSayisi.SelectedRows[0].Cells["SayiNo"].Value.ToString();
            mtx_yayinTarihi.Text=((DateTime)dgv_gazeteSayisi.SelectedRows[0].Cells["YayinTarihi"].Value).ToString("dd.MM.yyyy");
            txt_sayfaSayisi.Text = dgv_gazeteSayisi.SelectedRows[0].Cells["SayfaSayisi"].Value.ToString();
            txt_manset.Text = dgv_gazeteSayisi.SelectedRows[0].Cells["Manset"].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int girilenSayiNo=0;
            int sayi=0;
            if (int.TryParse(txt_sayiNo.Text, out sayi) == false)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz!");
                return;
            }
            int sayfa = int.Parse(txt_sayfaSayisi.Text);

            if (sayfa < 0 || sayfa > 100)
            {
                MessageBox.Show("Sayfa sayısı 0-100 arasında olmalıdır!");
                return;
            }
            DateTime tarih = Convert.ToDateTime(mtx_yayinTarihi.Text);
            if (tarih > DateTime.Now)
            {
                MessageBox.Show("Gelecek bir tarih yazamazsın!");
                return;
            }
            if (txt_manset.Text == "")
            {
                MessageBox.Show("Manşet boş bırakılamaz!");
            }

            int secilenID = (int)dgv_gazeteSayisi.SelectedRows[0].Cells["GazeteSayisiID"].Value;
            foreach (var gs in gazeteSayilari)
            {
                if (gs.SayiNo == sayi && gs.GazeteSayisiID != secilenID)
                {
                    MessageBox.Show(sayi + ". sayı numarası zaten başka bir kayıtta kullanılmış!");
                    return;
                }
            }
            bool bulundu = false;
            for (int i = 0; i < gazeteSayilari.Count; i++)
            {
                if (gazeteSayilari[i].GazeteSayisiID == secilenID) 
                {   
                    gazeteSayilari[i].SayiNo = sayi;
                    gazeteSayilari[i].SayfaSayisi = sayfa;
                    gazeteSayilari[i].YayinTarihi= tarih;
                    gazeteSayilari[i].Manset = txt_manset.Text;
                     bulundu = true;
                     break;   
                }
            }
            dgv_gazeteSayisi.DataSource = null;
            dgv_gazeteSayisi.DataSource = gazeteSayilari;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            if (dgv_gazeteSayisi.SelectedRows.Count > 0)
                dgv_gazeteSayisi.SelectedRows[0].Selected = false;
            txt_sayiNo.Clear();
            mtx_yayinTarihi.Text = DateTime.Now.ToString("ddMMyyyy");
            txt_sayfaSayisi.Clear();
            txt_manset.Clear();

            txt_sayiNo.Focus();
        }

        private void GazeteSayisiIslemleri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.E)
                btn_ekle_Click(null, null);
            else if (e.Control == true && e.KeyCode == Keys.G)
                btn_guncelle_Click(null, null);
            else if (e.KeyCode == Keys.Delete)
                btn_sil_Click(null, null);
            else if (e.Control == true && e.KeyCode == Keys.T)
                btn_temizle_Click(null, null);
        }
    }
}
