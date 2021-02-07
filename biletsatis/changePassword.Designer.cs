namespace biletsatis
{
    partial class changePassword
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.eskiSifre_Textbox = new System.Windows.Forms.TextBox();
            this.yeniSifre_Textbox = new System.Windows.Forms.TextBox();
            this.yeniSifreTekrar_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eski Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yeni Şifre (Tekrar) :";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(15, 93);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "İptal";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(155, 93);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // eskiSifre_Textbox
            // 
            this.eskiSifre_Textbox.Location = new System.Drawing.Point(117, 6);
            this.eskiSifre_Textbox.Name = "eskiSifre_Textbox";
            this.eskiSifre_Textbox.PasswordChar = '*';
            this.eskiSifre_Textbox.Size = new System.Drawing.Size(113, 20);
            this.eskiSifre_Textbox.TabIndex = 5;
            // 
            // yeniSifre_Textbox
            // 
            this.yeniSifre_Textbox.Location = new System.Drawing.Point(117, 32);
            this.yeniSifre_Textbox.Name = "yeniSifre_Textbox";
            this.yeniSifre_Textbox.PasswordChar = '*';
            this.yeniSifre_Textbox.Size = new System.Drawing.Size(113, 20);
            this.yeniSifre_Textbox.TabIndex = 6;
            // 
            // yeniSifreTekrar_Textbox
            // 
            this.yeniSifreTekrar_Textbox.Location = new System.Drawing.Point(116, 59);
            this.yeniSifreTekrar_Textbox.Name = "yeniSifreTekrar_Textbox";
            this.yeniSifreTekrar_Textbox.PasswordChar = '*';
            this.yeniSifreTekrar_Textbox.Size = new System.Drawing.Size(114, 20);
            this.yeniSifreTekrar_Textbox.TabIndex = 7;
            // 
            // changePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 124);
            this.Controls.Add(this.yeniSifreTekrar_Textbox);
            this.Controls.Add(this.yeniSifre_Textbox);
            this.Controls.Add(this.eskiSifre_Textbox);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(259, 163);
            this.MinimumSize = new System.Drawing.Size(259, 163);
            this.Name = "changePassword";
            this.Text = "Şifre Yenile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox eskiSifre_Textbox;
        private System.Windows.Forms.TextBox yeniSifre_Textbox;
        private System.Windows.Forms.TextBox yeniSifreTekrar_Textbox;
    }
}