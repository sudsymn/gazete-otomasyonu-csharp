using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorsel1_Proje_Gazete_Sistemi
{
    public class Haber
    {
        public int Haber_ID { get; set; }
        public string Baslik {  get; set; }
        public string Icerik { get; set; }
        public string Kategori { get; set; }
        public string Yazar {  get; set; }
        public int GazeteSayisiID { get; set; }
        public string HaberBaslikIcerikKategoriYazarGazeteSayisiID { get { return Baslik + " - " + Icerik + " - " + Kategori + " - " + Yazar + " - " + GazeteSayisiID; } }



        public Haber(int haber_id, string baslik, string icerik, string kategori, string yazar, int gazeteSayisi_id){
            Haber_ID = haber_id;
            Baslik = baslik;
            Icerik = icerik;
            Kategori = kategori;
            Yazar = yazar;
            GazeteSayisiID = gazeteSayisi_id;
        }
    }
}
