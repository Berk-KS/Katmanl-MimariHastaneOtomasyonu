using HastaneOtomasyonFinalProje.isKatmani;
using HastaneOtomasyonFinalProje.veriKatmani.Prop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonFinalProje.sunumKatmani
{
    public partial class SekreterRandevuEkranFrm : Form
    {
        public SekreterRandevuEkranFrm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void hastaSkrtrGeriDönBtm_Click(object sender, EventArgs e)
        {
            this.Hide();
            SekreterAnaEkranFrm sekreterAnaEkran = new SekreterAnaEkranFrm();
            sekreterAnaEkran.FormClosed += (s, args) => this.Close();
            sekreterAnaEkran.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SekreterRandevuEkranFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastane_DbDataSet9.Randevu_TB' table. You can move, or remove it, as needed.
            this.randevu_TBTableAdapter2.Fill(this.hastane_DbDataSet9.Randevu_TB);
            // TODO: This line of code loads data into the 'hastane_DbDataSet8.Randevu_TB' table. You can move, or remove it, as needed.
            this.randevu_TBTableAdapter1.Fill(this.hastane_DbDataSet8.Randevu_TB);

            

        }

        private void randevuOluşturBtn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    RandevuYönlendirici randevu = new RandevuYönlendirici();
                    RandevuProps rnd = new RandevuProps();
                    rnd.Doktor_id = Convert.ToInt32(doktorIdtextBox.Text);
                    rnd.Hasta_id = Convert.ToInt32(hastaIdtextBox.Text);
                    rnd.DoktorTani = "yok";
                    rnd.Tarih = TARIHPICKER.Value.ToString("dd/MM/yyyy");
                    randevu.AddRandevu(rnd);
                    RandevuGridView.DataSource = randevu.GetAllRandevu();
                    hastaIdtextBox.Clear();
                    doktorIdtextBox.Clear();
                } catch { 
                    MessageBox.Show("HATA MEYDANA GELDİ..." + "\n\n" + "HATA KODU :" + "\n" + " BİR HATA MEYDANA GELDİ"); 
                }
            }
        }

        private void TARIHPICKER_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
