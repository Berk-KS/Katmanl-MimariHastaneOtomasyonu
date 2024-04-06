using HastaneOtomasyonFinalProje.veriKatmani.DB;
using HastaneOtomasyonFinalProje.veriKatmani.Prop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonFinalProje.isKatmani
{
    public class RandevuYönlendirici
    {
        private static List<RandevuProps> Temp_Randevular = null;
        public RandevuYönlendirici()
        {

            if (Temp_Randevular == null)
            {
                RefreshRandevular();
            }
        }
        public void DeleteRandevu(int id) { RandevuDB.deleteRandevu(id); RefreshRandevular(); }
        public void AddRandevu(RandevuProps rp) { RandevuDB.addRandevu(rp); RefreshRandevular(); }
        public void UpdateRandevu(RandevuProps rp) { RandevuDB.updateRandevu(rp); RefreshRandevular(); }
        private void RefreshRandevular() => Temp_Randevular = RandevuDB.GettAllRandevu();

        public List<RandevuProps> GetAllRandevu()
        {
            if (Temp_Randevular != null)
            {
                //RefreshRandevular();
            }
            return Temp_Randevular;
        }
        public RandevuProps FindRandevu(int _id) => GetAllRandevu().Find(x => x.id == _id);

    }
}
