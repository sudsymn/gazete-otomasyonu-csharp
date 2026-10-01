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
    public partial class PersonelIslemleri : Form
    {
        public PersonelIslemleri()
        {
            InitializeComponent();
        }
        List<Personel> personeller=new List<Personel>();
        int sonPersonelID;
        private void PersonelIslemleri_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("personel.ss", Encoding.UTF8);
            string oku = "";
            while ((oku = sr.ReadLine()) != null)
            {
                string[] parca = oku.Split('|');

                Personel p = new Personel(Convert.ToInt32(parca[0]), parca[1], parca[2], parca[3], parca[4], parca[5], Convert.ToInt32(parca[6]));
                personeller.Add(p); 
                sonPersonelID = p.PersonelID; 
            }
            sr.Close();

            dgv_personel.DataSource = null;
            dgv_personel.DataSource = personeller;
            // 1. Satırların genel arka planı beyaz, yazıları siyah olsun
            dgv_personel.DefaultCellStyle.BackColor = Color.White;
            dgv_personel.DefaultCellStyle.ForeColor = Color.Black;

            // 2. Bir satıra tıklandığında (seçildiğinde) arka plan koyu mavi, yazı beyaz olsun
            dgv_personel.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215); // Windows Standart Mavisi
            dgv_personel.DefaultCellStyle.SelectionForeColor = Color.White;

            // 3. Başlıkların (en üstteki sütun isimleri) rengi
            dgv_personel.EnableHeadersVisualStyles = false; // Bunu false yapmazsan renk değişmez
            dgv_personel.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv_personel.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // 4. Izgara (çizgi) rengi
            dgv_personel.GridColor = Color.Gainsboro;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_departman.Text == "")
            {
                MessageBox.Show("Departman boş bırakılamaz!");
                return;
            }
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
            if (mtx_tcNo.MaskFull == false)
            {
                MessageBox.Show("TC kimlik numarasını eksik girdiniz! 11 rakam içermelidir.");
                return;
            }
            if (txt_adres.Text == "")
            {
                MessageBox.Show("Adres boş bırakılamaz!");
                return;
            }
            if (int.TryParse(txt_maas.Text, out int maasMiktari) == false)
            {
                MessageBox.Show("Maaş alanına sadece rakam giriniz!");
                return;
            }

            if (maasMiktari <= 0)
            {
                MessageBox.Show("Maaş 0'dan büyük olmalıdır!");
                return;
            }
            string girilenTC = mtx_tcNo.Text;

            foreach (var prsnl in personeller)
            {
                if (prsnl.TcNo == girilenTC)
                {
                    MessageBox.Show("Bu TC Kimlik numarasına sahip bir personel zaten kayıtlı!");
                    return;
                }
            }

                sonPersonelID++;
            Personel p = new Personel(sonPersonelID, txt_departman.Text, txt_ad.Text, txt_soyad.Text, mtx_tcNo.Text,txt_adres.Text,Convert.ToInt32(txt_maas.Text));
            personeller.Add(p);

            dgv_personel.DataSource = null;
            dgv_personel.DataSource = personeller;
        }

        private void PersonelIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("personel.ss", false, Encoding.UTF8);

            foreach (var p in personeller)
            {
                sw.WriteLine(p.PersonelID + "|" + p.DepartmanAdi + "|" + p.Ad + "|" + p.Soyad + "|" + p.TcNo + "|" + p.Adres +"|"+p.Maas);
            }
            sw.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_personel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek satırı seçiniz");
                return;
            }

            foreach (var p in personeller)
            {
                if ((int)dgv_personel.SelectedRows[0].Cells["PersonelID"].Value == p.PersonelID)
                {
                    personeller.Remove(p);
                    break;
                }
            }
            dgv_personel.DataSource = null;
            dgv_personel.DataSource = personeller;
        }

        private void dgv_personel_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_personel.SelectedRows.Count == 0)
                return;
            txt_departman.Text = dgv_personel.SelectedRows[0].Cells["DepartmanAdi"].Value.ToString();
            txt_ad.Text = dgv_personel.SelectedRows[0].Cells["Ad"].Value.ToString();
            txt_soyad.Text = dgv_personel.SelectedRows[0].Cells["Soyad"].Value.ToString();
            mtx_tcNo.Text = dgv_personel.SelectedRows[0].Cells["TcNo"].Value.ToString();
            txt_adres.Text = dgv_personel.SelectedRows[0].Cells["Adres"].Value.ToString();
            txt_maas.Text = dgv_personel.SelectedRows[0].Cells["Maas"].Value.ToString();

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_departman.Text == "")
            {
                MessageBox.Show("Departman boş bırakılamaz!");
                return;
            }
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
            if (mtx_tcNo.MaskFull == false)
            {
                MessageBox.Show("TC kimlik numarasını eksik girdiniz! 11 rakam içermelidir.");
                return;
            }
            if (txt_adres.Text == "")
            {
                MessageBox.Show("Adres boş bırakılamaz!");
                return;
            }
            if (int.TryParse(txt_maas.Text, out int maasMiktari) == false)
            {
                MessageBox.Show("Maaş alanına sadece rakam giriniz!");
                return;
            }

            if (maasMiktari <= 0)
            {
                MessageBox.Show("Maaş 0'dan büyük olmalıdır!");
                return;
            }
            int secilenID = (int)dgv_personel.SelectedRows[0].Cells["PersonelID"].Value;
            string girilenTC = mtx_tcNo.Text;

            foreach (var p in personeller)
            {
                if (p.TcNo == girilenTC && p.PersonelID != secilenID)
                {
                    MessageBox.Show("Girdiğiniz TC Kimlik numarası başka bir personele ait!");
                    return;
                }
            }
            bool bulundu = false;
            for (int i = 0; i < personeller.Count; i++)
            {
                if (personeller[i].PersonelID == secilenID)
                {
                    personeller[i].DepartmanAdi = txt_departman.Text;
                    personeller[i].Ad = txt_ad.Text;
                    personeller[i].Soyad = txt_soyad.Text;
                    personeller[i].TcNo = mtx_tcNo.Text;
                    personeller[i].Adres = txt_adres.Text;
                    personeller[i].Maas = maasMiktari;
                    bulundu = true;
                    break;
                }
            }
            dgv_personel.DataSource = null;
            dgv_personel.DataSource = personeller;
        }

        private void PersonelIslemleri_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control == true&& e.KeyCode==Keys.E)
                btn_ekle_Click(null, null);
            else if(e.Control == true&& e.KeyCode==Keys.G)
                btn_guncelle_Click(null, null);
            else if( e.KeyCode==Keys.Delete)
                btn_sil_Click(null, null);
            else if(e.Control == true && e.KeyCode==Keys.T)
                btn_temizle_Click(null, null);
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            if (dgv_personel.SelectedRows.Count > 0)
                dgv_personel.SelectedRows[0].Selected = false;
            txt_departman.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
            mtx_tcNo.Clear();
            txt_adres.Clear();
            txt_maas.Clear();

            txt_departman.Focus();

            
        }
    }
}
