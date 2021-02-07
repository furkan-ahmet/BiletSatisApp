namespace biletsatis
{
    partial class biletler_ADD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBox = new System.Windows.Forms.PictureBox();
            this.biletAdi_Textbox = new System.Windows.Forms.TextBox();
            this.konum_Combo = new System.Windows.Forms.ComboBox();
            this.fotoSec_btn = new System.Windows.Forms.Button();
            this.alan_Combo = new System.Windows.Forms.ComboBox();
            this.tur_Combo = new System.Windows.Forms.ComboBox();
            this.sehir_Combo = new System.Windows.Forms.ComboBox();
            this.stok_Textbox = new System.Windows.Forms.TextBox();
            this.tarih_Picker = new System.Windows.Forms.DateTimePicker();
            this.fiyat_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.durum_Combo = new System.Windows.Forms.ComboBox();
            this.durumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(88, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(160, 140);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // biletAdi_Textbox
            // 
            this.biletAdi_Textbox.Location = new System.Drawing.Point(23, 205);
            this.biletAdi_Textbox.Name = "biletAdi_Textbox";
            this.biletAdi_Textbox.Size = new System.Drawing.Size(142, 20);
            this.biletAdi_Textbox.TabIndex = 1;
            // 
            // konum_Combo
            // 
            this.konum_Combo.FormattingEnabled = true;
            this.konum_Combo.Location = new System.Drawing.Point(182, 287);
            this.konum_Combo.Name = "konum_Combo";
            this.konum_Combo.Size = new System.Drawing.Size(142, 21);
            this.konum_Combo.TabIndex = 2;
            // 
            // fotoSec_btn
            // 
            this.fotoSec_btn.Location = new System.Drawing.Point(118, 158);
            this.fotoSec_btn.Name = "fotoSec_btn";
            this.fotoSec_btn.Size = new System.Drawing.Size(100, 23);
            this.fotoSec_btn.TabIndex = 3;
            this.fotoSec_btn.Text = "Fotoğraf Seç";
            this.fotoSec_btn.UseVisualStyleBackColor = true;
            this.fotoSec_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // alan_Combo
            // 
            this.alan_Combo.FormattingEnabled = true;
            this.alan_Combo.Location = new System.Drawing.Point(23, 246);
            this.alan_Combo.Name = "alan_Combo";
            this.alan_Combo.Size = new System.Drawing.Size(142, 21);
            this.alan_Combo.TabIndex = 4;
            this.alan_Combo.SelectionChangeCommitted += new System.EventHandler(this.alan_Combo_SelectionChangeCommitted);
            // 
            // tur_Combo
            // 
            this.tur_Combo.FormattingEnabled = true;
            this.tur_Combo.Location = new System.Drawing.Point(182, 246);
            this.tur_Combo.Name = "tur_Combo";
            this.tur_Combo.Size = new System.Drawing.Size(142, 21);
            this.tur_Combo.TabIndex = 5;
            // 
            // sehir_Combo
            // 
            this.sehir_Combo.FormattingEnabled = true;
            this.sehir_Combo.Location = new System.Drawing.Point(23, 287);
            this.sehir_Combo.Name = "sehir_Combo";
            this.sehir_Combo.Size = new System.Drawing.Size(142, 21);
            this.sehir_Combo.TabIndex = 6;
            this.sehir_Combo.SelectionChangeCommitted += new System.EventHandler(this.sehir_Combo_SelectionChangeCommitted);
            // 
            // stok_Textbox
            // 
            this.stok_Textbox.Location = new System.Drawing.Point(182, 205);
            this.stok_Textbox.Name = "stok_Textbox";
            this.stok_Textbox.Size = new System.Drawing.Size(142, 20);
            this.stok_Textbox.TabIndex = 7;
            // 
            // tarih_Picker
            // 
            this.tarih_Picker.Location = new System.Drawing.Point(182, 329);
            this.tarih_Picker.Name = "tarih_Picker";
            this.tarih_Picker.Size = new System.Drawing.Size(142, 20);
            this.tarih_Picker.TabIndex = 8;
            // 
            // fiyat_Textbox
            // 
            this.fiyat_Textbox.Location = new System.Drawing.Point(23, 329);
            this.fiyat_Textbox.Name = "fiyat_Textbox";
            this.fiyat_Textbox.Size = new System.Drawing.Size(142, 20);
            this.fiyat_Textbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bilet Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stok :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Alan :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tür :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Şehir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Konum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tarih :";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(232, 368);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(92, 28);
            this.btn_Save.TabIndex = 18;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(23, 368);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(92, 28);
            this.btn_Cancel.TabIndex = 19;
            this.btn_Cancel.Text = "İptal";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // durum_Combo
            // 
            this.durum_Combo.FormattingEnabled = true;
            this.durum_Combo.Location = new System.Drawing.Point(121, 373);
            this.durum_Combo.Name = "durum_Combo";
            this.durum_Combo.Size = new System.Drawing.Size(105, 21);
            this.durum_Combo.TabIndex = 20;
            this.durum_Combo.Visible = false;
            // 
            // durumLabel
            // 
            this.durumLabel.AutoSize = true;
            this.durumLabel.Location = new System.Drawing.Point(118, 357);
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(44, 13);
            this.durumLabel.TabIndex = 21;
            this.durumLabel.Text = "Durum :";
            this.durumLabel.Visible = false;
            // 
            // biletler_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 408);
            this.Controls.Add(this.durumLabel);
            this.Controls.Add(this.durum_Combo);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fiyat_Textbox);
            this.Controls.Add(this.tarih_Picker);
            this.Controls.Add(this.stok_Textbox);
            this.Controls.Add(this.sehir_Combo);
            this.Controls.Add(this.tur_Combo);
            this.Controls.Add(this.alan_Combo);
            this.Controls.Add(this.fotoSec_btn);
            this.Controls.Add(this.konum_Combo);
            this.Controls.Add(this.biletAdi_Textbox);
            this.Controls.Add(this.picBox);
            this.MaximumSize = new System.Drawing.Size(362, 447);
            this.MinimumSize = new System.Drawing.Size(362, 447);
            this.Name = "biletler_ADD";
            this.Text = "Bilet Ekle";
            this.Load += new System.EventHandler(this.biletler_ADD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox biletAdi_Textbox;
        private System.Windows.Forms.ComboBox konum_Combo;
        private System.Windows.Forms.Button fotoSec_btn;
        private System.Windows.Forms.ComboBox alan_Combo;
        private System.Windows.Forms.ComboBox tur_Combo;
        private System.Windows.Forms.ComboBox sehir_Combo;
        private System.Windows.Forms.TextBox stok_Textbox;
        private System.Windows.Forms.DateTimePicker tarih_Picker;
        private System.Windows.Forms.TextBox fiyat_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox durum_Combo;
        private System.Windows.Forms.Label durumLabel;
    }
}