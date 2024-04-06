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
    public partial class SekreterSekreterEkranıFrm : Form
    {
        public SekreterSekreterEkranıFrm()
        {
            InitializeComponent();
        }
        DataGridViewCheckBoxColumn dbcc = new DataGridViewCheckBoxColumn();
        private void SekreterSekreterEkranıFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastane_DbDataSet4.Sekreter' table. You can move, or remove it, as needed.
            this.sekreterTableAdapter.Fill(this.hastane_DbDataSet4.Sekreter);
            dbcc.Name = "checkBox";
            sekreterGridView.Columns.Add(dbcc);

            foreach (DataGridViewRow dataGridView in sekreterGridView.Rows) //checkbox dışındakileri readonly true yapma olayı.
            {
                for (int i = 1; i < dataGridView.Cells.Count; i++)
                {
                    dataGridView.Cells[i].ReadOnly = true;
                    if (i == 4) //checkbox indexi.
                    {
                        dataGridView.Cells[i].ReadOnly = false;
                    }
                }
            }
            sekreterGridView.CellContentClick += new DataGridViewCellEventHandler(sekreterGridView_CellContentClick); //Checkbox event oluşturma.

        }
        private void sekreterGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DoktorYönlendirici dr = new DoktorYönlendirici();
            DataGridViewRow row = sekreterGridView.Rows[e.RowIndex];
            row.Cells["checkBox"].Value = !Convert.ToBoolean(row.Cells["checkBox"].Value);

            if (Convert.ToBoolean(row.Cells["checkBox"].Value) == true)
            {
                sekreterAdTextbox.Text = sekreterGridView.CurrentRow.Cells[1].Value.ToString();
                sekreterSoyadTextbox.Text = sekreterGridView.CurrentRow.Cells[2].Value.ToString();
                sekreterSifreMaskedTextbox.Text = sekreterGridView.CurrentRow.Cells[3].Value.ToString();
            }
        }
        private void sekreterGeridonBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SekreterAnaEkranFrm sekreterAnaEkran =new SekreterAnaEkranFrm();
            sekreterAnaEkran.FormClosed += (s, args) => this.Close();
            sekreterAnaEkran.Show();
        }
        private void sekreterEkleBtn_Click(object sender, EventArgs e)
        {
            try { 
            SekreterYönlendirici Sekreter = new SekreterYönlendirici();
            SekreterProps SekreterProp = new SekreterProps();
            SekreterProp.Ad = sekreterAdTextbox.Text;
            SekreterProp.Soyad = sekreterSoyadTextbox.Text;
            SekreterProp.Sifre = Convert.ToInt32(sekreterSifreMaskedTextbox.Text);

            Sekreter.AddSekreter(SekreterProp);
            sekreterGridView.DataSource = Sekreter.GetAllSekreter();
            sekreterAdTextbox.Clear();
            sekreterSoyadTextbox.Clear();
            sekreterSifreMaskedTextbox.Clear();
            }
            catch
            {
                MessageBox.Show("HATA MEYDANA GELDİ..." + "\n\n" + "HATA KODU :" + "\n" + " BİR HATA MEYDANA GELDİ");
            }
        }
        private void sekreterSilBtn_Click(object sender, EventArgs e)
        {
            SekreterYönlendirici sekreter = new SekreterYönlendirici();
            foreach (DataGridViewRow row in sekreterGridView.Rows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells[4];
                if (checkbox.Selected == true)
                {
                    sekreter.DeleteSekreter(Convert.ToInt32(row.Cells[0].Value));
                    sekreterGridView.DataSource = sekreter.GetAllSekreter();
                }
            }
        }
        private void sekreterGüncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SekreterYönlendirici sekreter = new SekreterYönlendirici();
                SekreterProps SekreterProp = new SekreterProps();

                SekreterProp.id = Convert.ToInt32(sekreterGridView.CurrentRow.Cells[0].Value);
                SekreterProp.Ad = sekreterAdTextbox.Text;
                SekreterProp.Soyad = sekreterSoyadTextbox.Text;
                SekreterProp.Sifre = Convert.ToInt32(sekreterSifreMaskedTextbox.Text);

                sekreter.UpdateSekreter(SekreterProp);
                sekreterGridView.DataSource = sekreter.GetAllSekreter();
                sekreterAdTextbox.Clear();
                sekreterSoyadTextbox.Clear();
                sekreterSifreMaskedTextbox.Clear();
            }
            catch
            {
                MessageBox.Show("HATA MEYDANA GELDİ..." + "\n\n" + "HATA KODU :" + "\n" + " BİR HATA MEYDANA GELDİ");
            }
        }
    }
}
