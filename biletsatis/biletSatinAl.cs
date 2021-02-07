using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace biletsatis
{
    public partial class biletSatinAl : Form
    {
        public biletSatinAl()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated security = true;");
        public int biletKodu, musteriKodu, adet, stok;

        private void biletSatinAl_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand bilet = new SqlCommand("SELECT biletler.bilet_adi, sehirler.sehir, konumlar.konum_adi, alanlar.alan, turler.tur_adi, biletler.fiyat, biletler.tarih, biletler.foto, biletler.stok FROM biletler LEFT JOIN sehirler ON biletler.sehir = sehirler.sehir_kodu LEFT JOIN konumlar ON biletler.konum = konumlar.konum_kodu LEFT JOIN alanlar ON biletler.alan = alanlar.alan_kodu LEFT JOIN turler ON biletler.tur = turler.tur_kodu WHERE bilet_kodu = @biletKodu", baglanti);
            bilet.Parameters.AddWithValue("@biletKodu", biletKodu);

            SqlDataReader oku = bilet.ExecuteReader();

            while (oku.Read()) 
            {
                biletAdi_Textbox.Text = oku[0].ToString();
                sehir_Text.Text = oku[1].ToString();
                konum_Text.Text = oku[2].ToString();
                alan_Text.Text = oku[3].ToString();
                tur_Text.Text = oku[4].ToString();
                fiyat_Textbox.Text = oku[5].ToString();
                tarih_Picker.Value = Convert.ToDateTime(oku[6].ToString());
                picBox.Image = Image.FromFile(oku[7].ToString());
                stok = Convert.ToInt32(oku[8].ToString());
            }

            oku.Close();

            baglanti.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if(adet_Text.Text.Length > 0 && Regex.IsMatch(adet_Text.Text, @"^\d+$")) 
            {
                adet = Convert.ToInt32(adet_Text.Text);
                baglanti.Open();

                SqlCommand satinAl = new SqlCommand("INSERT INTO siparisler(adet, bilet, kullanici, iade) VALUES(@adet, @biletKodu, @kullaniciKodu, 0)", baglanti);
                satinAl.Parameters.AddWithValue("@adet", adet);
                satinAl.Parameters.AddWithValue("@biletKodu", biletKodu);
                satinAl.Parameters.AddWithValue("kullaniciKodu", musteriKodu);

                DialogResult result = MessageBox.Show("Satın almak istediğinize emin misiniz ?", "Satın alım", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes) 
                {
                    satinAl.ExecuteNonQuery();

                    MessageBox.Show("Bilet başarıyla satın alındı!");

                    SqlCommand updateStok = new SqlCommand("UPDATE biletler SET stok = @stok WHERE bilet_kodu = @biletKodu", baglanti);
                    updateStok.Parameters.AddWithValue("@stok", stok - adet);
                    updateStok.Parameters.AddWithValue("@biletKodu", biletKodu);

                    updateStok.ExecuteNonQuery();
                    this.Close();
                }

                baglanti.Close();
            }
            else 
            {
                MessageBox.Show("Geçersiz adet bilgisi!");
            }
        }
    }
}
