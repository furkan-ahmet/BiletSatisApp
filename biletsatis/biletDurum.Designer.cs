namespace biletsatis
{
    partial class biletDurum
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
            this.btn_Menu = new System.Windows.Forms.Button();
            this.biletList_table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.biletList_table)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(12, 8);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(75, 23);
            this.btn_Menu.TabIndex = 17;
            this.btn_Menu.Text = "<-- Menü";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // biletList_table
            // 
            this.biletList_table.AllowUserToAddRows = false;
            this.biletList_table.AllowUserToDeleteRows = false;
            this.biletList_table.AllowUserToResizeColumns = false;
            this.biletList_table.AllowUserToResizeRows = false;
            this.biletList_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.biletList_table.Location = new System.Drawing.Point(12, 48);
            this.biletList_table.Name = "biletList_table";
            this.biletList_table.RowHeadersVisible = false;
            this.biletList_table.Size = new System.Drawing.Size(513, 339);
            this.biletList_table.TabIndex = 16;
            this.biletList_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.biletList_table_CellClick);
            // 
            // biletDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 399);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.biletList_table);
            this.MaximumSize = new System.Drawing.Size(552, 438);
            this.MinimumSize = new System.Drawing.Size(552, 438);
            this.Name = "biletDurum";
            this.Text = "Bilet İstekleri";
            this.Load += new System.EventHandler(this.biletDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biletList_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.DataGridView biletList_table;
    }
}