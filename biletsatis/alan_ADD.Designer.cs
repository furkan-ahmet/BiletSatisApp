namespace biletsatis
{
    partial class alan_ADD
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
            this.checkBoxKapatma = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.alanNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxKapatma
            // 
            this.checkBoxKapatma.AutoSize = true;
            this.checkBoxKapatma.Location = new System.Drawing.Point(15, 37);
            this.checkBoxKapatma.Name = "checkBoxKapatma";
            this.checkBoxKapatma.Size = new System.Drawing.Size(161, 17);
            this.checkBoxKapatma.TabIndex = 10;
            this.checkBoxKapatma.Text = "Kaydettikten sonra kapatma.";
            this.checkBoxKapatma.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 27);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(155, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 27);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // alanNameTextbox
            // 
            this.alanNameTextbox.Location = new System.Drawing.Point(73, 6);
            this.alanNameTextbox.Name = "alanNameTextbox";
            this.alanNameTextbox.Size = new System.Drawing.Size(161, 20);
            this.alanNameTextbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alan Adı :";
            // 
            // alan_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 98);
            this.Controls.Add(this.checkBoxKapatma);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.alanNameTextbox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(263, 137);
            this.MinimumSize = new System.Drawing.Size(263, 137);
            this.Name = "alan_ADD";
            this.Text = "Alan Ekle";
            this.Load += new System.EventHandler(this.alan_ADD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxKapatma;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox alanNameTextbox;
        private System.Windows.Forms.Label label1;
    }
}