using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorsel1_Proje_Gazete_Sistemi
{
    internal class Yorum
    {
        public int YorumID { get; set; }
        public int HaberID { get; set; }
        public int AboneID { get; set; }
        public string YorumMetni {  get; set; }
        public DateTime YorumTarihi { get; set; }
        public Yorum( int yorum_id, int haber_id, int abone_id, string yorumMetni,DateTime yorumTarihi)
        {
            YorumID = yorum_id;
            HaberID = haber_id;
            AboneID = abone_id;
            YorumMetni = yorumMetni;
            YorumTarihi = yorumTarihi;
        }
        
    }
}
