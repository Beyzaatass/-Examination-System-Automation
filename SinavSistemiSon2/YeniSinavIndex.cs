using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace SinavSistemiSon
{
    public partial class YeniSinavIndex : Form
    {
        SinavSistemiEntities DB = new SinavSistemiEntities();
        public static Tbl_Kisi Kullanici;
        public int KullaniciID ;
        public int cıkısDenetle = 1;

        int i = 0;
        string[,] SorularDizi = new string[51, 6];
        int timerSayac = 0;

        public YeniSinavIndex()
        {
            InitializeComponent();
        }

        public YeniSinavIndex(Tbl_Kisi GelenMusteri)
        {
            InitializeComponent();
            Tbl_Sinav tbl_Sinav = new Tbl_Sinav();
            Kullanici = GelenMusteri;
            KullaniciID = Kullanici.ID;
            var sinavID = (from si in DB.Tbl_Sinav
                           orderby si.ID descending
                           select si).Take(1).FirstOrDefault();

            tbl_Sinav.ID = sinavID.ID + 1;
            //tbl_Sinav.Tarih = DateTime.Now.Date;
            tbl_Sinav.KisiID = KullaniciID;
            DB.Tbl_Sinav.Add(tbl_Sinav);
            DB.SaveChanges();
        }
        private void YeniSinavIndex_Load(object sender, EventArgs e)
        {
           
            for (int sr = 0; sr < 50; sr++)
            {
                soruGetir();
                if (sr == 49)
                {
                    i = 0;
                }
            }
        }
        private void SinavCikisButon_Click(object sender, EventArgs e)
        {
            if(cıkısDenetle==2)
            {
                var sinav = (from ss in DB.Tbl_Sinav
                             orderby ss.ID descending
                             select ss).Take(1).FirstOrDefault();
                DB.Tbl_Sinav.Remove(sinav);
                DB.SaveChanges();
                timer1.Stop();
                this.Hide();
                ÖgrenciIndex frm = new ÖgrenciIndex();
                frm.Show();
            }
            else
               MessageBox.Show("Sınavı bitirmeden çıkış yaparsanız sınavınız kaydedilmeyecektir.");

            cıkısDenetle++;
        }
        private void SinavaBaslaButon_Click(object sender, EventArgs e)
        {
            SinavaBaslaButon.Visible = false;
            Ileri();
            timer1.Start();
        }
        private void YeniSoruButon_Click(object sender, EventArgs e)
        {

            yanlisDogru();
            Ileri();

        }
        private void EskiSoruButon_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                i = 2;
            }
            Geri();
        }
        void soruGetir()
        {
            i++;
            if (0<i && i < 10)
            {
                OlduguSoruSAyisiLbl.Text = Convert.ToString(i);
                var kategori = (from sg in DB.Tbl_Kategoriler
                                orderby sg.GenelOran
                                select sg).Take(1).FirstOrDefault();

                int sayi = kategori.ID;
                Soru(sayi);
            }
            else if (9 < i && i < 18)
            {
                OlduguSoruSAyisiLbl.Text = Convert.ToString(i);
                var kategori = (from sg in DB.Tbl_Kategoriler
                                orderby sg.GenelOran
                                select sg).Skip(1).Take(1).FirstOrDefault();
                int sayi = kategori.ID;
                Soru(sayi);
            }
            else if (17 < i && i < 25)
            {
                OlduguSoruSAyisiLbl.Text = Convert.ToString(i);
                var kategori = (from sg in DB.Tbl_Kategoriler
                                orderby sg.GenelOran
                                select sg).Skip(2).Take(1).FirstOrDefault();
                int sayi = kategori.ID;
                Soru(sayi);
            }
            else if (24 < i && i < 31)
            {
                OlduguSoruSAyisiLbl.Text = Convert.ToString(i);
                var kategori = (from sg in DB.Tbl_Kategoriler
                                orderby sg.GenelOran
                                select sg).Skip(3).Take(1).FirstOrDefault();
                int sayi = kategori.ID;
                Soru(sayi);
            }
            else if (30 < i && i < 36)
            {
                OlduguSoruSAyisiLbl.Text = Convert.ToString(i);
                var kategori = (from sg in DB.Tbl_Kategoriler
                                orderby sg.GenelOran
                                select sg).Skip(4).Take(1).FirstOrDefault();
                int sayi = kategori.ID;
                Soru(sayi);
            }
            else if (35 < i && i < 41)
            {
                OlduguSoruSAyisiLbl.Text = Convert.ToString(i);
                var kategori = (from sg in DB.Tbl_Kategoriler
                                orderby sg.GenelOran
                                select sg).Skip(5).Take(1).FirstOrDefault();
                int sayi = kategori.ID;
                Soru(sayi);
            }
            else if (40 < i && i < 45)
            {
                OlduguSoruSAyisiLbl.Text = Convert.ToString(i);
                var kategori = (from sg in DB.Tbl_Kategoriler
                                orderby sg.GenelOran
                                select sg).Skip(6).Take(1).FirstOrDefault();
                int sayi = kategori.ID;
                Soru(sayi);
            }
            else if (44 < i && i < 48)
            {
                OlduguSoruSAyisiLbl.Text = Convert.ToString(i);
                var kategori = (from sg in DB.Tbl_Kategoriler
                                orderby sg.GenelOran
                                select sg).Skip(7).Take(1).FirstOrDefault();
                int sayi = kategori.ID;
                Soru(sayi);
            }
            else if (47 < i && i < 50)
            {
                OlduguSoruSAyisiLbl.Text = Convert.ToString(i);
                var kategori = (from sg in DB.Tbl_Kategoriler
                                orderby sg.GenelOran
                                select sg).Skip(8).Take(1).FirstOrDefault();
                int sayi = kategori.ID;
                Soru(sayi);
            }
            else if (i == 50)
            {
                OlduguSoruSAyisiLbl.Text = Convert.ToString(i);
                var kategori = (from sg in DB.Tbl_Kategoriler
                                orderby sg.GenelOran
                                select sg).Skip(9).Take(1).FirstOrDefault();
                int sayi = kategori.ID;
                Soru(sayi);
            }
        }
        private void SinavBitirButon_Click(object sender, EventArgs e)
        {
            yanlisDogru();
            sinavKaydet();
            this.Hide();
            ÖgrenciIndex frm = new ÖgrenciIndex();
            frm.Show();
        }
        void Soru(int sayi)
        {
            Random secenekRandom = new Random();
            int dogruSecenekRdn = secenekRandom.Next(4) + 1;
            var soru = (from sr in DB.Tbl_Sorular
                        where sr.KategoriID == sayi
                        orderby Guid.NewGuid()
                        select sr).Take(1);

            foreach (var sorular in soru)
            {
                if (dogruSecenekRdn == 1)
                {
                    SorularDizi[i, 0] = Convert.ToString(sorular.Soru);
                    SorularDizi[i, 1] = Convert.ToString(sorular.DogruSecenek);
                    SorularDizi[i, 2] = Convert.ToString(sorular.Secenek2);
                    SorularDizi[i, 3] = Convert.ToString(sorular.Secenek3);
                    SorularDizi[i, 4] = Convert.ToString(sorular.Secenek1);
                    SorularDizi[i, 5] = Convert.ToString(sorular.SoruResmi);
                }
                else if (dogruSecenekRdn == 2)
                {
                    SorularDizi[i, 0] = Convert.ToString(sorular.Soru);
                    SorularDizi[i, 1] = Convert.ToString(sorular.Secenek2);
                    SorularDizi[i, 2] = Convert.ToString(sorular.DogruSecenek);
                    SorularDizi[i, 3] = Convert.ToString(sorular.Secenek3);
                    SorularDizi[i, 4] = Convert.ToString(sorular.Secenek1);
                    SorularDizi[i, 5] = Convert.ToString(sorular.SoruResmi);
                }
                else if (dogruSecenekRdn == 3)
                {
                    SorularDizi[i, 0] = Convert.ToString(sorular.Soru);
                    SorularDizi[i, 1] = Convert.ToString(sorular.Secenek3);
                    SorularDizi[i, 2] = Convert.ToString(sorular.Secenek2);
                    SorularDizi[i, 3] = Convert.ToString(sorular.DogruSecenek);
                    SorularDizi[i, 4] = Convert.ToString(sorular.Secenek1);
                    SorularDizi[i, 5] = Convert.ToString(sorular.SoruResmi);
                }
                else if (dogruSecenekRdn == 4)
                {
                    SorularDizi[i, 0] = Convert.ToString(sorular.Soru);
                    SorularDizi[i, 1] = Convert.ToString(sorular.Secenek1);
                    SorularDizi[i, 2] = Convert.ToString(sorular.Secenek2);
                    SorularDizi[i, 3] = Convert.ToString(sorular.Secenek3);
                    SorularDizi[i, 4] = Convert.ToString(sorular.DogruSecenek);
                    SorularDizi[i, 5] = Convert.ToString(sorular.SoruResmi);
                }
            }
        }
        void Ileri()
        {
            SecenekARadioButon.Checked = false;
            SecenekBRadioButon.Checked = false;
            SecenekCRadioButon.Checked = false;
            SecenekDRadioButon.Checked = false;
            i++;
            OlduguSoruSAyisiLbl.Text = Convert.ToString(i);
            SoruTextBox.Text = SorularDizi[i, 0];
            SecenekARadioButon.Text = SorularDizi[i, 1];
            SecenekBRadioButon.Text = SorularDizi[i, 2];
            SecenekCRadioButon.Text = SorularDizi[i, 3];
            SecenekDRadioButon.Text = SorularDizi[i, 4];
            SoruResimPicBox.ImageLocation = SorularDizi[i, 5];
            

            if (i != 50)
            {
                SinavBitirButon.Visible = false;
                YeniSoruButon.Enabled = true;
            }
            else
            {
                SinavBitirButon.Visible = true;
                YeniSoruButon.Enabled = false;
            }

            if (i == 50)
                i--;




        }
        void Geri()
        {
            i--;
            OlduguSoruSAyisiLbl.Text = Convert.ToString(i);
            SoruTextBox.Text = SorularDizi[i, 0];
            SecenekARadioButon.Text = SorularDizi[i, 1];
            SecenekBRadioButon.Text = SorularDizi[i, 2];
            SecenekCRadioButon.Text = SorularDizi[i, 3];
            SecenekDRadioButon.Text = SorularDizi[i, 4];
            SoruResimPicBox.ImageLocation = SorularDizi[i, 5];
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerSayac++; 
            ZamanBar.Value = timerSayac;
            if (timerSayac == 600)
            {
                timer1.Stop();
                YeniSoruButon.Enabled = false;
                EskiSoruButon.Enabled = false;
                SinavBitirButon.Visible = true;
                MessageBox.Show("Sınav süreniz bitmiştir.Sınav bitir butonuna basarak devam ediniz.");
            }
                
        }

       void  yanlisDogru()
        {
            Tbl_İstatistik istastik = new Tbl_İstatistik();
            int sinavId;
            var dogruDurum = (from dd in DB.Tbl_Sorular
                              where dd.Soru.StartsWith(SoruTextBox.Text)
                              select dd).FirstOrDefault();
            var sinavID = (from si in DB.Tbl_Sinav
                           orderby si.ID descending
                           select si).Take(1).FirstOrDefault();

            sinavId = sinavID.ID;

            if (SecenekARadioButon.Checked && dogruDurum.DogruSecenek == SecenekARadioButon.Text)
            {
                istastik.SoruID = dogruDurum.ID;
                istastik.SınavID = sinavId;
                istastik.Durum = true;
                DB.Tbl_İstatistik.Add(istastik);
            }
            else if (SecenekBRadioButon.Checked && dogruDurum.DogruSecenek == SecenekBRadioButon.Text)
            {
                istastik.SoruID = dogruDurum.ID;
                istastik.SınavID = sinavId;
                istastik.Durum = true;

                DB.Tbl_İstatistik.Add(istastik);
            }
            else if (SecenekCRadioButon.Checked && dogruDurum.DogruSecenek == SecenekCRadioButon.Text)
            {
                istastik.SoruID = dogruDurum.ID;
                istastik.SınavID = sinavId;
                istastik.Durum = true;

                DB.Tbl_İstatistik.Add(istastik);
            }
            else if (SecenekDRadioButon.Checked && dogruDurum.DogruSecenek == SecenekDRadioButon.Text)
            {
                istastik.SoruID = dogruDurum.ID;
                istastik.SınavID = sinavId;
                istastik.Durum = true;
                DB.Tbl_İstatistik.Add(istastik);

            }
            else
            {
                istastik.Durum = false;
                istastik.SoruID = dogruDurum.ID;
                istastik.SınavID = sinavId;
                DB.Tbl_İstatistik.Add(istastik);
            }  
        }
        void sinavKaydet()
        {
            timer1.Stop();
            DB.SaveChanges();
            var sinavID = (from si in DB.Tbl_Sinav
                         orderby si.ID descending
                         select si).Take(1).FirstOrDefault();
            int sinavId = sinavID.ID;
            int sinavNot = (from sn in DB.Tbl_İstatistik
                            where sn.SınavID == sinavId && sn.Durum == true
                            select sn).Count();
            sinavID.SınavNotu = sinavNot*2;
            sinavID.Tarih = DateTime.Now.Date;
            DB.SaveChanges();
        }
    }
}