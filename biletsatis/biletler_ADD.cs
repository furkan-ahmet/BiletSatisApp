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
using System.Text.RegularExpressions;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;

namespace biletsatis
{
    public partial class biletler_ADD : Form
    {
        public biletler_ADD()
        {
            InitializeComponent();
        }

        public bool isAdmin;
        public bool isEdit;
        public int kullaniciId;
        public int biletId;
        string path;
        string destLoc = AppDomain.CurrentDomain.BaseDirectory + "\\photos";
        string fileName;
        string photoName;
        SqlConnection baglanti = new SqlConnection("Server = DESKTOP-VPTEM77\\SQLEXPRESS; Initial Catalog = biletsatis; Integrated Security = true;");

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fotoSec = new OpenFileDialog();
            fotoSec.Title = "Yüklemek için bir fotoğraf seç.";
            fotoSec.Filter = "Image Files (*.jpg; *.jpeg; *.png;)|*.jpg;*.jpeg;*.png";
            fotoSec.FilterIndex = 1;
            if (fotoSec.ShowDialog() == DialogResult.OK) 
            {
                picBox.Image = new Bitmap(fotoSec.FileName);
                path = Path.GetFullPath(fotoSec.FileName);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            if (isEdit) 
            {
                SqlCommand biletEdit = new SqlCommand("UPDATE biletler SET bilet_adi = @biletAdi, sehir = @sehir, konum = @konum, tur = @tur, fiyat = @fiyat, alan = @alan, tarih = @tarih, stok = @stok, foto = @foto WHERE bilet_kodu = @biletId", baglanti);
                biletEdit.Parameters.AddWithValue("@biletAdi", biletAdi_Textbox.Text);
                biletEdit.Parameters.AddWithValue("@sehir", sehir_Combo.SelectedValue);
                biletEdit.Parameters.AddWithValue("@konum", konum_Combo.SelectedValue);
                biletEdit.Parameters.AddWithValue("@tur", tur_Combo.SelectedValue);
                biletEdit.Parameters.AddWithValue("@fiyat", fiyat_Textbox.Text);
                biletEdit.Parameters.AddWithValue("@alan", alan_Combo.SelectedValue);
                biletEdit.Parameters.AddWithValue("@tarih", tarih_Picker.Value);
                biletEdit.Parameters.AddWithValue("@stok", stok_Textbox.Text);
                biletEdit.Parameters.AddWithValue("@biletId", biletId);
                
                if(photoName != "nofoto") 
                {
                    picBox.Image.Save(AppDomain.CurrentDomain.BaseDirectory + "\\photos\\" + photoName + ".jpg");
                }

                biletEdit.Parameters.AddWithValue("@foto", AppDomain.CurrentDomain.BaseDirectory + "\\photos\\" + photoName + ".jpg");

                if (biletAdi_Textbox.Text == null || sehir_Combo.SelectedValue == null || konum_Combo.SelectedValue == null || tur_Combo.SelectedValue == null || fiyat_Textbox.Text == null || alan_Combo.SelectedValue == null || stok_Textbox.Text == null || path == null)
                {
                    MessageBox.Show("Alanlar boş bırakılamaz!", "Dikkat!");
                }
                else 
                {
                    if (Regex.IsMatch(stok_Textbox.Text, @"^\d+$") && Regex.IsMatch(fiyat_Textbox.Text, @"^\d+$"))
                    {
                        int stok = Convert.ToInt32(stok_Textbox.Text);
                        if (stok > 0)
                        {
                            biletEdit.ExecuteNonQuery();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Stok 0'dan büyük olmalıdır");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz stok veya fiyat bilgisi!");
                    }
                }
            }
            else if (isAdmin) 
            {
                if(durum_Combo.SelectedIndex == 2) 
                {
                    SqlCommand deleteBilet = new SqlCommand("DELETE FROM biletler WHERE bilet_kodu = @biletKodu", baglanti);
                    deleteBilet.Parameters.AddWithValue("@biletKodu", biletId);

                    deleteBilet.ExecuteNonQuery();
                }
                else 
                {
                    SqlCommand updateDurum = new SqlCommand("UPDATE biletler SET durum = @durum WHERE bilet_kodu = @biletKodu", baglanti);
                    updateDurum.Parameters.AddWithValue("@durum", durum_Combo.SelectedValue);
                    updateDurum.Parameters.AddWithValue("@biletKodu", biletId);

                    updateDurum.ExecuteNonQuery();
                }
                
                this.Close();
            }
            else 
            {
                SqlCommand biletEkle = new SqlCommand("INSERT INTO biletler(bilet_adi, sehir, konum, tur, fiyat, alan, tarih, durum, stok, foto, olusturan) VALUES(@biletAdi, @sehir, @konum, @tur, @fiyat, @alan, @tarih, 0, @stok, @foto, @olusturan)", baglanti);
                biletEkle.Parameters.AddWithValue("@biletAdi", biletAdi_Textbox.Text);
                biletEkle.Parameters.AddWithValue("@sehir", sehir_Combo.SelectedValue);
                biletEkle.Parameters.AddWithValue("@konum", konum_Combo.SelectedValue);
                biletEkle.Parameters.AddWithValue("@tur", tur_Combo.SelectedValue);
                biletEkle.Parameters.AddWithValue("@fiyat", fiyat_Textbox.Text);
                biletEkle.Parameters.AddWithValue("@alan", alan_Combo.SelectedValue);
                biletEkle.Parameters.AddWithValue("@tarih", tarih_Picker.Value);
                biletEkle.Parameters.AddWithValue("@stok", stok_Textbox.Text);

                biletEkle.Parameters.AddWithValue("@olusturan", kullaniciId);

                if (biletAdi_Textbox.Text == null || sehir_Combo.SelectedValue == null || konum_Combo.SelectedValue == null || tur_Combo.SelectedValue == null || fiyat_Textbox.Text == null || alan_Combo.SelectedValue == null || stok_Textbox.Text == null || path == null)
                {
                    MessageBox.Show("Alanlar boş bırakılamaz!", "Dikkat!");
                }
                else
                {
                    if (Regex.IsMatch(stok_Textbox.Text, @"^\d+$") && Regex.IsMatch(fiyat_Textbox.Text, @"^\d+$"))
                    {
                        int stok = Convert.ToInt32(stok_Textbox.Text);
                        if (stok > 0)
                        {
                            Random randomNumb = new Random();
                            int randFileName = randomNumb.Next(100000, 999999);
                            while (File.Exists(destLoc + "\\" + randFileName.ToString() + ".jpg"))
                            {
                                randFileName = randomNumb.Next(100000, 999999);
                            }
                            picBox.Image.Save(destLoc + "\\" + randFileName.ToString() + ".jpg");
                            byte[] foto = GetPhoto(destLoc + "\\" + randFileName.ToString() + ".jpg");
                            biletEkle.Parameters.AddWithValue("@foto", destLoc + "\\" + randFileName.ToString() + ".jpg");
                            biletEkle.ExecuteNonQuery();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Stok 0'dan büyük olmalıdır");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz stok veya fiyat bilgisi!");
                    }
                }
            }

            baglanti.Close();
        }

        public static byte[] GetPhoto(string filePath) 
        {
            FileStream stream = new FileStream(
            filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }

        private void biletler_ADD_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sehirCombo = new SqlCommand("SELECT * FROM sehirler", baglanti);

            SqlDataReader doldur = sehirCombo.ExecuteReader();
            DataTable tb1 = new DataTable();
            tb1.Load(doldur);

            sehir_Combo.DataSource = tb1;
            sehir_Combo.DisplayMember = "sehir";
            sehir_Combo.ValueMember = "sehir_kodu";
            sehir_Combo.SelectedIndex = -1;

            doldur.Close();

            SqlCommand alanCombo = new SqlCommand("SELECT * FROM alanlar", baglanti);

            doldur = alanCombo.ExecuteReader();
            DataTable tb2 = new DataTable();
            tb2.Load(doldur);

            alan_Combo.DataSource = tb2;
            alan_Combo.DisplayMember = "alan";
            alan_Combo.ValueMember = "alan_kodu";
            alan_Combo.SelectedIndex = -1;

            doldur.Close();

            if (isAdmin) 
            {
                fotoSec_btn.Visible = false;
                biletAdi_Textbox.Enabled = false;
                stok_Textbox.Enabled = false;
                alan_Combo.Enabled = false;
                tur_Combo.Enabled = false;
                sehir_Combo.Enabled = false;
                konum_Combo.Enabled = false;
                fiyat_Textbox.Enabled = false;
                tarih_Picker.Enabled = false;
                durumLabel.Visible = true;
                durum_Combo.Visible = true;

                SqlCommand durumCombo = new SqlCommand("SELECT * FROM durumlar", baglanti);

                doldur = durumCombo.ExecuteReader();
                DataTable tb5 = new DataTable();
                tb5.Load(doldur);

                durum_Combo.DataSource = tb5;
                durum_Combo.DisplayMember = "durum";
                durum_Combo.ValueMember = "durum_kod";
            }


            if (isEdit || isAdmin) 
            {
                SqlCommand loadEditBilet = new SqlCommand("SELECT foto, bilet_adi, sehir, konum, tur, fiyat, alan, tarih, stok, durum FROM biletler WHERE bilet_kodu = @biletKodu", baglanti);
                loadEditBilet.Parameters.AddWithValue("@biletKodu", biletId);

                SqlDataReader oku = loadEditBilet.ExecuteReader();
                string turVal = "";
                string konumVal = "";
                while (oku.Read()) 
                {
                    picBox.Image = Image.FromFile(oku[0].ToString());
                    biletAdi_Textbox.Text = oku[1].ToString();
                    sehir_Combo.SelectedValue = oku[2].ToString();
                    konumVal = oku[3].ToString();
                    alan_Combo.SelectedValue = oku[6].ToString();
                    turVal = oku[4].ToString();
                    fiyat_Textbox.Text = Convert.ToInt32(oku[5]).ToString();
                    tarih_Picker.Value = Convert.ToDateTime(oku[7].ToString());
                    stok_Textbox.Text = oku[8].ToString();
                    path = oku[0].ToString();
                    photoName = oku[0].ToString().Substring(68);
                    durum_Combo.SelectedValue = oku[9].ToString();

                    if (oku[9].ToString() == "1")
                    {
                        fotoSec_btn.Visible = false;
                        biletAdi_Textbox.Enabled = false;
                        alan_Combo.Enabled = false;
                        tur_Combo.Enabled = false;
                        sehir_Combo.Enabled = false;
                        konum_Combo.Enabled = false;
                        fiyat_Textbox.Enabled = false;
                        tarih_Picker.Enabled = false;
                    }
                }
                oku.Close(); 

                
                
                turComboCall();
                konumComboCall();
                tur_Combo.SelectedValue = turVal;
                konum_Combo.SelectedValue = konumVal;
            }

            baglanti.Close();
        }

        private void alan_Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            baglanti.Open();

            turComboCall();

            baglanti.Close();
        }

        private void sehir_Combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            baglanti.Open();

            konumComboCall();

            baglanti.Close();
        }

