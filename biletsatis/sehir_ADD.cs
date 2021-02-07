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
    public partial class sehir_ADD : Form
    {
        public sehir_ADD()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");
        public String sehirAdiEdit;
        public bool isEdit;

        private void btnSave_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            String sehirAdi;
            sehirAdi = sehirNameTextbox.Text;

            SqlCommand sehirCheck = new SqlCommand("SELECT Count(sehir) as Adet FROM sehirler WHERE sehir = @sehir", baglanti);
            sehirCheck.Parameters.AddWithValue("@sehir", sehirAdi);

            SqlDataReader oku = sehirCheck.ExecuteReader();

            while (oku.Read())
            {
                if (Convert.ToInt32(oku[0]) != 0 && sehirNameTextbox.Text != sehirAdiEdit)
                {
                    MessageBox.Show("Böyle bir kayıt zaten var!");
                }
                else
                {
                    saveSehir(sehirAdi, oku);
                    break;
                }
            }

            baglanti.Close();
        }

        public void saveSehir(String sehirAdi, SqlDataReader dataRead)
        {
            dataRead.Close();
            if (isEdit) 
            {
                SqlCommand sehirUpdate = new SqlCommand("UPDATE sehirler SET sehir = @sehir WHERE sehir = @sehirEdit", baglanti);
                sehirUpdate.Parameters.AddWithValue("@sehir", sehirAdi);
                sehirUpdate.Parameters.AddWithValue("@sehirEdit", sehirAdiEdit);

                sehirUpdate.ExecuteNonQuery();

                baglanti.Close();
                this.Close();
            }
            else 
            {
                SqlCommand sehirKaydet = new SqlCommand("INSERT INTO sehirler(sehir) VALUES(@sehir)", baglanti);
                sehirKaydet.Parameters.AddWithValue("@sehir", sehirAdi);

                sehirKaydet.ExecuteNonQuery();

                baglanti.Close();

                if (checkBoxKapatma.Checked)
                {
                    sehirNameTextbox.Text = "";
                }
                else
                {
                    this.Close();
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sehir_ADD_Load(object sender, EventArgs e)
        {
            if (isEdit) 
            {
                sehirNameTextbox.Text = sehirAdiEdit;
                checkBoxKapatma.Visible = false;
            }
        }
    }
}
