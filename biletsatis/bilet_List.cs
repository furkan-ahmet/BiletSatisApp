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
using System.Management.Instrumentation;

namespace biletsatis
{
    public partial class bilet_List : Form
    {
        public bilet_List()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");
        public int kullaniciKodu;
        bool btnEnabled = true;

        public void satinAlFormClosed(object sender, FormClosedEventArgs e) 
        {
            refreshList();
            btnEnabled = true;
        }

        private void bilet_List_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sehirCombo = new SqlCommand("SELECT * FROM sehirler", baglanti);

            SqlDataReader doldur = sehirCombo.ExecuteReader();
            DataTable tb1 = new DataTable();
            tb1.Load(doldur);

            sehir_Select.DataSource = tb1;
            sehir_Select.DisplayMember = "sehir";
            sehir_Select.ValueMember = "sehir_kodu";
            sehir_Select.SelectedIndex = -1;

            doldur.Close();

            SqlCommand alanCombo = new SqlCommand("SELECT * FROM alanlar", baglanti);

            doldur = alanCombo.ExecuteReader();
            DataTable tb2 = new DataTable();
            tb2.Load(doldur);

            alan_Select.DataSource = tb2;
            alan_Select.DisplayMember = "alan";
            alan_Select.ValueMember = "alan_kodu";
            alan_Select.SelectedIndex = -1;

            doldur.Close();

            SqlCommand biletList = new SqlCommand("SELECT biletler.bilet_kodu as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', sehirler.sehir as 'Şehir', konumlar.konum_adi as 'Konum', alanlar.alan as 'Alan', turler.tur_adi as 'Tür', biletler.tarih as 'Tarih ve Saat', biletler.fiyat as 'Fiyat' FROM biletler LEFT JOIN sehirler ON biletler.sehir = sehirler.sehir_kodu LEFT JOIN konumlar ON biletler.konum = konumlar.konum_kodu LEFT JOIN alanlar ON biletler.alan = alanlar.alan_kodu LEFT JOIN turler ON biletler.tur = turler.tur_kodu WHERE biletler.stok > 0 AND biletler.tarih > GETDATE() AND biletler.durum = 1 ORDER BY tarih ", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(biletList);

            DataGridViewImageColumn buyBtn = new DataGridViewImageColumn();

            buyBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\buy.png");
            buyBtn.HeaderText = "";
            buyBtn.Width = 40;

            DataTable tablo = new DataTable();
            oku.Fill(tablo);
            biletList_table.DataSource = tablo;
            biletList_table.Columns.Add(buyBtn);

            DataGridViewColumn biletKod = biletList_table.Columns[0];
            DataGridViewColumn biletAd = biletList_table.Columns[1];
            DataGridViewColumn sehir = biletList_table.Columns[2];
            DataGridViewColumn konum = biletList_table.Columns[3];
            DataGridViewColumn alan = biletList_table.Columns[4];
            DataGridViewColumn tur = biletList_table.Columns[5];
            DataGridViewColumn tarih = biletList_table.Columns[6];
            DataGridViewColumn fiyat = biletList_table.Columns[7];
            DataGridViewColumn buy = biletList_table.Columns[8];

            biletKod.Width = 60;
            fiyat.Width = 80;
            tur.Width = 80;

            baglanti.Close();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            menu mainMenu = new menu();
            mainMenu.Show();
            this.Close();
        }

