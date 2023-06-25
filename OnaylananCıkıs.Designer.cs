namespace BM102_Proje2
{
    partial class OnaylananCıkıs
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
            this.İşaretKayıtbuton = new System.Windows.Forms.Button();
            this.listViewonaylı = new System.Windows.Forms.ListView();
            this.columnHeaderTal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMikt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOnay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderişlen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // İşaretKayıtbuton
            // 
            this.İşaretKayıtbuton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İşaretKayıtbuton.Location = new System.Drawing.Point(888, 529);
            this.İşaretKayıtbuton.Name = "İşaretKayıtbuton";
            this.İşaretKayıtbuton.Size = new System.Drawing.Size(115, 37);
            this.İşaretKayıtbuton.TabIndex = 1;
            this.İşaretKayıtbuton.Text = "İşlendi";
            this.İşaretKayıtbuton.UseVisualStyleBackColor = true;
            this.İşaretKayıtbuton.Click += new System.EventHandler(this.İşaretKayıtbuton_Click);
            // 
            // listViewonaylı
            // 
            this.listViewonaylı.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTal,
            this.columnHeaderMikt,
            this.columnHeaderOnay,
            this.columnHeaderişlen});
            this.listViewonaylı.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewonaylı.FullRowSelect = true;
            this.listViewonaylı.GridLines = true;
            this.listViewonaylı.HideSelection = false;
            this.listViewonaylı.Location = new System.Drawing.Point(237, 175);
            this.listViewonaylı.Name = "listViewonaylı";
            this.listViewonaylı.Size = new System.Drawing.Size(766, 304);
            this.listViewonaylı.TabIndex = 0;
            this.listViewonaylı.UseCompatibleStateImageBehavior = false;
            this.listViewonaylı.View = System.Windows.Forms.View.Details;
            this.listViewonaylı.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            // 
            // columnHeaderTal
            // 
            this.columnHeaderTal.Text = "                              Talep";
            this.columnHeaderTal.Width = 202;
            // 
            // columnHeaderMikt
            // 
            this.columnHeaderMikt.Text = "Miktar (Ünite)";
            this.columnHeaderMikt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderMikt.Width = 181;
            // 
            // columnHeaderOnay
            // 
            this.columnHeaderOnay.Text = "Onay durumu";
            this.columnHeaderOnay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderOnay.Width = 205;
            // 
            // columnHeaderişlen
            // 
            this.columnHeaderişlen.Text = "İşlendi";
            this.columnHeaderişlen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderişlen.Width = 172;
            // 
            // OnaylananCıkıs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BM102_Proje2.Properties.Resources.ts1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1267, 633);
            this.Controls.Add(this.İşaretKayıtbuton);
            this.Controls.Add(this.listViewonaylı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OnaylananCıkıs";
            this.Text = "Onaylanan Çıkışlar";
            this.Load += new System.EventHandler(this.OnaylananCıkıs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewonaylı;
        private System.Windows.Forms.ColumnHeader columnHeaderTal;
        private System.Windows.Forms.ColumnHeader columnHeaderMikt;
        private System.Windows.Forms.ColumnHeader columnHeaderOnay;
        private System.Windows.Forms.Button İşaretKayıtbuton;
        private System.Windows.Forms.ColumnHeader columnHeaderişlen;
    }
}