namespace biletsatis
{
    partial class kullanicilar
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
            this.kullaniciListe = new System.Windows.Forms.DataGridView();
            this.adSearchTextbox = new System.Windows.Forms.TextBox();
            this.rolSearchCombobox = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sehirSearchCombobox = new System.Windows.Forms.ComboBox();
            this.btn_Rastgele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciListe)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciListe
            // 
            this.kullaniciListe.AllowUserToAddRows = false;
            this.kullaniciListe.AllowUserToDeleteRows = false;
            this.kullaniciListe.AllowUserToResizeColumns = false;
            this.kullaniciListe.AllowUserToResizeRows = false;
            this.kullaniciListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullaniciListe.Location = new System.Drawing.Point(12, 88);
            this.kullaniciListe.Name = "kullaniciListe";
            this.kullaniciListe.RowHeadersVisible = false;
            this.kullaniciListe.Size = new System.Drawing.Size(604, 280);
            this.kullaniciListe.TabIndex = 0;
            this.kullaniciListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kullaniciListe_CellClick);
            // 
            // adSearchTextbox
            // 
            this.adSearchTextbox.Location = new System.Drawing.Point(12, 52);
            this.adSearchTextbox.Name = "adSearchTextbox";
            this.adSearchTextbox.Size = new System.Drawing.Size(125, 20);
            this.adSearchTextbox.TabIndex = 1;
            this.adSearchTextbox.TextChanged += new System.EventHandler(this.adSearchTextbox_TextChanged);
            // 
            // rolSearchCombobox
            // 
            this.rolSearchCombobox.FormattingEnabled = true;
            this.rolSearchCombobox.Location = new System.Drawing.Point(152, 51);
            this.rolSearchCombobox.Name = "rolSearchCombobox";
            this.rolSearchCombobox.Size = new System.Drawing.Size(131, 21);
            this.rolSearchCombobox.TabIndex = 2;
            this.rolSearchCombobox.SelectionChangeCommitted += new System.EventHandler(this.rolSearchCombobox_SelectionChangeCommitted);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(541, 50);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Temizle";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rol";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 7);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "<-- Menü";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şehir";
            // 
            // sehirSearchCombobox
            // 
            this.sehirSearchCombobox.FormattingEnabled = true;
            this.sehirSearchCombobox.Location = new System.Drawing.Point(299, 52);
            this.sehirSearchCombobox.Name = "sehirSearchCombobox";
            this.sehirSearchCombobox.Size = new System.Drawing.Size(131, 21);
            this.sehirSearchCombobox.TabIndex = 8;
            this.sehirSearchCombobox.SelectionChangeCommitted += new System.EventHandler(this.sehirSearchCombobox_SelectionChangeCommitted);
            // 
            // btn_Rastgele
            // 
            this.btn_Rastgele.Enabled = false;
            this.btn_Rastgele.Location = new System.Drawing.Point(497, 7);
            this.btn_Rastgele.Name = "btn_Rastgele";
            this.btn_Rastgele.Size = new System.Drawing.Size(119, 23);
            this.btn_Rastgele.TabIndex = 10;
            this.btn_Rastgele.Text = "Rastgele Oluştur";
            this.btn_Rastgele.UseVisualStyleBackColor = true;
            this.btn_Rastgele.Click += new System.EventHandler(this.btn_Rastgele_Click);
            // 
            // kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 378);
            this.Controls.Add(this.btn_Rastgele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sehirSearchCombobox);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.rolSearchCombobox);
            this.Controls.Add(this.adSearchTextbox);
            this.Controls.Add(this.kullaniciListe);
            this.MaximumSize = new System.Drawing.Size(644, 417);
            this.MinimumSize = new System.Drawing.Size(644, 417);
            this.Name = "kullanicilar";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.kullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kullaniciListe;
        private System.Windows.Forms.TextBox adSearchTextbox;
        private System.Windows.Forms.ComboBox rolSearchCombobox;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sehirSearchCombobox;
        private System.Windows.Forms.Button btn_Rastgele;
    }
}