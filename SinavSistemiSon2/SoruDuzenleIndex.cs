using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemiSon
{
    public partial class SoruDuzenleIndex : Form
    {
        SinavSistemiEntities DB = new SinavSistemiEntities();
        public SoruDuzenleIndex()
        {
            InitializeComponent();
        }

        private void SoruDuzenleIndex_Load(object sender, EventArgs e)
        {
            soruGoruntule();
        }

        private void SorularDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SoruDuzenleTextBox.Text = SorularDataGrid.CurrentRow.Cells[0].Value.ToString();
            ADuzenleTextBox.Text = SorularDataGrid.CurrentRow.Cells[1].Value.ToString();
            BDuzenleTextBox.Text = SorularDataGrid.CurrentRow.Cells[2].Value.ToString();
            CDuzenleTextBox.Text = SorularDataGrid.CurrentRow.Cells[3].Value.ToString();
            DogruDuzenleTextBox.Text = SorularDataGrid.CurrentRow.Cells[4].Value.ToString();
            SilGuncelleLbl.Text = SorularDataGrid.CurrentRow.Cells[0].Value.ToString();
        }

        private void SorularSilButon_Click(object sender, EventArgs e)
        {
            string sil = SilGuncelleLbl.Text;
            //var soruSil = (from sr in DB.Tbl_Sorular
            //               where sr.Soru.StartsWith(sil)
            //               select sr);
            var soruSil = DB.Tbl_Sorular.Where(w => w.Soru == sil).FirstOrDefault();
            DB.Tbl_Sorular.Remove(soruSil);
            DB.SaveChanges();
            soruGoruntule();

        }

        private void SorularGuncelleButon_Click(object sender, EventArgs e)
        {
            string guncelle = SilGuncelleLbl.Text;
            var soruGuncelle = DB.Tbl_Sorular.Where(w => w.Soru == guncelle).FirstOrDefault();
            soruGuncelle.Soru = SoruDuzenleTextBox.Text;
            soruGuncelle.Secenek1 = ADuzenleTextBox.Text;
            soruGuncelle.Secenek2 = BDuzenleTextBox.Text;
            soruGuncelle.Secenek3 = CDuzenleTextBox.Text;
            soruGuncelle.DogruSecenek = DogruDuzenleTextBox.Text;

            DB.SaveChanges();
            soruGoruntule();
        }
        void soruGoruntule()
        {
            var sorularVeri = (from sr in DB.Tbl_Sorular
                               select new
                               {
                                   sr.Soru,
                                   sr.Secenek1,
                                   sr.Secenek2,
                                   sr.Secenek3,
                                   sr.DogruSecenek,
                               });
            SorularDataGrid.DataSource = sorularVeri.ToList();
        }

        private void SinavCikisButon_Click(object sender, EventArgs e)
        {
            ÖgretmenIndex frm = new ÖgretmenIndex();
            this.Hide();
            frm.Show();
        }
    }
}