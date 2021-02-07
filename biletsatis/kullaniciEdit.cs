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
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace biletsatis
{
    public partial class kullaniciEdit : Form
    {
        public kullaniciEdit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");
        public String id;

        private void kullaniciEdit_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand rollerCombo = new SqlCommand("SELECT * FROM roller", baglanti);

            SqlDataReader oku = rollerCombo.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(oku);

            rolCombobox.DataSource = tb;
            rolCombobox.DisplayMember = "rol_adi";
            rolCombobox.ValueMember = "rol_kodu";

            oku.Close();

            SqlCommand kullaniciVerisi = new SqlCommand("SELECT kullanicilar.ad, kullanicilar.soyad, kullanicilar.eposta, sehirler.sehir, kullanicilar.rol FROM kullanicilar LEFT JOIN sehirler ON kullanicilar.sehir = sehirler.sehir_kodu WHERE id = @id", baglanti);
            kullaniciVerisi.Parameters.AddWithValue("@id", id);

            SqlDataReader oku2 = kullaniciVerisi.ExecuteReader();

            while (oku2.Read()) 
            {
                adTextbox.Text = oku2[0].ToString();
                soyadTextbox.Text = oku2[1].ToString();
                epostaTextbox.Text = oku2[2].ToString();
                sehirTextbox.Text = oku2[3].ToString();
                rolCombobox.SelectedValue = oku2[4].ToString();
            }

            baglanti.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand kullaniciRolUpdate = new SqlCommand("UPDATE kullanicilar SET rol = @rol WHERE id = @id", baglanti);
            kullaniciRolUpdate.Parameters.AddWithValue("@rol", rolCombobox.SelectedValue.ToString());
            kullaniciRolUpdate.Parameters.AddWithValue("@id", id);

            kullaniciRolUpdate.ExecuteNonQuery();
            this.Close();

            baglanti.Close();
        }
    }
}
