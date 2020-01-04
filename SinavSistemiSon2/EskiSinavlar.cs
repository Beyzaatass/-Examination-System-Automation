using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SinavSistemiSon
{
    public partial class EskiSinavlar : Form
    {
        SinavSistemiEntities DB = new SinavSistemiEntities();
        int[] oran = new int[10];
        public EskiSinavlar()
        {
            InitializeComponent();
        }

        private void SoruKaydetCikisButon_Click(object sender, EventArgs e)
        {
            this.Hide();
            ÖgrenciIndex frm = new ÖgrenciIndex();
            frm.Show();
        }

        private void EskiSinavlar_Load(object sender, EventArgs e)
        {
            //int x = 0;

            //var SinavTarih = (from iv in DB.Tbl_Sinav
            //                  select iv).ToList();

            //IstatistikComboBox.DataSource = SinavTarih;
            //IstatistikComboBox.DisplayMember = "Tarih";
            //IstatistikComboBox.ValueMember = "ID";

            //var istatistik = (from s in DB.Tbl_Sinav
            //                  join i in DB.Tbl_İstatistik on s.ID equals i.SınavID
            //                  join sr in DB.Tbl_Sorular on i.SoruID equals sr.ID
            //                  where sr.KategoriID == x && s.Tarih == SinavTarih.
            //                  select new
            //                  {
            //                      soru = sr.Soru
            //                  }).Count();
            //var dogruSayi = (from s in DB.Tbl_Sinav
            //                 join i in DB.Tbl_İstatistik on s.ID equals i.SınavID
            //                 join sr in DB.Tbl_Sorular on i.SoruID equals sr.ID
            //                 where sr.KategoriID == x && i.Durum == true
            //                 select new
            //                 {
            //                     soru = sr.Soru
            //                 }).Count();


            var istatistik = (from s in DB.Tbl_Sorular
                             join c in DB.Tbl_İstatistik on s.ID equals c.SoruID
                             join k in DB.Tbl_Kategoriler on s.KategoriID equals k.ID
                             select new
                             {
                                 KategoriAdi = k.KategoriAdi,
                                 GenelOran = k.GenelOran
                             }).ToList();

            SınavDogruChart.DataSource = istatistik;
            SınavDogruChart.Series["Sinav"].XValueMember = "KategoriAdi";    
            SınavDogruChart.Series["Sinav"].YValueMembers = "GenelOran";

            //oran[x] = dogruSayi / istatistik;
            //Series seri = this.SınavDogruChart.Series.Add(oran[x]);





            //int[] dogruorani = { 30, 15, 10, 10, 0, 10, 10, 12, 20, 50 };

            //string[] kategoriler = { "Doğal Sayılar", "Mutlak Değer", " Köklü Sayılar", "Kümeler", "Fonksiyonlar", "Üçgenler", "Çember", "Olasılık", "Mantık", "Açılar" };
            //SınavDogruChart.Series["Sinav"].Points.AddXY(string.Format(kategoriler[0].ToString()), int.Parse(dogruorani[0].ToString()));
            //SınavDogruChart.Series["Sinav"].Points.AddXY(string.Format(kategoriler[1].ToString()), int.Parse(dogruorani[1].ToString()));
            //SınavDogruChart.Series["Sinav"].Points.AddXY(string.Format(kategoriler[2].ToString()), int.Parse(dogruorani[2].ToString()));
            //SınavDogruChart.Series["Sinav"].Points.AddXY(string.Format(kategoriler[3].ToString()), int.Parse(dogruorani[3].ToString()));
            //SınavDogruChart.Series["Sinav"].Points.AddXY(string.Format(kategoriler[4].ToString()), int.Parse(dogruorani[4].ToString()));
            //SınavDogruChart.Series["Sinav"].Points.AddXY(string.Format(kategoriler[5].ToString()), int.Parse(dogruorani[5].ToString()));
            //SınavDogruChart.Series["Sinav"].Points.AddXY(string.Format(kategoriler[6].ToString()), int.Parse(dogruorani[6].ToString()));
            //SınavDogruChart.Series["Sinav"].Points.AddXY(string.Format(kategoriler[7].ToString()), int.Parse(dogruorani[7].ToString()));
            //SınavDogruChart.Series["Sinav"].Points.AddXY(string.Format(kategoriler[8].ToString()), int.Parse(dogruorani[8].ToString()));
            //SınavDogruChart.Series["Sinav"].Points.AddXY(string.Format(kategoriler[9].ToString()), int.Parse(dogruorani[9].ToString()));
            //SınavDogruChart.Series["Sinav"].IsValueShownAsLabel = true;

            //SınavDogruChart.Series.Clear();
            //SınavDogruChart.Series.Add("Sinav");



        }
    }
}
