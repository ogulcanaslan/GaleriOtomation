
namespace GaleriOtomation
{
    partial class KullaniciGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiris = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtKullaniciAdi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(53, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE";
            // 
            // btnGiris
            // 
            this.btnGiris.ActiveBorderThickness = 1;
            this.btnGiris.ActiveCornerRadius = 20;
            this.btnGiris.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGiris.ActiveForecolor = System.Drawing.Color.White;
            this.btnGiris.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.ButtonText = "GİRİŞ";
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGiris.IdleBorderThickness = 1;
            this.btnGiris.IdleCornerRadius = 20;
            this.btnGiris.IdleFillColor = System.Drawing.Color.White;
            this.btnGiris.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGiris.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGiris.Location = new System.Drawing.Point(111, 266);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(5);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(181, 41);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(554, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 426);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            // 
            // txtSifre
            // 
            this.txtSifre.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSifre.BorderColorIdle = System.Drawing.Color.MediumBlue;
            this.txtSifre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSifre.BorderThickness = 3;
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSifre.isPassword = true;
            this.txtSifre.Location = new System.Drawing.Point(157, 172);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(179, 36);
            this.txtSifre.TabIndex = 5;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtKullaniciAdi.BorderColorIdle = System.Drawing.Color.MediumBlue;
            this.txtKullaniciAdi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtKullaniciAdi.BorderThickness = 3;
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKullaniciAdi.isPassword = false;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(157, 82);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(179, 36);
            this.txtKullaniciAdi.TabIndex = 6;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Yellow;
            this.linkLabel1.LinkColor = System.Drawing.Color.Crimson;
            this.linkLabel1.Location = new System.Drawing.Point(272, 353);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Üye Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1640, 724);
            this.Controls.Add(this.groupBox1);
            this.Name = "KullaniciGiris";
            this.Text = "KullaniciGiris";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KullaniciGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGiris;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSifre;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtKullaniciAdi;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}