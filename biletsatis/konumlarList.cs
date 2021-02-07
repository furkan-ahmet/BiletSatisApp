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
using System.Security.Policy;

namespace biletsatis
{
    public partial class konumlarList : Form
    {
        public konumlarList()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");
        bool btnEditEnabled = true;
        public void konumRefreshList() 
        {
            konumList.DataSource = null;
            konumList.Columns.Clear();

            SqlCommand konumListele = new SqlCommand("SELECT konumlar.konum_adi as 'Konum', sehirler.sehir as 'Şehir', konumlar.adres as 'Adres' FROM konumlar LEFT JOIN sehirler ON konumlar.sehir = sehirler.sehir_kodu", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(konumListele);

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();
            DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();

            editBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\edit_btn.png");
            editBtn.HeaderText = "";
            editBtn.Width = 10;

            deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
            deleteBtn.HeaderText = "";
            deleteBtn.Width = 10;

            DataTable tablo = new DataTable();
            oku.Fill(tablo);
            konumList.DataSource = tablo;
            konumList.Columns.Add(editBtn);
            konumList.Columns.Add(deleteBtn);

            DataGridViewColumn isim = konumList.Columns[0];
            DataGridViewColumn konum = konumList.Columns[1];
            DataGridViewColumn adres = konumList.Columns[2];
            DataGridViewColumn edit = konumList.Columns[3];
            DataGridViewColumn delete = konumList.Columns[4];

            isim.Width = 92;
            konum.Width = 92;
            adres.Width = 90;
            edit.Width = 50;
            delete.Width = 50;
            konumList.AllowUserToResizeColumns = false;

            baglanti.Close();
        }

        public void konumEkleFormClosed(object sender, FormClosedEventArgs e) 
        {
            btnEditEnabled = true;
            btn_Add.Enabled = true;
            konumList.DataSource = null;
            konumList.Columns.Clear();

            baglanti.Open();

            SqlCommand konumListele = new SqlCommand("SELECT konumlar.konum_adi as 'Konum', sehirler.sehir as 'Şehir', konumlar.adres as 'Adres' FROM konumlar LEFT JOIN sehirler ON konumlar.sehir = sehirler.sehir_kodu", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(konumListele);

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();
            DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();

            editBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\edit_btn.png");
            editBtn.HeaderText = "";
            editBtn.Width = 10;

            deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
            deleteBtn.HeaderText = "";
            deleteBtn.Width = 10;

            DataTable tablo = new DataTable();
            oku.Fill(tablo);
            konumList.DataSource = tablo;
            konumList.Columns.Add(editBtn);
            konumList.Columns.Add(deleteBtn);

            DataGridViewColumn isim = konumList.Columns[0];
            DataGridViewColumn konum = konumList.Columns[1];
            DataGridViewColumn adres = konumList.Columns[2];
            DataGridViewColumn edit = konumList.Columns[3];
            DataGridViewColumn delete = konumList.Columns[4];

            isim.Width = 92;
            konum.Width = 92;
            adres.Width = 90;
            edit.Width = 50;
            delete.Width = 50;
            konumList.AllowUserToResizeColumns = false;

            baglanti.Close();
        }

        private void konumlarList_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand konumListele = new SqlCommand("SELECT konumlar.konum_adi as 'Konum', sehirler.sehir as 'Şehir', konumlar.adres as 'Adres' FROM konumlar LEFT JOIN sehirler ON konumlar.sehir = sehirler.sehir_kodu", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(konumListele);

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();
            DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();

            editBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\edit_btn.png");
            editBtn.HeaderText = "";
            editBtn.Width = 10;

            deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
            deleteBtn.HeaderText = "";
            deleteBtn.Width = 10;

            DataTable tablo = new DataTable();
            oku.Fill(tablo);
            konumList.DataSource = tablo;
            konumList.Columns.Add(editBtn);
            konumList.Columns.Add(deleteBtn);

            DataGridViewColumn isim = konumList.Columns[0];
            DataGridViewColumn konum = konumList.Columns[1];
            DataGridViewColumn adres = konumList.Columns[2];
            DataGridViewColumn edit = konumList.Columns[3];
            DataGridViewColumn delete = konumList.Columns[4];

            isim.Width = 92;
            konum.Width = 92;
            adres.Width = 90;
            edit.Width = 50;
            delete.Width = 50;
            konumList.AllowUserToResizeColumns = false;

            baglanti.Close();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            menu mainMenu = new menu();
            mainMenu.Show();
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            konum_ADD konumEkle = new konum_ADD();
            btn_Add.Enabled = false;
            konumEkle.Show();
            konumEkle.FormClosed += konumEkleFormClosed;
        }

        private void konumList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3 && btnEditEnabled) 
            {
                konum_ADD konumEdit = new konum_ADD();
                konumEdit.isEdit = true;
                konumEdit.sehirValEdit = konumList.CurrentRow.Cells[1].Value.ToString();
                konumEdit.adresEdit = konumList.CurrentRow.Cells[2].Value.ToString();

                baglanti.Open();
                SqlCommand getSehirVal = new SqlCommand("SELECT sehir_kodu FROM sehirler WHERE sehir = @sehir", baglanti);
                getSehirVal.Parameters.AddWithValue("@sehir", konumList.CurrentRow.Cells[1].Value.ToString());
                
                String sehirKodu = "";

                SqlDataReader oku = getSehirVal.ExecuteReader();

                while (oku.Read()) 
                {
                    sehirKodu = oku[0].ToString();
                }

                oku.Close();
                baglanti.Close();

                konumEdit.konumAdiEdit = konumList.CurrentRow.Cells[0].Value.ToString();
                konumEdit.sehirValEdit = sehirKodu;
                btnEditEnabled = false;
                konumEdit.Show();
                konumEdit.FormClosed += konumEkleFormClosed;
            }
            else if(e.ColumnIndex == 4) 
            {
                baglanti.Open();

                SqlCommand iadeBilet = new SqlCommand("UPDATE siparisler SET iade = 1 WHERE bilet = (SELECT bilet_kodu FROM biletler WHERE konum = (SELECT konum_kodu FROM konumlar WHERE konum_adi = @konum))", baglanti);
                iadeBilet.Parameters.AddWithValue("@konum", konumList.CurrentRow.Cells[0].Value.ToString());

                SqlCommand deleteBilet = new SqlCommand("DELETE FROM biletler WHERE konum = (SELECT konum_kodu FROM konumlar WHERE konum_adi = @konum)", baglanti);
                deleteBilet.Parameters.AddWithValue("@konum", konumList.CurrentRow.Cells[0].Value.ToString());

                SqlCommand deleteKonum = new SqlCommand("DELETE FROM konumlar WHERE konum_adi = @konum", baglanti);
                deleteKonum.Parameters.AddWithValue("@konum", konumList.CurrentRow.Cells[0].Value.ToString());

                DialogResult result = MessageBox.Show("Seçilen kayıt silinecek. Devam edilsin mi ?", "Dikkat!", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes) 
                {
                    iadeBilet.ExecuteNonQuery();
                    deleteBilet.ExecuteNonQuery();
                    deleteKonum.ExecuteNonQuery();
                    konumRefreshList();
                }

                baglanti.Close();
            }
        }
    }
}
