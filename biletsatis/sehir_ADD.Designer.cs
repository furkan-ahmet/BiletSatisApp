namespace biletsatis
{
    partial class sehir_ADD
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
            this.sehirNameTextbox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBoxKapatma = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir Adı :";
            // 
            // sehirNameTextbox
            // 
            this.sehirNameTextbox.Location = new System.Drawing.Point(73, 11);
            this.sehirNameTextbox.Name = "sehirNameTextbox";
            this.sehirNameTextbox.Size = new System.Drawing.Size(161, 20);
            this.sehirNameTextbox.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(155, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBoxKapatma
            // 
            this.checkBoxKapatma.AutoSize = true;
            this.checkBoxKapatma.Location = new System.Drawing.Point(15, 42);
            this.checkBoxKapatma.Name = "checkBoxKapatma";
            this.checkBoxKapatma.Size = new System.Drawing.Size(161, 17);
            this.checkBoxKapatma.TabIndex = 5;
            this.checkBoxKapatma.Text = "Kaydettikten sonra kapatma.";
            this.checkBoxKapatma.UseVisualStyleBackColor = true;
            // 
            // sehir_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 105);
            this.Controls.Add(this.checkBoxKapatma);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.sehirNameTextbox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(269, 144);
            this.MinimumSize = new System.Drawing.Size(269, 144);
            this.Name = "sehir_ADD";
            this.Text = "Şehir Ekle";
            this.Load += new System.EventHandler(this.sehir_ADD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sehirNameTextbox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxKapatma;
    }
}