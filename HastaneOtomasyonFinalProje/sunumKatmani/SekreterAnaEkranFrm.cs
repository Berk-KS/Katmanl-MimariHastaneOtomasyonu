using HastaneOtomasyonFinalProje.isKatmani;
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
    public partial class SekreterAnaEkranFrm : Form
    {
        public SekreterAnaEkranFrm()
        {
            InitializeComponent();
        }

        private void hastaEkranbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SekreterHastaEkranFrm HastaEklemeEkran = new SekreterHastaEkranFrm();
            HastaEklemeEkran.FormClosed += (s, args) => this.Close();
            HastaEklemeEkran.Show();
        }

        private void randevuEkranBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SekreterRandevuEkranFrm HastaRandevuEkran = new SekreterRandevuEkranFrm();
            HastaRandevuEkran.FormClosed += (s, args) => this.Close();
            HastaRandevuEkran.Show();
        }

        private void doktorEkranBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SekreterDoktorEkranFrm HastaDoktorEkran = new SekreterDoktorEkranFrm();
            HastaDoktorEkran.FormClosed += (s, args) => this.Close();
            HastaDoktorEkran.Show();
        }

        private void sekreterEkranBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SekreterSekreterEkranıFrm SekreterEklemeEkran = new SekreterSekreterEkranıFrm();
            SekreterEklemeEkran.FormClosed += (s, args) => this.Close();
            SekreterEklemeEkran.Show();
        }

        private void sekreterCıkısBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisFrm Ekran = new GirisFrm();
            Ekran.FormClosed += (s, args) => this.Close();
            Ekran.Show();
        }
    }
}
