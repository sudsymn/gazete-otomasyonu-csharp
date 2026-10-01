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
    public partial class AboneIslemleri : Form
    {
        public AboneIslemleri()
        {
            InitializeComponent();
        }
        List<Abone> aboneler = new List<Abone>();
        int sonAboneId;
        private void AboneIslemleri_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("abone.ss", Encoding.UTF8);
            string oku = "";

            while ((oku = sr.ReadLine()) != null)
            {
                string[] parca = oku.Split('|');
                Abone a = new Abone(Convert.ToInt32(parca[0]), parca[1], parca[2], parca[3],parca[4], DateTime.Parse(parca[5]), DateTime.Parse(parca[6]));
                aboneler.Add(a);
                sonAboneId = a.AboneID;
            }
            sr.Close();
            
            dgv_abone.DataSource = aboneler;

            dgv_abone.DefaultCellStyle.ForeColor = Color.Black;
            dgv_abone.DefaultCellStyle.BackColor = Color.White;
            dgv_abone.RowsDefaultCellStyle.ForeColor = Color.Black;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (txt_ad.Text == "")
            {
                MessageBox.Show("Ad boş bırakılamaz!");
                return;
            }
           
            if (txt_soyad.Text == "")
            {
                MessageBox.Show("Soyad boş bırakılamaz!");
                return;
            }
            if (mtx_telefon.MaskFull == false)
            {
                MessageBox.Show("Telefon numarasını eksik girdiniz! 11 rakam içermelidir.");
                return;
            }
            if (txt_adres.Text == "")
            {
                MessageBox.Show("Adres boş bırakılamaz!");
                return;
            }
            if (mtx_baslangicT.MaskFull == false || mtx_bitisT.MaskFull == false)
            {
                MessageBox.Show("Lütfen tarihleri eksiksiz doldurun!");
                return;
            }
            DateTime baslangic, bitis;

            if (!DateTime.TryParse(mtx_baslangicT.Text, out baslangic))
            {
                MessageBox.Show("Başlangıç tarihi geçersiz!");
                return;
            }

            if (!DateTime.TryParse(mtx_bitisT.Text, out bitis))
            {
                MessageBox.Show("Bitiş tarihi geçersiz!");
                return;
            }

            if (bitis <= baslangic)
            {
                MessageBox.Show("Bitiş tarihi, başlangıçtan sonra olmalı!");
                return;
            }
            string girilenTelefon = mtx_telefon.Text;
            foreach (var abone in aboneler)
            {
                if (abone.Telefon == girilenTelefon)
                {
                    MessageBox.Show("Bu telefon numarasına sahip bir abone zaten mevcut!");
                    return;
                }
            }


            sonAboneId++;
            Abone a = new Abone(sonAboneId, txt_ad.Text, txt_soyad.Text, mtx_telefon.Text, txt_adres.Text, DateTime.Parse(mtx_baslangicT.Text), DateTime.Parse(mtx_bitisT.Text));
            aboneler.Add(a);
            dgv_abone.DataSource = null;
            dgv_abone.DataSource = aboneler;
            txt_ad.Clear();
            txt_soyad.Clear();
            mtx_telefon.Clear();
            txt_adres.Clear();
        }

        private void AboneIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {

            StreamWriter sw = new StreamWriter("abone.ss", false, Encoding.UTF8);

            foreach (var abone in aboneler)
            {
                sw.WriteLine(abone.AboneID + "|" + abone.AboneAd + "|" + abone.AboneSoyad + "|" + abone.Telefon + "|" + abone.Adres + "|" + abone.BaslangicTarihi+"|"+abone.BitisTarihi);
            }
            sw.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_abone.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek satırı seçiniz");
                return;
            }

            foreach (var a in aboneler)
            {
                if ((int)dgv_abone.SelectedRows[0].Cells["AboneID"].Value == a.AboneID)
                {
                    aboneler.Remove(a);
                    break;
                }
            }
            dgv_abone.DataSource = null;
            dgv_abone.DataSource = aboneler;
        }

        private void dgv_abone_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_abone.SelectedRows.Count == 0)
                return;
            txt_ad.Text = dgv_abone.SelectedRows[0].Cells["AboneAd"].Value.ToString();
            txt_soyad.Text = dgv_abone.SelectedRows[0].Cells["AboneSoyad"].Value.ToString();
            mtx_telefon.Text = dgv_abone.SelectedRows[0].Cells["Telefon"].Value.ToString();
            txt_adres.Text = dgv_abone.SelectedRows[0].Cells["Adres"].Value.ToString();
            mtx_baslangicT.Text = ((DateTime)dgv_abone.SelectedRows[0].Cells["BaslangicTarihi"].Value).ToString("dd.MM.yyyy");
            mtx_bitisT.Text = ((DateTime)dgv_abone.SelectedRows[0].Cells["BitisTarihi"].Value).ToString("dd.MM.yyyy");

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text == "")
            {
                MessageBox.Show("Ad boş bırakılamaz!");
                return;
            }

            if (txt_soyad.Text == "")
            {
                MessageBox.Show("Soyad boş bırakılamaz!");
                return;
            }
            if (mtx_telefon.MaskFull == false)
            {
                MessageBox.Show("Telefon numarasını eksik girdiniz! 11 rakam içermelidir.");
                return;
            }
            if (txt_adres.Text == "")
            {
                MessageBox.Show("Adres boş bırakılamaz!");
                return;
            }
            if (mtx_baslangicT.MaskFull == false || mtx_bitisT.MaskFull == false)
            {
                MessageBox.Show("Lütfen tarihleri eksiksiz doldurun!");
                return;
            }
            DateTime baslangic;
            DateTime bitis;

            if (!DateTime.TryParse(mtx_baslangicT.Text, out baslangic))
            {
                MessageBox.Show("Başlangıç tarihi geçersiz!");
                return;
            }

            if (!DateTime.TryParse(mtx_bitisT.Text, out bitis))
            {
                MessageBox.Show("Bitiş tarihi geçersiz!");
                return;
            }

            if (bitis <= baslangic)
            {
                MessageBox.Show("Bitiş tarihi, başlangıçtan sonra olmalı!");
                return;
            }

            int secilenID = (int)dgv_abone.SelectedRows[0].Cells["AboneID"].Value;
            string girilenTelefon = mtx_telefon.Text;
            foreach (var abn in aboneler)
            {
                if (abn.Telefon == girilenTelefon && abn.AboneID != secilenID)
                {
                    MessageBox.Show("Girdiğiniz telefon numarası başka bir aboneye aittir!");
                    return;
                }
            }
            bool bulundu = false;
            for (int i = 0; i < aboneler.Count; i++)
            {
                if (aboneler[i].AboneID == secilenID)
                {
                    aboneler[i].AboneAd = txt_ad.Text;
                    aboneler[i].AboneSoyad = txt_soyad.Text;
                    aboneler[i].Telefon = mtx_telefon.Text;
                    aboneler[i].Adres = txt_adres.Text;
                    aboneler[i].BaslangicTarihi = baslangic;
                    aboneler[i].BitisTarihi = bitis;
                    bulundu = true;
                    break;
                }
            }
            dgv_abone.DataSource = null;
            dgv_abone.DataSource = aboneler;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            if (dgv_abone.SelectedRows.Count > 0)
                dgv_abone.SelectedRows[0].Selected = false;
            txt_ad.Clear();
            txt_soyad.Clear();
            mtx_telefon.Clear();
            txt_adres.Clear();
            mtx_baslangicT.Text=DateTime.Now.ToString("ddMMyyyy");
            mtx_bitisT.Text=DateTime.Now.ToString("ddMMyyyy");

            txt_ad.Focus();
        }

        private void AboneIslemleri_KeyDown(object sender, KeyEventArgs e)
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
