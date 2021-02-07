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
    public partial class alan_ADD : Form
    {
        public alan_ADD()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");

        public String alanAdiEdit;
        public bool isEdit;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alan_ADD_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            if (isEdit) 
            {
                SqlCommand alanEdit = new SqlCommand("SELECT alan FROM alanlar WHERE alan = @alanEdit", baglanti);
                alanEdit.Parameters.AddWithValue("@alanEdit", alanAdiEdit);

                SqlDataReader oku = alanEdit.ExecuteReader();

                while (oku.Read()) 
                {
                    alanNameTextbox.Text = oku[0].ToString();
                }
                oku.Close();

                checkBoxKapatma.Visible = false;
            }
            baglanti.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand checkAlan = new SqlCommand("SELECT Count(alan_kodu) as 'Adet' FROM alanlar WHERE alan = @alan", baglanti);
            checkAlan.Parameters.AddWithValue("@alan", alanNameTextbox.Text);

            SqlDataReader oku = checkAlan.ExecuteReader();

            while (oku.Read()) 
            {
                if(Convert.ToInt32(oku[0].ToString()) != 0 && alanNameTextbox.Text != alanAdiEdit) 
                {
                    MessageBox.Show("Böyle bir kayıt zaten var!");
                }
                else 
                {
                    saveAlan(oku);
                    break;
                }
            }

            baglanti.Close();
        }

        public void saveAlan(SqlDataReader oku) 
        {
            oku.Close();

            if (isEdit) 
            {
                SqlCommand alanUpdate = new SqlCommand("UPDATE alanlar SET alan = @alan WHERE alan = @alanEdit", baglanti);
                alanUpdate.Parameters.AddWithValue("@alan", alanNameTextbox.Text);
                alanUpdate.Parameters.AddWithValue("@alanEdit", alanAdiEdit);

                alanUpdate.ExecuteNonQuery();
                baglanti.Close();

                this.Close();
            }
            else 
            {
                SqlCommand alanEkle = new SqlCommand("INSERT INTO alanlar(alan) VALUES(@alan)", baglanti);
                alanEkle.Parameters.AddWithValue("@alan", alanNameTextbox.Text);

                alanEkle.ExecuteNonQuery();
                baglanti.Close();

                if (checkBoxKapatma.Checked) 
                {
                    alanNameTextbox.Text = "";
                }
                else 
                {
                    this.Close();
                }
            }
        }
    }
}
