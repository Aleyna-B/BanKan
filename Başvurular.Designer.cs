namespace BM102_Proje2
{
    partial class Başvurular
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
            this.button1 = new System.Windows.Forms.Button();
            this.listViewbaşvuru = new System.Windows.Forms.ListView();
            this.columnHeaderad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadersoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderyas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadercins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderposta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderonay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.buttonOnaylama = new System.Windows.Forms.Button();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(947, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewbaşvuru
            // 
            this.listViewbaşvuru.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderad,
            this.columnHeadersoyad,
            this.columnHeaderyas,
            this.columnHeadercins,
            this.columnHeaderposta,
            this.columnHeaderonay});
            this.listViewbaşvuru.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewbaşvuru.GridLines = true;
            this.listViewbaşvuru.HideSelection = false;
            this.listViewbaşvuru.Location = new System.Drawing.Point(186, 165);
            this.listViewbaşvuru.Name = "listViewbaşvuru";
            this.listViewbaşvuru.Size = new System.Drawing.Size(745, 263);
            this.listViewbaşvuru.TabIndex = 1;
            this.listViewbaşvuru.UseCompatibleStateImageBehavior = false;
            this.listViewbaşvuru.View = System.Windows.Forms.View.Details;
            this.listViewbaşvuru.SelectedIndexChanged += new System.EventHandler(this.listViewbaşvuru_SelectedIndexChanged);
            // 
            // columnHeaderad
            // 
            this.columnHeaderad.Text = "İsim";
            this.columnHeaderad.Width = 141;
            // 
            // columnHeadersoyad
            // 
            this.columnHeadersoyad.Text = "Soyisim";
            this.columnHeadersoyad.Width = 139;
            // 
            // columnHeaderyas
            // 
            this.columnHeaderyas.Text = "Yaş";
            this.columnHeaderyas.Width = 70;
            // 
            // columnHeadercins
            // 
            this.columnHeadercins.Text = "Cinsiyet";
            this.columnHeadercins.Width = 90;
            // 
            // columnHeaderposta
            // 
            this.columnHeaderposta.Text = "E-posta";
            this.columnHeaderposta.Width = 149;
            // 
            // columnHeaderonay
            // 
            this.columnHeaderonay.Text = "Onay Durumu";
            this.columnHeaderonay.Width = 150;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(70, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonOnaylama
            // 
            this.buttonOnaylama.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOnaylama.Location = new System.Drawing.Point(515, 559);
            this.buttonOnaylama.Name = "buttonOnaylama";
            this.buttonOnaylama.Size = new System.Drawing.Size(119, 72);
            this.buttonOnaylama.TabIndex = 3;
            this.buttonOnaylama.Text = "Gönüllülük Başvurusunu Onayla";
            this.buttonOnaylama.UseVisualStyleBackColor = true;
            this.buttonOnaylama.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(388, 503);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(141, 20);
            this.textBoxad.TabIndex = 4;
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(619, 503);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(141, 20);
            this.textBoxsoyad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(431, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "İsim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(658, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyisim";
            // 
            // Başvurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BM102_Proje2.Properties.Resources.ts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1138, 692);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxsoyad);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.buttonOnaylama);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewbaşvuru);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Başvurular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Başvurular";
            this.Load += new System.EventHandler(this.Başvurular_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewbaşvuru;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeaderad;
        private System.Windows.Forms.ColumnHeader columnHeadersoyad;
        private System.Windows.Forms.ColumnHeader columnHeaderyas;
        private System.Windows.Forms.ColumnHeader columnHeadercins;
        private System.Windows.Forms.ColumnHeader columnHeaderposta;
        private System.Windows.Forms.ColumnHeader columnHeaderonay;
        private System.Windows.Forms.Button buttonOnaylama;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}