namespace biletsatis
{
    partial class kullaniciEdit
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
            this.adTextbox = new System.Windows.Forms.TextBox();
            this.soyadTextbox = new System.Windows.Forms.TextBox();
            this.epostaTextbox = new System.Windows.Forms.TextBox();
            this.sehirTextbox = new System.Windows.Forms.TextBox();
            this.rolCombobox = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "e-Posta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol :";
            // 
            // adTextbox
            // 
            this.adTextbox.Enabled = false;
            this.adTextbox.Location = new System.Drawing.Point(63, 12);
            this.adTextbox.Name = "adTextbox";
            this.adTextbox.Size = new System.Drawing.Size(169, 20);
            this.adTextbox.TabIndex = 5;
            // 
            // soyadTextbox
            // 
            this.soyadTextbox.Enabled = false;
            this.soyadTextbox.Location = new System.Drawing.Point(63, 38);
            this.soyadTextbox.Name = "soyadTextbox";
            this.soyadTextbox.Size = new System.Drawing.Size(169, 20);
            this.soyadTextbox.TabIndex = 6;
            // 
            // epostaTextbox
            // 
            this.epostaTextbox.Enabled = false;
            this.epostaTextbox.Location = new System.Drawing.Point(63, 65);
            this.epostaTextbox.Name = "epostaTextbox";
            this.epostaTextbox.Size = new System.Drawing.Size(169, 20);
            this.epostaTextbox.TabIndex = 7;
            // 
            // sehirTextbox
            // 
            this.sehirTextbox.Enabled = false;
            this.sehirTextbox.Location = new System.Drawing.Point(63, 92);
            this.sehirTextbox.Name = "sehirTextbox";
            this.sehirTextbox.Size = new System.Drawing.Size(169, 20);
            this.sehirTextbox.TabIndex = 8;
            // 
            // rolCombobox
            // 
            this.rolCombobox.FormattingEnabled = true;
            this.rolCombobox.Location = new System.Drawing.Point(63, 118);
            this.rolCombobox.Name = "rolCombobox";
            this.rolCombobox.Size = new System.Drawing.Size(169, 21);
            this.rolCombobox.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // kullaniciEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 193);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rolCombobox);
            this.Controls.Add(this.sehirTextbox);
            this.Controls.Add(this.epostaTextbox);
            this.Controls.Add(this.soyadTextbox);
            this.Controls.Add(this.adTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(259, 232);
            this.MinimumSize = new System.Drawing.Size(259, 232);
            this.Name = "kullaniciEdit";
            this.Text = "Kullanıcı Düzenle";
            this.Load += new System.EventHandler(this.kullaniciEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adTextbox;
        private System.Windows.Forms.TextBox soyadTextbox;
        private System.Windows.Forms.TextBox epostaTextbox;
        private System.Windows.Forms.TextBox sehirTextbox;
        private System.Windows.Forms.ComboBox rolCombobox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}