        public void turComboCall()
        {
            SqlCommand turCombo = new SqlCommand("SELECT * FROM turler WHERE alan = @alan", baglanti);
            turCombo.Parameters.AddWithValue("@alan", alan_Combo.SelectedValue);

            SqlDataReader doldur = turCombo.ExecuteReader();
            DataTable tb3 = new DataTable();
            tb3.Load(doldur);

            tur_Combo.DataSource = tb3;
            tur_Combo.DisplayMember = "tur_adi";
            tur_Combo.ValueMember = "tur_kodu";
            tur_Combo.SelectedIndex = -1;

            doldur.Close();
        }

        public void konumComboCall() 
        {
            SqlCommand konumCombo = new SqlCommand("SELECT * FROM konumlar WHERE sehir = @sehir", baglanti);
            konumCombo.Parameters.AddWithValue("@sehir", sehir_Combo.SelectedValue);

            SqlDataReader doldur = konumCombo.ExecuteReader();
            DataTable tb4 = new DataTable();
            tb4.Load(doldur);

            konum_Combo.DataSource = tb4;
            konum_Combo.DisplayMember = "konum_adi";
            konum_Combo.ValueMember = "konum_kodu";
            konum_Combo.SelectedIndex = -1;

            doldur.Close();
        }
    }
}
