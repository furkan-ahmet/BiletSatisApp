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

namespace biletsatis
{
    public partial class profil : Form
    {
        string kAdi;
        public profil()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            menu mainMenu = new menu();
            mainMenu.Show();
            this.Close();
        }

        private void profil_Load(object sender, EventArgs e)
        {
            kAdi = menu.eposta;

            baglanti.Open();

            SqlCommand sehirLoad = new SqlCommand("SELECT sehir_kodu, sehir FROM sehirler", baglanti);

            SqlDataReader sehirGetir = sehirLoad.ExecuteReader();
            
            DataTable dt = new DataTable();
            dt.Load(sehirGetir);

            sehir_Combobox.DataSource = dt;
            sehir_Combobox.DisplayMember = "sehir";
            sehir_Combobox.ValueMember = "sehir_kodu";

            sehirGetir.Close();

            SqlCommand kullaniciBilgileri = new SqlCommand("SELECT ad, soyad, sehir FROM kullanicilar WHERE eposta = @eposta", baglanti);
            kullaniciBilgileri.Parameters.AddWithValue("@eposta", kAdi);

            SqlDataReader bilgiOku = kullaniciBilgileri.ExecuteReader();

            while (bilgiOku.Read())
            {
                ad_Textbox.Text = bilgiOku[0].ToString();
                soyad_Textbox.Text = bilgiOku[1].ToString();
                eposta_Textbox.Text = kAdi;
                sehir_Combobox.SelectedValue = bilgiOku[2].ToString();
            }

            baglanti.Close();
        }

        private void btn_PassEdit_Click(object sender, EventArgs e)
        {
            changePassword sifreDegistir = new changePassword();
            sifreDegistir.Show();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand bilgileriKaydet = new SqlCommand("UPDATE kullanicilar SET ad = @ad, soyad = @soyad, sehir = @sehir, eposta = @epostaEski WHERE eposta = @eposta", baglanti);
            bilgileriKaydet.Parameters.AddWithValue("@ad", ad_Textbox.Text);
            bilgileriKaydet.Parameters.AddWithValue("@soyad", soyad_Textbox.Text);
            bilgileriKaydet.Parameters.AddWithValue("@sehir", sehir_Combobox.SelectedValue);
            bilgileriKaydet.Parameters.AddWithValue("@eposta", eposta_Textbox.Text);
            bilgileriKaydet.Parameters.AddWithValue("@epostaEski", kAdi);

            bilgileriKaydet.ExecuteNonQuery();

            MessageBox.Show("Bilgiler değiştirildi. Değişikliklerin gerçekleşmesi için tekrar giriş yapın.");
            Form1 girisEkran = new Form1();
            girisEkran.Show();
            this.Close();

            baglanti.Close();
        }
    }
}
