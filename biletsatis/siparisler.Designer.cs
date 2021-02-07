namespace biletsatis
{
    partial class siparisler
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
            this.siparisler_List = new System.Windows.Forms.DataGridView();
            this.searchBox_text = new System.Windows.Forms.TextBox();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.musteriKodu_Combo = new System.Windows.Forms.ComboBox();
            this.biletKodu_Combo = new System.Windows.Forms.ComboBox();
            this.musteriKodu_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siparisAdet_Label = new System.Windows.Forms.Label();
            this.siparisAdet_text = new System.Windows.Forms.Label();
            this.btn_Iade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.siparisler_List)).BeginInit();
            this.SuspendLayout();
            // 
            // siparisler_List
            // 
            this.siparisler_List.AllowUserToAddRows = false;
            this.siparisler_List.AllowUserToDeleteRows = false;
            this.siparisler_List.AllowUserToResizeColumns = false;
            this.siparisler_List.AllowUserToResizeRows = false;
            this.siparisler_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparisler_List.Location = new System.Drawing.Point(12, 89);
            this.siparisler_List.Name = "siparisler_List";
            this.siparisler_List.RowHeadersVisible = false;
            this.siparisler_List.Size = new System.Drawing.Size(583, 315);
            this.siparisler_List.TabIndex = 0;
            this.siparisler_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.siparisler_List_CellClick);
            // 
            // searchBox_text
            // 
            this.searchBox_text.Location = new System.Drawing.Point(12, 57);
            this.searchBox_text.Name = "searchBox_text";
            this.searchBox_text.Size = new System.Drawing.Size(143, 20);
            this.searchBox_text.TabIndex = 1;
            this.searchBox_text.TextChanged += new System.EventHandler(this.searchBox_text_TextChanged);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(12, 12);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(75, 23);
            this.btn_Menu.TabIndex = 3;
            this.btn_Menu.Text = "<-- Menü";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ara :";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(520, 55);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Temizle";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // musteriKodu_Combo
            // 
            this.musteriKodu_Combo.FormattingEnabled = true;
            this.musteriKodu_Combo.Location = new System.Drawing.Point(345, 56);
            this.musteriKodu_Combo.Name = "musteriKodu_Combo";
            this.musteriKodu_Combo.Size = new System.Drawing.Size(143, 21);
            this.musteriKodu_Combo.TabIndex = 8;
            this.musteriKodu_Combo.Visible = false;
            this.musteriKodu_Combo.SelectionChangeCommitted += new System.EventHandler(this.musteriKodu_Combo_SelectionChangeCommitted);
            // 
            // biletKodu_Combo
            // 
            this.biletKodu_Combo.FormattingEnabled = true;
            this.biletKodu_Combo.Location = new System.Drawing.Point(177, 56);
            this.biletKodu_Combo.Name = "biletKodu_Combo";
            this.biletKodu_Combo.Size = new System.Drawing.Size(143, 21);
            this.biletKodu_Combo.TabIndex = 9;
            this.biletKodu_Combo.SelectionChangeCommitted += new System.EventHandler(this.biletKodu_Combo_SelectionChangeCommitted);
            // 
            // musteriKodu_label
            // 
            this.musteriKodu_label.AutoSize = true;
            this.musteriKodu_label.Location = new System.Drawing.Point(342, 40);
            this.musteriKodu_label.Name = "musteriKodu_label";
            this.musteriKodu_label.Size = new System.Drawing.Size(75, 13);
            this.musteriKodu_label.TabIndex = 10;
            this.musteriKodu_label.Text = "Müşteri Kodu :";
            this.musteriKodu_label.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bilet Kodu :";
            // 
            // siparisAdet_Label
            // 
            this.siparisAdet_Label.AutoSize = true;
            this.siparisAdet_Label.Location = new System.Drawing.Point(497, 11);
            this.siparisAdet_Label.Name = "siparisAdet_Label";
            this.siparisAdet_Label.Size = new System.Drawing.Size(82, 13);
            this.siparisAdet_Label.TabIndex = 12;
            this.siparisAdet_Label.Text = "Toplam Sipariş :";
            this.siparisAdet_Label.Visible = false;
            // 
            // siparisAdet_text
            // 
            this.siparisAdet_text.AutoSize = true;
            this.siparisAdet_text.Location = new System.Drawing.Point(582, 12);
            this.siparisAdet_text.Name = "siparisAdet_text";
            this.siparisAdet_text.Size = new System.Drawing.Size(13, 13);
            this.siparisAdet_text.TabIndex = 13;
            this.siparisAdet_text.Text = "0";
            this.siparisAdet_text.Visible = false;
            // 
            // btn_Iade
            // 
            this.btn_Iade.Location = new System.Drawing.Point(520, 28);
            this.btn_Iade.Name = "btn_Iade";
            this.btn_Iade.Size = new System.Drawing.Size(75, 23);
            this.btn_Iade.TabIndex = 14;
            this.btn_Iade.Text = "İadeler";
            this.btn_Iade.UseVisualStyleBackColor = true;
            this.btn_Iade.Visible = false;
            this.btn_Iade.Click += new System.EventHandler(this.btn_Iade_Click);
            // 
            // siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 418);
            this.Controls.Add(this.btn_Iade);
            this.Controls.Add(this.siparisAdet_text);
            this.Controls.Add(this.siparisAdet_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.musteriKodu_label);
            this.Controls.Add(this.biletKodu_Combo);
            this.Controls.Add(this.musteriKodu_Combo);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.searchBox_text);
            this.Controls.Add(this.siparisler_List);
            this.MaximumSize = new System.Drawing.Size(620, 457);
            this.MinimumSize = new System.Drawing.Size(620, 457);
            this.Name = "siparisler";
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.siparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siparisler_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView siparisler_List;
        private System.Windows.Forms.TextBox searchBox_text;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox musteriKodu_Combo;
        private System.Windows.Forms.ComboBox biletKodu_Combo;
        private System.Windows.Forms.Label musteriKodu_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label siparisAdet_Label;
        private System.Windows.Forms.Label siparisAdet_text;
        private System.Windows.Forms.Button btn_Iade;
    }
}