namespace BM102_Proje2
{
    partial class Hastane
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
            this.label1 = new System.Windows.Forms.Label();
            this.combohastaneadları = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxhastşifre = new System.Windows.Forms.TextBox();
            this.Girisbutonhastane = new System.Windows.Forms.Button();
            this.Çıkışbutonhastane = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(112, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kurum Adı:";
            // 
            // combohastaneadları
            // 
            this.combohastaneadları.FormattingEnabled = true;
            this.combohastaneadları.Items.AddRange(new object[] {
            "A Hastanesi",
            "B Hastanesi",
            "C Hastanesi",
            "D Hastanesi",
            "E Hastanesi",
            "F Hastanesi"});
            this.combohastaneadları.Location = new System.Drawing.Point(299, 166);
            this.combohastaneadları.Name = "combohastaneadları";
            this.combohastaneadları.Size = new System.Drawing.Size(183, 21);
            this.combohastaneadları.TabIndex = 6;
            this.combohastaneadları.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(158, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre:";
            // 
            // textBoxhastşifre
            // 
            this.textBoxhastşifre.Location = new System.Drawing.Point(299, 229);
            this.textBoxhastşifre.Name = "textBoxhastşifre";
            this.textBoxhastşifre.Size = new System.Drawing.Size(183, 20);
            this.textBoxhastşifre.TabIndex = 8;
            // 
            // Girisbutonhastane
            // 
            this.Girisbutonhastane.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Girisbutonhastane.Location = new System.Drawing.Point(196, 314);
            this.Girisbutonhastane.Name = "Girisbutonhastane";
            this.Girisbutonhastane.Size = new System.Drawing.Size(142, 42);
            this.Girisbutonhastane.TabIndex = 9;
            this.Girisbutonhastane.Text = "Giriş";
            this.Girisbutonhastane.UseVisualStyleBackColor = true;
            this.Girisbutonhastane.Click += new System.EventHandler(this.Girisbutonhastane_Click);
            // 
            // Çıkışbutonhastane
            // 
            this.Çıkışbutonhastane.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Çıkışbutonhastane.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Çıkışbutonhastane.Location = new System.Drawing.Point(196, 399);
            this.Çıkışbutonhastane.Name = "Çıkışbutonhastane";
            this.Çıkışbutonhastane.Size = new System.Drawing.Size(142, 40);
            this.Çıkışbutonhastane.TabIndex = 10;
            this.Çıkışbutonhastane.Text = "Çıkış";
            this.Çıkışbutonhastane.UseVisualStyleBackColor = true;
            this.Çıkışbutonhastane.Click += new System.EventHandler(this.Çıkışbutonhastane_Click);
            // 
            // Hastane
            // 
            this.AcceptButton = this.Girisbutonhastane;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BM102_Proje2.Properties.Resources.ts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Çıkışbutonhastane;
            this.ClientSize = new System.Drawing.Size(617, 578);
            this.Controls.Add(this.Çıkışbutonhastane);
            this.Controls.Add(this.Girisbutonhastane);
            this.Controls.Add(this.textBoxhastşifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combohastaneadları);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hastane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane_giriş";
            this.Load += new System.EventHandler(this.Hastane_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxhastşifre;
        private System.Windows.Forms.Button Girisbutonhastane;
        private System.Windows.Forms.Button Çıkışbutonhastane;
        public System.Windows.Forms.ComboBox combohastaneadları;
    }
}