namespace biletsatis
{
    partial class konum_ADD
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
            this.label2 = new System.Windows.Forms.Label();
            this.sehirCombobox = new System.Windows.Forms.ComboBox();
            this.kapatmaCheckbox = new System.Windows.Forms.CheckBox();
            this.konumNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.adresTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şehir :";
            // 
            // sehirCombobox
            // 
            this.sehirCombobox.FormattingEnabled = true;
            this.sehirCombobox.Location = new System.Drawing.Point(72, 43);
            this.sehirCombobox.Name = "sehirCombobox";
            this.sehirCombobox.Size = new System.Drawing.Size(161, 21);
            this.sehirCombobox.TabIndex = 3;
            // 
            // kapatmaCheckbox
            // 
            this.kapatmaCheckbox.AutoSize = true;
            this.kapatmaCheckbox.Location = new System.Drawing.Point(15, 137);
            this.kapatmaCheckbox.Name = "kapatmaCheckbox";
            this.kapatmaCheckbox.Size = new System.Drawing.Size(158, 17);
            this.kapatmaCheckbox.TabIndex = 6;
            this.kapatmaCheckbox.Text = "Kaydettikten sonra kapatma";
            this.kapatmaCheckbox.UseVisualStyleBackColor = true;
            // 
            // konumNameTextbox
            // 
            this.konumNameTextbox.Location = new System.Drawing.Point(72, 12);
            this.konumNameTextbox.Name = "konumNameTextbox";
            this.konumNameTextbox.Size = new System.Drawing.Size(161, 20);
            this.konumNameTextbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Konum Adı :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(14, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 27);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(154, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 27);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adres :";
            // 
            // adresTextbox
            // 
            this.adresTextbox.Location = new System.Drawing.Point(72, 78);
            this.adresTextbox.Multiline = true;
            this.adresTextbox.Name = "adresTextbox";
            this.adresTextbox.Size = new System.Drawing.Size(161, 53);
            this.adresTextbox.TabIndex = 12;
            // 
            // konum_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 199);
            this.Controls.Add(this.adresTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.konumNameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kapatmaCheckbox);
            this.Controls.Add(this.sehirCombobox);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(263, 238);
            this.MinimumSize = new System.Drawing.Size(263, 238);
            this.Name = "konum_ADD";
            this.Text = "Konum Ekle";
            this.Load += new System.EventHandler(this.konum_ADD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sehirCombobox;
        private System.Windows.Forms.CheckBox kapatmaCheckbox;
        private System.Windows.Forms.TextBox konumNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adresTextbox;
    }
}