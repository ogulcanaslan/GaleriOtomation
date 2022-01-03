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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        GaleriEntities baglanti = new GaleriEntities();
        public void Goruntule()
        {
            bunifuCustomDataGrid1.DataSource = baglanti.Musterilers.ToList();
        }
        private void Musteri_Load(object sender, EventArgs e)
        {
            GaleriEntities baglanti = new GaleriEntities();
            comboBox1.DataSource = baglanti.Musterilers.ToList();
            comboBox1.ValueMember = "MusteriNo";
        }
        public void AlanTemizle()
        {
            txtMusteriAdSoyad.Text = "";
            txtMusteriBakiye.Text = "";
            comboBox1.Text = "";
            txtMusteriYas.Text = "";
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = bunifuCustomDataGrid1.CurrentRow;
            txtMusteriAdSoyad.Tag = satir.Cells["MusteriNo"].Value.ToString();
            txtMusteriAdSoyad.Text = satir.Cells["MusteriAdSoyad"].Value.ToString();
            txtMusteriYas.Text = satir.Cells["MusteriYas"].Value.ToString();
            txtMusteriBakiye.Text = satir.Cells["MusteriBakiye"].Value.ToString();
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Goruntule();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteriler ekle = new Musteriler();
            ekle.MusteriAdSoyad = txtMusteriAdSoyad.Text;
            ekle.MusteriYas = Convert.ToInt32(txtMusteriYas.Text);
            ekle.MusteriBakiye = Convert.ToDecimal(txtMusteriBakiye.Text);
            baglanti.Musterilers.Add(ekle);
            baglanti.SaveChanges();
            Goruntule();
            AlanTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            int no = Convert.ToInt32(txtMusteriAdSoyad.Tag);
            Musteriler sil = baglanti.Musterilers.SingleOrDefault(a => a.MusteriNo == no);
            baglanti.Musterilers.Remove(sil);
            baglanti.SaveChanges();
            Goruntule();
            AlanTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtMusteriAdSoyad.Tag);
            Musteriler yenile = baglanti.Musterilers.SingleOrDefault(y => y.MusteriNo == no);
            yenile.MusteriAdSoyad = txtMusteriAdSoyad.Text;
            yenile.MusteriYas = Convert.ToInt32(txtMusteriYas.Text);
            yenile.MusteriBakiye = Convert.ToDecimal(txtMusteriBakiye.Text);
            baglanti.SaveChanges();
            Goruntule();
            AlanTemizle();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = baglanti.Musterilers.Where(a => a.MusteriAdSoyad.ToLower().Contains(txtMusteriAdSoyad.Text) || a.MusteriAdSoyad.ToUpper().Contains(txtMusteriAdSoyad.Text)).ToList();
        }

        private void anasayfaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEnZenginMusteri_Click(object sender, EventArgs e)
        {
            var sonuc = from m in baglanti.Musterilers
                        
                        group m by m.MusteriYas into Gruplandir
                        select new
                        {
                            
                            
                            musteriBakiye = Gruplandir.Max(m=> m.MusteriBakiye),
                            
                            musteriYas = Gruplandir.Key,
                            
                        };
            bunifuCustomDataGrid1.DataSource = sonuc.ToList();
                        
                        
                        
        }
    }
    
}
