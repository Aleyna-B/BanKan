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

namespace Proje2
{
    public partial class stoktablosu : Form
    {
        public stoktablosu()
        {
            InitializeComponent();
        }
        OleDbConnection bağlantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =.accdb");

        void dbgör()                             //verisetinden veri çekmek için kullanılan metot,bütün uygulamada aynı adla kullanıldı
        {
            bağlantı.Open();                                //veriseti bağlantısı açılır
            OleDbCommand kom = new OleDbCommand();          //komutlar verebilmek için kom adında command objesi oluşturuldu
            kom.Connection = bağlantı;                      //connection özelliği bağlantıyla ilişkilendirildi
            kom.CommandText = ("select * from kan_stok");   //verilerin seçileceği tabloyu belirten dizin
            OleDbDataReader okuyucu = kom.ExecuteReader();       //verileri okuyacak okuyucu oluşturulur
            while (okuyucu.Read())                              //okuyucu okuduğu sürece
            {
                ListViewItem stok = new ListViewItem();             //stok adlı ListViewItem objesi oluşturuldu 
                stok.Text = okuyucu["urunler"].ToString();          //stokun elemanları okunup listview'e ekleniyor
                stok.SubItems.Add(okuyucu["Miktar"].ToString());
                listViewstok.Items.Add(stok);               //seçilen listview elemanları formdaki listviewe ekleniyor
            }
            textBox2.Clear();                   //textboxlar temizlenip bağlantı kapatılıyor
            bağlantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)      //çıkış butonu
        {
            DialogResult onay = MessageBox.Show("Sistemden çıkış yapıyorsunuz.", "Çıkış ekranı", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                Application.Exit();             //uygulamayı arka planda çalışamayacak şekilde kapatır
            }
        }
        private void button2_Click(object sender, EventArgs e)      //geri butonu
        {
            seçimform sçf = new seçimform();        //seçimform örneği oluşturur 
            sçf.Show();                             // ve açar
            this.Close();                       //mevcut formu saklar
        }


        private void stoktablosu_Load(object sender, EventArgs e)
        {
            dbgör();              //form yüklendiğinde metot çağırılır
        }

        private void kaydetbuton_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand("insert into kan_stok (urunler,Miktar) values('"+textBoxÜrünismi.Text.ToString()+"','"+textBox2.Text.ToString()+"')",bağlantı);
            if (textBoxÜrünismi.Text.Equals("") || textBox2.Text.Equals(""))     //boş değer var mı diye kontrol eder
            {
                MessageBox.Show("Bir değer giriniz.", "Uyarı");
                bağlantı.Close();           //uyarı gösterir ve tekrar değer girilebilmesi için bağlantıyı kapatır
            }
            else if (!textBox2.Text.Any(Char.IsDigit))      //miktar değerinin sayı olmasını kontrol eden string işlemi
            {
                MessageBox.Show("Miktar değeri sadece sayı olabilir.");
                bağlantı.Close();
            }
            else
            {
                DialogResult emin = MessageBox.Show("Değişiklikten emin misiniz?", "Onay ekranı", MessageBoxButtons.YesNo);
                if (emin == DialogResult.Yes)
                {
                    komut.ExecuteNonQuery();        //komutu devreye sokar
                    bağlantı.Close();               //işlem tamamlanınca bağlantı kapatılır
                    MessageBox.Show("Yeni içerik kaydedildi");
                    listViewstok.Items.Clear();     //tabloyu temizler
                    dbgör();                        //ve yeni kayıtlarla tekrar gösterir
                }
                else bağlantı.Close();
            }
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void degişbuton_Click(object sender, EventArgs e)   //değişiklik yapma butonu
        {
            bağlantı.Open();
            OleDbCommand kom = new OleDbCommand();
            kom.Connection = bağlantı;
            if (textBoxÜrünismi.Text.Equals("")||textBox2.Text.Equals(""))
            {
                MessageBox.Show("Bir değer giriniz.", "Uyarı");
                bağlantı.Close();
            }
            else if (!textBox2.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("Miktar değeri sadece sayı olabilir.");
                bağlantı.Close();
            }
            else
            {
                DialogResult emin = MessageBox.Show("Değişiklikten emin misiniz?", "Onay ekranı", MessageBoxButtons.YesNo);
                if (emin == DialogResult.Yes)
                {
                    kom.CommandText = "(update kan_stok set Miktar = '" + textBox2.Text + "' where urunler = '" + textBoxÜrünismi.Text + "')";
                    kom.ExecuteNonQuery();
                    bağlantı.Close();
                    MessageBox.Show("Değişiklikler kaydedildi.");
                    listViewstok.Items.Clear();
                    dbgör();
                }
                else bağlantı.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void silbuton_Click(object sender, EventArgs e)     //verileri silme butonu
        {
            bağlantı.Open();
            OleDbCommand kom = new OleDbCommand();
            kom.Connection = bağlantı;
            if (textBoxÜrünismi.Text.Equals(""))
            {
                MessageBox.Show("Bir değer giriniz.", "Uyarı");
                bağlantı.Close();
            }
            else
            {
                DialogResult emin = MessageBox.Show("Öğe silinecek, emin misiniz?", "Onay ekranı", MessageBoxButtons.YesNo);
                if (emin == DialogResult.Yes)
                {
                    kom.CommandText = "delete from kan_stok where urunler = '" + textBoxÜrünismi.Text + "'";

                    kom.ExecuteNonQuery();
                    bağlantı.Close();
                    MessageBox.Show("Değişiklikler kaydedildi.");
                    listViewstok.Items.Clear();
                    dbgör();
                }
                else bağlantı.Close();
            }
        }

        private void Onaylanan_çıkışlar_Click(object sender, EventArgs e)   //onaylanan çıkışları görme butonu
        {
            OnaylananCıkıs on = new OnaylananCıkıs();       //on adında OnaylananCıkıs objesi oluşturulur
            on.Show();                                      //ve gösterilir
        }
    }               //onaylanan çıkış formundan eksilen stoklar görülür ve buradaki tabloya işlenir
}
