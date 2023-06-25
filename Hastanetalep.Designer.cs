namespace Proje2
{
    partial class Hastanetalep
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
            this.listViewtalep = new System.Windows.Forms.ListView();
            this.columnHeaderHastane = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTalep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderonay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.çıkbuton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.onaybuton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxhastaneler = new System.Windows.Forms.ComboBox();
            this.comboBoxtalep = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listViewtalep
            // 
            this.listViewtalep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderHastane,
            this.columnHeaderTalep,
            this.columnHeaderMik,
            this.columnHeaderonay});
            this.listViewtalep.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewtalep.GridLines = true;
            this.listViewtalep.HideSelection = false;
            this.listViewtalep.Location = new System.Drawing.Point(268, 172);
            this.listViewtalep.Name = "listViewtalep";
            this.listViewtalep.Size = new System.Drawing.Size(604, 251);
            this.listViewtalep.TabIndex = 0;
            this.listViewtalep.UseCompatibleStateImageBehavior = false;
            this.listViewtalep.View = System.Windows.Forms.View.Details;
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
            // çıkbuton
            // 
            this.çıkbuton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkbuton.Location = new System.Drawing.Point(905, 172);
            this.çıkbuton.Name = "çıkbuton";
            this.çıkbuton.Size = new System.Drawing.Size(104, 38);
            this.çıkbuton.TabIndex = 1;
            this.çıkbuton.Text = "Çıkış";
            this.çıkbuton.UseVisualStyleBackColor = true;
            this.çıkbuton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(133, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // onaybuton
            // 
            this.onaybuton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaybuton.Location = new System.Drawing.Point(519, 584);
            this.onaybuton.Name = "onaybuton";
            this.onaybuton.Size = new System.Drawing.Size(149, 37);
            this.onaybuton.TabIndex = 3;
            this.onaybuton.Text = "Talebi onayla";
            this.onaybuton.UseVisualStyleBackColor = true;
            this.onaybuton.Click += new System.EventHandler(this.onaybuton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(465, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hastane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(465, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Talep";
            // 
            // comboBoxhastaneler
            // 
            this.comboBoxhastaneler.FormattingEnabled = true;
            this.comboBoxhastaneler.Items.AddRange(new object[] {
            "A Hastanesi",
            "B Hastanesi",
            "C Hastanesi",
            "D Hastanesi",
            "E Hastanesi",
            "F Hastanesi"});
            this.comboBoxhastaneler.Location = new System.Drawing.Point(601, 488);
            this.comboBoxhastaneler.Name = "comboBoxhastaneler";
            this.comboBoxhastaneler.Size = new System.Drawing.Size(151, 21);
            this.comboBoxhastaneler.TabIndex = 9;
            this.comboBoxhastaneler.SelectedIndexChanged += new System.EventHandler(this.comboBoxhastaneler_SelectedIndexChanged);
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
            this.comboBoxtalep.Location = new System.Drawing.Point(601, 526);
            this.comboBoxtalep.Name = "comboBoxtalep";
            this.comboBoxtalep.Size = new System.Drawing.Size(151, 21);
            this.comboBoxtalep.TabIndex = 10;
            // 
            // Hastanetalep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BM102_Proje2.Properties.Resources.ts2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 693);
            this.Controls.Add(this.comboBoxtalep);
            this.Controls.Add(this.comboBoxhastaneler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onaybuton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.çıkbuton);
            this.Controls.Add(this.listViewtalep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hastanetalep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Talepleri";
            this.Load += new System.EventHandler(this.Hastanetalep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewtalep;
        private System.Windows.Forms.ColumnHeader columnHeaderHastane;
        private System.Windows.Forms.ColumnHeader columnHeaderTalep;
        private System.Windows.Forms.Button çıkbuton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeaderMik;
        private System.Windows.Forms.ColumnHeader columnHeaderonay;
        private System.Windows.Forms.Button onaybuton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxhastaneler;
        private System.Windows.Forms.ComboBox comboBoxtalep;
    }
}