namespace BM102_Proje2
{
    partial class seçimform
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
            this.stokgörbuton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hastanetalepgörbuton = new System.Windows.Forms.Button();
            this.başvurugörbuton = new System.Windows.Forms.Button();
            this.sonuçgirbuton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stokgörbuton
            // 
            this.stokgörbuton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokgörbuton.Location = new System.Drawing.Point(111, 248);
            this.stokgörbuton.Name = "stokgörbuton";
            this.stokgörbuton.Size = new System.Drawing.Size(195, 68);
            this.stokgörbuton.TabIndex = 0;
            this.stokgörbuton.Text = "Kan stoklarını görüntüleme/değiştirme";
            this.stokgörbuton.UseVisualStyleBackColor = true;
            this.stokgörbuton.Click += new System.EventHandler(this.stokgörbuton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(175, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen yapmak istediğiniz işlemi seçin";
            // 
            // hastanetalepgörbuton
            // 
            this.hastanetalepgörbuton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastanetalepgörbuton.Location = new System.Drawing.Point(366, 248);
            this.hastanetalepgörbuton.Name = "hastanetalepgörbuton";
            this.hastanetalepgörbuton.Size = new System.Drawing.Size(195, 68);
            this.hastanetalepgörbuton.TabIndex = 4;
            this.hastanetalepgörbuton.Text = "Hastanelerin taleplerini görüntüleme";
            this.hastanetalepgörbuton.UseVisualStyleBackColor = true;
            this.hastanetalepgörbuton.Click += new System.EventHandler(this.hastanetalepgörbuton_Click);
            // 
            // başvurugörbuton
            // 
            this.başvurugörbuton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.başvurugörbuton.Location = new System.Drawing.Point(111, 349);
            this.başvurugörbuton.Name = "başvurugörbuton";
            this.başvurugörbuton.Size = new System.Drawing.Size(195, 85);
            this.başvurugörbuton.TabIndex = 5;
            this.başvurugörbuton.Text = "Gönüllülük başvurusu yapanları görüntüleme";
            this.başvurugörbuton.UseVisualStyleBackColor = true;
            this.başvurugörbuton.Click += new System.EventHandler(this.başvurugörbuton_Click);
            // 
            // sonuçgirbuton
            // 
            this.sonuçgirbuton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuçgirbuton.Location = new System.Drawing.Point(366, 349);
            this.sonuçgirbuton.Name = "sonuçgirbuton";
            this.sonuçgirbuton.Size = new System.Drawing.Size(195, 85);
            this.sonuçgirbuton.TabIndex = 6;
            this.sonuçgirbuton.Text = "Bağışçıların uygunluk testi sonuçlarını girme/görüntüleme";
            this.sonuçgirbuton.UseVisualStyleBackColor = true;
            this.sonuçgirbuton.Click += new System.EventHandler(this.sonuçgirbuton_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(283, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sistemden çık";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seçimform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BM102_Proje2.Properties.Resources.ts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(686, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sonuçgirbuton);
            this.Controls.Add(this.başvurugörbuton);
            this.Controls.Add(this.hastanetalepgörbuton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stokgörbuton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "seçimform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kan Bankası Yönetici Paneli";
            this.Load += new System.EventHandler(this.seçimform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stokgörbuton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hastanetalepgörbuton;
        private System.Windows.Forms.Button başvurugörbuton;
        private System.Windows.Forms.Button sonuçgirbuton;
        private System.Windows.Forms.Button button1;
    }
}