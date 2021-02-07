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
    public partial class turlerList : Form
    {
        public turlerList()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");
        bool editBtnEnabled = true;
        public void turListRefresh() 
        {
            turList.DataSource = null;
            turList.Columns.Clear();


            SqlCommand turListele = new SqlCommand("SELECT turler.tur_adi as 'Tür', alanlar.alan as 'Alan' FROM turler LEFT JOIN alanlar ON turler.alan = alanlar.alan_kodu", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(turListele);

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
            turList.DataSource = tablo;
            turList.Columns.Add(editBtn);
            turList.Columns.Add(deleteBtn);

            DataGridViewColumn tur = turList.Columns[0];
            DataGridViewColumn alan = turList.Columns[1];
            DataGridViewColumn edit = turList.Columns[2];
            DataGridViewColumn delete = turList.Columns[3];

            tur.Width = 92;
            alan.Width = 92;
            edit.Width = 50;
            delete.Width = 50;
            turList.AllowUserToResizeColumns = false;
        }

        public void turAddFormClosed(object sender, FormClosedEventArgs e) 
        {
            btn_Add.Enabled = true;
            editBtnEnabled = true;
            turList.DataSource = null;
            turList.Columns.Clear();

            baglanti.Open();

            SqlCommand turListele = new SqlCommand("SELECT turler.tur_adi as 'Tür', alanlar.alan as 'Alan' FROM turler LEFT JOIN alanlar ON turler.alan = alanlar.alan_kodu", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(turListele);

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
            turList.DataSource = tablo;
            turList.Columns.Add(editBtn);
            turList.Columns.Add(deleteBtn);

            DataGridViewColumn tur = turList.Columns[0];
            DataGridViewColumn alan = turList.Columns[1];
            DataGridViewColumn edit = turList.Columns[2];
            DataGridViewColumn delete = turList.Columns[3];

            tur.Width = 92;
            alan.Width = 92;
            edit.Width = 50;
            delete.Width = 50;
            turList.AllowUserToResizeColumns = false;

            baglanti.Close();
        }

        private void turlerList_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand turListele = new SqlCommand("SELECT turler.tur_adi as 'Tür', alanlar.alan as 'Alan' FROM turler LEFT JOIN alanlar ON turler.alan = alanlar.alan_kodu", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(turListele);

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
            turList.DataSource = tablo;
            turList.Columns.Add(editBtn);
            turList.Columns.Add(deleteBtn);

            DataGridViewColumn tur = turList.Columns[0];
            DataGridViewColumn alan = turList.Columns[1];
            DataGridViewColumn edit = turList.Columns[2];
            DataGridViewColumn delete = turList.Columns[3];

            tur.Width = 92;
            alan.Width = 92;
            edit.Width = 50;
            delete.Width = 50;
            turList.AllowUserToResizeColumns = false;

            baglanti.Close();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            menu mainMenu = new menu();
            mainMenu.Show();
            this.Close();
        }

        private void turList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2 && editBtnEnabled) 
            {
                tur_ADD turEdit = new tur_ADD();
                turEdit.isEdit = true;
                turEdit.turAdiEdit = turList.CurrentRow.Cells[0].Value.ToString();

                baglanti.Open();

                SqlCommand turAlanKodu = new SqlCommand("SELECT alan FROM turler WHERE tur_adi = @turAdi", baglanti);
                turAlanKodu.Parameters.AddWithValue("@turAdi", turList.CurrentRow.Cells[0].Value.ToString());

                SqlDataReader oku = turAlanKodu.ExecuteReader();

                while (oku.Read()) 
                {
                    turEdit.alanValEdit = oku[0].ToString();
                }

                oku.Close();
                baglanti.Close();

                editBtnEnabled = false;
                turEdit.Show();
                turEdit.FormClosed += turAddFormClosed;
            }
            else if(e.ColumnIndex == 3) 
            {
                baglanti.Open();

                SqlCommand iadeBilet = new SqlCommand("UPDATE siparisler SET iade = 1 WHERE bilet = (SELECT bilet_kodu FROM biletler WHERE tur = (SELECT tur_kodu FROM turler WHERE tur_adi = @turAdi))", baglanti);
                iadeBilet.Parameters.AddWithValue("@turAdi", turList.CurrentRow.Cells[0].Value.ToString());

                SqlCommand deleteBilet = new SqlCommand("DELETE FROM biletler WHERE tur = (SELECT tur_kodu FROM turler WHERE tur_adi = @turAdi)", baglanti);
                deleteBilet.Parameters.AddWithValue("@turAdi", turList.CurrentRow.Cells[0].Value.ToString());

                SqlCommand turSil = new SqlCommand("DELETE FROM turler WHERE tur_adi = @turAdi", baglanti);
                turSil.Parameters.AddWithValue("@turadi", turList.CurrentRow.Cells[0].Value.ToString());

                DialogResult result = MessageBox.Show("Kayıt silinecek. Devam edilsin mi ?", "Dikkat!", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes) 
                {
                    iadeBilet.ExecuteNonQuery();
                    deleteBilet.ExecuteNonQuery();
                    turSil.ExecuteNonQuery();
                    turListRefresh();
                }

                baglanti.Close();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            tur_ADD turEkle = new tur_ADD();
            btn_Add.Enabled = false;
            turEkle.Show();
            turEkle.FormClosed += turAddFormClosed;
        }
    }
}
