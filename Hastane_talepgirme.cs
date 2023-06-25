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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje2
{
    public partial class Hastane_talepgirme : Form
    {
        public Hastane_talepgirme()
        {
            InitializeComponent();
        }

        OleDbConnection bağlantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =.accdb");     //bağlantı dizini
        private void button1_Click(object sender, EventArgs e)      //çıkış butonu
        {
            DialogResult onay = MessageBox.Show("Sistemden çıkış yapıyorsunuz.", "Çıkış ekranı", MessageBoxButtons.OKCancel);   //çıkış butonuna tıklanınca mesaj kutusu çıkar
            if (onay == DialogResult.OK)
            {
                Application.Exit();         //uygulamayı kapatır
            }
        }

        void dbgör()                             //verisetinden veri çekmek için kullanılan metot,bütün uygulamada aynı adla kullanıldı
        {
            bağlantı.Open();                     //veriseti bağlantısı açılır
            OleDbCommand kom = new OleDbCommand();          //komutlar verebilmek için kom adında command objesi oluşturuldu
            kom.Connection = bağlantı;                      //connection özelliği bağlantıyla ilişkilendirildi
            kom.CommandText = ("select * from hastane_talep where [Hastane Adı] = '"+ labelKurumad.Text.ToString() +"' ");   //verilerin seçileceği tabloyu belirten dizin
            OleDbDataReader okuyucu = kom.ExecuteReader();       //verileri okuyacak okuyucu oluşturulur
            while (okuyucu.Read())                               //okuyucu okuduğu sürece
            {
                ListViewItem talgir = new ListViewItem();              //talgir adlı ListViewItem objesi oluşturuldu 
                talgir.Text = okuyucu["Hastane Adı"].ToString();       //talgir'in elemanları okunup listview'e ekleniyor
                talgir.SubItems.Add(okuyucu["Talep"].ToString());
                talgir.SubItems.Add(okuyucu["Miktar"].ToString());
                talgir.SubItems.Add(okuyucu["Onay durumu"].ToString());
                listViewtalepgörme.Items.Add(talgir);              //seçilen listview elemanları formdaki listviewe ekleniyor
            }
            bağlantı.Close();       //sonunda bağlantı kapatılıyor
        }
        private void Hastane_talepgirme_Load(object sender, EventArgs e)
        {
            try
            {
                dbgör();            //form yüklendiğinde metot çağırılır
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void Talepkayıtbuton_Click(object sender, EventArgs e)      //talebi tabloya kaydeden buton
        {
            try
            {
                bağlantı.Open();
                OleDbCommand komut = new OleDbCommand("insert into hastane_talep ([Hastane Adı],Talep,Miktar) values('" + labelKurumad.Text + "','" + comboBoxtalep.Text + "' , '"+TBtalepmiktar.Text+"')", bağlantı);     //komutlar verebilmek için komut adında command objesi oluşturuldu
                if (comboBoxtalep.Text.Equals("") || TBtalepmiktar.Text.Equals(""))     //boş değer var mı diye kontrol eder
                {
                    MessageBox.Show("Bir değer giriniz.", "Uyarı");
                    bağlantı.Close();                       //tekrar değer girilebilmesi için bağlantıyı kapatır
                }
                else if (!TBtalepmiktar.Text.Any(Char.IsDigit))         //miktar değerinin sayı olmasını kontrol eder
                {
                    MessageBox.Show("Miktar değeri sadece sayı olabilir.");
                    bağlantı.Close();
                }
                else
                {
                        komut.ExecuteNonQuery();            //komutu çalışır
                        bağlantı.Close();                   //işlem bitince bağlantıyı kapatır
                        MessageBox.Show("Yeni talep kaydedildi.\n Onay için lütfen sistemi takip edin.");
                        listViewtalepgörme.Items.Clear();       //yeni tablo gösterileceği için listviewi temizler
                        dbgör();                            //güncellenmiş tablo gösterilir
                }
            }
            catch (Exception j)
            {
                MessageBox.Show(j.Message);
            }
        }
        private void buttonİptal_Click(object sender, EventArgs e)      //talebi geri çekme butonu
        {
            try
            {
                bağlantı.Open();
                OleDbCommand kom = new OleDbCommand();
                kom.Connection = bağlantı;
                {
                    DialogResult emin = MessageBox.Show("Talep silinecek, emin misiniz?", "Onay ekranı", MessageBoxButtons.YesNo);
                    if (emin == DialogResult.Yes)
                    {
                        kom.CommandText = "delete from hastane_talep where [Hastane Adı] = '" + HastaneVal + "' and Talep = '"+TalpVal+"' and Miktar = '"+MiktrVal+"' ";
                        kom.ExecuteNonQuery();
                        bağlantı.Close();
                        MessageBox.Show("Talep geri çekildi.");
                        listViewtalepgörme.Items.Clear();
                        dbgör();
                    }
                    else bağlantı.Close();
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message);
            }
        }
                              //kullanıcının hangi satırı işaretlediğini anlamak için yazılan komutlar
        private string HastaneVal = "";         //satırlardan alınacak bilgilerin atanacağı string değişkenleri
        private string TalpVal = "";
        private string MiktrVal = "";
        private void lvv_SelectedIndexChanged(object sender, EventArgs e)   //listviewdeki değişikliklerin kullanıldığı event
        {
            try
            {
                if (listViewtalepgörme.SelectedItems.Count > 0)     //tablodan seçilen eleman varsa
                {
                    HastaneVal = listViewtalepgörme.SelectedItems[0].SubItems[0].Text;  //seçilen ilk satırın ilk elemanını okur ve değişkene atar
                    TalpVal = listViewtalepgörme.SelectedItems[0].SubItems[1].Text;     //seçilen ilk satırın ikinci elemanını okur ve değişkene atar
                    MiktrVal = listViewtalepgörme.SelectedItems[0].SubItems[2].Text;    //seçilen ilk satırın üçüncü elemanını okur ve değişkene atar
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
