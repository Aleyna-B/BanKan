namespace BM102_Proje2
{
    partial class Yonetici
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Girisbuton = new System.Windows.Forms.Button();
            this.çıkışbutonu = new System.Windows.Forms.Button();
            this.k_adıtextbox = new System.Windows.Forms.TextBox();
            this.şifregirişitextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Girisbuton
            // 
            this.Girisbuton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Girisbuton.Location = new System.Drawing.Point(179, 318);
            this.Girisbuton.Name = "Girisbuton";
            this.Girisbuton.Size = new System.Drawing.Size(142, 42);
            this.Girisbuton.TabIndex = 0;
            this.Girisbuton.Text = "Giriş";
            this.Girisbuton.UseVisualStyleBackColor = true;
            this.Girisbuton.Click += new System.EventHandler(this.Girisbuton_Click);
            // 
            // çıkışbutonu
            // 
            this.çıkışbutonu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.çıkışbutonu.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışbutonu.Location = new System.Drawing.Point(179, 412);
            this.çıkışbutonu.Name = "çıkışbutonu";
            this.çıkışbutonu.Size = new System.Drawing.Size(142, 40);
            this.çıkışbutonu.TabIndex = 1;
            this.çıkışbutonu.Text = "Çıkış";
            this.çıkışbutonu.UseVisualStyleBackColor = true;
            this.çıkışbutonu.Click += new System.EventHandler(this.çıkışbutonu_Click);
            // 
            // k_adıtextbox
            // 
            this.k_adıtextbox.Location = new System.Drawing.Point(272, 172);
            this.k_adıtextbox.Name = "k_adıtextbox";
            this.k_adıtextbox.Size = new System.Drawing.Size(194, 20);
            this.k_adıtextbox.TabIndex = 2;
            this.k_adıtextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // şifregirişitextbox
            // 
            this.şifregirişitextbox.Location = new System.Drawing.Point(272, 223);
            this.şifregirişitextbox.Name = "şifregirişitextbox";
            this.şifregirişitextbox.PasswordChar = '*';
            this.şifregirişitextbox.Size = new System.Drawing.Size(194, 20);
            this.şifregirişitextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(152, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // Yonetici
            // 
            this.AcceptButton = this.Girisbuton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::BM102_Proje2.Properties.Resources.ts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.çıkışbutonu;
            this.ClientSize = new System.Drawing.Size(555, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.şifregirişitextbox);
            this.Controls.Add(this.k_adıtextbox);
            this.Controls.Add(this.çıkışbutonu);
            this.Controls.Add(this.Girisbuton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Yonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kan Bankası Yönetici Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Girisbuton;
        private System.Windows.Forms.Button çıkışbutonu;
        private System.Windows.Forms.TextBox k_adıtextbox;
        private System.Windows.Forms.TextBox şifregirişitextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

