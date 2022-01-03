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
    public partial class Arac : Form
    {
        public Arac()
        {
            InitializeComponent();
        }
        GaleriEntities baglanti = new GaleriEntities();
        public void Goruntule()
        {
            bunifuCustomDataGrid1.DataSource = baglanti.Araclars.ToList();
        }

        public void AlanTemizle()
        {
            txtAracAdet.Text = "";
            txtAracFiyat.Text = "";
            txtAracMarka.Text = "";
            txtAracModel.Text = "";
            txtAracMotor.Text = "";
            comboBox1.Text = "";
            txtAracOzellik.Text = "";
            txtAracPaket.Text = "";
            txtAracRenk.Text = "";
            txtAracSubeNo.Text = "";
            txtAracYil.Text = "";
            
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = bunifuCustomDataGrid1.CurrentRow;
            txtAracFiyat.Tag = satir.Cells["AracNo"].Value.ToString();
            txtAracFiyat.Text = satir.Cells["AracFiyat"].Value.ToString();
            txtAracAdet.Text= satir.Cells["AracAdet"].Value.ToString();
            txtAracMarka.Text = satir.Cells["AracMarka"].Value.ToString();
            txtAracModel.Text= satir.Cells["AracModel"].Value.ToString();
            txtAracYil.Text = satir.Cells["AracYil"].Value.ToString();
            txtAracOzellik.Text = satir.Cells["AracOzellik"].Value.ToString();
            txtAracMotor.Text = satir.Cells["AracMotor"].Value.ToString();
            txtAracPaket.Text = satir.Cells["AracPaket"].Value.ToString();
            txtAracRenk.Text = satir.Cells["AracRenk"].Value.ToString();
            txtAracSubeNo.Text = satir.Cells["SubeNo"].Value.ToString();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Goruntule();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Araclar ekle = new Araclar();
            ekle.AracFiyat = Convert.ToInt32(txtAracFiyat.Text);
            ekle.AracAdet = Convert.ToInt32(txtAracAdet.Text);
            ekle.AracMarka = txtAracMarka.Text;
            ekle.AracModel = txtAracModel.Text;
            ekle.AracYil = txtAracYil.Text;
            ekle.AracOzellik = txtAracOzellik.Text;
            ekle.AracMotor = txtAracMotor.Text;
            ekle.AracPaket = txtAracPaket.Text;
            ekle.AracRenk = txtAracRenk.Text;
            ekle.SubeNo = Convert.ToInt32(txtAracSubeNo.Text);
            baglanti.Araclars.Add(ekle);
            baglanti.SaveChanges();
            Goruntule();
            AlanTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtAracFiyat.Tag);
            Araclar sil = baglanti.Araclars.SingleOrDefault(a => a.AracNo == no);
            baglanti.Araclars.Remove(sil);
            baglanti.SaveChanges();
            Goruntule();
            AlanTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtAracFiyat.Tag);
            Araclar yenile = baglanti.Araclars.SingleOrDefault(y => y.AracNo == no);
            yenile.AracFiyat = Convert.ToInt32(txtAracFiyat.Text);
            yenile.AracAdet = Convert.ToInt32(txtAracAdet.Text);
            yenile.AracMarka = txtAracMarka.Text;
            yenile.AracModel = txtAracModel.Text;
            yenile.AracYil = txtAracYil.Text;
            yenile.AracOzellik = txtAracOzellik.Text;
            yenile.AracMotor = txtAracMotor.Text;
            yenile.AracPaket = txtAracPaket.Text;
            yenile.AracRenk = txtAracRenk.Text;
            yenile.SubeNo = Convert.ToInt32(txtAracSubeNo.Text);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Arac_Load(object sender, EventArgs e)
        {
            GaleriEntities baglanti = new GaleriEntities();
            comboBox1.DataSource = baglanti.Araclars.ToList();
            comboBox1.ValueMember = "AracNo";
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = baglanti.Araclars.Where(a => a.AracMarka.ToLower().Contains(txtAracMarka.Text) || a.AracMarka.ToUpper().Contains(txtAracMarka.Text)).ToList();
        }

        private void btnModeleGoreSirala_Click(object sender, EventArgs e)
        {
            var sonuc = from a in baglanti.Araclars
                        orderby a.AracMarka descending
                        select a;
            bunifuCustomDataGrid1.DataSource = sonuc.ToList();
        }

        private void btnMarkayaGoreTopFiyat_Click(object sender, EventArgs e)
        {
            var sonuc = from f in baglanti.Araclars
                        group f by f.AracMarka into Grup
                        select new
                        {
                            ToplamFiyat = Grup.Sum(Fiyat => Fiyat.AracAdet*Fiyat.AracFiyat),
                            Marka = Grup.Key
                        };
            bunifuCustomDataGrid1.DataSource = sonuc.ToList();
        }

        private void btnYilaGoreSiralama_Click(object sender, EventArgs e)
        {
            var sonuc = from y in baglanti.Araclars
                        orderby y.AracYil ascending
                        select y;
            bunifuCustomDataGrid1.DataSource = sonuc.ToList();
        }

        private void btnAracSube_Click(object sender, EventArgs e)
        {
            var sonuc = from a in baglanti.Araclars
                        join s in baglanti.Subelers
                        on a.SubeNo equals s.SubeNo
                        select new
                        {
                            a.AracMarka,
                            a.AracModel,
                            a.AracFiyat,
                            a.AracYil,
                            s.SubeAdi,
                            s.SubeNo

                        };
            bunifuCustomDataGrid1.DataSource = sonuc.ToList();

        }

        private void btnAracMusteriSube_Click(object sender, EventArgs e)
        {
            var sonuc = from a in baglanti.Araclars
                        join s in baglanti.Subelers
                        on a.SubeNo equals s.SubeNo
                        join m in baglanti.Musterilers
                        on s.MusteriNo equals m.MusteriNo
                        select new
                        {
                            a.AracMarka,
                            a.AracModel,
                            s.SubeAdi,
                            m.MusteriAdSoyad
                        };
            bunifuCustomDataGrid1.DataSource = sonuc.ToList();
        }
    }
}
