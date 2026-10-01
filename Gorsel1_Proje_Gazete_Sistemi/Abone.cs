using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorsel1_Proje_Gazete_Sistemi
{
    internal class Abone
    {
        public int AboneID { get; set; }
        public string AboneAd {  get; set; }
        public string AboneSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string AboneADSoyadTelefonBaslangicTarihibitisTarihi
        {
            get { return AboneAd + " - " + AboneSoyad + " - " + Telefon + " - " + Adres + " - " + BaslangicTarihi.ToShortDateString() + " - " + BitisTarihi.ToShortDateString(); }
        }
        public Abone(int aboneID, string aboneAd, string aboneSoyad, string telefon, string adres, DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            AboneID = aboneID;
            AboneAd = aboneAd;
            AboneSoyad = aboneSoyad;
            Telefon = telefon;
            Adres = adres;
            BaslangicTarihi = baslangicTarihi;
            BitisTarihi = bitisTarihi;
        }
    }
}
