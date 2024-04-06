using HastaneOtomasyonFinalProje.veriKatmani.DB;
using HastaneOtomasyonFinalProje.veriKatmani.Prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonFinalProje.isKatmani
{
    public class BransYönlendirici
    {
        private static List<BransProps> Temp_Branslar;
        public BransYönlendirici()
        {
            //Branşlar listesini yeniler
            if (Temp_Branslar == null)
            {
                RefreshBranslar();
            }
        }
        private void RefreshBranslar() => Temp_Branslar = BransDB.GetBranslar(); //Branş liste yenileme

        //Branşları listeleme
        public List<BransProps> GetAllBrans()
        {
            if (Temp_Branslar != null)
            {
                RefreshBranslar();
            }
            return Temp_Branslar;
        }

    }
}
