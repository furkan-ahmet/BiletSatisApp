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
using System.Management.Instrumentation;
using System.Data.Common;
using System.IO;
using System.Xml.Linq;

namespace biletsatis
{
    public partial class biletlerimList : Form
    {
        public biletlerimList()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");
        public String kullaniciAdi;
        public int kullaniciId;
        bool editBtnEnabled = true;

        public void refreshBiletList() 
        {
            search_Textbox.Text = "";
            sehir_Combo.SelectedIndex = -1;
            durum_Combo.SelectedIndex = -1;

            biletlerimListesi.DataSource = null;
            biletlerimListesi.Columns.Clear();

            SqlCommand biletlerimListe = new SqlCommand("SELECT biletler.bilet_kodu as 'Bilet Kodu', biletler.bilet_adi as 'Adı', sehirler.sehir as 'Şehir', biletler.tarih as 'Tarih' FROM biletler LEFT JOIN sehirler ON biletler.sehir = sehirler.sehir_kodu WHERE olusturan = @olusturan", baglanti);
            biletlerimListe.Parameters.AddWithValue("@olusturan", kullaniciId);

            SqlDataAdapter oku = new SqlDataAdapter(biletlerimListe);

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
            biletlerimListesi.DataSource = tablo;
            biletlerimListesi.Columns.Add(editBtn);
            biletlerimListesi.Columns.Add(deleteBtn);

            DataGridViewColumn kod = biletlerimListesi.Columns[0];
            DataGridViewColumn ad = biletlerimListesi.Columns[1];
            DataGridViewColumn sehir = biletlerimListesi.Columns[2];
            DataGridViewColumn tarih = biletlerimListesi.Columns[3];
            DataGridViewColumn edit = biletlerimListesi.Columns[4];
            DataGridViewColumn delete = biletlerimListesi.Columns[5];

            kod.Width = 100;
            ad.Width = 160;
            sehir.Width = 80;
            tarih.Width = 120;
            edit.Width = 50;
            delete.Width = 50;
        }

        private void biletlerimList_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sehirCommand = new SqlCommand("SELECT * FROM sehirler", baglanti);

            SqlDataReader doldur = sehirCommand.ExecuteReader();
            DataTable tb1 = new DataTable();
            tb1.Load(doldur);

            sehir_Combo.DataSource = tb1;
            sehir_Combo.DisplayMember = "sehir";
            sehir_Combo.ValueMember = "sehir_kodu";
            sehir_Combo.SelectedIndex = -1;

            doldur.Close();

            SqlCommand durumCommand = new SqlCommand("SELECT * FROM durumlar", baglanti);

            doldur = durumCommand.ExecuteReader();
            DataTable tb2 = new DataTable();
            tb2.Load(doldur);

            durum_Combo.DataSource = tb2;
            durum_Combo.DisplayMember = "durum";
            durum_Combo.ValueMember = "durum_kod";
            durum_Combo.SelectedIndex = -1;

            doldur.Close();

            SqlCommand getUserId = new SqlCommand("SELECT id FROM kullanicilar WHERE eposta = @eposta", baglanti);
            getUserId.Parameters.AddWithValue("@eposta", kullaniciAdi);

            SqlDataReader readUserId = getUserId.ExecuteReader();

            while (readUserId.Read()) 
            {
                kullaniciId = Convert.ToInt32(readUserId[0].ToString());
            }

            readUserId.Close();

            SqlCommand biletlerimListe = new SqlCommand("SELECT biletler.bilet_kodu as 'Bilet Kodu', biletler.bilet_adi as 'Adı', sehirler.sehir as 'Şehir', biletler.tarih as 'Tarih' FROM biletler LEFT JOIN sehirler ON biletler.sehir = sehirler.sehir_kodu WHERE olusturan = @olusturan", baglanti);
            biletlerimListe.Parameters.AddWithValue("@olusturan", kullaniciId);

            SqlDataAdapter oku = new SqlDataAdapter(biletlerimListe);

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

            biletlerimListesi.DataSource = tablo;
            biletlerimListesi.Columns.Add(editBtn);
            biletlerimListesi.Columns.Add(deleteBtn);

