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
    public partial class Başvurular : Form
    {
        public Başvurular()
        {
            InitializeComponent();
        }
        OleDbConnection bağlantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =.accdb");  //bağlantı dizini

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
            seçimform sçf = new seçimform();    //seçimform instanceı oluşturur
            sçf.Show();     //seçimformu gösterir
            this.Close();
        }

        void dbgör()                            //verisetinden veri çekmek için kullanılan metot,bütün uygulamada aynı adla kullanıldı
        {
            bağlantı.Open();                            //bağlantı açılır
            OleDbCommand kom = new OleDbCommand();          //komutlar verebilmek için kom adında command objesi oluşturuldu
            kom.Connection = bağlantı;                          //connection özelliği bağlantıyla ilişkilendirildi
            kom.CommandText = ("select * from basvuru");            //verilerin seçileceği tabloyu belirten dizin
            OleDbDataReader okuyucu = kom.ExecuteReader();       //verileri okuyacak okuyucu oluşturulur
            while (okuyucu.Read())                               //okuyucu okuduğu sürece
            {
                ListViewItem baş = new ListViewItem();              //baş adlı listviewitem objesi oluşturuldu 
                baş.Text = okuyucu["Ad"].ToString();            //baş'ın elemanları okunup listview'e ekleniyor
                baş.SubItems.Add(okuyucu["Soyad"].ToString());
                baş.SubItems.Add(okuyucu["Yas"].ToString());
                baş.SubItems.Add(okuyucu["Cinsiyet"].ToString());
                baş.SubItems.Add(okuyucu["E_Posta"].ToString());
                baş.SubItems.Add(okuyucu["Onay_durumu"].ToString());
                listViewbaşvuru.Items.Add(baş);                 //seçilen listview elemanları formdaki listviewe ekleniyor
            }
            bağlantı.Close();                                      //bağlantı kapanır
            textBoxad.Clear();                                    //textboxlara yazılanlar silinir
            textBoxsoyad.Clear();
        }

        private void listViewbaşvuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Başvurular_Load(object sender, EventArgs e)
        {
            dbgör();        //form yüklendiğinde dbgör metodu çalışır
        }

        private void button3_Click(object sender, EventArgs e) //onaylama butonu
        {
            try             //run-time hataları yakalayabilmek için try-catch yapısı
            {
                bağlantı.Open();        //bağlantı açılır
                OleDbCommand kom = new OleDbCommand();       //komutlar verebilmek için kom adında command objesi oluşturuldu
                kom.Connection = bağlantı;                  //connection özelliği bağlantıyla ilişkilendirildi
                if (textBoxad.Text.Equals("") || textBoxsoyad.Text.Equals(""))   //boş değer girilip girilmediğini kontrol eder
                {
                    MessageBox.Show("Tüm değerleri giriniz.", "Uyarı"); //uyarı mesajı verir
                    bağlantı.Close();                       //tekrar işlem yapılabilmesi için bağlantıyı kapatır
                }
                else
                {
                    DialogResult emin = MessageBox.Show("Talep onaylanacak.", "Onay ekranı", MessageBoxButtons.OKCancel);
                    if (emin == DialogResult.OK)
                    {
                        kom.CommandText = "update basvuru set Onay_durumu = '" + "Onaylandı" + "' where [Ad] = '" + textBoxad.Text + "' and Soyad = '" + textBoxsoyad.Text + "'";   //girilen değerlere göre basvuru adlı tabloyu günceller
                        kom.ExecuteNonQuery();      //komut dizesini çalıştırmaya başlar
                        bağlantı.Close();
                        MessageBox.Show("Kayıt başarılı.");     //kayıt durumuyla ilgili bilgi kutucuğu gösterir
                        listViewbaşvuru.Items.Clear();  //listview üzerindeki elemanları bir sonraki kullanımda karışıklık olmaması için temizler
                        dbgör();    //güncellenmiş tabloyu gösterir
                    }
                    else bağlantı.Close();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);     //özel durum mesajını gösterir
                bağlantı.Close();   //tekrar işlem yapılabilmesi için bağlantıyı kapatır
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
