using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje2
{
    public partial class Testsonuç : Form
    {
        public Testsonuç()
        {
            InitializeComponent();
        }
        OleDbConnection bağlantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =.accdb");     //bağlantı dizini

        void dbgör()           //verisetinden veri çekmek için kullanılan metot,bütün uygulamada aynı adla kullanıldı
        {
            bağlantı.Open();
            OleDbCommand kom = new OleDbCommand();
            kom.Connection = bağlantı;
            kom.CommandText = ("select * from testsonuc");
            OleDbDataReader okuyucu = kom.ExecuteReader();
            while (okuyucu.Read())
            {
                ListViewItem sonuc = new ListViewItem();
                sonuc.Text = okuyucu["Ad"].ToString();           //sonuc'un elemanları okunup listviewe ekleniyor
                sonuc.SubItems.Add(okuyucu["Soyad"].ToString());
                sonuc.SubItems.Add(okuyucu["Yas"].ToString());
                sonuc.SubItems.Add(okuyucu["Cinsiyet"].ToString());
                sonuc.SubItems.Add(okuyucu["Kan_Grubu"].ToString());
                sonuc.SubItems.Add(okuyucu["Hepatit B"].ToString());
                sonuc.SubItems.Add(okuyucu["Hepatit C"].ToString());
                sonuc.SubItems.Add(okuyucu["AIDS_HIV"].ToString());
                sonuc.SubItems.Add(okuyucu["Frengi_Sifiliz"].ToString());
                sonuc.SubItems.Add(okuyucu["E_Posta"].ToString());
                listViewtestsonuc.Items.Add(sonuc);           //seçilen listview elemanları formdaki listviewe ekleniyor
            }
            textBoxad.Clear();          //textboxlar temizlenir ve bağlantı kapanır
            textBoxsoyad.Clear();
            bağlantı.Close();
        }

        private void Testsonuç_Load(object sender, EventArgs e)
        {
            dbgör();
        }
        private void button1_Click(object sender, EventArgs e)      //çıkış butonu
        {
            DialogResult onay = MessageBox.Show("Sistemden çıkış yapıyorsunuz.", "Çıkış ekranı", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void button2_Click(object sender, EventArgs e)      //geri butonu
        {
            seçimform sçf = new seçimform();
            sçf.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void degişbuton_Click(object sender, EventArgs e)   //test sonuçlarını girmek için kullanılan buton
        {
            try
            {
                bağlantı.Open();
                OleDbCommand kom = new OleDbCommand();
                kom.Connection = bağlantı;
                if(textBoxad.Text.Equals("") || textBoxsoyad.Text.Equals("") || comboBoxB.Text.Equals("") || comboBoxC.Text.Equals("") || comboBoxAI.Text.Equals("") || comboBoxFR.Text.Equals(""))
                {
                    MessageBox.Show("Tüm değerleri giriniz.", "Uyarı");
                    bağlantı.Close();
                }
                else
                {
                    DialogResult emin = MessageBox.Show("Değişiklikten emin misiniz?", "Onay ekranı", MessageBoxButtons.YesNo);
                    if (emin == DialogResult.Yes)       //kullanıcı eminse komutlar uygulanır
                    {
                        kom.CommandText = "update testsonuc set Kan_Grubu = '" + comboBoxkan.Text + "' , [Hepatit B] = '" + comboBoxB.Text + "' , [Hepatit C] = '" + comboBoxC.Text + "' , AIDS_HIV = '" + comboBoxAI.Text + "' , Frengi_Sifiliz = '" + comboBoxFR.Text + "' where Ad = '" + textBoxad.Text + "' and Soyad = '" + textBoxsoyad.Text + "'";
                        kom.ExecuteNonQuery();
                        bağlantı.Close();
                        MessageBox.Show("Kayıt başarılı.");
                        listViewtestsonuc.Items.Clear();
                        dbgör();
                    }
                    else bağlantı.Close();      //kullanıcı emin değilse bağlantı kapatılır ki başa dönülebilsin
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message); //çalıştırma anında sorun çıkarsa uygulama kapanmadan önce hata mesajı görülür
                bağlantı.Close();           //ve bağlantı kapatılır
            }
        }

        private void silbuton_Click(object sender, EventArgs e)     //adı ve soyadı girilen gönüllünün bilgileri silinir
        {
            try
            {
                bağlantı.Open();
                OleDbCommand kom = new OleDbCommand();
                kom.Connection = bağlantı;
                if (textBoxad.Text.Equals("") || textBoxsoyad.Text.Equals(""))
                {
                    MessageBox.Show("Adı ve soyadı girin.", "Uyarı");
                    bağlantı.Close();
                }
                else
                {
                    DialogResult emin = MessageBox.Show("Öğe silinecek, emin misiniz?", "Onay ekranı", MessageBoxButtons.YesNo);
                    if (emin == DialogResult.Yes)
                    {
                        kom.CommandText = "delete from testsonuc where Ad = '" + textBoxad.Text + "' and Soyad = '"+ textBoxsoyad.Text +"' ";

                        kom.ExecuteNonQuery();
                        bağlantı.Close();
                        MessageBox.Show("Değişiklikler kaydedildi.");
                        listViewtestsonuc.Items.Clear();
                        dbgör();
                    }
                    else bağlantı.Close();
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
                bağlantı.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listViewtestsonuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
