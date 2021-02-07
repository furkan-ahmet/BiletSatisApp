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
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");
        int sehir;

        private void btnSignup_Click(object sender, EventArgs e)
        {
            String ad, soyad, eposta, sifre;
            ad = ad_Textbox.Text;
            soyad = soyad_Textbox.Text;
            eposta = email_Textbox.Text;
            sifre = sifre2_Textbox.Text;
            sehir = Convert.ToInt32(sehir_Combobox.SelectedValue);

            if (ad_Textbox.Text == "" || soyad_Textbox.Text == "" || email_Textbox.Text == "" || sifre_Textbox.Text == "" || sifre2_Textbox.Text == "" || sehir_Combobox.SelectedItem == null) 
            {
                MessageBox.Show("Hiçbir alan boş bırakılamaz!");
            }
            else 
            {
                baglanti.Open();

                SqlCommand epostaCheck = new SqlCommand("SELECT Count(eposta) as Adet FROM kullanicilar WHERE eposta = @eposta", baglanti);
                epostaCheck.Parameters.AddWithValue("@eposta", eposta);

                SqlDataReader epostaOku = epostaCheck.ExecuteReader();

                while (epostaOku.Read()) 
                {
                    if(Convert.ToInt32(epostaOku[0].ToString()) != 0) 
                    {
                        MessageBox.Show("Bu eposta adresi zaten kayıtlı!");
                        baglanti.Close();
                        return;
                    }
                }

                baglanti.Close();

                if (sifre_Textbox.Text == sifre2_Textbox.Text)
                {
                    baglanti.Open();

                    SqlCommand sql_Kayitol = new SqlCommand("INSERT INTO kullanicilar(ad, soyad, sehir, rol, eposta, sifre) VALUES(@ad, @soyad, @sehir, '1', @eposta, @sifre)", baglanti);
                    sql_Kayitol.Parameters.AddWithValue("@ad", ad);
                    sql_Kayitol.Parameters.AddWithValue("@soyad", soyad);
                    sql_Kayitol.Parameters.AddWithValue("@sehir", sehir);
                    sql_Kayitol.Parameters.AddWithValue("@eposta", eposta);
                    sql_Kayitol.Parameters.AddWithValue("@sifre", sifre);

                    sql_Kayitol.ExecuteNonQuery();

                    baglanti.Close();
                    
                    Form1 girisEkran = new Form1();
                    girisEkran.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifreler eşleşmiyor!");
                }
            }
        }

        private void kayitol_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sql_sehirSelectbox = new SqlCommand("SELECT * FROM sehirler", baglanti);

            SqlDataReader oku = sql_sehirSelectbox.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(oku);

            sehir_Combobox.DataSource = dt;
            sehir_Combobox.DisplayMember = "sehir";
            sehir_Combobox.ValueMember = "sehir_kodu";

            baglanti.Close();
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            Form1 girisEkran = new Form1();
            girisEkran.Show();
            this.Close();
        }
    }
}
