using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonFinalProje.veriKatmani.Prop
{
    public class RandevuProps
    {
        public int id { get; set; }
        public int Doktor_id { get; set; }
        public int Hasta_id { get; set; }
        public string DoktorTani { get; set; }
        public bool Durum { get; set; }
        public string Tarih { get; set; }
    }
}
