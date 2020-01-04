using System;
using System.Windows.Forms;

namespace SinavSistemiSon
{
    public partial class ÖgretmenIndex : Form
    {
        SinavSistemiEntities DB = new SinavSistemiEntities();
        public ÖgretmenIndex()
        {
            InitializeComponent();
        }
        private void SoruKaydetCikisButon_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginIndex frm = new LoginIndex();
            frm.Show();

        }

        private void ResimEkleButon_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            SoruFotoPic.ImageLocation = openFileDialog1.FileName;
        }

        private void ÖgretmenIndex_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sinavSistemiDataSet.Tbl_Kategoriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_KategorilerTableAdapter.Fill(this.sinavSistemiDataSet.Tbl_Kategoriler);
        }

        private void SoruEkle()
        {
            //Veri Tabanı Bağlantısı
            Tbl_Sorular Soru = new Tbl_Sorular();

            //Sorunun yazılması
            Soru.Soru = SoruRichTextBox.Text;

            //Resmin eklenmesi
            Soru.SoruResmi = SoruFotoPic.ImageLocation;

            //Doğru Cevabın Belirlenmesi
            if (SecenekARadioButon.Checked)
            {
                Soru.DogruSecenek = SecenekATextBox.Text;
                Soru.Secenek1 = SecenekBTextBox.Text;
                Soru.Secenek2 = SecenekCTextBox.Text;
                Soru.Secenek3 = SecenekDTextBox.Text;
            }
            else if (SecenekBRadioButon.Checked)
            {
                Soru.DogruSecenek = SecenekBTextBox.Text;
                Soru.Secenek1 = SecenekATextBox.Text;
                Soru.Secenek2 = SecenekCTextBox.Text;
                Soru.Secenek3 = SecenekDTextBox.Text;
            }
            else if (SecenekCRadioButon.Checked)
            {
                Soru.DogruSecenek = SecenekCTextBox.Text;
                Soru.Secenek1 = SecenekATextBox.Text;
                Soru.Secenek2 = SecenekBTextBox.Text;
                Soru.Secenek3 = SecenekDTextBox.Text;
            }
            else if (SecenekDRadioButon.Checked)
            {
                Soru.DogruSecenek = SecenekDTextBox.Text;
                Soru.Secenek1 = SecenekATextBox.Text;
                Soru.Secenek2 = SecenekBTextBox.Text;
                Soru.Secenek3 = SecenekCTextBox.Text;
            }

            //kategorinin belirlenmesi
            if (KategoriDropDown.Text == "Kümeler")
            {
                Soru.KategoriID = 4;
            }
            else if (KategoriDropDown.Text == "Doğal Sayılar")
            {
                Soru.KategoriID = 1;
            }
            else if (KategoriDropDown.Text == "Mutlak Değer")
            {
                Soru.KategoriID = 2;
            }
            else if (KategoriDropDown.Text == "Köklü Sayılar")
            {
                Soru.KategoriID = 3;
            }
            else if (KategoriDropDown.Text == "Fonksiyonlar")
            {
                Soru.KategoriID = 5;
            }
            else if (KategoriDropDown.Text == "Üçgenler")
            {
                Soru.KategoriID = 6;
            }
            else if (KategoriDropDown.Text == "Çember")
            {
                Soru.KategoriID = 7;
            }
            else if (KategoriDropDown.Text == "Olasılık")
            {
                Soru.KategoriID = 8;
            }
            else if (KategoriDropDown.Text == "Mantık")
            {
                Soru.KategoriID = 9;
            }
            else if (KategoriDropDown.Text == "Açılar")
            {
                Soru.KategoriID = 10;
            }
            //else if (KategoriDropDown.Text == "Doğal Sayılar")
            //{
            //    Soru.KategoriID = 1;
            //}
            else
                MessageBox.Show("Kategori Seçiniz!");


            //Veri tabanı kaydetmesi ve kontroller
            if (SoruRichTextBox.Text != "" && SecenekATextBox.Text != "" && SecenekBTextBox.Text != "" && SecenekCTextBox.Text != "" && SecenekDTextBox.Text != "" && (SecenekARadioButon.Checked || SecenekBRadioButon.Checked || SecenekCRadioButon.Checked || SecenekDRadioButon.Checked))
            {
                DB.Tbl_Sorular.Add(Soru);
                DB.SaveChanges();
            }
            else MessageBox.Show("SORU BİLGİLERİNİ BOŞ BIRAKMAYINIZ!");
        }

        private void SoruKaydetButon_Click(object sender, EventArgs e)
        {
            SoruEkle();
            MessageBox.Show("Kaydedildi..");
        }

        private void SoruSilButon_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoruDuzenleIndex frm = new SoruDuzenleIndex();
            frm.Show();
        }

        private void FontAyarlaButon_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            this.SoruRichTextBox.Font = fontDialog1.Font;
        }
    }
}
