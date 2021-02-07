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
    public partial class Form1 : Form
    {
        public static string kullaniciAdi;
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String k_adi, k_sifre;

            k_adi = kullaniciadi_Textbox.Text;
            k_sifre = sifre_Textbox.Text;

            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT sifre FROM kullanicilar WHERE eposta = @eposta", baglanti);
            komut.Parameters.AddWithValue("@eposta", k_adi);

            SqlDataReader oku = komut.ExecuteReader();
            
            while (oku.Read()) 
            {
                if (oku[0].ToString() == k_sifre)
                {
                    kullaniciAdi = k_adi;
                    menu mainMenu = new menu();
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
           
            baglanti.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            kayitol kayitForm = new kayitol();
            kayitForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