            DataGridViewColumn kod = biletlerimListesi.Columns[0];
            DataGridViewColumn ad = biletlerimListesi.Columns[1];
            DataGridViewColumn sehir = biletlerimListesi.Columns[2];
            DataGridViewColumn tarih = biletlerimListesi.Columns[3];
            DataGridViewColumn edit = biletlerimListesi.Columns[4];
            DataGridViewColumn delete = biletlerimListesi.Columns[5];

            kod.Width = 100;
            ad.Width = 160;
            sehir.Width = 80;
            tarih.Width = 120;
            edit.Width = 50;
            delete.Width = 50;

            baglanti.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            search_Textbox.Text = "";
            sehir_Combo.SelectedIndex = -1;
            durum_Combo.SelectedIndex = -1;

            biletlerimListesi.DataSource = null;
            biletlerimListesi.Columns.Clear();

            SqlCommand biletlerimListe = new SqlCommand("SELECT biletler.bilet_kodu as 'Bilet Kodu', biletler.bilet_adi as 'Adı', sehirler.sehir as 'Şehir', biletler.tarih as 'Tarih' FROM biletler LEFT JOIN sehirler ON biletler.sehir = sehirler.sehir_kodu WHERE olusturan = @olusturan", baglanti);
            biletlerimListe.Parameters.AddWithValue("@olusturan", kullaniciId);

            SqlDataAdapter oku = new SqlDataAdapter(biletlerimListe);

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

            biletlerimListesi.DataSource = tablo;
            biletlerimListesi.Columns.Add(editBtn);
            biletlerimListesi.Columns.Add(deleteBtn);

            DataGridViewColumn kod = biletlerimListesi.Columns[0];
            DataGridViewColumn ad = biletlerimListesi.Columns[1];
            DataGridViewColumn sehir = biletlerimListesi.Columns[2];
            DataGridViewColumn tarih = biletlerimListesi.Columns[3];
            DataGridViewColumn edit = biletlerimListesi.Columns[4];
            DataGridViewColumn delete = biletlerimListesi.Columns[5];

            kod.Width = 100;
            ad.Width = 160;
            sehir.Width = 80;
            tarih.Width = 120;
            edit.Width = 50;
            delete.Width = 50;
        }

        public void searchList() 
        {
            biletlerimListesi.DataSource = null;
            biletlerimListesi.Columns.Clear();

            SqlCommand biletlerimListe = new SqlCommand("SELECT biletler.bilet_kodu as 'Bilet Kodu', biletler.bilet_adi as 'Adı', sehirler.sehir as 'Şehir', biletler.tarih as 'Tarih' FROM biletler " +
                "LEFT JOIN sehirler ON biletler.sehir = sehirler.sehir_kodu WHERE olusturan = @olusturan AND " +
                "(biletler.bilet_kodu LIKE '%' + @searchbox + '%' OR biletler.bilet_adi LIKE '%' + @searchbox + '%') AND (biletler.sehir LIKE '%' + @sehirCombo + '%') AND (biletler.durum LIKE '%' + @durumCombo + '%')", baglanti);
            biletlerimListe.Parameters.AddWithValue("@olusturan", kullaniciId);
            biletlerimListe.Parameters.AddWithValue("@searchbox", search_Textbox.Text);

            if(sehir_Combo.SelectedIndex != -1) 
            {
                biletlerimListe.Parameters.AddWithValue("@sehirCombo", sehir_Combo.SelectedValue.ToString());
            }
            else 
            {
                biletlerimListe.Parameters.AddWithValue("@sehirCombo", "");
            }

            if (durum_Combo.SelectedIndex != -1)
            {
                biletlerimListe.Parameters.AddWithValue("@durumCombo", durum_Combo.SelectedValue.ToString());
            }
            else
            {
                biletlerimListe.Parameters.AddWithValue("@durumCombo", "");
            }

            SqlDataAdapter oku = new SqlDataAdapter(biletlerimListe);

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
            biletlerimListesi.DataSource = tablo;
            biletlerimListesi.Columns.Add(editBtn);
            biletlerimListesi.Columns.Add(deleteBtn);

            DataGridViewColumn kod = biletlerimListesi.Columns[0];
            DataGridViewColumn ad = biletlerimListesi.Columns[1];
            DataGridViewColumn sehir = biletlerimListesi.Columns[2];
            DataGridViewColumn tarih = biletlerimListesi.Columns[3];
            DataGridViewColumn edit = biletlerimListesi.Columns[4];
            DataGridViewColumn delete = biletlerimListesi.Columns[5];

            kod.Width = 100;
            ad.Width = 160;
            sehir.Width = 80;
            tarih.Width = 120;
            edit.Width = 50;
            delete.Width = 50;

            baglanti.Close();
        }

