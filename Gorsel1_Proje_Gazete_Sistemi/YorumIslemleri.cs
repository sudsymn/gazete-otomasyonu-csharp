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
    public partial class YorumIslemleri : Form
    {
        public YorumIslemleri()
        {
            InitializeComponent();
        }
        List<Yorum> yorumlar = new List<Yorum>();
        List<Haber> haberler = new List<Haber>();
        List<Abone> aboneler = new List<Abone>();
        int sonYorum_id;
        private void YorumIslemleri_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("haber.ss", Encoding.UTF8);
            string oku = "";

            while ((oku = sr.ReadLine()) != null)
            {
                string[] parca = oku.Split('|');
                Haber h = new Haber(Convert.ToInt32(parca[0]), parca[1], parca[2], parca[3], parca[4], Convert.ToInt32(parca[5]));
                haberler.Add(h);
                
            }
            sr.Close();
            cbx_haber.DisplayMember = "HaberBaslikIcerikKategoriYazarGazeteSayisiID";
            cbx_haber.ValueMember = "Haber_ID";
            cbx_haber.DataSource = haberler;

            sr = new StreamReader("abone.ss", Encoding.UTF8);
            oku = "";

            while ((oku = sr.ReadLine()) != null)
            {
                string[] parca = oku.Split('|');
                Abone a = new Abone(Convert.ToInt32(parca[0]), parca[1], parca[2], parca[3], parca[4], DateTime.Parse(parca[5]), DateTime.Parse(parca[6]));
                aboneler.Add(a);
                
            }
            sr.Close();
            cbx_abone.DisplayMember = "AboneADSoyadTelefonBaslangicTarihibitisTarihi";
            cbx_abone.ValueMember = "AboneID";
            cbx_abone.DataSource = aboneler;

            sr = new StreamReader("yorum.ss", Encoding.UTF8);
            oku = "";

            while ((oku = sr.ReadLine()) != null)
            {
                string[] parca = oku.Split('|');
                Yorum y = new Yorum(Convert.ToInt32(parca[0]), Convert.ToInt32(parca[1]), Convert.ToInt32(parca[2]), parca[3], DateTime.Parse(parca[4]));
                yorumlar.Add(y);
                sonYorum_id = y.YorumID;
            }
            sr.Close();
            dgv_yorum.DataSource = yorumlar;
            dgv_yorum.DefaultCellStyle.ForeColor = Color.Black;
            dgv_yorum.DefaultCellStyle.BackColor = Color.White;
            dgv_yorum.RowsDefaultCellStyle.ForeColor = Color.Black;


        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if(cbx_haber.SelectedIndex==-1)
            {
                MessageBox.Show("Haber bilgilerini seçiniz!");
                return;
            }
            if (cbx_abone.SelectedIndex == -1)
            {
                MessageBox.Show("Abone bilgilerini seçiniz!");
                return;
            }
            if(txt_yorumMetni.Text=="")
            {
                MessageBox.Show("Yorum metni boş bırakılamaz!");
                return;
            }
            if (mtx_yorumTarihi.MaskFull == false)
            {
                MessageBox.Show("Lütfen yorum tarihini tam giriniz!");
                return;
            }
            DateTime yorumTarihi;
            if (DateTime.TryParse(mtx_yorumTarihi.Text, out yorumTarihi) == false)
            {
                MessageBox.Show("Geçersiz bir tarih girdiniz!");
                return;
            }

            int secilenHaberID = (int)cbx_haber.SelectedValue;
            int secilenAboneID = (int)cbx_abone.SelectedValue;
            string girilenYorum = txt_yorumMetni.Text.Trim().ToLower();

            foreach (var yrm in yorumlar)
            {
                if (yrm.HaberID == secilenHaberID &&
                    yrm.AboneID == secilenAboneID &&
                    yrm.YorumMetni.Trim().ToLower() == girilenYorum)
                {
                    MessageBox.Show("Bu abone bu habere zaten aynı yorumu yapmış!");
                    return;
                }
            }

            sonYorum_id++;
            Yorum y = new Yorum(sonYorum_id, (int)cbx_haber.SelectedValue, (int)cbx_abone.SelectedValue, txt_yorumMetni.Text, DateTime.Parse(mtx_yorumTarihi.Text));
            yorumlar.Add(y);

            dgv_yorum.DataSource = null;
            dgv_yorum.DataSource = yorumlar;
        }

        private void YorumIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {

            StreamWriter sw = new StreamWriter("yorum.ss", false, Encoding.UTF8);

            foreach (var yorum in yorumlar)
            {
                sw.WriteLine(yorum.YorumID + "|" + yorum.HaberID + "|" + yorum.AboneID + "|" + yorum.YorumMetni + "|" + yorum.YorumTarihi );
            }
            sw.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            if (dgv_yorum.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek satırı seçiniz");
                return;
            }

            foreach (var y in yorumlar)
            {
                if ((int)dgv_yorum.SelectedRows[0].Cells["YorumID"].Value == y.YorumID)
                {
                    yorumlar.Remove(y);
                    break;
                }
            }
            dgv_yorum.DataSource = null;
            dgv_yorum.DataSource = yorumlar;
        }

        private void dgv_yorum_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_yorum.SelectedRows.Count == 0)
                return;
            cbx_haber.Text = dgv_yorum.SelectedRows[0].Cells["HaberID"].Value.ToString();
            cbx_abone.Text = dgv_yorum.SelectedRows[0].Cells["AboneID"].Value.ToString();
            txt_yorumMetni.Text = dgv_yorum.SelectedRows[0].Cells["YorumMetni"].Value.ToString();
            mtx_yorumTarihi.Text = ((DateTime)dgv_yorum.SelectedRows[0].Cells["YorumTarihi"].Value).ToString("dd.MM.yyyy");

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (cbx_haber.SelectedIndex == -1)
            {
                MessageBox.Show("Haber bilgilerini seçiniz!");
                return;
            }
            if (cbx_abone.SelectedIndex == -1)
            {
                MessageBox.Show("Abone bilgilerini seçiniz!");
                return;
            }
            if (txt_yorumMetni.Text == "")
            {
                MessageBox.Show("Yorum metni boş bırakılamaz!");
                return;
            }
            if (mtx_yorumTarihi.MaskFull == false)
            {
                MessageBox.Show("Lütfen yorum tarihini tam giriniz!");
                return;
            }
            DateTime yorumTarihi;
            if (DateTime.TryParse(mtx_yorumTarihi.Text, out yorumTarihi) == false)
            {
                MessageBox.Show("Geçersiz bir tarih girdiniz!");
                return;
            }
            int secilenID = (int)dgv_yorum.SelectedRows[0].Cells["YorumID"].Value;
            int secilenHaberID = (int)cbx_haber.SelectedValue;
            int secilenAboneID = (int)cbx_abone.SelectedValue;
            string girilenYorum = txt_yorumMetni.Text.Trim().ToLower();
            foreach (var yrm in yorumlar)
            {
                if (yrm.HaberID == secilenHaberID &&
                    yrm.AboneID == secilenAboneID &&
                    yrm.YorumMetni.Trim().ToLower() == girilenYorum &&
                    yrm.YorumID != secilenID) 
                {
                    MessageBox.Show("Aynı yorum zaten mevcut!");
                    return;
                }
            }
            bool bulundu = false;
            for (int i = 0; i < yorumlar.Count; i++)
            {
                if (yorumlar[i].YorumID == secilenID)
                {
                    yorumlar[i].HaberID = (int)cbx_haber.SelectedValue;
                    yorumlar[i].AboneID = (int)cbx_abone.SelectedValue;
                    yorumlar[i].YorumTarihi = yorumTarihi;
                    bulundu = true;
                    break;
                }
            }

            dgv_yorum.DataSource = null;
            dgv_yorum.DataSource = yorumlar;
        }

        private void YorumIslemleri_KeyDown(object sender, KeyEventArgs e)
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

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            if (dgv_yorum.SelectedRows.Count > 0)
                dgv_yorum.SelectedRows[0].Selected = false;
            cbx_haber.SelectedIndex = -1;
            cbx_abone.SelectedIndex = -1;
            txt_yorumMetni.Clear();
            mtx_yorumTarihi.Text = DateTime.Now.ToString("ddMMyyyy");
            
        }
    }
}
