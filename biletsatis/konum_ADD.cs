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
    public partial class konum_ADD : Form
    {
        public konum_ADD()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");

        public String konumAdiEdit, sehirValEdit, adresEdit;
        public bool isEdit;

        private void konum_ADD_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sehirler = new SqlCommand("SELECT * FROM sehirler", baglanti);

            SqlDataReader oku = sehirler.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(oku);

            sehirCombobox.DataSource = tb;
            sehirCombobox.DisplayMember = "sehir";
            sehirCombobox.ValueMember = "sehir_kodu";
            oku.Close();

            if (isEdit) 
            {
                konumNameTextbox.Text = konumAdiEdit;
                sehirCombobox.SelectedValue = sehirValEdit;
                adresTextbox.Text = adresEdit;

                kapatmaCheckbox.Visible = false;
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
            SqlCommand konumCheck = new SqlCommand("SELECT Count(konum_kodu) as 'Adet' FROM konumlar WHERE konum_adi = @konumAdi", baglanti);
            konumCheck.Parameters.AddWithValue("@konumAdi", konumNameTextbox.Text);

            SqlDataReader oku = konumCheck.ExecuteReader();

            while (oku.Read())
            {
                if (Convert.ToInt32(oku[0]) != 0 && konumNameTextbox.Text != konumAdiEdit)
                {
                    MessageBox.Show("Böyle bir kayıt zaten var!");
                }
                else
                {
                    saveKonum(oku);
                    break;
                }
            }
            baglanti.Close();
        }

        public void saveKonum(SqlDataReader dr) 
        {
            dr.Close();

            if (isEdit)
            {
                SqlCommand updateKonum = new SqlCommand("UPDATE konumlar SET konum_adi = @konumAdi, sehir = @sehir, adres = @adres WHERE konum_adi = @konumAdiEdit", baglanti);
                updateKonum.Parameters.AddWithValue("@konumAdi", konumNameTextbox.Text);
                updateKonum.Parameters.AddWithValue("@sehir", sehirCombobox.SelectedValue.ToString());
                updateKonum.Parameters.AddWithValue("@konumAdiEdit", konumAdiEdit);
                updateKonum.Parameters.AddWithValue("@adres", adresTextbox.Text);

                updateKonum.ExecuteNonQuery();

                baglanti.Close();
                this.Close();
            }
            else
            {
                SqlCommand saveKonum = new SqlCommand("INSERT INTO konumlar(konum_adi, sehir, adres) VALUES(@konumAdi, @sehir, @adres)", baglanti);
                saveKonum.Parameters.AddWithValue("@konumAdi", konumNameTextbox.Text);
                saveKonum.Parameters.AddWithValue("@sehir", sehirCombobox.SelectedValue.ToString());
                saveKonum.Parameters.AddWithValue("@adres", adresTextbox.Text);

                saveKonum.ExecuteNonQuery();

                baglanti.Close();

                if (kapatmaCheckbox.Checked)
                {
                    konumNameTextbox.Text = "";
                    sehirCombobox.SelectedItem = "";
                }
                else
                {
                    this.Close();
                }
            }
            
        }
    }
}
