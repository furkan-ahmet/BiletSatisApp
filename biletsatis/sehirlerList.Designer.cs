namespace biletsatis
{
    partial class sehirlerList
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.sehirList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sehirList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(225, 53);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(12, 12);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(75, 23);
            this.btn_Menu.TabIndex = 7;
            this.btn_Menu.Text = "<-- Menü";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // sehirList
            // 
            this.sehirList.AllowUserToAddRows = false;
            this.sehirList.AllowUserToDeleteRows = false;
            this.sehirList.AllowUserToResizeColumns = false;
            this.sehirList.AllowUserToResizeRows = false;
            this.sehirList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sehirList.Location = new System.Drawing.Point(12, 82);
            this.sehirList.Name = "sehirList";
            this.sehirList.ReadOnly = true;
            this.sehirList.RowHeadersVisible = false;
            this.sehirList.Size = new System.Drawing.Size(288, 356);
            this.sehirList.TabIndex = 6;
            this.sehirList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sehirList_CellClick);
            // 
            // sehirlerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.sehirList);
            this.MaximumSize = new System.Drawing.Size(327, 489);
            this.MinimumSize = new System.Drawing.Size(327, 489);
            this.Name = "sehirlerList";
            this.Text = "Şehirler";
            this.Load += new System.EventHandler(this.sehirlerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sehirList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.DataGridView sehirList;
    }
}