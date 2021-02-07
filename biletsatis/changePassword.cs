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
    public partial class changePassword : Form
    {
        string kullaniciAdi;
        string eskiSifre;
        public changePassword()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            kullaniciAdi = menu.eposta;

            if(yeniSifre_Textbox.Text == yeniSifreTekrar_Textbox.Text) 
            {
                baglanti.Open();

                SqlCommand sifreCheck = new SqlCommand("SELECT sifre FROM kullanicilar WHERE eposta = @eposta", baglanti);
                sifreCheck.Parameters.AddWithValue("@eposta", kullaniciAdi);

                SqlDataReader sifreOku = sifreCheck.ExecuteReader();

                while (sifreOku.Read()) 
                {
                    eskiSifre = sifreOku[0].ToString();
                }

                sifreOku.Close();

                if (eskiSifre_Textbox.Text == eskiSifre)
                {
                    SqlCommand sifreDegistir = new SqlCommand("UPDATE kullanicilar SET sifre = @sifre WHERE eposta = @eposta", baglanti);
                    sifreDegistir.Parameters.AddWithValue("@eposta", kullaniciAdi);
                    sifreDegistir.Parameters.AddWithValue("@sifre", yeniSifreTekrar_Textbox.Text);

                    sifreDegistir.ExecuteNonQuery();
                    MessageBox.Show("Şifre başarıyla değiştirildi!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Eski şifreniz yanlış!");
                }

                baglanti.Close();
            }
            else 
            {
                MessageBox.Show("Girilen şifreler eşleşmiyor!");
            }
        }
    }
}
