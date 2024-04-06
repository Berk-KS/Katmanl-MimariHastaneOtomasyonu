using HastaneOtomasyonFinalProje.veriKatmani.DB;
using HastaneOtomasyonFinalProje.veriKatmani.Prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonFinalProje.isKatmani
{
    public class DoktorYönlendirici
    {
        private static List<DoktorProps> Temp_Doktorlar = null; //Doktor Listesi

        public DoktorYönlendirici()
        {
            //Doktorlar listesini yeniler
            if (Temp_Doktorlar == null)
            {
                RefreshDoktorlar();
            }
        }

        public void DeleteDoktor(int id) { DoktorDB.DeleteDoktor(id); RefreshDoktorlar(); }
        public void AddDoktor(DoktorProps dp) { DoktorDB.AddDoktor(dp); RefreshDoktorlar(); }
        public void UpdateDoktor(DoktorProps dp) { DoktorDB.UpdateDoktor(dp); RefreshDoktorlar(); }

        //Doktorları listeleyen method
        public List<DoktorProps> GetAllDoktorlar()
        {
            if (Temp_Doktorlar != null)
            {
                RefreshDoktorlar();
            }
            return Temp_Doktorlar;
        }
        private void RefreshDoktorlar() => Temp_Doktorlar = DoktorDB.GetAllDoktor();//Doktor liste yenileme

        public DoktorProps FindDoktor(int _id) => GetAllDoktorlar().Find(x => x.id == _id); //Verilen id'e göre Doktoru bulma

    }
}
