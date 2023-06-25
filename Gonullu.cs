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
    public partial class Gonullu : Form
    {
        public Gonullu()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =.accdb");               // veritabanı ile bağlantı yapılıyor
        private void Gonullu_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click_1(object sender, EventArgs e)                // kaydet butonu 
        {
            baglanti.Open();             // bağlantıyı açar
            OleDbCommand komut = new OleDbCommand("insert into basvuru (Ad,Soyad,Yas,Cinsiyet,Kan_Grubu,E_Posta) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "') ", baglanti);   //textBoxlara yazılan bilgileri veri tabanındaki tabloya aktarma komutu
            komut.ExecuteNonQuery();    // komutu çalıştırır
            baglanti.Close();           // bağlantıyı kapatır
            textBox1.Clear();          // textBoxlar bir sonraki kişi için temizlenir
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            MessageBox.Show("Bilgileriniz başarıyla kaydedilmiştir.","Bildirim");    // başvuru kaydedilince bildirim olarak göüzükür
        }
        private void dbgor()             // veri setinden veri çekme metodu
        {
            baglanti.Open();            // bağlantı açar
            OleDbCommand komut1 = new OleDbCommand();
            komut1.Connection = baglanti;
            komut1.CommandText = ("Select * From testsonuc WHERE Kod LIKE '" + textAra.Text + "'");        // verilerin seçileceği tabloyu seçer tablo içindede aratılan bilgiye göre satırı bulmaya yarar
            OleDbDataReader oku = komut1.ExecuteReader();       // komutu çalıştırır
            while (oku.Read())                                
            {
                ListViewItem ekle = new ListViewItem();                       // ekle adlı bir ListView oluşturur
                ekle.Text = oku["Hepatit B"].ToString();                     // veri tabanındaki bilgileri ekle'ye ekledi
                ekle.SubItems.Add(oku["Hepatit C"].ToString());
                ekle.SubItems.Add(oku["AIDS_HIV"].ToString());
                ekle.SubItems.Add(oku["Frengi_Sifiliz"].ToString());

                listView1.Items.Add(ekle);                                  // ekledeki bilgileri formadi listview e yazdı

            }
            baglanti.Close();                                         // bağlantı kapatıldı
        }
        private void button2_Click_1(object sender, EventArgs e)       // sonuç gösterme butonu
        {
            dbgor();                     // yukarıdaki metodu çağırdı
        }

        private void button3_Click_1(object sender, EventArgs e)             // randevu alma butonu
        {
            Randevu randevu = new Randevu();                                // randevu formuna götürür
            randevu.ShowDialog();
        }
    }
}
