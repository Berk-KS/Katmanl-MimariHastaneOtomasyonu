using HastaneOtomasyonFinalProje.veriKatmani.DB;
using HastaneOtomasyonFinalProje.veriKatmani.Prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonFinalProje.isKatmani
{
    public class HastaYönlendirici
    {
        private static List<HastaProps> Temp_Hastalar = null;//Hasta Listesi

        public HastaYönlendirici()
        {
            //Hastaların listesini yeniler
            if (Temp_Hastalar == null)
            {
                RefreshHastalar();
            }
        }

        //Hastalara Ait İşlemler
        public void AddHasta(HastaProps hp) { HastaDB.addHasta(hp); RefreshHastalar(); }
        public void UpdateHasta(HastaProps hp) { HastaDB.updateHasta(hp); RefreshHastalar(); }
        public void DeleteHasta(int id) { HastaDB.deleteHasta(id); RefreshHastalar(); }
        public void RefreshHastalar() => Temp_Hastalar = HastaDB.GetAllHasta();//Hastaları yenileme

        //Hastaları listeleyen method
        public List<HastaProps> GetAllHasta()
        {
            if (Temp_Hastalar != null)
            {
                RefreshHastalar();
            }
            return Temp_Hastalar;
        }

        public List<HastaProps> GetAllHastalar()
        {
            if (Temp_Hastalar != null)
            {
                RefreshHastalar();  
            }
            return Temp_Hastalar;
        }
        public HastaProps FindHasta(int _id)=>GetAllHastalar().Find(x=>x.id==_id);  
    }
}
