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
    public partial class Sube : Form
    {
        public Sube()
        {
            InitializeComponent();
        }
        GaleriEntities baglanti = new GaleriEntities();

        public void Goruntule()
        {
            bunifuCustomDataGrid1.DataSource = baglanti.Subelers.ToList();
        }

        private void Sube_Load(object sender, EventArgs e)
        {
            GaleriEntities baglanti = new GaleriEntities();
            comboBox1.DataSource = baglanti.Subelers.ToList();
            comboBox1.ValueMember = "SubeNo";

            /*
 * private formLoad(object sender, Eventargs e)
 * {
 *  GalertiEmtites baglati = galertient...();
 *  ComboBox1.datesource = baglanti.kullaniclars.ToList();
 *  combobox1.ValueMember = "kullanıcıNo";
 * }
 */

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Goruntule();
        }

        public void AlanTemizle()
        {

            txtMusteriNo.Text = "";
            txtSubeAdi.Text = "";
            txtPersonelSayisi.Text = "";
            txtSubeCiro.Text = "";
            
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            Subeler ekle = new Subeler();
            ekle.SubeAdi = txtSubeAdi.Text;
            ekle.SubeCalisanSayisi = Convert.ToInt32(txtPersonelSayisi.Text); 
            ekle.SubeCiro = Convert.ToInt32(txtSubeCiro.Text);
            ekle.MusteriNo = Convert.ToInt32(txtMusteriNo.Text); 
            

            baglanti.Subelers.Add(ekle);
            baglanti.SaveChanges();
            Goruntule();
            AlanTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtSubeAdi.Tag);
            Subeler sil = baglanti.Subelers.SingleOrDefault(a => a.SubeNo == no);
            baglanti.Subelers.Remove(sil);
            baglanti.SaveChanges();
            Goruntule();
            AlanTemizle();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = bunifuCustomDataGrid1.CurrentRow;
            txtSubeAdi.Tag = satir.Cells["SubeNo"].Value.ToString();
            txtSubeAdi.Text = satir.Cells["SubeAdi"].Value.ToString();
            txtPersonelSayisi.Text = satir.Cells["SubeCalisanSayisi"].Value.ToString();
            txtSubeCiro.Text = satir.Cells["SubeCiro"].Value.ToString();
            txtMusteriNo.Text = satir.Cells["MusteriNo"].Value.ToString();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtSubeAdi.Tag);
            Subeler yenile = baglanti.Subelers.SingleOrDefault(z => z.SubeNo == no);
            yenile.SubeAdi = txtSubeAdi.Text;
            yenile.SubeCalisanSayisi = Convert.ToInt32(txtPersonelSayisi.Text); 
            yenile.SubeCiro = Convert.ToDecimal(txtSubeCiro.Text);
            yenile.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
            
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

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = baglanti.Subelers.Where(a => a.SubeAdi.ToLower().Contains(txtSubeAdi.Text) || a.SubeAdi.ToUpper().Contains(txtSubeAdi.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


