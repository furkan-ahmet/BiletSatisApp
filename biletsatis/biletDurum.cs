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
    public partial class biletDurum : Form
    {
        public biletDurum()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated security = true");

        private void biletDurum_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand biletlerimListe = new SqlCommand("SELECT biletler.bilet_kodu as 'Bilet Kodu', biletler.bilet_adi as 'Adı', sehirler.sehir as 'Şehir', biletler.tarih as 'Tarih' FROM biletler LEFT JOIN sehirler ON biletler.sehir = sehirler.sehir_kodu WHERE durum = 0", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(biletlerimListe);

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();

            editBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\edit_btn.png");
            editBtn.HeaderText = "";
            editBtn.Width = 10;


            DataTable tablo = new DataTable();
            oku.Fill(tablo);

            biletList_table.DataSource = tablo;
            biletList_table.Columns.Add(editBtn);

            DataGridViewColumn kod = biletList_table.Columns[0];
            DataGridViewColumn ad = biletList_table.Columns[1];
            DataGridViewColumn sehir = biletList_table.Columns[2];
            DataGridViewColumn tarih = biletList_table.Columns[3];
            DataGridViewColumn edit = biletList_table.Columns[4];

            kod.Width = 100;
            ad.Width = 160;
            sehir.Width = 80;
            tarih.Width = 120;
            edit.Width = 50;

            baglanti.Close();
        }

        public void editBiletFormClosed(object sender, FormClosedEventArgs e) 
        {
            biletList_table.DataSource = null;
            biletList_table.Columns.Clear();

            baglanti.Open();

            SqlCommand biletlerimListe = new SqlCommand("SELECT biletler.bilet_kodu as 'Bilet Kodu', biletler.bilet_adi as 'Adı', sehirler.sehir as 'Şehir', biletler.tarih as 'Tarih' FROM biletler LEFT JOIN sehirler ON biletler.sehir = sehirler.sehir_kodu WHERE durum = 0", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(biletlerimListe);

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();

            editBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\edit_btn.png");
            editBtn.HeaderText = "";
            editBtn.Width = 10;


            DataTable tablo = new DataTable();
            oku.Fill(tablo);

            biletList_table.DataSource = tablo;
            biletList_table.Columns.Add(editBtn);

            DataGridViewColumn kod = biletList_table.Columns[0];
            DataGridViewColumn ad = biletList_table.Columns[1];
            DataGridViewColumn sehir = biletList_table.Columns[2];
            DataGridViewColumn tarih = biletList_table.Columns[3];
            DataGridViewColumn edit = biletList_table.Columns[4];

            kod.Width = 100;
            ad.Width = 160;
            sehir.Width = 80;
            tarih.Width = 120;
            edit.Width = 50;

            baglanti.Close();
        }

        private void biletList_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4) 
            {
                biletler_ADD editBilet = new biletler_ADD();
                editBilet.biletId = Convert.ToInt32(biletList_table.CurrentRow.Cells[0].Value.ToString());
                editBilet.isAdmin = true;
                editBilet.Show();
                editBilet.FormClosed += editBiletFormClosed;
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            menu mainMenu = new menu();
            mainMenu.Show();
            this.Close();
        }
    }
}
