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
    public partial class kullanicilar : Form
    {
        public kullanicilar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");
        bool editBtnEnabled = true;

        private void btn_Back_Click(object sender, EventArgs e)
        {
            menu mainMenu = new menu();
            mainMenu.Show();
            this.Close();
        }
        
        public void kullaniciEditFormClosed(object sender, FormClosedEventArgs e) 
        {
            editBtnEnabled = true;
            kullaniciListe.DataSource = null;
            kullaniciListe.Columns.Clear();

            baglanti.Open();

            SqlCommand kullaniciList = new SqlCommand("SELECT kullanicilar.id as 'Kullanıcı Kodu', kullanicilar.ad as 'Ad', kullanicilar.soyad as 'Soyad', kullanicilar.eposta as 'e-Posta', sehirler.sehir as 'Şehir', roller.rol_adi as 'Rol' FROM kullanicilar LEFT JOIN sehirler ON kullanicilar.sehir = sehirler.sehir_kodu LEFT JOIN roller ON kullanicilar.rol = roller.rol_kodu", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(kullaniciList);

            DataTable tb = new DataTable();
            oku.Fill(tb);

            kullaniciListe.DataSource = tb;

            DataGridViewColumn kod = kullaniciListe.Columns[0];
            DataGridViewColumn ad = kullaniciListe.Columns[1];
            DataGridViewColumn soyad = kullaniciListe.Columns[2];
            DataGridViewColumn eposta = kullaniciListe.Columns[3];
            DataGridViewColumn sehir = kullaniciListe.Columns[4];
            DataGridViewColumn rol = kullaniciListe.Columns[5];

            kod.Width = 60;
            ad.Width = 80;
            soyad.Width = 80;
            eposta.Width = 200;
            sehir.Width = 60;
            rol.Width = 50;

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();
            DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();

            editBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\edit_btn.png");
            editBtn.HeaderText = "";
            editBtn.Width = 36;

            deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
            deleteBtn.HeaderText = "";
            deleteBtn.Width = 35;

            kullaniciListe.Columns.Add(editBtn);
            kullaniciListe.Columns.Add(deleteBtn);

            baglanti.Close();
        }

        public void kullaniciListRefresh() 
        {
            kullaniciListe.DataSource = null;
            kullaniciListe.Columns.Clear();

            adSearchTextbox.Text = "";
            rolSearchCombobox.SelectedIndex = -1;
            sehirSearchCombobox.SelectedIndex = -1;

            SqlCommand kullaniciList = new SqlCommand("SELECT kullanicilar.id as 'Kullanıcı Kodu', kullanicilar.ad as 'Ad', kullanicilar.soyad as 'Soyad', kullanicilar.eposta as 'e-Posta', sehirler.sehir as 'Şehir', roller.rol_adi as 'Rol' FROM kullanicilar LEFT JOIN sehirler ON kullanicilar.sehir = sehirler.sehir_kodu LEFT JOIN roller ON kullanicilar.rol = roller.rol_kodu", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(kullaniciList);

            DataTable tb = new DataTable();
            oku.Fill(tb);

            kullaniciListe.DataSource = tb;

            DataGridViewColumn kod = kullaniciListe.Columns[0];
            DataGridViewColumn ad = kullaniciListe.Columns[1];
            DataGridViewColumn soyad = kullaniciListe.Columns[2];
            DataGridViewColumn eposta = kullaniciListe.Columns[3];
            DataGridViewColumn sehir = kullaniciListe.Columns[4];
            DataGridViewColumn rol = kullaniciListe.Columns[5];

            kod.Width = 60;
            ad.Width = 80;
            soyad.Width = 80;
            eposta.Width = 200;
            sehir.Width = 60;
            rol.Width = 50;

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();
            DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();

            editBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\edit_btn.png");
            editBtn.HeaderText = "";
            editBtn.Width = 36;

            deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
            deleteBtn.HeaderText = "";
            deleteBtn.Width = 35;

            kullaniciListe.Columns.Add(editBtn);
            kullaniciListe.Columns.Add(deleteBtn);
        }

        private void kullanicilar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kullaniciList = new SqlCommand("SELECT kullanicilar.id as 'Kullanıcı Kodu', kullanicilar.ad as 'Ad', kullanicilar.soyad as 'Soyad', kullanicilar.eposta as 'e-Posta', sehirler.sehir as 'Şehir', roller.rol_adi as 'Rol' FROM kullanicilar LEFT JOIN sehirler ON kullanicilar.sehir = sehirler.sehir_kodu LEFT JOIN roller ON kullanicilar.rol = roller.rol_kodu", baglanti);

            SqlDataAdapter oku = new SqlDataAdapter(kullaniciList);

            DataTable tb = new DataTable();
            oku.Fill(tb);

            kullaniciListe.DataSource = tb;

            DataGridViewColumn kod = kullaniciListe.Columns[0];
            DataGridViewColumn ad = kullaniciListe.Columns[1];
            DataGridViewColumn soyad = kullaniciListe.Columns[2];
            DataGridViewColumn eposta = kullaniciListe.Columns[3];
            DataGridViewColumn sehir = kullaniciListe.Columns[4];
            DataGridViewColumn rol = kullaniciListe.Columns[5];

            kod.Width = 60;
            ad.Width = 80;
            soyad.Width = 80;
            eposta.Width = 200;
            sehir.Width = 60;
            rol.Width = 50;

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();
            DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();

            editBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\edit_btn.png");
            editBtn.HeaderText = "";
            editBtn.Width = 36;

            deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
            deleteBtn.HeaderText = "";
            deleteBtn.Width = 35;

            kullaniciListe.Columns.Add(editBtn);
            kullaniciListe.Columns.Add(deleteBtn);

            SqlCommand rolCombo = new SqlCommand("SELECT * FROM roller ORDER BY rol_adi", baglanti);

            SqlDataReader doldur = rolCombo.ExecuteReader();
            DataTable tb2 = new DataTable();
            tb2.Load(doldur);

            rolSearchCombobox.DataSource = tb2;
            rolSearchCombobox.DisplayMember = "rol_adi";
            rolSearchCombobox.ValueMember = "rol_kodu";
            rolSearchCombobox.SelectedIndex= -1;

            doldur.Close();

            int biletSayisi = 0;
            SqlCommand checkBilet = new SqlCommand("SELECT * FROM biletler WHERE durum = 1", baglanti);

            doldur = checkBilet.ExecuteReader();


            while (doldur.Read())
            {
                biletSayisi++;
            }

            doldur.Close();

            if (biletSayisi > 0)
            {
                btn_Rastgele.Enabled = true;
            }

            SqlCommand sehirCombo = new SqlCommand("SELECT * FROM sehirler ORDER BY sehir", baglanti);

            doldur = sehirCombo.ExecuteReader();
            DataTable tb3 = new DataTable();
            tb3.Load(doldur);

            sehirSearchCombobox.DataSource = tb3;
            sehirSearchCombobox.DisplayMember = "sehir";
            sehirSearchCombobox.ValueMember = "sehir_kodu";
            sehirSearchCombobox.SelectedIndex = -1;

            doldur.Close();

            

            baglanti.Close();
        }

        private void kullaniciListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6 && editBtnEnabled) 
            {
                kullaniciEdit editKullanici = new kullaniciEdit();
                editKullanici.id = kullaniciListe.CurrentRow.Cells[0].Value.ToString();
                editBtnEnabled = false;
                editKullanici.Show();
                editKullanici.FormClosed += kullaniciEditFormClosed;

            }
            else if(e.ColumnIndex == 7) 
            {
                baglanti.Open();

                SqlCommand deleteBiletler = new SqlCommand("DELETE FROM biletler WHERE olusturan = @kullaniciId", baglanti);
                deleteBiletler.Parameters.AddWithValue("@kullaniciId", kullaniciListe.CurrentRow.Cells[0].Value.ToString());

                SqlCommand deleteSiparisler = new SqlCommand("DELETE FROM siparisler WHERE kullanici = @kullaniciId AND iade = 0", baglanti);
                deleteSiparisler.Parameters.AddWithValue("@kullaniciId", kullaniciListe.CurrentRow.Cells[0].Value.ToString());

                SqlCommand iadeAllSiparis = new SqlCommand("UPDATE siparisler SET iade = 1 WHERE bilet = (SELECT bilet_kodu FROM biletler WHERE olusturan = @kullaniciId)", baglanti);
                iadeAllSiparis.Parameters.AddWithValue("@kullaniciId", kullaniciListe.CurrentRow.Cells[0].Value.ToString());

                SqlCommand deleteKullanici = new SqlCommand("DELETE FROM kullanicilar WHERE id = @kod", baglanti);
                deleteKullanici.Parameters.AddWithValue("@kod", kullaniciListe.CurrentRow.Cells[0].Value.ToString());

                DialogResult result = MessageBox.Show("Kayıt silinecek. Devam edilsin mi ?", "Dikkat!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) 
                {
                    iadeAllSiparis.ExecuteNonQuery();
                    deleteSiparisler.ExecuteNonQuery();
                    deleteBiletler.ExecuteNonQuery();
                    deleteKullanici.ExecuteNonQuery();
                    kullaniciListRefresh();
                }

                baglanti.Close();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            kullaniciListRefresh();
        }

        public void searchKullanici() 
        {
            kullaniciListe.DataSource = null;
            kullaniciListe.Columns.Clear();

            baglanti.Open();

            SqlCommand kullaniciSearch = new SqlCommand("SELECT kullanicilar.id as 'Kullanıcı Kodu', kullanicilar.ad as 'Ad', kullanicilar.soyad as 'Soyad', kullanicilar.eposta as 'e-Posta', sehirler.sehir as 'Şehir', roller.rol_adi as 'Rol' FROM kullanicilar " +
                "LEFT JOIN sehirler ON kullanicilar.sehir = sehirler.sehir_kodu " +
                "LEFT JOIN roller ON kullanicilar.rol = roller.rol_kodu " +
                "WHERE (kullanicilar.ad LIKE '%' + @searchBox + '%' OR kullanicilar.soyad LIKE '%' + @searchBox + '%') AND (kullanicilar.sehir LIKE '%' + @sehirCombo + '%') AND (kullanicilar.rol LIKE '%' + @rolCombo + '%')"
                , baglanti);
            kullaniciSearch.Parameters.AddWithValue("@searchBox", adSearchTextbox.Text);

            if(sehirSearchCombobox.SelectedIndex != -1) 
            {
                kullaniciSearch.Parameters.AddWithValue("@sehirCombo", sehirSearchCombobox.SelectedValue.ToString());
            }
            else 
            {
                kullaniciSearch.Parameters.AddWithValue("@sehirCombo", "");
            }

            if(rolSearchCombobox.SelectedIndex != -1) 
            {
                kullaniciSearch.Parameters.AddWithValue("@rolCombo", rolSearchCombobox.SelectedValue.ToString());
            }
            else 
            {
                kullaniciSearch.Parameters.AddWithValue("@rolCombo", "");
            }

            SqlDataAdapter oku = new SqlDataAdapter(kullaniciSearch);

            DataTable tb = new DataTable();
            oku.Fill(tb);

            kullaniciListe.DataSource = tb;

            DataGridViewColumn kod = kullaniciListe.Columns[0];
            DataGridViewColumn ad = kullaniciListe.Columns[1];
            DataGridViewColumn soyad = kullaniciListe.Columns[2];
            DataGridViewColumn eposta = kullaniciListe.Columns[3];
            DataGridViewColumn sehir = kullaniciListe.Columns[4];
            DataGridViewColumn rol = kullaniciListe.Columns[5];

            kod.Width = 60;
            ad.Width = 80;
            soyad.Width = 80;
            eposta.Width = 200;
            sehir.Width = 60;
            rol.Width = 50;

            DataGridViewImageColumn editBtn = new DataGridViewImageColumn();
            DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();

            editBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\edit_btn.png");
            editBtn.HeaderText = "";
            editBtn.Width = 36;

            deleteBtn.Image = Image.FromFile("C:\\Users\\furka\\source\\repos\\biletsatis\\biletsatis\\icons\\delete_btn.png");
            deleteBtn.HeaderText = "";
            deleteBtn.Width = 35;

            kullaniciListe.Columns.Add(editBtn);
            kullaniciListe.Columns.Add(deleteBtn);

        }

        private void adSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            searchKullanici();

            baglanti.Close();
        }

        private void rolSearchCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            searchKullanici();

            baglanti.Close();
        }

        private void sehirSearchCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            searchKullanici();

            baglanti.Close();
        }

        private void btn_Rastgele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            Random randomNumb = new Random();
            string[] isimler = new string[] {"Furkan", "Mehmet", "Ayşe", "Damla", "Merve", "Ahmet", "Hakan", "Yağız", "Aykut", "Aslı", "Feyza", "Mustafa", "Ali", "Murat", "Selin", "Hakkı", "Pelin", "Asya", "Can", "Ekrem", "Berke", "Hilal"};
            string[] soyisimler = new string[] { "Özdemir", "Candan", "Turgut", "Dürüst", "Taş", "Yılmaz", "Öz", "Koz", "Göz", "Ağaoğlu", "Genç", "Okur", "Yıldız", "Ekşi", "Mutlu", "Dağ", "Dalkıran", "Bulut", "Demir", "Çelik", "Bal", "Gökmen"};

            for(int i = 0; i < 5000; i++) 
            {
                int randNumb = randomNumb.Next(0, 22);
                string isim = isimler[randNumb];
                randNumb = randomNumb.Next(0, 22);
                string soyisim = soyisimler[randNumb];

                string eposta = isim.ToLower() + randomNumb.Next(0, 100).ToString() + soyisim.ToLower() + randomNumb.Next(0, 100).ToString() + "@mail.com";

                int rol = randomNumb.Next(0, 3);
                
                List<int> sehirCode = new List<int>();

                SqlCommand sehirCom = new SqlCommand("SELECT sehir_kodu FROM sehirler", baglanti);
                SqlDataReader oku = sehirCom.ExecuteReader();

                while (oku.Read())
                {
                    sehirCode.Add(Convert.ToInt32(oku[0]));
                }

                oku.Close();

                int sehir = sehirCode[randomNumb.Next(0, sehirCode.Count())];
                string sifre = "123";

                SqlCommand insertKullanici = new SqlCommand("INSERT INTO kullanicilar(ad, soyad, sehir, rol, eposta, sifre) VALUES(@ad, @soyad, @sehir, @rol, @eposta, @sifre)", baglanti);
                insertKullanici.Parameters.AddWithValue("@ad", isim);
                insertKullanici.Parameters.AddWithValue("@soyad", soyisim);
                insertKullanici.Parameters.AddWithValue("@sehir", sehir);
                insertKullanici.Parameters.AddWithValue("@rol", rol);
                insertKullanici.Parameters.AddWithValue("@eposta", eposta);
                insertKullanici.Parameters.AddWithValue("@sifre", sifre);

                insertKullanici.ExecuteNonQuery();
            }
            kullaniciListRefresh();

            List<int> musteriler = new List<int>();
            List<int> biletler = new List<int>();

            SqlCommand musterilerCom = new SqlCommand("SELECT * FROM kullanicilar WHERE rol = 1", baglanti);

            SqlDataReader okuSiparis = musterilerCom.ExecuteReader();

            while (okuSiparis.Read()) 
            {
                musteriler.Add(Convert.ToInt32(okuSiparis[0]));
            }

            okuSiparis.Close();

            SqlCommand biletlerCom = new SqlCommand("SELECT * FROM biletler WHERE durum = 1", baglanti);

            okuSiparis = biletlerCom.ExecuteReader();

            while (okuSiparis.Read()) 
            {
                biletler.Add(Convert.ToInt32(okuSiparis[0]));
            }

            okuSiparis.Close();

            int siparisAdet = randomNumb.Next(100, musteriler.Count());

            for(int i = 0; i < siparisAdet; i++) 
            {
                int iade = 0;
                int musteri = musteriler[randomNumb.Next(0, musteriler.Count())];
                int adet = randomNumb.Next(1, 4);
                int iadeCheck = randomNumb.Next(0, 100);
                int bilet = biletler[randomNumb.Next(0, biletler.Count())];

                if(iadeCheck >= 75) 
                {
                    iade = 1;
                }

                SqlCommand insertSiparis = new SqlCommand("INSERT INTO siparisler(adet, bilet, kullanici, iade) VALUES(@adet, @bilet, @kullanici, @iade)", baglanti);
                insertSiparis.Parameters.AddWithValue("@adet", adet);
                insertSiparis.Parameters.AddWithValue("@bilet", bilet);
                insertSiparis.Parameters.AddWithValue("@kullanici", musteri);
                insertSiparis.Parameters.AddWithValue("@iade", iade);

                insertSiparis.ExecuteNonQuery();
            }

            baglanti.Close();
        }
    }
}
