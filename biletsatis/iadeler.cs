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
    public partial class iadeler : Form
    {
        public iadeler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated security = true;");

        private void iadeler_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand iadeList = new SqlCommand("SELECT siparisler.siparis_kodu as 'Sipariş No', siparisler.bilet as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', siparisler.kullanici as 'Kullanıcı', siparisler.adet as 'Adet' FROM siparisler LEFT JOIN biletler ON siparisler.bilet = biletler.bilet_kodu WHERE siparisler.iade = 1", baglanti);

            DataGridViewImageColumn refundBtn = new DataGridViewImageColumn();

            refundBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\refund_btn.png");
            refundBtn.HeaderText = "";
            refundBtn.Width = 40;

            SqlDataAdapter doldur = new SqlDataAdapter(iadeList);
            DataTable tablo = new DataTable();
            doldur.Fill(tablo);

            iade_List.DataSource = tablo;
            iade_List.Columns.Add(refundBtn);

            DataGridViewColumn biletAdi = iade_List.Columns[2];
            biletAdi.Width = 140;

            baglanti.Close();
        }

        public void refreshList() 
        {
            iade_List.DataSource = null;
            iade_List.Columns.Clear();

            baglanti.Open();

            SqlCommand iadeList = new SqlCommand("SELECT siparisler.siparis_kodu as 'Sipariş No', siparisler.bilet as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', siparisler.kullanici as 'Kullanıcı', siparisler.adet as 'Adet' FROM siparisler LEFT JOIN biletler ON siparisler.bilet = biletler.bilet_kodu WHERE siparisler.iade = 1", baglanti);

            DataGridViewImageColumn refundBtn = new DataGridViewImageColumn();

            refundBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\refund_btn.png");
            refundBtn.HeaderText = "";
            refundBtn.Width = 40;

            SqlDataAdapter doldur = new SqlDataAdapter(iadeList);
            DataTable tablo = new DataTable();
            doldur.Fill(tablo);

            iade_List.DataSource = tablo;
            iade_List.Columns.Add(refundBtn);

            DataGridViewColumn biletAdi = iade_List.Columns[2];
            biletAdi.Width = 140;

            baglanti.Close();
        }

        private void iade_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) 
            {
                DialogResult result = MessageBox.Show("İade yapılacak. Onaylıyor musunuz ?", "Dikkat!", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes) 
                {
                    baglanti.Open();

                    SqlCommand deleteSiparis = new SqlCommand("DELETE FROM siparisler WHERE siparis_kodu = @siparisKodu", baglanti);
                    deleteSiparis.Parameters.AddWithValue("@siparisKodu", iade_List.CurrentRow.Cells[0].Value.ToString());

                    deleteSiparis.ExecuteNonQuery();

                    baglanti.Close();

                    refreshList();
                }
            }
        }
    }
}
