using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorsel1_Proje_Gazete_Sistemi
{
    public class GazeteSayisi
    {
        public int GazeteSayisiID {  get; set; }
        public int SayiNo {  get; set; }
        public DateTime YayinTarihi { get; set; }
        public int SayfaSayisi {  get; set; }
        public string Manset {  get; set; }
        public GazeteSayisi(int gazeteSayisi_id, int sayiNo, DateTime yayinTarihi, int sayfaSayisi, string manset) {
            GazeteSayisiID=gazeteSayisi_id;
            SayiNo=sayiNo;
            YayinTarihi=yayinTarihi;
            SayfaSayisi=sayfaSayisi;
            Manset = manset;
        }
    }
}
