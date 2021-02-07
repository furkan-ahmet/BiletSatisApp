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
    public partial class alanlarList : Form
    {
        public alanlarList()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");
        bool editBtnEnabled = true;
        public void alanRefresh() 
        {
            alanList.DataSource = null;
            alanList.Columns.Clear();

            SqlCommand alanListele = new SqlCommand("SELECT alan as 'Alan' FROM alanlar", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(alanListele);

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
            alanList.DataSource = tablo;
            alanList.Columns.Add(editBtn);
            alanList.Columns.Add(deleteBtn);

            DataGridViewColumn isim = alanList.Columns[0];
            DataGridViewColumn edit = alanList.Columns[1];
            DataGridViewColumn delete = alanList.Columns[2];

            isim.Width = 185;
            edit.Width = 50;
            delete.Width = 50;
            alanList.AllowUserToResizeColumns = false;
        }

        public void alanlarAddFormClosed(object sender, FormClosedEventArgs e) 
        {
            editBtnEnabled = true;
            btn_Add.Enabled = true;
            alanList.DataSource = null;
            alanList.Columns.Clear();

            baglanti.Open();

            SqlCommand alanListele = new SqlCommand("SELECT alan as 'Alan' FROM alanlar", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(alanListele);

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
            alanList.DataSource = tablo;
            alanList.Columns.Add(editBtn);
            alanList.Columns.Add(deleteBtn);

            DataGridViewColumn isim = alanList.Columns[0];
            DataGridViewColumn edit = alanList.Columns[1];
            DataGridViewColumn delete = alanList.Columns[2];

            isim.Width = 185;
            edit.Width = 50;
            delete.Width = 50;
            alanList.AllowUserToResizeColumns = false;


            baglanti.Close();
        }

        private void alanlarList_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand alanListele = new SqlCommand("SELECT alan as 'Alan' FROM alanlar", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(alanListele);

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
            alanList.DataSource = tablo;
            alanList.Columns.Add(editBtn);
            alanList.Columns.Add(deleteBtn);

            DataGridViewColumn isim = alanList.Columns[0];
            DataGridViewColumn edit = alanList.Columns[1];
            DataGridViewColumn delete = alanList.Columns[2];

            isim.Width = 185;
            edit.Width = 50;
            delete.Width = 50;
            alanList.AllowUserToResizeColumns = false;


            baglanti.Close();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            menu anaMenu = new menu();
            anaMenu.Show();
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            alan_ADD alanEkle = new alan_ADD();
            alanEkle.Show();
            btn_Add.Enabled = false;
            alanEkle.FormClosed += alanlarAddFormClosed;
        }

        private void alanList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1 && editBtnEnabled) 
            {
                alan_ADD alanEdit = new alan_ADD();
                alanEdit.isEdit = true;
                alanEdit.alanAdiEdit = alanList.CurrentRow.Cells[0].Value.ToString();
                alanEdit.Show();
                editBtnEnabled = false;
                alanEdit.FormClosed += alanlarAddFormClosed;
            }
            else if(e.ColumnIndex == 2) 
            {
                baglanti.Open();

                SqlCommand iadeSiparis = new SqlCommand("UPDATE siparisler SET iade = 1 WHERE bilet = (SELECT bilet_kodu FROM biletler WHERE alan = (SELECT alan_kodu FROM alanlar WHERE alan = @alan))", baglanti);
                iadeSiparis.Parameters.AddWithValue("@alan", alanList.CurrentRow.Cells[0].Value.ToString());

                SqlCommand deleteBilet = new SqlCommand("DELETE FROM biletler WHERE alan = (SELECT alan_kodu FROM alanlar WHERE alan = @alan)", baglanti);
                deleteBilet.Parameters.AddWithValue("@alan", alanList.CurrentRow.Cells[0].Value.ToString());

                SqlCommand deleteTur = new SqlCommand("DELETE FROM turler WHERE alan = (SELECT alan_kodu FROM alanlar WHERE alan = @alan)", baglanti);
                deleteTur.Parameters.AddWithValue("@alan", alanList.CurrentRow.Cells[0].Value.ToString());

                SqlCommand deleteAlan = new SqlCommand("DELETE FROM alanlar WHERE alan = @alan", baglanti);
                deleteAlan.Parameters.AddWithValue("@alan", alanList.CurrentRow.Cells[0].Value.ToString());

                DialogResult result = MessageBox.Show("Kayıt silinecek. Devam edilsin mi ?", "Dikkat!", MessageBoxButtons.YesNo);
                
                if(result == DialogResult.Yes) 
                {
                    iadeSiparis.ExecuteNonQuery();
                    deleteBilet.ExecuteNonQuery();
                    deleteTur.ExecuteNonQuery();
                    deleteAlan.ExecuteNonQuery();
                    alanRefresh();
                }

                baglanti.Close();
            }
        }
    }
}
