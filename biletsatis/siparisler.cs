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
    public partial class siparisler : Form
    {
        public siparisler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated security = true;");
        public int kullaniciId, rol;
        bool detayBtnEnabled = true;

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            menu mainMenu = new menu();
            mainMenu.Show();
            this.Close();
        }

        public void searchList() 
        {
            siparisler_List.DataSource = null;
            siparisler_List.Columns.Clear();


            baglanti.Open();

            SqlCommand rolCheck = new SqlCommand("SELECT rol FROM kullanicilar WHERE id = @kullaniciId", baglanti);
            rolCheck.Parameters.AddWithValue("@kullaniciId", kullaniciId);

            SqlDataReader oku = rolCheck.ExecuteReader();

            while (oku.Read())
            {
                rol = Convert.ToInt32(oku[0].ToString());
            }

            oku.Close();

            if (rol == 0)
            {
                musteriKodu_label.Visible = true;
                musteriKodu_Combo.Visible = true;
                siparisAdet_text.Visible = true;
                siparisAdet_Label.Visible = true;

                SqlCommand siparisList = new SqlCommand("SELECT siparisler.siparis_kodu as 'Sipariş No', siparisler.bilet as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', siparisler.kullanici as 'Kullanıcı', siparisler.adet as 'Adet' FROM siparisler LEFT JOIN biletler ON siparisler.bilet = biletler.bilet_kodu " +
                    "WHERE (siparisler.siparis_kodu LIKE '%' + @searchBox + '%' OR biletler.bilet_adi LIKE '%' + @searchBox + '%') AND (siparisler.bilet LIKE '%' + @biletCombo + '%') AND (siparisler.kullanici LIKE '%' + @musteriCombo + '%') AND siparisler.iade = 0", baglanti);
                
                siparisList.Parameters.AddWithValue("@searchBox", searchBox_text.Text);

                if(biletKodu_Combo.SelectedIndex != -1) 
                {
                    siparisList.Parameters.AddWithValue("@biletCombo", biletKodu_Combo.SelectedValue.ToString());
                }
                else 
                {
                    siparisList.Parameters.AddWithValue("@biletCombo", "");
                }

                if (musteriKodu_Combo.SelectedIndex != -1)
                {
                    siparisList.Parameters.AddWithValue("@musteriCombo", musteriKodu_Combo.SelectedValue.ToString());
                }
                else
                {
                    siparisList.Parameters.AddWithValue("@musteriCombo", "");
                }

                DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
                DataGridViewImageColumn prevBtn = new DataGridViewImageColumn();

                deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
                deleteBtn.HeaderText = "";
                deleteBtn.Width = 40;

                prevBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\preview_btn.png");
                prevBtn.HeaderText = "";
                prevBtn.Width = 40;

                SqlDataAdapter doldur = new SqlDataAdapter(siparisList);
                DataTable tbList = new DataTable();
                doldur.Fill(tbList);

                siparisler_List.DataSource = tbList;
                siparisler_List.Columns.Add(prevBtn);
                siparisler_List.Columns.Add(deleteBtn);
                siparisAdet_text.Text = siparisler_List.RowCount.ToString();

                DataGridViewColumn biletAdi = siparisler_List.Columns[2];
                DataGridViewColumn adet = siparisler_List.Columns[4];
                adet.Width = 60;
                biletAdi.Width = 140;

            }
            else if (rol == 2)
            {
                siparisAdet_text.Visible = true;
                siparisAdet_Label.Visible = true;

                SqlCommand siparisOrList = new SqlCommand("SELECT siparisler.siparis_kodu as 'Sipariş No', siparisler.bilet as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', siparisler.kullanici as 'Kullanıcı', siparisler.adet as 'Adet' FROM siparisler LEFT JOIN biletler ON siparisler.bilet = biletler.bilet_kodu WHERE (siparisler.siparis_kodu LIKE '%' + @searchBox + '%' OR biletler.bilet_adi LIKE '%' + @searchBox + '%') AND (siparisler.bilet LIKE '%' + @biletCombo + '%') AND (siparisler.kullanici LIKE '%' + @musteriCombo + '%') AND olusturan = @kullaniciId AND siparisler.iade = 0", baglanti);
                siparisOrList.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                siparisOrList.Parameters.AddWithValue("@searchBox", searchBox_text.Text);

                if (biletKodu_Combo.SelectedIndex != -1)
                {
                    siparisOrList.Parameters.AddWithValue("@biletCombo", biletKodu_Combo.SelectedValue.ToString());
                }
                else
                {
                    siparisOrList.Parameters.AddWithValue("@biletCombo", "");
                }

                if (musteriKodu_Combo.SelectedIndex != -1)
                {
                    siparisOrList.Parameters.AddWithValue("@musteriCombo", musteriKodu_Combo.SelectedValue.ToString());
                }
                else
                {
                    siparisOrList.Parameters.AddWithValue("@musteriCombo", "");
                }

                DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
                DataGridViewImageColumn prevBtn = new DataGridViewImageColumn();

                deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
                deleteBtn.HeaderText = "";
                deleteBtn.Width = 40;

                prevBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\preview_btn.png");
                prevBtn.HeaderText = "";
                prevBtn.Width = 40;

                SqlDataAdapter doldur = new SqlDataAdapter(siparisOrList);
                DataTable tbList = new DataTable();
                doldur.Fill(tbList);

                siparisler_List.DataSource = tbList;
                siparisler_List.Columns.Add(prevBtn);
                siparisler_List.Columns.Add(deleteBtn);
                siparisAdet_text.Text = siparisler_List.RowCount.ToString();

                DataGridViewColumn biletAdi = siparisler_List.Columns[2];
                biletAdi.Width = 140;
            }
            else
            {
                SqlCommand siparisMusteriList = new SqlCommand("SELECT siparisler.siparis_kodu as 'Sipariş No', siparisler.bilet as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', siparisler.kullanici as 'Kullanıcı', siparisler.adet as 'Adet' FROM siparisler LEFT JOIN biletler ON siparisler.bilet = biletler.bilet_kodu WHERE (siparisler.siparis_kodu LIKE '%' + @searchBox + '%' OR biletler.bilet_adi LIKE '%' + @searchBox + '%') AND (siparisler.bilet LIKE '%' + @biletCombo + '%') AND (siparisler.kullanici LIKE '%' + @musteriCombo + '%') AND kullanici = @kullaniciId AND siparisler.iade = 0", baglanti);
                siparisMusteriList.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                siparisMusteriList.Parameters.AddWithValue("@searchBox", searchBox_text.Text);

                if (biletKodu_Combo.SelectedIndex != -1)
                {
                    siparisMusteriList.Parameters.AddWithValue("@biletCombo", biletKodu_Combo.SelectedValue.ToString());
                }
                else
                {
                    siparisMusteriList.Parameters.AddWithValue("@biletCombo", "");
                }

                if (musteriKodu_Combo.SelectedIndex != -1)
                {
                    siparisMusteriList.Parameters.AddWithValue("@musteriCombo", musteriKodu_Combo.SelectedValue.ToString());
                }
                else
                {
                    siparisMusteriList.Parameters.AddWithValue("@musteriCombo", "");
                }

                DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
                DataGridViewImageColumn prevBtn = new DataGridViewImageColumn();

                deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
                deleteBtn.HeaderText = "";
                deleteBtn.Width = 40;

                prevBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\preview_btn.png");
                prevBtn.HeaderText = "";
                prevBtn.Width = 40;

                SqlDataAdapter doldur = new SqlDataAdapter(siparisMusteriList);
                DataTable tbList = new DataTable();
                doldur.Fill(tbList);

                siparisler_List.DataSource = tbList;
                siparisler_List.Columns.Add(prevBtn);
                siparisler_List.Columns.Add(deleteBtn);

                DataGridViewColumn biletAdi = siparisler_List.Columns[2];
                biletAdi.Width = 140;
            }

            baglanti.Close();
        }

        private void searchBox_text_TextChanged(object sender, EventArgs e)
        {
            searchList();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void biletKodu_Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            searchList();
        }

        private void musteriKodu_Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            searchList();
        }

        public void detayFormClosed(object sender, FormClosedEventArgs e) 
        {
            detayBtnEnabled = true;
        }

        private void siparisler_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5 && detayBtnEnabled) 
            {
                siparisDetay detayGor = new siparisDetay();
                detayGor.biletKodu = Convert.ToInt32(siparisler_List.CurrentRow.Cells[1].Value.ToString());
                detayBtnEnabled = false;
                detayGor.Show();
                detayGor.FormClosed += detayFormClosed;
            }
            else if(e.ColumnIndex == 6) 
            {
                DialogResult result = MessageBox.Show("Sipariş iade talebinde bulunmak istediğinize emin misiniz ?", "Uyarı!", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes) 
                {
                    baglanti.Open();

                    SqlCommand tarihCheck = new SqlCommand("SELECT tarih, stok FROM biletler WHERE bilet_kodu = @biletKodu", baglanti);
                    tarihCheck.Parameters.AddWithValue("@biletKodu", siparisler_List.CurrentRow.Cells[1].Value.ToString());

                    SqlDataReader oku = tarihCheck.ExecuteReader();
                    DateTime tarih = DateTime.Now;
                    int stok = 0;

                    while (oku.Read())
                    {
                        tarih = Convert.ToDateTime(oku[0].ToString());
                        stok = Convert.ToInt32(oku[1].ToString());
                    }
                    oku.Close();

                    if (DateTime.Now.Day >= tarih.Day - 2)
                    {
                        MessageBox.Show("Etkinlik tarihine 2 gün veya daha az kalan biletler iade edilemez.");
                    }
                    else
                    {
                        SqlCommand iadeBilet = new SqlCommand("UPDATE siparisler SET iade = 1 WHERE siparis_kodu = @siparisKodu", baglanti);
                        iadeBilet.Parameters.AddWithValue("@siparisKodu", siparisler_List.CurrentRow.Cells[0].Value.ToString());

                        iadeBilet.ExecuteNonQuery();

                        SqlCommand stokUpdate = new SqlCommand("UPDATE biletler SET stok = @stok WHERE bilet_kodu = @biletKodu", baglanti);
                        stokUpdate.Parameters.AddWithValue("@stok", (stok + Convert.ToInt32(siparisler_List.CurrentRow.Cells[4].Value.ToString())).ToString());
                        stokUpdate.Parameters.AddWithValue("@biletKodu", siparisler_List.CurrentRow.Cells[1].Value.ToString());

                        stokUpdate.ExecuteNonQuery();

                        baglanti.Close();
                        MessageBox.Show("İade talebi oluşturuldu.");
                        refreshList();
                    }

                }
            }
        }

        public void refreshList() 
        {
            searchBox_text.Text = "";
            biletKodu_Combo.SelectedIndex = -1;
            musteriKodu_Combo.SelectedIndex = -1;

            siparisler_List.DataSource = null;
            siparisler_List.Columns.Clear();

            baglanti.Open();

            SqlCommand rolCheck = new SqlCommand("SELECT rol FROM kullanicilar WHERE id = @kullaniciId", baglanti);
            rolCheck.Parameters.AddWithValue("@kullaniciId", kullaniciId);

            SqlDataReader oku = rolCheck.ExecuteReader();

            while (oku.Read())
            {
                rol = Convert.ToInt32(oku[0].ToString());
            }

            oku.Close();

            if (rol == 0)
            {
                musteriKodu_label.Visible = true;
                musteriKodu_Combo.Visible = true;
                siparisAdet_text.Visible = true;
                siparisAdet_Label.Visible = true;

                SqlCommand musteriCombo = new SqlCommand("SELECT id FROM kullanicilar", baglanti);

                oku = musteriCombo.ExecuteReader();
                DataTable tb1 = new DataTable();
                tb1.Load(oku);

                musteriKodu_Combo.DataSource = tb1;
                musteriKodu_Combo.DisplayMember = "id";
                musteriKodu_Combo.ValueMember = "id";
                musteriKodu_Combo.SelectedIndex = -1;

                oku.Close();

                SqlCommand biletCombo = new SqlCommand("SELECT bilet_kodu FROM biletler", baglanti);

                oku = biletCombo.ExecuteReader();
                DataTable tb2 = new DataTable();
                tb2.Load(oku);

                biletKodu_Combo.DataSource = tb2;
                biletKodu_Combo.DisplayMember = "bilet_kodu";
                biletKodu_Combo.ValueMember = "bilet_kodu";
                biletKodu_Combo.SelectedIndex = -1;

                oku.Close();

                SqlCommand siparisList = new SqlCommand("SELECT siparisler.siparis_kodu as 'Sipariş No', siparisler.bilet as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', siparisler.kullanici as 'Kullanıcı', siparisler.adet as 'Adet' FROM siparisler LEFT JOIN biletler ON siparisler.bilet = biletler.bilet_kodu WHERE siparisler.iade = 0", baglanti);

                DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
                DataGridViewImageColumn prevBtn = new DataGridViewImageColumn();

                deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
                deleteBtn.HeaderText = "";
                deleteBtn.Width = 40;

                prevBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\preview_btn.png");
                prevBtn.HeaderText = "";
                prevBtn.Width = 40;

                SqlDataAdapter doldur = new SqlDataAdapter(siparisList);
                DataTable tbList = new DataTable();
                doldur.Fill(tbList);

                siparisler_List.DataSource = tbList;
                siparisler_List.Columns.Add(prevBtn);
                siparisler_List.Columns.Add(deleteBtn);
                siparisAdet_text.Text = siparisler_List.RowCount.ToString();

                DataGridViewColumn biletAdi = siparisler_List.Columns[2];
                DataGridViewColumn adet = siparisler_List.Columns[4];
                adet.Width = 60;
                biletAdi.Width = 140;

            }
            else if (rol == 2)
            {
                siparisAdet_text.Visible = true;
                siparisAdet_Label.Visible = true;

                SqlCommand biletCombo = new SqlCommand("SELECT bilet_kodu FROM biletler WHERE olusturan = @kullaniciId", baglanti);
                biletCombo.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                oku = biletCombo.ExecuteReader();
                DataTable tb2 = new DataTable();
                tb2.Load(oku);

                biletKodu_Combo.DataSource = tb2;
                biletKodu_Combo.DisplayMember = "bilet_kodu";
                biletKodu_Combo.ValueMember = "bilet_kodu";
                biletKodu_Combo.SelectedIndex = -1;

                oku.Close();

                SqlCommand siparisOrList = new SqlCommand("SELECT siparisler.siparis_kodu as 'Sipariş No', siparisler.bilet as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', siparisler.kullanici as 'Kullanıcı', siparisler.adet as 'Adet' FROM siparisler LEFT JOIN biletler ON siparisler.bilet = biletler.bilet_kodu WHERE olusturan = @kullaniciId AND siparisler.iade = 0", baglanti);
                siparisOrList.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
                DataGridViewImageColumn prevBtn = new DataGridViewImageColumn();

                deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
                deleteBtn.HeaderText = "";
                deleteBtn.Width = 40;

                prevBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\preview_btn.png");
                prevBtn.HeaderText = "";
                prevBtn.Width = 40;

                SqlDataAdapter doldur = new SqlDataAdapter(siparisOrList);
                DataTable tbList = new DataTable();
                doldur.Fill(tbList);

                siparisler_List.DataSource = tbList;
                siparisler_List.Columns.Add(prevBtn);
                siparisler_List.Columns.Add(deleteBtn);
                siparisAdet_text.Text = siparisler_List.RowCount.ToString();

                DataGridViewColumn biletAdi = siparisler_List.Columns[2];
                biletAdi.Width = 140;
            }
            else
            {
                SqlCommand siparisMusteriList = new SqlCommand("SELECT siparisler.siparis_kodu as 'Sipariş No', siparisler.bilet as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', siparisler.kullanici as 'Kullanıcı', siparisler.adet as 'Adet' FROM siparisler LEFT JOIN biletler ON siparisler.bilet = biletler.bilet_kodu WHERE kullanici = @kullaniciId AND siparisler.iade = 0", baglanti);
                siparisMusteriList.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
                DataGridViewImageColumn prevBtn = new DataGridViewImageColumn();

                deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
                deleteBtn.HeaderText = "";
                deleteBtn.Width = 40;

                prevBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\preview_btn.png");
                prevBtn.HeaderText = "";
                prevBtn.Width = 40;

                SqlDataAdapter doldur = new SqlDataAdapter(siparisMusteriList);
                DataTable tbList = new DataTable();
                doldur.Fill(tbList);

                siparisler_List.DataSource = tbList;
                siparisler_List.Columns.Add(prevBtn);
                siparisler_List.Columns.Add(deleteBtn);

                DataGridViewColumn biletAdi = siparisler_List.Columns[2];
                biletAdi.Width = 140;
            }

            baglanti.Close();
        }

        public void iadeFormClosed(object sender, FormClosedEventArgs e) 
        {
            btn_Iade.Enabled = true;
        }

        private void btn_Iade_Click(object sender, EventArgs e)
        {
            iadeler iadeSayfa = new iadeler();
            btn_Iade.Enabled = false;
            iadeSayfa.Show();
            iadeSayfa.FormClosed += iadeFormClosed;
        }

        private void siparisler_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand rolCheck = new SqlCommand("SELECT rol FROM kullanicilar WHERE id = @kullaniciId", baglanti);
            rolCheck.Parameters.AddWithValue("@kullaniciId", kullaniciId);

            SqlDataReader oku = rolCheck.ExecuteReader();

            while (oku.Read()) 
            {
                rol = Convert.ToInt32(oku[0].ToString());
            }

            oku.Close();
            
            if(rol == 0) 
            {
                musteriKodu_label.Visible = true;
                musteriKodu_Combo.Visible = true;
                siparisAdet_text.Visible = true;
                siparisAdet_Label.Visible = true;
                btn_Iade.Visible = true;

                SqlCommand musteriCombo = new SqlCommand("SELECT id FROM kullanicilar", baglanti);

                oku = musteriCombo.ExecuteReader();
                DataTable tb1 = new DataTable();
                tb1.Load(oku);

                musteriKodu_Combo.DataSource = tb1;
                musteriKodu_Combo.DisplayMember = "id";
                musteriKodu_Combo.ValueMember = "id";
                musteriKodu_Combo.SelectedIndex = -1;

                oku.Close();

                SqlCommand biletCombo = new SqlCommand("SELECT bilet_kodu FROM biletler", baglanti);

                oku = biletCombo.ExecuteReader();
                DataTable tb2 = new DataTable();
                tb2.Load(oku);

                biletKodu_Combo.DataSource = tb2;
                biletKodu_Combo.DisplayMember = "bilet_kodu";
                biletKodu_Combo.ValueMember = "bilet_kodu";
                biletKodu_Combo.SelectedIndex = -1;

                oku.Close();

                SqlCommand siparisList = new SqlCommand("SELECT siparisler.siparis_kodu as 'Sipariş No', siparisler.bilet as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', siparisler.kullanici as 'Kullanıcı', siparisler.adet as 'Adet' FROM siparisler LEFT JOIN biletler ON siparisler.bilet = biletler.bilet_kodu WHERE siparisler.iade = 0", baglanti);

                DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
                DataGridViewImageColumn prevBtn = new DataGridViewImageColumn();

                deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
                deleteBtn.HeaderText = "";
                deleteBtn.Width = 40;

                prevBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\preview_btn.png");
                prevBtn.HeaderText = "";
                prevBtn.Width = 40;

                SqlDataAdapter doldur = new SqlDataAdapter(siparisList);
                DataTable tbList = new DataTable();
                doldur.Fill(tbList);

                siparisler_List.DataSource = tbList;
                siparisler_List.Columns.Add(prevBtn);
                siparisler_List.Columns.Add(deleteBtn);
                siparisAdet_text.Text = siparisler_List.RowCount.ToString();

                DataGridViewColumn biletAdi = siparisler_List.Columns[2];
                DataGridViewColumn adet = siparisler_List.Columns[4];
                adet.Width = 60;
                biletAdi.Width = 140;

            }
            else if(rol == 2) 
            {
                siparisAdet_text.Visible = true;
                siparisAdet_Label.Visible = true;

                SqlCommand biletCombo = new SqlCommand("SELECT bilet_kodu FROM biletler WHERE olusturan = @kullaniciId", baglanti);
                biletCombo.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                oku = biletCombo.ExecuteReader();
                DataTable tb2 = new DataTable();
                tb2.Load(oku);

                biletKodu_Combo.DataSource = tb2;
                biletKodu_Combo.DisplayMember = "bilet_kodu";
                biletKodu_Combo.ValueMember = "bilet_kodu";
                biletKodu_Combo.SelectedIndex = -1;

                oku.Close();

                SqlCommand siparisOrList = new SqlCommand("SELECT siparisler.siparis_kodu as 'Sipariş No', siparisler.bilet as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', siparisler.kullanici as 'Kullanıcı', siparisler.adet as 'Adet' FROM siparisler LEFT JOIN biletler ON siparisler.bilet = biletler.bilet_kodu WHERE olusturan = @kullaniciId AND siparisler.iade = 0", baglanti);
                siparisOrList.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
                DataGridViewImageColumn prevBtn = new DataGridViewImageColumn();

                deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
                deleteBtn.HeaderText = "";
                deleteBtn.Width = 40;

                prevBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\preview_btn.png");
                prevBtn.HeaderText = "";
                prevBtn.Width = 40;

                SqlDataAdapter doldur = new SqlDataAdapter(siparisOrList);
                DataTable tbList = new DataTable();
                doldur.Fill(tbList);

                siparisler_List.DataSource = tbList;
                siparisler_List.Columns.Add(prevBtn);
                siparisler_List.Columns.Add(deleteBtn);
                siparisAdet_text.Text = siparisler_List.RowCount.ToString();

                DataGridViewColumn biletAdi = siparisler_List.Columns[2];
                biletAdi.Width = 140;
            }
            else 
            {
                SqlCommand siparisMusteriList = new SqlCommand("SELECT siparisler.siparis_kodu as 'Sipariş No', siparisler.bilet as 'Bilet Kodu', biletler.bilet_adi as 'Bilet Adı', siparisler.kullanici as 'Kullanıcı', siparisler.adet as 'Adet' FROM siparisler LEFT JOIN biletler ON siparisler.bilet = biletler.bilet_kodu WHERE kullanici = @kullaniciId AND siparisler.iade = 0", baglanti);
                siparisMusteriList.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
                DataGridViewImageColumn prevBtn = new DataGridViewImageColumn();

                SqlCommand biletCombo = new SqlCommand("SELECT * FROM siparisler WHERE kullanici = @kullaniciId", baglanti);
                biletCombo.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                oku = biletCombo.ExecuteReader();
                DataTable tb2 = new DataTable();
                tb2.Load(oku);

                biletKodu_Combo.DataSource = tb2;
                biletKodu_Combo.DisplayMember = "bilet";
                biletKodu_Combo.ValueMember = "bilet";
                biletKodu_Combo.SelectedIndex = -1;

                deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
                deleteBtn.HeaderText = "";
                deleteBtn.Width = 40;

                prevBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\preview_btn.png");
                prevBtn.HeaderText = "";
                prevBtn.Width = 40;

                SqlDataAdapter doldur = new SqlDataAdapter(siparisMusteriList);
                DataTable tbList = new DataTable();
                doldur.Fill(tbList);

                siparisler_List.DataSource = tbList;
                siparisler_List.Columns.Add(prevBtn);
                siparisler_List.Columns.Add(deleteBtn);

                DataGridViewColumn biletAdi = siparisler_List.Columns[2];
                biletAdi.Width = 140;
            }

            baglanti.Close();
        }
    }
}
