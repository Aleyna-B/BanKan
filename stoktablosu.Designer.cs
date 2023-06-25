namespace BM102_Proje2
{
    partial class stoktablosu
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
            this.components = new System.ComponentModel.Container();
            this.kanstokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bM102_proje_dbDataSet = new BM102_Proje2.BM102_proje_dbDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.kan_stokTableAdapter = new BM102_Proje2.BM102_proje_dbDataSetTableAdapters.kan_stokTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kaydetbuton = new System.Windows.Forms.Button();
            this.listViewstok = new System.Windows.Forms.ListView();
            this.columnHeaderürün2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadermiktar2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.degişbuton = new System.Windows.Forms.Button();
            this.silbuton = new System.Windows.Forms.Button();
            this.textBoxÜrünismi = new System.Windows.Forms.TextBox();
            this.Onaylanan_çıkışlar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kanstokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bM102_proje_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kanstokBindingSource
            // 
            this.kanstokBindingSource.DataMember = "kan_stok";
            this.kanstokBindingSource.DataSource = this.bM102_proje_dbDataSet;
            // 
            // bM102_proje_dbDataSet
            // 
            this.bM102_proje_dbDataSet.DataSetName = "BM102_proje_dbDataSet";
            this.bM102_proje_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(952, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kan_stokTableAdapter
            // 
            this.kan_stokTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(397, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün ismi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(598, 517);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(679, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Miktar(Ünite cinsinden)";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(338, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(516, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni kayıt girmek ya da değişiklik yapmak için ürün ismini ve bilgilerini girin, " +
    "silmek için yalnızca ürün ismini girin.\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // kaydetbuton
            // 
            this.kaydetbuton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetbuton.Location = new System.Drawing.Point(288, 587);
            this.kaydetbuton.Name = "kaydetbuton";
            this.kaydetbuton.Size = new System.Drawing.Size(110, 33);
            this.kaydetbuton.TabIndex = 7;
            this.kaydetbuton.Text = "Kaydet";
            this.kaydetbuton.UseVisualStyleBackColor = true;
            this.kaydetbuton.Click += new System.EventHandler(this.kaydetbuton_Click);
            // 
            // listViewstok
            // 
            this.listViewstok.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewstok.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderürün2,
            this.columnHeadermiktar2});
            this.listViewstok.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewstok.FullRowSelect = true;
            this.listViewstok.GridLines = true;
            this.listViewstok.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewstok.HideSelection = false;
            this.listViewstok.HoverSelection = true;
            this.listViewstok.Location = new System.Drawing.Point(288, 136);
            this.listViewstok.Name = "listViewstok";
            this.listViewstok.Size = new System.Drawing.Size(616, 263);
            this.listViewstok.TabIndex = 8;
            this.listViewstok.UseCompatibleStateImageBehavior = false;
            this.listViewstok.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderürün2
            // 
            this.columnHeaderürün2.Text = "                             Ürün";
            this.columnHeaderürün2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderürün2.Width = 305;
            // 
            // columnHeadermiktar2
            // 
            this.columnHeadermiktar2.Text = "Miktar (Ünite)";
            this.columnHeadermiktar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeadermiktar2.Width = 305;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(147, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // degişbuton
            // 
            this.degişbuton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degişbuton.Location = new System.Drawing.Point(545, 587);
            this.degişbuton.Name = "degişbuton";
            this.degişbuton.Size = new System.Drawing.Size(110, 33);
            this.degişbuton.TabIndex = 10;
            this.degişbuton.Text = "Değiştir";
            this.degişbuton.UseVisualStyleBackColor = true;
            this.degişbuton.Click += new System.EventHandler(this.degişbuton_Click);
            // 
            // silbuton
            // 
            this.silbuton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbuton.Location = new System.Drawing.Point(794, 587);
            this.silbuton.Name = "silbuton";
            this.silbuton.Size = new System.Drawing.Size(110, 33);
            this.silbuton.TabIndex = 11;
            this.silbuton.Text = "Sil";
            this.silbuton.UseVisualStyleBackColor = true;
            this.silbuton.Click += new System.EventHandler(this.silbuton_Click);
            // 
            // textBoxÜrünismi
            // 
            this.textBoxÜrünismi.Location = new System.Drawing.Point(285, 517);
            this.textBoxÜrünismi.Name = "textBoxÜrünismi";
            this.textBoxÜrünismi.Size = new System.Drawing.Size(315, 20);
            this.textBoxÜrünismi.TabIndex = 12;
            // 
            // Onaylanan_çıkışlar
            // 
            this.Onaylanan_çıkışlar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Onaylanan_çıkışlar.Location = new System.Drawing.Point(952, 293);
            this.Onaylanan_çıkışlar.Name = "Onaylanan_çıkışlar";
            this.Onaylanan_çıkışlar.Size = new System.Drawing.Size(109, 58);
            this.Onaylanan_çıkışlar.TabIndex = 13;
            this.Onaylanan_çıkışlar.Text = "Onaylanan Çıkışları Gör";
            this.Onaylanan_çıkışlar.UseVisualStyleBackColor = true;
            this.Onaylanan_çıkışlar.Click += new System.EventHandler(this.Onaylanan_çıkışlar_Click);
            // 
            // stoktablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BM102_Proje2.Properties.Resources.ts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1231, 680);
            this.Controls.Add(this.Onaylanan_çıkışlar);
            this.Controls.Add(this.textBoxÜrünismi);
            this.Controls.Add(this.silbuton);
            this.Controls.Add(this.degişbuton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewstok);
            this.Controls.Add(this.kaydetbuton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stoktablosu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.stoktablosu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kanstokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bM102_proje_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private BM102_proje_dbDataSet bM102_proje_dbDataSet;
        private System.Windows.Forms.BindingSource kanstokBindingSource;
        private BM102_proje_dbDataSetTableAdapters.kan_stokTableAdapter kan_stokTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kaydetbuton;
        private System.Windows.Forms.ListView listViewstok;
        private System.Windows.Forms.ColumnHeader columnHeaderürün2;
        private System.Windows.Forms.ColumnHeader columnHeadermiktar2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button degişbuton;
        private System.Windows.Forms.Button silbuton;
        private System.Windows.Forms.TextBox textBoxÜrünismi;
        private System.Windows.Forms.Button Onaylanan_çıkışlar;
    }
}