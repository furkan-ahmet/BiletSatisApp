namespace biletsatis
{
    partial class biletlerimList
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
            this.biletlerimListesi = new System.Windows.Forms.DataGridView();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.search_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sehir_Combo = new System.Windows.Forms.ComboBox();
            this.durum_Combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_RandomAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerimListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // biletlerimListesi
            // 
            this.biletlerimListesi.AllowUserToAddRows = false;
            this.biletlerimListesi.AllowUserToDeleteRows = false;
            this.biletlerimListesi.AllowUserToResizeColumns = false;
            this.biletlerimListesi.AllowUserToResizeRows = false;
            this.biletlerimListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.biletlerimListesi.Location = new System.Drawing.Point(12, 90);
            this.biletlerimListesi.Name = "biletlerimListesi";
            this.biletlerimListesi.RowHeadersVisible = false;
            this.biletlerimListesi.Size = new System.Drawing.Size(563, 339);
            this.biletlerimListesi.TabIndex = 0;
            this.biletlerimListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.biletlerimListesi_CellClick);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(12, 12);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(75, 23);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.Text = "<-- Menü";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(490, 10);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(85, 26);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // search_Textbox
            // 
            this.search_Textbox.Location = new System.Drawing.Point(12, 62);
            this.search_Textbox.Name = "search_Textbox";
            this.search_Textbox.Size = new System.Drawing.Size(131, 20);
            this.search_Textbox.TabIndex = 3;
            this.search_Textbox.TextChanged += new System.EventHandler(this.search_Textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ara :";
            // 
            // sehir_Combo
            // 
            this.sehir_Combo.FormattingEnabled = true;
            this.sehir_Combo.Location = new System.Drawing.Point(162, 62);
            this.sehir_Combo.Name = "sehir_Combo";
            this.sehir_Combo.Size = new System.Drawing.Size(131, 21);
            this.sehir_Combo.TabIndex = 5;
            this.sehir_Combo.SelectionChangeCommitted += new System.EventHandler(this.sehir_Combo_SelectionChangeCommitted);
            // 
            // durum_Combo
            // 
            this.durum_Combo.FormattingEnabled = true;
            this.durum_Combo.Location = new System.Drawing.Point(316, 62);
            this.durum_Combo.Name = "durum_Combo";
            this.durum_Combo.Size = new System.Drawing.Size(131, 21);
            this.durum_Combo.TabIndex = 6;
            this.durum_Combo.SelectionChangeCommitted += new System.EventHandler(this.durum_Combo_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şehir :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Durumu :";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(490, 58);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(85, 26);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Temizle";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_RandomAdd
            // 
            this.btn_RandomAdd.Location = new System.Drawing.Point(356, 10);
            this.btn_RandomAdd.Name = "btn_RandomAdd";
            this.btn_RandomAdd.Size = new System.Drawing.Size(119, 26);
            this.btn_RandomAdd.TabIndex = 10;
            this.btn_RandomAdd.Text = "Rastgele Ekle";
            this.btn_RandomAdd.UseVisualStyleBackColor = true;
            this.btn_RandomAdd.Click += new System.EventHandler(this.btn_RandomAdd_Click);
            // 
            // biletlerimList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 440);
            this.Controls.Add(this.btn_RandomAdd);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.durum_Combo);
            this.Controls.Add(this.sehir_Combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_Textbox);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.biletlerimListesi);
            this.MaximumSize = new System.Drawing.Size(603, 479);
            this.MinimumSize = new System.Drawing.Size(603, 479);
            this.Name = "biletlerimList";
            this.Text = "Biletlerim";
            this.Load += new System.EventHandler(this.biletlerimList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biletlerimListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView biletlerimListesi;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox search_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sehir_Combo;
        private System.Windows.Forms.ComboBox durum_Combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_RandomAdd;
    }
}