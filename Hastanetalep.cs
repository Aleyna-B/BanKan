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
using System.Runtime.Remoting;

namespace Proje2
{
    public partial class Hastanetalep : Form
    {
        public Hastanetalep()
        {
            InitializeComponent();
        }

        OleDbConnection bağlantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =.accdb");     //veri setini bağlayan dize

        void dbgör()        //tablolardan veri çekip listviewlere ekleyen metot,projenin her dosyasında aynı adla kulanıldı
        {
            bağlantı.Open();
            OleDbCommand kom = new OleDbCommand();
            kom.Connection = bağlantı;
            kom.CommandText = ("select * from hastane_talep");
            OleDbDataReader okuyucu = kom.ExecuteReader();
            while (okuyucu.Read())
            {
                ListViewItem tal = new ListViewItem();
                tal.Text = okuyucu["Hastane Adı"].ToString();
                tal.SubItems.Add(okuyucu["Talep"].ToString());
                tal.SubItems.Add(okuyucu["Miktar"].ToString());
                tal.SubItems.Add(okuyucu["Onay durumu"].ToString());
                listViewtalep.Items.Add(tal);
            }
            bağlantı.Close();
        }

        
        private void Hastanetalep_Load(object sender, EventArgs e)
        {
            dbgör();                   //form yüklendiğinde çağrılır
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
            seçimform sçf = new seçimform();        //seçim menüsü olan seçimform formunu oluşturur
            sçf.Show();                             //ve açar
            this.Close();
        }
        private void onaybuton_Click(object sender, EventArgs e)
        {
            try
            {
                bağlantı.Open();
                OleDbCommand kom = new OleDbCommand();
                kom.Connection = bağlantı;
                if (comboBoxhastaneler.Text.Equals("") || comboBoxtalep.Text.Equals(""))   //boş değer girilip girilmediğini kontrol eder
                {
                    MessageBox.Show("Tüm değerleri giriniz.", "Uyarı");
                    bağlantı.Close();           //bilgiler doğru değilse tekrar girilebilmesi için bağlantı kapatılır
                }
                else
                {
                    DialogResult emin = MessageBox.Show("Talep onaylanacak.", "Onay ekranı", MessageBoxButtons.OKCancel);
                    if (emin == DialogResult.OK)
                    {
                        kom.CommandText = "update hastane_talep set [Onay durumu] = '" +"Onaylandı"+ "' where [Hastane Adı] = '" + comboBoxhastaneler.Text + "' and Talep = '" + comboBoxtalep.Text + "' ";    //komutlar verebilmek için kom adında command objesi oluşturuldu
                        kom.ExecuteNonQuery();              //komut dizesini çalıştırmaya başlar
                        bağlantı.Close();                  //connection özelliği bağlantıyla ilişkilendirildi
                        MessageBox.Show("Kayıt başarılı.");
                        listViewtalep.Items.Clear();       //yeni tablo gösterileceği için listviewi temizler
                        dbgör();                            //güncellenmiş tablo gösterilir
                    }
                    else bağlantı.Close();
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
                bağlantı.Close();
            }
        }

        private void comboBoxhastaneler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
