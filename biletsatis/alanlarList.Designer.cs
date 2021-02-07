namespace biletsatis
{
    partial class alanlarList
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
            this.alanList = new System.Windows.Forms.DataGridView();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alanList)).BeginInit();
            this.SuspendLayout();
            // 
            // alanList
            // 
            this.alanList.AllowUserToAddRows = false;
            this.alanList.AllowUserToDeleteRows = false;
            this.alanList.AllowUserToResizeColumns = false;
            this.alanList.AllowUserToResizeRows = false;
            this.alanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alanList.Location = new System.Drawing.Point(12, 82);
            this.alanList.MaximumSize = new System.Drawing.Size(288, 356);
            this.alanList.MinimumSize = new System.Drawing.Size(288, 356);
            this.alanList.Name = "alanList";
            this.alanList.RowHeadersVisible = false;
            this.alanList.Size = new System.Drawing.Size(288, 356);
            this.alanList.TabIndex = 0;
            this.alanList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alanList_CellClick);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(12, 12);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(75, 23);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.Text = "<-- Menü";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(225, 53);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // alanlarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 450);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.alanList);
            this.MaximumSize = new System.Drawing.Size(328, 489);
            this.MinimumSize = new System.Drawing.Size(328, 489);
            this.Name = "alanlarList";
            this.Text = "Alanlar";
            this.Load += new System.EventHandler(this.alanlarList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alanList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView alanList;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Add;
    }
}