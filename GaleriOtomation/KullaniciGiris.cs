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
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {

        }
        
        private bool GirisYap(string ad, string sifre)
        {
            GaleriEntities baglanti = new GaleriEntities();
            var sorgu = from p in baglanti.Kullanicilars
                        where p.KullaniciAdi == ad
                        && p.KullaniciSifre == sifre
                        select p;

            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (GirisYap(txtKullaniciAdi.Text,txtSifre.Text))
            {
                Form1 git = new Form1();
                MessageBox.Show("Giriş Başarılı");
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl git = new KayitOl();
            git.Show();
            this.Hide();

        }
    }
}
