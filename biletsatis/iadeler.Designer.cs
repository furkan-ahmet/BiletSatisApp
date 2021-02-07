namespace biletsatis
{
    partial class iadeler
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
            this.iade_List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.iade_List)).BeginInit();
            this.SuspendLayout();
            // 
            // iade_List
            // 
            this.iade_List.AllowUserToAddRows = false;
            this.iade_List.AllowUserToDeleteRows = false;
            this.iade_List.AllowUserToResizeColumns = false;
            this.iade_List.AllowUserToResizeRows = false;
            this.iade_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iade_List.Location = new System.Drawing.Point(12, 12);
            this.iade_List.Name = "iade_List";
            this.iade_List.RowHeadersVisible = false;
            this.iade_List.Size = new System.Drawing.Size(583, 315);
            this.iade_List.TabIndex = 4;
            this.iade_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.iade_List_CellClick);
            // 
            // iadeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 338);
            this.Controls.Add(this.iade_List);
            this.MaximumSize = new System.Drawing.Size(620, 377);
            this.MinimumSize = new System.Drawing.Size(620, 377);
            this.Name = "iadeler";
            this.Text = "İade Listesi";
            this.Load += new System.EventHandler(this.iadeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iade_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView iade_List;
    }
}