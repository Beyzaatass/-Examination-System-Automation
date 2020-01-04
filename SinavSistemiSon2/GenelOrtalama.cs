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
    public partial class GenelOrtalama : Form
    {
        SinavSistemiEntities DB = new SinavSistemiEntities();
        public GenelOrtalama()
        {
            InitializeComponent();
        }

        private void SoruKaydetCikisButon_Click(object sender, EventArgs e)
        {
            this.Hide();
            ÖgrenciIndex frm = new ÖgrenciIndex();
            frm.Show();
        }

        private void GenelOrtalama_Load(object sender, EventArgs e)
        {



            var istatistik = (from k in DB.Tbl_Sinav
                              select new
                              {
                                  SinavNotu = k.SınavNotu,
                                  Tarih = k.Tarih
                              }).ToList();

            GenelOrtalamaChart.DataSource = istatistik;
            GenelOrtalamaChart.Series["Sinav"].XValueMember = "Tarih";
            GenelOrtalamaChart.Series["Sinav"].YValueMembers = "SinavNotu";




        }
    }
}
