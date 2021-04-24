using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Kitaplik_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\AccessDB\Kitaplik.mdb");

        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Kitaplar", baglanti);
            da.Fill(dt);
            dgwKitaplar.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        string durum = "";

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("insert into Kitaplar (KitapAd,Yazar,Tur,Sayfa,Durum) values (@ad,@yazar,@tur,@sayfa,@durum)", baglanti);
            komut1.Parameters.AddWithValue("@ad", txtKitapAdi.Text);
            komut1.Parameters.AddWithValue("@yazar", txtYazar.Text);
            komut1.Parameters.AddWithValue("@tur", cmbTur.Text);
            komut1.Parameters.AddWithValue("@sayfa", txtSayfaSayisi.Text);
            komut1.Parameters.AddWithValue("@durum", durum);
            komut1.ExecuteReader();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void rdbKullanilmis_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void rdbYeni_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dgwKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgwKitaplar.SelectedCells[0].RowIndex;
            txtKitapId.Text = dgwKitaplar.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAdi.Text = dgwKitaplar.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dgwKitaplar.Rows[secilen].Cells[2].Value.ToString();
            cmbTur.Text = dgwKitaplar.Rows[secilen].Cells[3].Value.ToString();
            txtSayfaSayisi.Text = dgwKitaplar.Rows[secilen].Cells[4].Value.ToString();

            if (dgwKitaplar.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                rdbYeni.Checked = true;
            }
            else
            {
                rdbKullanilmis.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Kitaplar where kitapId=@id", baglanti);
            komut.Parameters.AddWithValue("@id", txtKitapId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Silindi", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Kitaplar set KitapAd=@ad,Yazar=@yazar,Tur=@tur,Sayfa=@sayfa,Durum=@durum where KitapId=@id", baglanti);
            komut.Parameters.AddWithValue("@ad", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@tur", cmbTur.Text);
            komut.Parameters.AddWithValue("@sayfa", txtSayfaSayisi.Text);

            if (rdbKullanilmis.Checked == true)
            {
                komut.Parameters.AddWithValue("@durum", durum);
            }
            if (rdbYeni.Checked == true)
            {
                komut.Parameters.AddWithValue("@durum", durum);
            }
            komut.Parameters.AddWithValue("@id", txtKitapId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayit Güncellendi", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from Kitaplar where KitapAd=@ad", baglanti);
            komut.Parameters.AddWithValue("@ad", txtKitapBul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dgwKitaplar.DataSource = dt;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from Kitaplar where KitapAd like '%" + txtKitapBul.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dgwKitaplar.DataSource = dt;
        }
    }
}
