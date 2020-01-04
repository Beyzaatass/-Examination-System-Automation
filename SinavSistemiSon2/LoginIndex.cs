using System;
using System.Linq;
using System.Windows.Forms;

namespace SinavSistemiSon
{
    public partial class LoginIndex : Form
    {
        SinavSistemiEntities DB = new SinavSistemiEntities();
        public LoginIndex()
        {
            InitializeComponent();
        }

        private void GirisYap()
        {
            if (LoginOgretmenRadioButon.Checked)
            {
                try
                {
                    Tbl_Kisi _Ogretmen = DB.Tbl_Kisi.First(s => s.kullaniciAdi == LoginAdTextBox.Text.Trim() && s.sifre == LoginSifreTestBox.Text.Trim() && s.rolID == 1);
                    this.Hide();
                    ÖgretmenIndex frm = new ÖgretmenIndex();
                    frm.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kullanıcı adı yada şifre hatası");
                    return;
                }
            }
            if (LoginOgrenciRadioButon.Checked)
            {
                try
                {
                    Tbl_Kisi _Ogrenci = DB.Tbl_Kisi.First(s => s.kullaniciAdi == LoginAdTextBox.Text.Trim() && s.sifre == LoginSifreTestBox.Text.Trim() && s.rolID == 2);
                    YeniSinavIndex frm2 = new YeniSinavIndex(_Ogrenci);
                    this.Hide();
                    ÖgrenciIndex frm = new ÖgrenciIndex();
                    frm.Show();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Kullanıcı adı yada şifre hatası");
                    return;
                }
            }

           
        }

        private void LoginGirisButon_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void LoginCikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
