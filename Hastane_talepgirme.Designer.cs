namespace BM102_Proje2
{
    partial class Hastane_talepgirme
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
            this.çıkbuton = new System.Windows.Forms.Button();
            this.listViewtalepgörme = new System.Windows.Forms.ListView();
            this.columnHeaderHastane = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTalep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderonay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxtalep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Talepkayıtbuton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TBtalepmiktar = new System.Windows.Forms.TextBox();
            this.buttonİptal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelKurumad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // çıkbuton
            // 
            this.çıkbuton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.çıkbuton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkbuton.Location = new System.Drawing.Point(867, 155);
            this.çıkbuton.Name = "çıkbuton";
            this.çıkbuton.Size = new System.Drawing.Size(104, 38);
            this.çıkbuton.TabIndex = 2;
            this.çıkbuton.Text = "Çıkış";
            this.çıkbuton.UseVisualStyleBackColor = true;
            this.çıkbuton.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewtalepgörme
            // 
            this.listViewtalepgörme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderHastane,
            this.columnHeaderTalep,
            this.columnHeaderMik,
            this.columnHeaderonay});
            this.listViewtalepgörme.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewtalepgörme.FullRowSelect = true;
            this.listViewtalepgörme.GridLines = true;
            this.listViewtalepgörme.HideSelection = false;
            this.listViewtalepgörme.Location = new System.Drawing.Point(183, 155);
            this.listViewtalepgörme.Name = "listViewtalepgörme";
            this.listViewtalepgörme.Size = new System.Drawing.Size(604, 251);
            this.listViewtalepgörme.TabIndex = 3;
            this.listViewtalepgörme.UseCompatibleStateImageBehavior = false;
            this.listViewtalepgörme.View = System.Windows.Forms.View.Details;
            this.listViewtalepgörme.SelectedIndexChanged += new System.EventHandler(this.lvv_SelectedIndexChanged);
            // 
            // columnHeaderHastane
            // 
            this.columnHeaderHastane.Text = "         Hastane";
            this.columnHeaderHastane.Width = 150;
            // 
            // columnHeaderTalep
            // 
            this.columnHeaderTalep.Text = "Talep";
            this.columnHeaderTalep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTalep.Width = 150;
            // 
            // columnHeaderMik
            // 
            this.columnHeaderMik.Text = "Miktar (Ünite)";
            this.columnHeaderMik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderMik.Width = 150;
            // 
            // columnHeaderonay
            // 
            this.columnHeaderonay.Text = "Onay Durumu";
            this.columnHeaderonay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderonay.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(372, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Daha önce girilen talepler";
            // 
            // comboBoxtalep
            // 
            this.comboBoxtalep.FormattingEnabled = true;
            this.comboBoxtalep.Items.AddRange(new object[] {
            "A Rh+ kan",
            "A Rh- kan",
            "B Rh+ kan",
            "B Rh- kan",
            "AB Rh+ kan",
            "AB Rh- kan",
            "0 Rh+ kan",
            "0 Rh- kan"});
            this.comboBoxtalep.Location = new System.Drawing.Point(414, 485);
            this.comboBoxtalep.Name = "comboBoxtalep";
            this.comboBoxtalep.Size = new System.Drawing.Size(187, 21);
            this.comboBoxtalep.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(230, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Talep :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Talepkayıtbuton
            // 
            this.Talepkayıtbuton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Talepkayıtbuton.Location = new System.Drawing.Point(311, 574);
            this.Talepkayıtbuton.Name = "Talepkayıtbuton";
            this.Talepkayıtbuton.Size = new System.Drawing.Size(144, 46);
            this.Talepkayıtbuton.TabIndex = 13;
            this.Talepkayıtbuton.Text = "Talebi Kaydet";
            this.Talepkayıtbuton.UseVisualStyleBackColor = true;
            this.Talepkayıtbuton.Click += new System.EventHandler(this.Talepkayıtbuton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(230, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Miktar (Ünite) :";
            // 
            // TBtalepmiktar
            // 
            this.TBtalepmiktar.Location = new System.Drawing.Point(414, 525);
            this.TBtalepmiktar.Name = "TBtalepmiktar";
            this.TBtalepmiktar.Size = new System.Drawing.Size(187, 20);
            this.TBtalepmiktar.TabIndex = 15;
            // 
            // buttonİptal
            // 
            this.buttonİptal.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonİptal.Location = new System.Drawing.Point(853, 574);
            this.buttonİptal.Name = "buttonİptal";
            this.buttonİptal.Size = new System.Drawing.Size(171, 37);
            this.buttonİptal.TabIndex = 16;
            this.buttonİptal.Text = "Talebi Geri Çek";
            this.buttonİptal.UseVisualStyleBackColor = true;
            this.buttonİptal.Click += new System.EventHandler(this.buttonİptal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(742, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 48);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lütfen geri çekilecek talebi tablodan seçin \r\nve aşağıdaki butona tıklayın.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(230, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kurum Adı";
            // 
            // labelKurumad
            // 
            this.labelKurumad.AutoSize = true;
            this.labelKurumad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKurumad.Location = new System.Drawing.Point(424, 437);
            this.labelKurumad.Name = "labelKurumad";
            this.labelKurumad.Size = new System.Drawing.Size(0, 20);
            this.labelKurumad.TabIndex = 19;
            // 
            // Hastane_talepgirme
            // 
            this.AcceptButton = this.Talepkayıtbuton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BM102_Proje2.Properties.Resources.ts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.çıkbuton;
            this.ClientSize = new System.Drawing.Size(1159, 683);
            this.Controls.Add(this.labelKurumad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonİptal);
            this.Controls.Add(this.TBtalepmiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Talepkayıtbuton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxtalep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewtalepgörme);
            this.Controls.Add(this.çıkbuton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hastane_talepgirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane_talepgirme";
            this.Load += new System.EventHandler(this.Hastane_talepgirme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button çıkbuton;
        private System.Windows.Forms.ListView listViewtalepgörme;
        private System.Windows.Forms.ColumnHeader columnHeaderHastane;
        private System.Windows.Forms.ColumnHeader columnHeaderTalep;
        private System.Windows.Forms.ColumnHeader columnHeaderMik;
        private System.Windows.Forms.ColumnHeader columnHeaderonay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxtalep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Talepkayıtbuton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBtalepmiktar;
        private System.Windows.Forms.Button buttonİptal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labelKurumad;
    }
}