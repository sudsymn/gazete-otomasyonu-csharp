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
    public partial class HaberIslemleri : Form
    {
        public HaberIslemleri()
        {
            InitializeComponent();
        }
        List<GazeteSayisi> gazeteSayilari = new List<GazeteSayisi>();
        List<Haber> haberler = new List<Haber>();
        int sonHaber_id;
        private void HaberIslemleri_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("gazeteSayisi.ss", Encoding.UTF8);
            string oku = "";

            while ((oku = sr.ReadLine()) != null)
            {
                string[] parca = oku.Split('|');
                GazeteSayisi s = new GazeteSayisi(Convert.ToInt32(parca[0]), Convert.ToInt32(parca[1]), DateTime.Parse(parca[2]), Convert.ToInt32(parca[3]), parca[4]);
                gazeteSayilari.Add(s);
            }
            sr.Close();

            cmbx_gazeteSayisi.DisplayMember = "SayiNo";
            cmbx_gazeteSayisi.ValueMember = "GazeteSayisiID";
            cmbx_gazeteSayisi.DataSource = gazeteSayilari;

            sr = new StreamReader("haber.ss", Encoding.UTF8);
            oku = "";

            while ((oku = sr.ReadLine()) != null)
            {
                string[] parca = oku.Split('|');
                Haber h = new Haber(Convert.ToInt32(parca[0]), parca[1], parca[2], parca[3],parca[4],Convert.ToInt32(parca[5]));
                haberler.Add(h);
                sonHaber_id = h.Haber_ID;
            }
            sr.Close();
            dgv_haberler.DataSource = haberler;
            dgv_haberler.EnableHeadersVisualStyles = false;
            dgv_haberler.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dgv_haberler.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv_haberler.DefaultCellStyle.ForeColor = Color.Black;
            dgv_haberler.DefaultCellStyle.BackColor = Color.White;
            dgv_haberler.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgv_haberler.EnableHeadersVisualStyles = false;
            dgv_haberler.ColumnHeadersHeight = 30; 
            dgv_haberler.DefaultCellStyle.BackColor = Color.White;
            dgv_haberler.DefaultCellStyle.ForeColor = Color.Black;

            dgv_haberler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv_haberler.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv_haberler.BackgroundColor = Color.DarkGray;

            dgv_haberler.GridColor = Color.LightGray;
            dgv_haberler.CellBorderStyle = DataGridViewCellBorderStyle.Single;

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (cmbx_gazeteSayisi.SelectedIndex == -1) {
                MessageBox.Show("Gazete Sayısı Seçilmemiş Lütfen Seçiniz...");
                return;
            }
            if (txt_baslik.Text == "")
            {
                MessageBox.Show("Başlık boş bırakılamaz!");
                return;
            }
            if (txt_icerik.Text == "")
            {
                MessageBox.Show("İçerik boş bırakılamaz!");
                return;
            }
            if (txt_kategori.Text == "")
            {
                MessageBox.Show("Kategori boş bırakılamaz!");
                return;
            }
            if (txt_yazar.Text == "")
            {
                MessageBox.Show("Yazar boş bırakılamaz!");
                return;
            }
            int secilenSayiID = (int)cmbx_gazeteSayisi.SelectedValue;

            foreach (var haber in haberler)
            {
                if (haber.Baslik.Trim().ToLower() == txt_baslik.Text.Trim().ToLower() &&
                    haber.GazeteSayisiID == secilenSayiID)
                {
                    MessageBox.Show("Aynı gazete sayısında aynı başlıkta birden fazla haber bulunamaz!");
                    return;
                }
            }
            sonHaber_id++;
            Haber h = new Haber(sonHaber_id, txt_baslik.Text, txt_icerik.Text, txt_kategori.Text, txt_yazar.Text, (int)cmbx_gazeteSayisi.SelectedValue);
            haberler.Add(h);

            dgv_haberler.DataSource = null;
            dgv_haberler.DataSource = haberler;

        }

        private void HaberIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("haber.ss",false, Encoding.UTF8);

            foreach (var haber in haberler)
            {
                sw.WriteLine(haber.Haber_ID+"|"+haber.Baslik+"|"+haber.Icerik+"|"+haber.Kategori+"|"+haber.Yazar+"|"+haber.GazeteSayisiID);
            }
            sw.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_haberler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek satırı seçiniz");
                return;
            }

            foreach (var h in haberler)
            {
                if ((int)dgv_haberler.SelectedRows[0].Cells["Haber_ID"].Value == h.Haber_ID)
                {
                    haberler.Remove(h);
                    break;
                }
            }
            dgv_haberler.DataSource = null;
            dgv_haberler.DataSource = haberler;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (cmbx_gazeteSayisi.SelectedIndex == -1)
            {
                MessageBox.Show("Gazete Sayısı Seçilmemiş Lütfen Seçiniz...");
                return;
            }
            if (txt_baslik.Text == "")
            {
                MessageBox.Show("Başlık boş bırakılamaz!");
                return;
            }
            if (txt_icerik.Text == "")
            {
                MessageBox.Show("İçerik boş bırakılamaz!");
                return;
            }
            if (txt_kategori.Text == "")
            {
                MessageBox.Show("Kategori boş bırakılamaz!");
                return;
            }
            if (txt_yazar.Text == "")
            {
                MessageBox.Show("Yazar boş bırakılamaz!");
                return;
            }

            int secilenID = (int)dgv_haberler.SelectedRows[0].Cells["Haber_ID"].Value;
            int secilenSayiID = (int)cmbx_gazeteSayisi.SelectedValue;

            foreach (var hbr in haberler)
            {
                if (hbr.Baslik.Trim().ToLower() == txt_baslik.Text.Trim().ToLower() &&
                    hbr.GazeteSayisiID == secilenSayiID &&
                    hbr.Haber_ID != secilenID)
                {
                    MessageBox.Show("Bu gazete sayısında bu başlık başka bir haberde zaten kullanılmış!", "Güncelleme Hatası");
                    return;
                }
            }
            bool bulundu = false;
            for (int i = 0; i < haberler.Count; i++)
            {
                if (haberler[i].Haber_ID == secilenID)
                {
                    haberler[i].GazeteSayisiID =(int)cmbx_gazeteSayisi.SelectedValue;
                    haberler[i].Baslik = txt_baslik.Text;
                    haberler[i].Icerik = txt_icerik.Text;
                    haberler[i].Kategori = txt_kategori.Text;
                    haberler[i].Yazar = txt_yazar.Text;
                    bulundu = true;
                    break;
                }
            }
            dgv_haberler.DataSource = null;
            dgv_haberler.DataSource = haberler;
        }

        private void dgv_haberler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_haberler.SelectedRows.Count == 0)
                return;
            txt_baslik.Text = dgv_haberler.SelectedRows[0].Cells["Baslik"].Value.ToString();
            txt_icerik.Text = dgv_haberler.SelectedRows[0].Cells["Icerik"].Value.ToString();
            txt_kategori.Text = dgv_haberler.SelectedRows[0].Cells["Kategori"].Value.ToString();
            txt_yazar.Text = dgv_haberler.SelectedRows[0].Cells["Yazar"].Value.ToString();
            cmbx_gazeteSayisi.Text=dgv_haberler.SelectedRows[0].Cells["GazeteSayisiID"].Value.ToString();
        }

        private void HaberIslemleri_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control==true && e.KeyCode==Keys.E)
                btn_ekle_Click(null, null);
          
            else if(e.Control==true && e.KeyCode==Keys.G)
                btn_guncelle_Click(null, null);

            else if(e.KeyCode==Keys.Delete)
                btn_sil_Click(null, null);

            else if(e.Control==true && e.KeyCode==Keys.T)
                btn_temizle_Click(null, null);
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            if (dgv_haberler.SelectedRows.Count > 0)
                dgv_haberler.SelectedRows[0].Selected = false;
            txt_baslik.Clear();
            txt_icerik.Clear();
            txt_kategori.Clear();
            txt_yazar.Clear();
            cmbx_gazeteSayisi.SelectedIndex = -1;

            txt_baslik.Focus();
        }
    }

            
}
