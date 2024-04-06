using HastaneOtomasyonFinalProje.veriKatmani.DB;
using HastaneOtomasyonFinalProje.veriKatmani.Prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonFinalProje.isKatmani
{
    public class SekreterYönlendirici
    {
        private static List<SekreterProps> Temp_Sekreterler = null; //Sekreter Listesi

        public SekreterYönlendirici()
        {
            //Sekreterler listesini yeniler
            if (Temp_Sekreterler == null)
            {
                RefreshSekreterler();
            }
        }


        //Sekreterlere ait işlemler
        public void DeleteSekreter(int id) { SekreterDB.DeleteSekreter(id); RefreshSekreterler(); }
        public void AddSekreter(SekreterProps sp) { SekreterDB.AddSekreter(sp); RefreshSekreterler(); }
        public void UpdateSekreter(SekreterProps sp) { SekreterDB.UpdateSekreter(sp); RefreshSekreterler(); }


        private void RefreshSekreterler() => Temp_Sekreterler = SekreterDB.GetAllSekreter(); //Sekreter liste yenileme

        //Sekreterleri listeleyen method
        public List<SekreterProps> GetAllSekreter()
        {
            if (Temp_Sekreterler != null)
            {
                RefreshSekreterler();
            }
            return Temp_Sekreterler;
        }

        public SekreterProps FindSekreter(int _id) => GetAllSekreter().Find(x => x.id == _id); //Verilen id'e göre Sekreteri bulma
    }
}
