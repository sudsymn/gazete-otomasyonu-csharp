using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel1_Proje_Gazete_Sistemi
{
    public partial class kullaniciGiris : Form
    {
        public kullaniciGiris()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (File.Exists("kullanicilar.ss") == false)
            {
                MessageBox.Show("Kullanıcı dosyası oluşturulmamış. Lütfen Sistem Yöneticisi İle İletişime Geçiniz.");
                return;
            }
            StreamReader sr = new StreamReader("kullanicilar.ss", Encoding.UTF8);
            bool girisBasarili = false;
            string oku = "";
            string sifreliSifre = SHA256Hash(tx_Sifre.Text);
            while ((oku = sr.ReadLine()) != null)
            {
                string[] parca = oku.Split('|');
                if (parca[1] == tx_kullaniciAdi.Text && parca[2] == sifreliSifre)
                {
                    girisBasarili = true;
                    break;
                }

            }
            sr.Close();

            if (girisBasarili == false)
            {
                MessageBox.Show("Kullanıcı Adı ve Şifreniz Hatalı...");
                return;
            }
            //MessageBox.Show("Giriş Başarılı.");
            GazeteSistemi afrm = new GazeteSistemi();
            this.Hide();
            afrm .Show();
        }
        string SHA256Hash(string text)
        {
            string source = text+"-Gazete";
            using (SHA256 sha1Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return hash;
            }
        }
        
    }
    
}
