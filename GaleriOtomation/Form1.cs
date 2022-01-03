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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Araçlar")
            {
                Arac git = new Arac();
                git.Show();
                this.Hide();
            }
            if (comboBox1.SelectedItem == "Şubeler")
            {
                Sube git = new Sube();
                git.Show();
                this.Hide();
            }
            if (comboBox1.SelectedItem == "Müşteriler")
            {
                Musteri git = new Musteri();
                git.Show();
                this.Hide();
            }
        }
    }
}
