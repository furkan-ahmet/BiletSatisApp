namespace biletsatis
{
    partial class bilet_List
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
            this.biletList_table = new System.Windows.Forms.DataGridView();
            this.search_Textbox = new System.Windows.Forms.TextBox();
            this.konum_Select = new System.Windows.Forms.ComboBox();
            this.tur_Select = new System.Windows.Forms.ComboBox();
            this.sehir_Select = new System.Windows.Forms.ComboBox();
            this.alan_Select = new System.Windows.Forms.ComboBox();
            this.btn_Sifirla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.biletList_table)).BeginInit();
            this.SuspendLayout();
            // 
            // biletList_table
            // 
            this.biletList_table.AllowUserToAddRows = false;
            this.biletList_table.AllowUserToDeleteRows = false;
            this.biletList_table.AllowUserToResizeColumns = false;
            this.biletList_table.AllowUserToResizeRows = false;
            this.biletList_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.biletList_table.Location = new System.Drawing.Point(12, 89);
            this.biletList_table.Name = "biletList_table";
            this.biletList_table.RowHeadersVisible = false;
            this.biletList_table.Size = new System.Drawing.Size(764, 339);
            this.biletList_table.TabIndex = 0;
            this.biletList_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.biletList_table_CellClick);
            // 
            // search_Textbox
            // 
            this.search_Textbox.Location = new System.Drawing.Point(12, 55);
            this.search_Textbox.Name = "search_Textbox";
            this.search_Textbox.Size = new System.Drawing.Size(142, 20);
            this.search_Textbox.TabIndex = 1;
            this.search_Textbox.TextChanged += new System.EventHandler(this.search_Textbox_TextChanged);
            // 
            // konum_Select
            // 
            this.konum_Select.FormattingEnabled = true;
            this.konum_Select.Location = new System.Drawing.Point(329, 55);
            this.konum_Select.Name = "konum_Select";
            this.konum_Select.Size = new System.Drawing.Size(142, 21);
            this.konum_Select.TabIndex = 2;
            this.konum_Select.SelectionChangeCommitted += new System.EventHandler(this.konum_Select_SelectionChangeCommitted);
            // 
            // tur_Select
            // 
            this.tur_Select.FormattingEnabled = true;
            this.tur_Select.Location = new System.Drawing.Point(169, 55);
            this.tur_Select.Name = "tur_Select";
            this.tur_Select.Size = new System.Drawing.Size(142, 21);
            this.tur_Select.TabIndex = 3;
            this.tur_Select.SelectionChangeCommitted += new System.EventHandler(this.tur_Select_SelectionChangeCommitted);
            // 
            // sehir_Select
            // 
            this.sehir_Select.FormattingEnabled = true;
            this.sehir_Select.Location = new System.Drawing.Point(329, 17);
            this.sehir_Select.Name = "sehir_Select";
            this.sehir_Select.Size = new System.Drawing.Size(142, 21);
            this.sehir_Select.TabIndex = 4;
            this.sehir_Select.SelectionChangeCommitted += new System.EventHandler(this.sehir_Select_SelectionChangeCommitted);
            // 
            // alan_Select
            // 
            this.alan_Select.FormattingEnabled = true;
            this.alan_Select.Location = new System.Drawing.Point(169, 19);
            this.alan_Select.Name = "alan_Select";
            this.alan_Select.Size = new System.Drawing.Size(142, 21);
            this.alan_Select.TabIndex = 5;
            this.alan_Select.SelectionChangeCommitted += new System.EventHandler(this.alan_Select_SelectionChangeCommitted);
            // 
            // btn_Sifirla
            // 
            this.btn_Sifirla.Location = new System.Drawing.Point(678, 52);
            this.btn_Sifirla.Name = "btn_Sifirla";
            this.btn_Sifirla.Size = new System.Drawing.Size(98, 23);
            this.btn_Sifirla.TabIndex = 8;
            this.btn_Sifirla.Text = "Sıfırla";
            this.btn_Sifirla.UseVisualStyleBackColor = true;
            this.btn_Sifirla.Click += new System.EventHandler(this.btn_Sifirla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ara :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Alan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tür";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şehir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Konum";
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(12, 9);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(75, 23);
            this.btn_Menu.TabIndex = 15;
            this.btn_Menu.Text = "<-- Menü";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // bilet_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 440);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sifirla);
            this.Controls.Add(this.alan_Select);
            this.Controls.Add(this.sehir_Select);
            this.Controls.Add(this.tur_Select);
            this.Controls.Add(this.konum_Select);
            this.Controls.Add(this.search_Textbox);
            this.Controls.Add(this.biletList_table);
            this.MaximumSize = new System.Drawing.Size(804, 479);
            this.MinimumSize = new System.Drawing.Size(804, 479);
            this.Name = "bilet_List";
            this.Text = "Biletler";
            this.Load += new System.EventHandler(this.bilet_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biletList_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView biletList_table;
        private System.Windows.Forms.TextBox search_Textbox;
        private System.Windows.Forms.ComboBox konum_Select;
        private System.Windows.Forms.ComboBox tur_Select;
        private System.Windows.Forms.ComboBox sehir_Select;
        private System.Windows.Forms.ComboBox alan_Select;
        private System.Windows.Forms.Button btn_Sifirla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Menu;
    }
}