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
    public partial class tur_ADD : Form
    {
        public tur_ADD()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");
        public String turAdiEdit, alanValEdit;
        public bool isEdit;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand turCheck = new SqlCommand("SELECT Count(tur_kodu) as 'Aset' FROM turler WHERE tur_adi = @turAdi", baglanti);
            turCheck.Parameters.AddWithValue("@turAdi", turNameTextbox.Text);

            SqlDataReader oku = turCheck.ExecuteReader();

            while (oku.Read())
            {
                if (Convert.ToInt32(oku[0]) != 0 && turNameTextbox.Text != turAdiEdit)
                {
                    MessageBox.Show("Böyle bir kayıt zaten var!");
                }
                else
                {
                    saveTur(oku);
                    break;
                }
            }

            baglanti.Close();
        }

        public void saveTur(SqlDataReader oku) 
        {
            oku.Close();
            if (isEdit) 
            {
                SqlCommand turUpdate = new SqlCommand("UPDATE turler SET tur_adi = @turAdi, alan = @alan WHERE tur_adi = @turAdiEdit", baglanti);
                turUpdate.Parameters.AddWithValue("@turAdi", turNameTextbox.Text);
                turUpdate.Parameters.AddWithValue("@alan", alanCombobox.SelectedValue);
                turUpdate.Parameters.AddWithValue("@turAdiEdit", turAdiEdit);

                turUpdate.ExecuteNonQuery();
                baglanti.Close();

                this.Close();
            }
            else 
            {
                SqlCommand turSave = new SqlCommand("INSERT INTO turler(tur_adi, alan) VALUES(@turAdi, @alan)", baglanti);
                turSave.Parameters.AddWithValue("@turAdi", turNameTextbox.Text);
                turSave.Parameters.AddWithValue("@alan", alanCombobox.SelectedValue);

                turSave.ExecuteNonQuery();
                baglanti.Close();

                if (kapatmaCheckbox.Checked) 
                {
                    turNameTextbox.Text = "";
                    alanCombobox.SelectedItem = "";
                }
                else 
                {
                    this.Close();
                }
            }
        }

        private void tur_ADD_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand turAlanlarCombo = new SqlCommand("SELECT * FROM alanlar", baglanti);

            SqlDataReader oku = turAlanlarCombo.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(oku);

            alanCombobox.DataSource = tb;
            alanCombobox.DisplayMember = "alan";
            alanCombobox.ValueMember = "alan_kodu";


            if (isEdit) 
            {
                turNameTextbox.Text = turAdiEdit;
                alanCombobox.SelectedValue = alanValEdit;

                kapatmaCheckbox.Visible = false;
            }

            baglanti.Close();
        }
    }
}