        private void biletList_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 8 && btnEnabled == true) 
            {
                biletSatinAl satinAl = new biletSatinAl();
                satinAl.biletKodu = Convert.ToInt32(biletList_table.CurrentRow.Cells[0].Value.ToString());
                satinAl.musteriKodu = kullaniciKodu;
                btnEnabled = false;
                satinAl.Show();
                satinAl.FormClosed += satinAlFormClosed;
            }
        }

        public void refreshList() 
        {
            search_Textbox.Text = null;
            sehir_Select.SelectedIndex = -1;
            konum_Select.SelectedIndex = -1;
            alan_Select.SelectedIndex = -1;
            tur_Select.SelectedIndex = -1;

            biletList_table.DataSource = null;
            biletList_table.Columns.Clear();

            baglanti.Open();

            SqlCommand biletList = new SqlCommand("SELECT biletler.bilet_kodu as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', sehirler.sehir as 'Şehir', konumlar.konum_adi as 'Konum', alanlar.alan as 'Alan', turler.tur_adi as 'Tür', biletler.tarih as 'Tarih ve Saat', biletler.fiyat as 'Fiyat' FROM biletler LEFT JOIN sehirler ON biletler.sehir = sehirler.sehir_kodu LEFT JOIN konumlar ON biletler.konum = konumlar.konum_kodu LEFT JOIN alanlar ON biletler.alan = alanlar.alan_kodu LEFT JOIN turler ON biletler.tur = turler.tur_kodu WHERE biletler.stok > 0 AND biletler.tarih > GETDATE() AND biletler.durum = 1 ORDER BY tarih", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(biletList);

            DataGridViewImageColumn buyBtn = new DataGridViewImageColumn();

            buyBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\buy.png");
            buyBtn.HeaderText = "";
            buyBtn.Width = 40;

            DataTable tablo = new DataTable();
            oku.Fill(tablo);
            biletList_table.DataSource = tablo;
            biletList_table.Columns.Add(buyBtn);

            DataGridViewColumn biletKod = biletList_table.Columns[0];
            DataGridViewColumn biletAd = biletList_table.Columns[1];
            DataGridViewColumn sehir = biletList_table.Columns[2];
            DataGridViewColumn konum = biletList_table.Columns[3];
            DataGridViewColumn alan = biletList_table.Columns[4];
            DataGridViewColumn tur = biletList_table.Columns[5];
            DataGridViewColumn tarih = biletList_table.Columns[6];
            DataGridViewColumn fiyat = biletList_table.Columns[7];
            DataGridViewColumn buy = biletList_table.Columns[8];

            biletKod.Width = 60;
            fiyat.Width = 80;
            tur.Width = 80;

            baglanti.Close();
        }

        private void btn_Sifirla_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void alan_Select_SelectionChangeCommitted(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand turCombo = new SqlCommand("SELECT * FROM turler WHERE alan = @alanKodu", baglanti);
            turCombo.Parameters.AddWithValue("@alanKodu", alan_Select.SelectedValue);

            SqlDataReader doldur = turCombo.ExecuteReader();
            DataTable tb3 = new DataTable();
            tb3.Load(doldur);

            tur_Select.DataSource = tb3;
            tur_Select.DisplayMember = "tur_adi";
            tur_Select.ValueMember = "tur_kodu";
            tur_Select.SelectedIndex = -1;

            doldur.Close();

            baglanti.Close();

            searchBilet();
        }

        private void sehir_Select_SelectionChangeCommitted(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand konumCombo = new SqlCommand("SELECT * FROM konumlar WHERE sehir = @sehirKodu", baglanti);
            konumCombo.Parameters.AddWithValue("@sehirKodu", sehir_Select.SelectedValue);

            SqlDataReader doldur = konumCombo.ExecuteReader();
            DataTable tb4 = new DataTable();
            tb4.Load(doldur);

            konum_Select.DataSource = tb4;
            konum_Select.DisplayMember = "konum_adi";
            konum_Select.ValueMember = "konum_kodu";
            konum_Select.SelectedIndex = -1;

            doldur.Close();

            baglanti.Close();

            searchBilet();
        }

        public void searchBilet() 
        {
            biletList_table.DataSource = null;
            biletList_table.Columns.Clear();

            baglanti.Open();

            SqlCommand searchBilet = new SqlCommand("SELECT biletler.bilet_kodu as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', sehirler.sehir as 'Şehir', konumlar.konum_adi as 'Konum', alanlar.alan as 'Alan', turler.tur_adi as 'Tür', biletler.tarih as 'Tarih ve Saat', biletler.fiyat as 'Fiyat' FROM biletler LEFT JOIN sehirler ON biletler.sehir = sehirler.sehir_kodu LEFT JOIN konumlar ON biletler.konum = konumlar.konum_kodu LEFT JOIN alanlar ON biletler.alan = alanlar.alan_kodu LEFT JOIN turler ON biletler.tur = turler.tur_kodu " +
                "WHERE (biletler.bilet_kodu LIKE '%' + @searchBox + '%' OR biletler.bilet_adi LIKE '%' + @searchBox + '%') AND (biletler.sehir LIKE '%' + @sehirCombo + '%') " +
                "AND (biletler.konum LIKE '%' + @konumCombo + '%') AND (biletler.alan LIKE '%' + @alanCombo + '%') AND (biletler.tur LIKE '%' + @turCombo + '%') AND (biletler.stok > 0) AND biletler.tarih > GETDATE() AND biletler.durum = 1 " +
                "ORDER BY tarih", baglanti);
            searchBilet.Parameters.AddWithValue("@searchBox", search_Textbox.Text);

            if (sehir_Select.SelectedIndex != -1)
            {
                searchBilet.Parameters.AddWithValue("@sehirCombo", sehir_Select.SelectedValue.ToString());
            }
            else
            {
                searchBilet.Parameters.AddWithValue("@sehirCombo", "");
            }

            if (konum_Select.SelectedIndex != -1)
            {
                searchBilet.Parameters.AddWithValue("@konumCombo", konum_Select.SelectedValue.ToString());
            }
            else
            {
                searchBilet.Parameters.AddWithValue("@konumCombo", "");
            }

            if (alan_Select.SelectedIndex != -1)
            {
                searchBilet.Parameters.AddWithValue("@alanCombo", alan_Select.SelectedValue.ToString());
            }
            else
            {
                searchBilet.Parameters.AddWithValue("@alanCombo", "");
            }

            if (tur_Select.SelectedIndex != -1)
            {
                searchBilet.Parameters.AddWithValue("@turCombo", tur_Select.SelectedValue.ToString());
            }
            else
            {
                searchBilet.Parameters.AddWithValue("@turCombo", "");
            }


            SqlDataAdapter oku = new SqlDataAdapter(searchBilet);

            DataGridViewImageColumn buyBtn = new DataGridViewImageColumn();

            buyBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\buy.png");
            buyBtn.HeaderText = "";
            buyBtn.Width = 40;

            DataTable tablo = new DataTable();
            oku.Fill(tablo);
            biletList_table.DataSource = tablo;
            biletList_table.Columns.Add(buyBtn);

            DataGridViewColumn biletKod = biletList_table.Columns[0];
            DataGridViewColumn biletAd = biletList_table.Columns[1];
            DataGridViewColumn sehir = biletList_table.Columns[2];
            DataGridViewColumn konum = biletList_table.Columns[3];
            DataGridViewColumn alan = biletList_table.Columns[4];
            DataGridViewColumn tur = biletList_table.Columns[5];
            DataGridViewColumn tarih = biletList_table.Columns[6];
            DataGridViewColumn fiyat = biletList_table.Columns[7];
            DataGridViewColumn buy = biletList_table.Columns[8];

            biletKod.Width = 60;
            fiyat.Width = 80;
            tur.Width = 80;

            baglanti.Close();
        }

        private void search_Textbox_TextChanged(object sender, EventArgs e)
        {
            searchBilet();
        }

        private void tur_Select_SelectionChangeCommitted(object sender, EventArgs e)
        {
            searchBilet();
        }

        private void konum_Select_SelectionChangeCommitted(object sender, EventArgs e)
        {
            searchBilet();
        }
    }
}
