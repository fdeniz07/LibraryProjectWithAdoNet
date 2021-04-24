
namespace Kitaplik_Proje
{
    partial class Form1
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
            this.dgwKitaplar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKitapId = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.rdbKullanilmis = new System.Windows.Forms.RadioButton();
            this.rdbYeni = new System.Windows.Forms.RadioButton();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKitapBul = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwKitaplar
            // 
            this.dgwKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitaplar.Location = new System.Drawing.Point(11, 290);
            this.dgwKitaplar.Margin = new System.Windows.Forms.Padding(2);
            this.dgwKitaplar.Name = "dgwKitaplar";
            this.dgwKitaplar.Size = new System.Drawing.Size(707, 241);
            this.dgwKitaplar.TabIndex = 120;
            this.dgwKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKitaplar_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yazar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tür :";
            // 
            // txtKitapId
            // 
            this.txtKitapId.Enabled = false;
            this.txtKitapId.Location = new System.Drawing.Point(132, 34);
            this.txtKitapId.Margin = new System.Windows.Forms.Padding(2);
            this.txtKitapId.Name = "txtKitapId";
            this.txtKitapId.Size = new System.Drawing.Size(189, 25);
            this.txtKitapId.TabIndex = 100;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(132, 104);
            this.txtYazar.Margin = new System.Windows.Forms.Padding(2);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(189, 25);
            this.txtYazar.TabIndex = 1;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(132, 67);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(189, 25);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // rdbKullanilmis
            // 
            this.rdbKullanilmis.AutoSize = true;
            this.rdbKullanilmis.Location = new System.Drawing.Point(132, 220);
            this.rdbKullanilmis.Margin = new System.Windows.Forms.Padding(2);
            this.rdbKullanilmis.Name = "rdbKullanilmis";
            this.rdbKullanilmis.Size = new System.Drawing.Size(102, 22);
            this.rdbKullanilmis.TabIndex = 4;
            this.rdbKullanilmis.TabStop = true;
            this.rdbKullanilmis.Text = "Kullanilmis";
            this.rdbKullanilmis.UseVisualStyleBackColor = true;
            this.rdbKullanilmis.CheckedChanged += new System.EventHandler(this.rdbKullanilmis_CheckedChanged);
            // 
            // rdbYeni
            // 
            this.rdbYeni.AutoSize = true;
            this.rdbYeni.Location = new System.Drawing.Point(268, 220);
            this.rdbYeni.Margin = new System.Windows.Forms.Padding(2);
            this.rdbYeni.Name = "rdbYeni";
            this.rdbYeni.Size = new System.Drawing.Size(57, 22);
            this.rdbYeni.TabIndex = 5;
            this.rdbYeni.TabStop = true;
            this.rdbYeni.Text = "Yeni";
            this.rdbYeni.UseVisualStyleBackColor = true;
            this.rdbYeni.CheckedChanged += new System.EventHandler(this.rdbYeni_CheckedChanged);
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Siir",
            "Tiyatro"});
            this.cmbTur.Location = new System.Drawing.Point(132, 139);
            this.cmbTur.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(189, 26);
            this.cmbTur.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Durum :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sayfa Sayisi :";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(132, 178);
            this.txtSayfaSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(189, 25);
            this.txtSayfaSayisi.TabIndex = 3;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(360, 34);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(133, 35);
            this.btnListele.TabIndex = 6;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(360, 78);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 35);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(360, 121);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 35);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(360, 166);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(133, 35);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kitaplik_Proje.Properties.Resources.flippingbook1;
            this.pictureBox1.Location = new System.Drawing.Point(522, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kitap Adi :";
            // 
            // txtKitapBul
            // 
            this.txtKitapBul.Location = new System.Drawing.Point(397, 260);
            this.txtKitapBul.Margin = new System.Windows.Forms.Padding(2);
            this.txtKitapBul.Name = "txtKitapBul";
            this.txtKitapBul.Size = new System.Drawing.Size(188, 25);
            this.txtKitapBul.TabIndex = 0;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(589, 261);
            this.btnBul.Margin = new System.Windows.Forms.Padding(2);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(41, 25);
            this.btnBul.TabIndex = 6;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(634, 261);
            this.btnAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(84, 25);
            this.btnAra.TabIndex = 121;
            this.btnAra.Text = "Icerik Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBul;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(729, 542);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.rdbYeni);
            this.Controls.Add(this.rdbKullanilmis);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitapBul);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtKitapId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwKitaplar);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kitaplik";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKitaplar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKitapId;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.RadioButton rdbKullanilmis;
        private System.Windows.Forms.RadioButton rdbYeni;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKitapBul;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnAra;
    }
}

