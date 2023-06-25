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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }
        OleDbConnection bağlantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =.accdb"); //bağlantı dizini
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void çıkışbutonu_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Sistemden çıkış yapıyorsunuz.", "Çıkış ekranı", MessageBoxButtons.OKCancel);   //çıkış butonuna tıklanınca mesaj kutusu çıkar
            if (onay == DialogResult.OK)        //"tamam"a tıklanırsa 
            {
                Application.Exit();     //uygulamayı kapatır
            }
        }

        private void Girisbuton_Click(object sender, EventArgs e)
        {
            try         //run-time hataları yakalayabilmek için try-catch yapısı
            {
                bağlantı.Open();        //bağlantıyı açar
                OleDbCommand kontrol = new OleDbCommand("select K_adı,Sifre from Banka_yetkili_girisbilg where K_adı=@ad and Sifre = @sifre", bağlantı);    //komutlar verebilmek için kontrol adında command objesi oluşturuldu
                kontrol.Parameters.AddWithValue("@K_adı", k_adıtextbox.Text);   //kullanıcı adı parametresi eklendi
                kontrol.Parameters.AddWithValue("@Sifre", şifregirişitextbox.Text);    // şifre parametresi eklendi
                OleDbDataReader datareader1;    //veri tabanındaki verileri okumak için datareader1 tanımlandı
                datareader1 = kontrol.ExecuteReader();  //datareader1 oluşturuldu

                if (datareader1.Read())     //veri okunduğu sürece
                {
                    seçimform sf = new seçimform();     //sf adında seçimform objesi oluşturuldu
                    sf.Show();      //uygulama sf adlı formu gösterir
                    this.Hide();    //mevcut Form1 formunu saklar
                }
                else    //veri okunamazsa
                {
                    bağlantı.Close();   //bağlantıyı kapatır
                    MessageBox.Show("Kullanıcı adı veya parola yanlış girildi.\nLütfen tekrar deneyin.");   //hata mesajı gösterir
                }
            }
            catch
            {
                MessageBox.Show("Lütfen bilgilerinizle giriş yapın.");
            }
            finally
            {
                k_adıtextbox.Clear();           //textboxlara yazılanlar temizlenir
                şifregirişitextbox.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
