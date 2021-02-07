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
    public partial class menu : Form
    {
        public string kullaniciAdi;
        public static string ad, soyad, eposta;
        public int kullaniciId;

        public menu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Form1 girisEkrani = new Form1();
            girisEkrani.Show();
            this.Close();
        }

        private void btn_Biletler_Click(object sender, EventArgs e)
        {
            bilet_List biletListe = new bilet_List();
            biletListe.kullaniciKodu = kullaniciId;
            biletListe.Show();
            this.Close();
        }

        private void btn_Kulllanicilar_Click(object sender, EventArgs e)
        {
            kullanicilar kullaniciListe = new kullanicilar();
            kullaniciListe.Show();
            this.Close();
        }

        private void btn_Sehirler_Click(object sender, EventArgs e)
        {
            sehirlerList sehirListesi = new sehirlerList();
            sehirListesi.Show();
            this.Close();
        }

        private void btn_Konumlar_Click(object sender, EventArgs e)
        {
            konumlarList konumlistesi = new konumlarList();
            konumlistesi.Show();
            this.Close();
        }

        private void btn_Alanlar_Click(object sender, EventArgs e)
        {
            alanlarList alanListesi = new alanlarList();
            alanListesi.Show();
            this.Close();
        }

        private void btn_Turler_Click(object sender, EventArgs e)
        {
            turlerList turListesi = new turlerList();
            turListesi.Show();
            this.Close();
        }

        private void btn_Biletlerim_Click(object sender, EventArgs e)
        {
            biletlerimList biletlerimListesi = new biletlerimList();
            biletlerimListesi.kullaniciAdi = kullaniciAdi;
            biletlerimListesi.Show();
            this.Close();
        }

        private void btn_Istekler_Click(object sender, EventArgs e)
        {
            biletDurum biletDurumList = new biletDurum();
            biletDurumList.Show();
            this.Close();
        }

        private void btn_Siparisler_Click(object sender, EventArgs e)
        {
            siparisler siparisList = new siparisler();
            siparisList.kullaniciId = kullaniciId;
            siparisList.Show();
            this.Close();
        }

        private void btn_Ayarlar_Click(object sender, EventArgs e)
        {
            profil profilForm = new profil();
            profilForm.Show();
            this.Close();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            kullaniciAdi = Form1.kullaniciAdi;

            baglanti.Open();

            SqlCommand getKullanici = new SqlCommand("SELECT id, ad, soyad, eposta, rol FROM kullanicilar WHERE eposta = @eposta", baglanti);
            getKullanici.Parameters.AddWithValue("@eposta", kullaniciAdi);

            SqlDataReader kullaniciAdiOku = getKullanici.ExecuteReader();

            while (kullaniciAdiOku.Read())
            {
                kullaniciId = Convert.ToInt32(kullaniciAdiOku[0].ToString());
                ad = kullaniciAdiOku[1].ToString();
                soyad = kullaniciAdiOku[2].ToString();
                eposta = kullaniciAdiOku[3].ToString();

                label_adsoyadA.Text = ad + " " + soyad;

                if(kullaniciAdiOku[4].ToString() == "1") 
                {
                    this.Size = new System.Drawing.Size(264, 163);
                    this.MaximumSize = new Size(264, 163);
                    this.MinimumSize = new Size(264, 163);

                    btn_Biletlerim.Visible = false;
                    btn_Istekler.Visible = false;
                    btn_Kulllanicilar.Visible = false;
                    btn_Alanlar.Visible = false;
                    btn_Turler.Visible = false;
                    btn_Sehirler.Visible = false;
                    btn_Konumlar.Visible = false;

                    btn_Ayarlar.Location = new Point(166, 83);
                    btn_Cikis.Location = new Point(12, 83);
                }
                else if (kullaniciAdiOku[4].ToString() == "2")
                {
                    this.Size = new System.Drawing.Size(264, 193);
                    this.MaximumSize = new Size(264, 193);
                    this.MinimumSize = new Size(264, 193);

                    btn_Biletlerim.Visible = true;
                    btn_Istekler.Visible = false;
                    btn_Kulllanicilar.Visible = false;
                    btn_Alanlar.Visible = false;
                    btn_Turler.Visible = false;
                    btn_Sehirler.Visible = false;
                    btn_Konumlar.Visible = false;

                    btn_Ayarlar.Location = new Point(166, 123);
                    btn_Cikis.Location = new Point(12, 123);
                }
                else 
                {
                    this.Size = new System.Drawing.Size(264, 306);
                    this.MaximumSize = new Size(264, 306);
                    this.MinimumSize = new Size(264, 306);

                    btn_Biletlerim.Visible = true;
                    btn_Istekler.Visible = true;
                    btn_Kulllanicilar.Visible = true;
                    btn_Alanlar.Visible = true;
                    btn_Turler.Visible = true;
                    btn_Sehirler.Visible = true;
                    btn_Konumlar.Visible = true;

                    btn_Ayarlar.Location = new Point(166, 234);
                    btn_Cikis.Location = new Point(12, 234);
                }
            }

            kullaniciAdiOku.Close();

            baglanti.Close();
        }
    }
}
