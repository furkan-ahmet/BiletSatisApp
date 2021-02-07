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
using System.Net.Http.Headers;

namespace biletsatis
{
    public partial class sehirlerList : Form
    {
        public sehirlerList()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");
        bool editBtnEnabled = true;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            sehir_ADD sehirEkle = new sehir_ADD();
            btn_Add.Enabled = false;
            sehirEkle.Show();
            sehirEkle.FormClosed += sehirEkleFormClosed;
        }

        private void sehirEkleFormClosed(object sender, FormClosedEventArgs e) 
        {
            btn_Add.Enabled = true;
            editBtnEnabled = true;
            sehirList.DataSource = null;
            sehirList.Columns.Clear();
            baglanti.Open();

            SqlCommand sehirListele = new SqlCommand("SELECT sehir as 'Şehir' FROM sehirler", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(sehirListele);

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
            sehirList.DataSource = tablo;
            sehirList.Columns.Add(editBtn);
            sehirList.Columns.Add(deleteBtn);

            DataGridViewColumn isim = sehirList.Columns[0];
            DataGridViewColumn edit = sehirList.Columns[1];
            DataGridViewColumn delete = sehirList.Columns[2];

            isim.Width = 185;
            edit.Width = 50;
            delete.Width = 50;
            sehirList.AllowUserToResizeColumns = false;

            baglanti.Close();
        }

        public void sehirlerListRefresh() 
        {
            sehirList.DataSource = null;
            sehirList.Columns.Clear();

            SqlCommand sehirListele = new SqlCommand("SELECT sehir as 'Şehir' FROM sehirler", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(sehirListele);

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
            sehirList.DataSource = tablo;
            sehirList.Columns.Add(editBtn);
            sehirList.Columns.Add(deleteBtn);

            DataGridViewColumn isim = sehirList.Columns[0];
            DataGridViewColumn edit = sehirList.Columns[1];
            DataGridViewColumn delete = sehirList.Columns[2];

            isim.Width = 185;
            edit.Width = 50;
            delete.Width = 50;
            sehirList.AllowUserToResizeColumns = false;

            baglanti.Close();
        }

        private void sehirlerList_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sehirListele = new SqlCommand("SELECT sehir as 'Şehir' FROM sehirler", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(sehirListele);

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
            sehirList.DataSource = tablo;
            sehirList.Columns.Add(editBtn);
            sehirList.Columns.Add(deleteBtn);

            DataGridViewColumn isim = sehirList.Columns[0];
            DataGridViewColumn edit = sehirList.Columns[1];
            DataGridViewColumn delete = sehirList.Columns[2];

            isim.Width = 185;
            edit.Width = 50;
            delete.Width = 50;
            sehirList.AllowUserToResizeColumns = false;

            baglanti.Close();
        }

        private void sehirList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1 && editBtnEnabled) 
            {
                sehir_ADD sehirEdit = new sehir_ADD();
                sehirEdit.isEdit = true;
                sehirEdit.sehirAdiEdit = sehirList.CurrentRow.Cells[0].Value.ToString();
                editBtnEnabled = false;
                sehirEdit.Show();
                sehirEdit.FormClosed += sehirEkleFormClosed;
            }
            else if(e.ColumnIndex == 2) 
            {
                baglanti.Open();

                SqlCommand iadeBilet = new SqlCommand("UPDATE siparisler SET iade = 1 WHERE bilet = (SELECT bilet_kodu FROM biletler WHERE sehir = (SELECT sehir_kodu FROM sehirler WHERE sehir = @sehir))", baglanti);
                iadeBilet.Parameters.AddWithValue("@sehir", sehirList.CurrentRow.Cells[0].Value.ToString());

                SqlCommand deleteBilet = new SqlCommand("DELETE FROM biletler WHERE bilet_kodu = (SELECT bilet_kodu FROM biletler WHERE sehir = (SELECT sehir_kodu FROM sehirler WHERE sehir = @sehir))", baglanti);
                deleteBilet.Parameters.AddWithValue("@sehir", sehirList.CurrentRow.Cells[0].Value.ToString());

                SqlCommand deleteKonum = new SqlCommand("DELETE FROM konumlar WHERE sehir = (SELECT sehir_kodu FROM sehirler WHERE sehir = @sehir)", baglanti);
                deleteKonum.Parameters.AddWithValue("@sehir", sehirList.CurrentRow.Cells[0].Value.ToString());

                SqlCommand deleteSehir = new SqlCommand("DELETE FROM sehirler WHERE sehir = @sehir", baglanti);
                deleteSehir.Parameters.AddWithValue("@sehir", sehirList.CurrentRow.Cells[0].Value.ToString());

                DialogResult result = MessageBox.Show("Kayıt silinecek. Devam edilsin mi ?", "Dikkat!", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes) 
                {
                    iadeBilet.ExecuteNonQuery();
                    deleteBilet.ExecuteNonQuery();
                    deleteKonum.ExecuteNonQuery();
                    deleteSehir.ExecuteNonQuery();
                    sehirlerListRefresh();
                }
                baglanti.Close();
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            menu anaMenu = new menu();
            anaMenu.Show();
            this.Close();
        }
    }
}
