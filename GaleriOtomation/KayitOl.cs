using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriOtomation
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        GaleriEntities baglanti = new GaleriEntities();
        private void KayitOl_Load(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == txtSifreTekrar.Text && checkBox1.Checked == true)
            {
                Kullanicilar ekle = new Kullanicilar();
                ekle.KullaniciAdi = txtKullaniciAdi.Text;
                ekle.KullaniciSifre = txtSifreTekrar.Text;
                baglanti.Kullanicilars.Add(ekle);
                baglanti.SaveChanges();
                KullaniciGiris git = new KullaniciGiris();
                git.Show();
                this.Hide();
                MessageBox.Show("Başarıyla Kayıt Olduz");
            }
            else if (checkBox1.Checked == false)
            {
                MessageBox.Show("Kullanıcı Sözleşmesini Kabul Etmediniz");

            }
            else if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Hatalı Bir Giriş Yaptınız");
            }
        }
    }
}
