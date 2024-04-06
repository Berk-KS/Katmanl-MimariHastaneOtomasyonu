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
    public partial class DoktorHastaBilgiEkranFrm : Form
    {
        public DoktorHastaBilgiEkranFrm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorAnaEkranFrm drAnaEkran = new DoktorAnaEkranFrm();
            drAnaEkran.FormClosed += (s, args) => this.Close();
            drAnaEkran.Show();
        }

        private void DoktorHastaBilgiEkranFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastane_DbDataSet11.Hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter.Fill(this.hastane_DbDataSet11.Hasta);

        }
    }
}
