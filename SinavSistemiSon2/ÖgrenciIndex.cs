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
    public partial class ÖgrenciIndex : Form
    { SinavSistemiEntities DB = new SinavSistemiEntities();
        public ÖgrenciIndex()
        {
            InitializeComponent();
        }

        private void SoruKaydetCikisButon_Click(object sender, EventArgs e)
        {
            var sinav = (from ss in DB.Tbl_Sinav
                         orderby ss.ID descending
                         select ss).Take(1).FirstOrDefault();
            DB.Tbl_Sinav.Remove(sinav);
            DB.SaveChanges();

            this.Hide();
            LoginIndex frm = new LoginIndex();
            frm.Show();
        }

        private void YeniSinavButon_Click(object sender, EventArgs e)
        {
            DateTime suanTarih = DateTime.Now.Date;

            var sonSinav = (from ss in DB.Tbl_Sinav
                            orderby ss.ID descending
                            select ss).Skip(1).Take(1).FirstOrDefault();
            DateTime bTarih = Convert.ToDateTime(sonSinav.Tarih);
            DateTime kTarih = Convert.ToDateTime(suanTarih);
            TimeSpan Sonuc = kTarih  - bTarih;

            if(Sonuc.TotalDays > 1)
            {
                this.Hide();
                YeniSinavIndex frm = new YeniSinavIndex();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Günlük sınav hakkınızı kullandınız.");
            }
        }

        private void EskiSinavlarButon_Click(object sender, EventArgs e)
        {
            this.Hide();
            EskiSinavlar frm = new EskiSinavlar();
            frm.Show();
        }

        private void GenelOrtalamaButon_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenelOrtalama frm = new GenelOrtalama();
            frm.Show();
        }
    }
}