        private void search_Textbox_TextChanged(object sender, EventArgs e)
        {
            if(baglanti.State == ConnectionState.Open) 
            {
                baglanti.Close();
            }
            baglanti.Open();

            searchList();

            baglanti.Close();
        }

        private void sehir_Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            baglanti.Open();

            searchList();

            baglanti.Close();
        }

        private void durum_Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            baglanti.Open();

            searchList();

            baglanti.Close();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            menu mainMenu = new menu();
            mainMenu.Show();
            this.Close();
        }

        public void biletAddFormClosed(object sender, FormClosedEventArgs e) 
        {
            baglanti.Open();
            btn_Add.Enabled = true;
            editBtnEnabled = true;
            refreshBiletList();
            baglanti.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            biletler_ADD biletEkle = new biletler_ADD();
            biletEkle.kullaniciId = kullaniciId;
            btn_Add.Enabled = false;
            biletEkle.Show();
            biletEkle.FormClosed += biletAddFormClosed;
        }

        private void biletlerimListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4 && editBtnEnabled) 
            {
                biletler_ADD biletEdit = new biletler_ADD();
                biletEdit.kullaniciId = kullaniciId;
                biletEdit.isEdit = true;
                biletEdit.biletId = Convert.ToInt32(biletlerimListesi.CurrentRow.Cells[0].Value.ToString());
                editBtnEnabled = false;
                biletEdit.Show();
                biletEdit.FormClosed += biletAddFormClosed;
            }
            else if(e.ColumnIndex == 5) 
            {
                baglanti.Open();

                SqlCommand iadeSiparisler = new SqlCommand("UPDATE siparisler SET iade = 1 WHERE bilet = @biletKodu", baglanti);
                iadeSiparisler.Parameters.AddWithValue("@biletKodu", biletlerimListesi.CurrentRow.Cells[0].Value.ToString());

                SqlCommand deleteBilet = new SqlCommand("DELETE FROM biletler WHERE bilet_kodu = @biletKodu", baglanti);
                deleteBilet.Parameters.AddWithValue("@biletKodu", biletlerimListesi.CurrentRow.Cells[0].Value.ToString());

                DialogResult result = MessageBox.Show("Kayıt silinecek. Devam edilsin mi ?", "Dikkat!", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes) 
                {
                    iadeSiparisler.ExecuteNonQuery();
                    deleteBilet.ExecuteNonQuery();
                    refreshBiletList();
                }
                
                baglanti.Close();
            }
        }

        private void btn_RandomAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string[] biletAdlari = new string[] { "Duman", "Gölge", "Gece", "Yüzüklerin Efendisi", "Pentagram", "Komedyen", "Slender", "Deli", "Metallica", "AC/DC", "The Call of Cthulhu", "Hadise", "Ölümsüz", "Taşıyıcı", "Baba", "Dost", "Us", "Hobbit", "Harry Pooter", "Sınav", "Ecel", "Ezhel", "Hızlı ve Öfkeli", "Müzisyen", "Jaws", "Anlamsız", "Mudvayne", "Skillet", "Hakan Muhafız", "Deli Dumrul"};

            List<int> alanCode = new List<int>();
            List<int> turCode = new List<int>();
            List<int> sehirCode = new List<int>();
            List<int> konumCode = new List<int>();
            List<int> kullaniciCode = new List<int>();

            Random randomNumber = new Random();

            for(int i = 0; i < 5000; i++) 
            {
                int alan, tur, sehir, konum, kullanici;

                SqlCommand alanCom = new SqlCommand("SELECT * FROM alanlar", baglanti);
                SqlDataReader oku = alanCom.ExecuteReader(); 

                while (oku.Read())
                {
                    alanCode.Add(Convert.ToInt32(oku[0]));
                }

                alan = alanCode[randomNumber.Next(0, alanCode.Count())];
                oku.Close();

                SqlCommand turCom = new SqlCommand("SELECT * FROM turler WHERE alan = @alanKodu", baglanti);
                turCom.Parameters.AddWithValue("@alanKodu", alan);

                oku = turCom.ExecuteReader();

                while (oku.Read())
                {
                    turCode.Add(Convert.ToInt32(oku[0]));
                }

                tur = turCode[randomNumber.Next(0, turCode.Count())];
                oku.Close();

                SqlCommand sehirCom = new SqlCommand("SELECT * FROM sehirler", baglanti);
                oku = sehirCom.ExecuteReader();

                while (oku.Read())
                {
                    sehirCode.Add(Convert.ToInt32(oku[0]));
                }

                sehir = sehirCode[randomNumber.Next(0, sehirCode.Count())];
                oku.Close();

                SqlCommand konumCom = new SqlCommand("SELECT * FROM konumlar WHERE sehir = @sehirKodu", baglanti);
                konumCom.Parameters.AddWithValue("@sehirKodu", sehir);

                oku = konumCom.ExecuteReader();

                while (oku.Read())
                {
                    konumCode.Add(Convert.ToInt32(oku[0]));
                }

                konum = konumCode[randomNumber.Next(0, konumCode.Count())];
                oku.Close();

                int durum = randomNumber.Next(0, 2);

                SqlCommand kullaniciCom = new SqlCommand("SELECT * FROM kullanicilar WHERE rol = 0 OR rol = 2", baglanti);

                oku = kullaniciCom.ExecuteReader();

                while (oku.Read())
                {
                    kullaniciCode.Add(Convert.ToInt32(oku[0]));
                }

                kullanici = kullaniciCode[randomNumber.Next(0, kullaniciCode.Count())];
                oku.Close();



                string biletAdi = biletAdlari[randomNumber.Next(0, biletAdlari.Length)];

                int fiyat = randomNumber.Next(2, 32) * 10;

                DateTime tarih()
                {
                    DateTime baslangic = new DateTime(2021, 03, 01);
                    int range = (DateTime.Today - baslangic).Days;
                    return baslangic.AddDays(randomNumber.Next(10, 90));
                }

                int stok = randomNumber.Next(1, 12) * 100;

                string foto = AppDomain.CurrentDomain.BaseDirectory + "\\photos\\nofoto.png";

                SqlCommand insertBilet = new SqlCommand("INSERT INTO biletler(bilet_adi, sehir, konum, tur, fiyat, alan, tarih, durum, stok, olusturan, foto) VALUES(@biletAdi, @sehir, @konum, @tur, @fiyat, @alan, @tarih, @durum, @stok, @olusturan, @foto)", baglanti);
                insertBilet.Parameters.AddWithValue("@biletAdi", biletAdi);
                insertBilet.Parameters.AddWithValue("@sehir", sehir);
                insertBilet.Parameters.AddWithValue("@konum", konum);
                insertBilet.Parameters.AddWithValue("@tur", tur);
                insertBilet.Parameters.AddWithValue("@fiyat", fiyat);
                insertBilet.Parameters.AddWithValue("@alan", alan);
                insertBilet.Parameters.AddWithValue("@tarih", tarih());
                insertBilet.Parameters.AddWithValue("@durum", durum);
                insertBilet.Parameters.AddWithValue("@stok", stok);
                insertBilet.Parameters.AddWithValue("@olusturan", kullanici);
                insertBilet.Parameters.AddWithValue("@foto", foto);

                insertBilet.ExecuteNonQuery();
                alanCode.Clear();
                turCode.Clear();
                sehirCode.Clear();
                konumCode.Clear();
                kullaniciCode.Clear();
            }

            baglanti.Close();
            refreshBiletList();
        }
    }
}
