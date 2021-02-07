namespace biletsatis
{
    partial class konumlarList
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
            this.konumList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.konumList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(314, 53);
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
            // konumList
            // 
            this.konumList.AllowUserToAddRows = false;
            this.konumList.AllowUserToDeleteRows = false;
            this.konumList.AllowUserToResizeColumns = false;
            this.konumList.AllowUserToResizeRows = false;
            this.konumList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.konumList.Location = new System.Drawing.Point(12, 82);
            this.konumList.Name = "konumList";
            this.konumList.RowHeadersVisible = false;
            this.konumList.Size = new System.Drawing.Size(377, 356);
            this.konumList.TabIndex = 6;
            this.konumList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.konumList_CellClick);
            // 
            // konumlarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.konumList);
            this.MaximumSize = new System.Drawing.Size(417, 489);
            this.MinimumSize = new System.Drawing.Size(417, 489);
            this.Name = "konumlarList";
            this.Text = "Konumlar";
            this.Load += new System.EventHandler(this.konumlarList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.konumList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.DataGridView konumList;
    }
}