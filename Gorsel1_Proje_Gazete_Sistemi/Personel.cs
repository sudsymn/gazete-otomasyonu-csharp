using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorsel1_Proje_Gazete_Sistemi
{
    internal class Personel
    {
        public int PersonelID { get; set; }
        public string DepartmanAdi { get; set; }
        public string Ad {  get; set; }
        public string Soyad {  get; set; }
        public string TcNo { get; set; }
        public string Adres { get; set; }
        public int Maas {  get; set; }

        public Personel(int personelID, string departmanAdi, string ad, string soyad, string tcNo ,string adres, int maas)
        {
            PersonelID = personelID;
            DepartmanAdi = departmanAdi;
            Ad = ad;
            Soyad = soyad;
            TcNo = tcNo;
            Adres = adres;
            Maas = maas;
        }
    }
}
