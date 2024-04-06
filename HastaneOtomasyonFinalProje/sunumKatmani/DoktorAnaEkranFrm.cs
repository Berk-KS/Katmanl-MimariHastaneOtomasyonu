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
    public partial class DoktorAnaEkranFrm : Form
    {
        public DoktorAnaEkranFrm()
        {
            InitializeComponent();
        }

        private void hastaBilgiDüzenleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorHastaBilgiEkranFrm drhastaEkran = new DoktorHastaBilgiEkranFrm();
            drhastaEkran.FormClosed += (s, args) => this.Close();
            drhastaEkran.Show();
        }

        private void çıkışYapBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisFrm girisEkran = new GirisFrm();
            girisEkran.FormClosed += (s, args) => this.Close();
            girisEkran.Show();
        }

        private void DoktorAnaEkranFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastane_DbDataSet10.Hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter.Fill(this.hastane_DbDataSet10.Hasta);

        }
    }
}
