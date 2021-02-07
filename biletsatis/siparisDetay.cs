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
using System.Net.Http.Headers;

namespace biletsatis
{
    public partial class siparisDetay : Form
    {
        public siparisDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated security = true;");
        public int biletKodu;

        private void siparisDetay_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand getBilet = new SqlCommand("SELECT biletler.bilet_adi, alanlar.alan, turler.tur_Adi, sehirler.sehir, konumlar.konum_adi, biletler.fiyat, biletler.tarih, konumlar.adres, biletler.foto FROM biletler LEFT JOIN sehirler ON biletler.sehir = sehirler.sehir_kodu LEFT JOIN konumlar ON biletler.konum = konumlar.konum_kodu LEFT JOIN alanlar ON biletler.alan = alanlar.alan_kodu LEFT JOIN turler ON biletler.tur = turler.tur_kodu WHERE bilet_kodu = @biletKodu", baglanti);
            getBilet.Parameters.AddWithValue("@biletKodu", biletKodu);

            SqlDataReader oku = getBilet.ExecuteReader();

            while (oku.Read()) 
            {
                biletAdi_Textbox.Text = oku[0].ToString();
                alan_Text.Text = oku[1].ToString();
                tur_Text.Text = oku[2].ToString();
                sehir_Text.Text = oku[3].ToString();
                konum_Text.Text = oku[4].ToString();
                fiyat_Textbox.Text = oku[5].ToString();
                tarih_Picker.Value = Convert.ToDateTime(oku[6].ToString());
                adres_Text.Text = oku[7].ToString();
                picBox.Image = Image.FromFile(oku[8].ToString());
            }

            oku.Close();

            baglanti.Close();
        }
    }
}
