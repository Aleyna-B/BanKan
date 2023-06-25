using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proje2
{
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =.accdb");      // veri tabanı bağlantısı
        private void Randevu_Load(object sender, EventArgs e)                 
        {
            comboBox1.Items.Add("YILDIRIM");                 // ilk comboBox a şubeler eklendi
            comboBox1.Items.Add("OSMANGAZİ");
            comboBox1.Items.Add("NİLÜFER");
            comboBox1.Items.Add("EMEK");
            comboBox1.Items.Add("İNEGÖL");
        }
       
       

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)            // değişen seçenekler için tarihler ekleniyor
        {
            if (comboBox1.Text == "YILDIRIM")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("05.06.2023");
                comboBox2.Items.Add("06.06.2023");
                comboBox2.Items.Add("07.06.2023");
                comboBox2.Items.Add("08.06.2023");
                comboBox2.Items.Add("09.06.2023");
            }
            else if (comboBox1.Text == "OSMANGAZİ")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("05.06.2023");
                comboBox2.Items.Add("06.06.2023");
                comboBox2.Items.Add("07.06.2023");
                comboBox2.Items.Add("08.06.2023");
                comboBox2.Items.Add("09.06.2023");
            }
            else if (comboBox1.Text == "NİLÜFER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("05.06.2023");
                comboBox2.Items.Add("06.06.2023");
                comboBox2.Items.Add("07.06.2023");
                comboBox2.Items.Add("08.06.2023");
                comboBox2.Items.Add("09.06.2023");
            }
            else if (comboBox1.Text == "EMEK")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("05.06.2023");
                comboBox2.Items.Add("06.06.2023");
                comboBox2.Items.Add("07.06.2023");
                comboBox2.Items.Add("08.06.2023");
                comboBox2.Items.Add("09.06.2023");
            }
            else if (comboBox1.Text == "İNEGÖL")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("05.06.2023");
                comboBox2.Items.Add("06.06.2023");
                comboBox2.Items.Add("07.06.2023");
                comboBox2.Items.Add("08.06.2023");
                comboBox2.Items.Add("09.06.2023");
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)               // her saat için saat ekleniyor
        {
            if (comboBox2.Text == "05.06.2023")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("09.00");
                comboBox3.Items.Add("09.30");
                comboBox3.Items.Add("10.00");
                comboBox3.Items.Add("10.30");
                comboBox3.Items.Add("11.00");
                comboBox3.Items.Add("11.30");
                comboBox3.Items.Add("12.00");
                comboBox3.Items.Add("12.30");
                comboBox3.Items.Add("13.00");
                comboBox3.Items.Add("13.30");
                comboBox3.Items.Add("14.00");
                comboBox3.Items.Add("14.30");
                comboBox3.Items.Add("15.00");
                comboBox3.Items.Add("15.30");
                comboBox3.Items.Add("16.00");
                comboBox3.Items.Add("16.30");
                comboBox3.Items.Add("17.00");
            }
            else if (comboBox2.Text == "06.06.2023")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("09.00");
                comboBox3.Items.Add("09.30");
                comboBox3.Items.Add("10.00");
                comboBox3.Items.Add("10.30");
                comboBox3.Items.Add("11.00");
                comboBox3.Items.Add("11.30");
                comboBox3.Items.Add("12.00");
                comboBox3.Items.Add("12.30");
                comboBox3.Items.Add("13.00");
                comboBox3.Items.Add("13.30");
                comboBox3.Items.Add("14.00");
                comboBox3.Items.Add("14.30");
                comboBox3.Items.Add("15.00");
                comboBox3.Items.Add("15.30");
                comboBox3.Items.Add("16.00");
                comboBox3.Items.Add("16.30");
                comboBox3.Items.Add("17.00");
            }
            else if (comboBox2.Text == "07.06.2023")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("09.00");
                comboBox3.Items.Add("09.30");
                comboBox3.Items.Add("10.00");
                comboBox3.Items.Add("10.30");
                comboBox3.Items.Add("11.00");
                comboBox3.Items.Add("11.30");
                comboBox3.Items.Add("12.00");
                comboBox3.Items.Add("12.30");
                comboBox3.Items.Add("13.00");
                comboBox3.Items.Add("13.30");
                comboBox3.Items.Add("14.00");
                comboBox3.Items.Add("14.30");
                comboBox3.Items.Add("15.00");
                comboBox3.Items.Add("15.30");
                comboBox3.Items.Add("16.00");
                comboBox3.Items.Add("16.30");
                comboBox3.Items.Add("17.00");
            }
            else if (comboBox2.Text == "08.06.2023")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("09.00");
                comboBox3.Items.Add("09.30");
                comboBox3.Items.Add("10.00");
                comboBox3.Items.Add("10.30");
                comboBox3.Items.Add("11.00");
                comboBox3.Items.Add("11.30");
                comboBox3.Items.Add("12.00");
                comboBox3.Items.Add("12.30");
                comboBox3.Items.Add("13.00");
                comboBox3.Items.Add("13.30");
                comboBox3.Items.Add("14.00");
                comboBox3.Items.Add("14.30");
                comboBox3.Items.Add("15.00");
                comboBox3.Items.Add("15.30");
                comboBox3.Items.Add("16.00");
                comboBox3.Items.Add("16.30");
                comboBox3.Items.Add("17.00");
            }
            else if (comboBox2.Text == "09.06.2023")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("09.00");
                comboBox3.Items.Add("09.30");
                comboBox3.Items.Add("10.00");
                comboBox3.Items.Add("10.30");
                comboBox3.Items.Add("11.00");
                comboBox3.Items.Add("11.30");
                comboBox3.Items.Add("12.00");
                comboBox3.Items.Add("12.30");
                comboBox3.Items.Add("13.00");
                comboBox3.Items.Add("13.30");
                comboBox3.Items.Add("14.00");
                comboBox3.Items.Add("14.30");
                comboBox3.Items.Add("15.00");
                comboBox3.Items.Add("15.30");
                comboBox3.Items.Add("16.00");
                comboBox3.Items.Add("16.30");
                comboBox3.Items.Add("17.00");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)   // kayıt butonu
        {
            baglanti.Open();   // bağlantı açıldı
            OleDbCommand komut = new OleDbCommand(" insert into randevu(Ad,Soyad,Numara,Sube,Tarih,Saat) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + comboBox3.Text.ToString() + "') ", baglanti);     // girilen bilgileri ve seçilen randeevu zamanını veri tabanına kaydetme komutu
            komut.ExecuteNonQuery();          // komutu çalıştırır
            baglanti.Close();                // bağlantıyı kapatır
            textBox1.Clear();              // sonraki kişi için textBoxlar temizlenir
            textBox2.Clear();
            textBox3.Clear();
            comboBox3.Items.Remove(comboBox3.SelectedItem);          // randevu saatlerinin çakışmaması için seçilen yer ve tarihte seçilen saat silinir
            MessageBox.Show("Randevunuz oluşturulmuştur.", "Bildirim");          // randevu oluşturulunca geşlen bildirim
        }
    }
}
