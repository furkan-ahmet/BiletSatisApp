namespace biletsatis
{
    partial class tur_ADD
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.turNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kapatmaCheckbox = new System.Windows.Forms.CheckBox();
            this.alanCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 27);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 27);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // turNameTextbox
            // 
            this.turNameTextbox.Location = new System.Drawing.Point(70, 12);
            this.turNameTextbox.Name = "turNameTextbox";
            this.turNameTextbox.Size = new System.Drawing.Size(161, 20);
            this.turNameTextbox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tür Adı :";
            // 
            // kapatmaCheckbox
            // 
            this.kapatmaCheckbox.AutoSize = true;
            this.kapatmaCheckbox.Location = new System.Drawing.Point(13, 76);
            this.kapatmaCheckbox.Name = "kapatmaCheckbox";
            this.kapatmaCheckbox.Size = new System.Drawing.Size(158, 17);
            this.kapatmaCheckbox.TabIndex = 13;
            this.kapatmaCheckbox.Text = "Kaydettikten sonra kapatma";
            this.kapatmaCheckbox.UseVisualStyleBackColor = true;
            // 
            // alanCombobox
            // 
            this.alanCombobox.FormattingEnabled = true;
            this.alanCombobox.Location = new System.Drawing.Point(70, 43);
            this.alanCombobox.Name = "alanCombobox";
            this.alanCombobox.Size = new System.Drawing.Size(161, 21);
            this.alanCombobox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Alan :";
            // 
            // tur_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 133);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.turNameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kapatmaCheckbox);
            this.Controls.Add(this.alanCombobox);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(257, 172);
            this.MinimumSize = new System.Drawing.Size(257, 172);
            this.Name = "tur_ADD";
            this.Text = "Tür Ekle";
            this.Load += new System.EventHandler(this.tur_ADD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox turNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox kapatmaCheckbox;
        private System.Windows.Forms.ComboBox alanCombobox;
        private System.Windows.Forms.Label label2;
    }
}