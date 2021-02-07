namespace biletsatis
{
    partial class profil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ad_Textbox = new System.Windows.Forms.TextBox();
            this.soyad_Textbox = new System.Windows.Forms.TextBox();
            this.eposta_Textbox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.sehir_Combobox = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_PassEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "e-Posta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şehir : ";
            // 
            // ad_Textbox
            // 
            this.ad_Textbox.Location = new System.Drawing.Point(77, 16);
            this.ad_Textbox.Name = "ad_Textbox";
            this.ad_Textbox.Size = new System.Drawing.Size(166, 20);
            this.ad_Textbox.TabIndex = 5;
            // 
            // soyad_Textbox
            // 
            this.soyad_Textbox.Location = new System.Drawing.Point(77, 50);
            this.soyad_Textbox.Name = "soyad_Textbox";
            this.soyad_Textbox.Size = new System.Drawing.Size(166, 20);
            this.soyad_Textbox.TabIndex = 6;
            // 
            // eposta_Textbox
            // 
            this.eposta_Textbox.Location = new System.Drawing.Point(77, 86);
            this.eposta_Textbox.Name = "eposta_Textbox";
            this.eposta_Textbox.Size = new System.Drawing.Size(166, 20);
            this.eposta_Textbox.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(77, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "**********";
            // 
            // sehir_Combobox
            // 
            this.sehir_Combobox.FormattingEnabled = true;
            this.sehir_Combobox.Location = new System.Drawing.Point(77, 159);
            this.sehir_Combobox.Name = "sehir_Combobox";
            this.sehir_Combobox.Size = new System.Drawing.Size(166, 21);
            this.sehir_Combobox.TabIndex = 9;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(15, 198);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(82, 23);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "İptal";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(161, 198);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(82, 23);
            this.btn_Kaydet.TabIndex = 11;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_PassEdit
            // 
            this.btn_PassEdit.Location = new System.Drawing.Point(159, 122);
            this.btn_PassEdit.Name = "btn_PassEdit";
            this.btn_PassEdit.Size = new System.Drawing.Size(84, 23);
            this.btn_PassEdit.TabIndex = 12;
            this.btn_PassEdit.Text = "Şifreyi Değiştir";
            this.btn_PassEdit.UseVisualStyleBackColor = true;
            this.btn_PassEdit.Click += new System.EventHandler(this.btn_PassEdit_Click);
            // 
            // profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 231);
            this.Controls.Add(this.btn_PassEdit);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.sehir_Combobox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.eposta_Textbox);
            this.Controls.Add(this.soyad_Textbox);
            this.Controls.Add(this.ad_Textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(273, 270);
            this.MinimumSize = new System.Drawing.Size(273, 270);
            this.Name = "profil";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.profil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ad_Textbox;
        private System.Windows.Forms.TextBox soyad_Textbox;
        private System.Windows.Forms.TextBox eposta_Textbox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox sehir_Combobox;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_PassEdit;
    }
}