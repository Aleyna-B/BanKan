using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    public partial class Hastane : Form
    {
        public Hastane()
        {
            InitializeComponent();
        }

        OleDbConnection bağlantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =.accdb"); //bağlantı dizesi

        Hastane_talepgirme frm2 = new Hastane_talepgirme();     //birden çok yerde kullanılacağı için global oluşturulan Hastane_talepgirme instanceı
        private void Girisbutonhastane_Click(object sender, EventArgs e)
        {
            try
            {
                bağlantı.Open();                    //bağlantı açılır
                OleDbCommand kontrol = new OleDbCommand("select Hastane,sifre from hastane_yetkili where Hastane=@ad and sifre = @sifre", bağlantı);    //komutlar verebilmek için kontrol adında command objesi oluşturuldu ve bağlantı dizesi yazıldı
                kontrol.Parameters.AddWithValue("@Hastane", combohastaneadları.Text);   //hastane adı parametresi eklendi
                kontrol.Parameters.AddWithValue("@sifre", textBoxhastşifre.Text);       //şifre parametresi eklendi
                OleDbDataReader datareader2;                            //veri tabanındaki verileri okumak için datareader2 tanımlandı
                datareader2 = kontrol.ExecuteReader();                  //datareader1 oluşturuldu

                if (datareader2.Read())                    //veri okunduğu sürece
                {
                    frm2.Show();                           //uygulama sf adlı formu gösterir
                    this.Hide();                           //mevcut form saklanır
                }
                else                                //girilen bilgiler yanlışsa 
                {
                    bağlantı.Close();               //bağlantı kapatılır
                    MessageBox.Show("Kullanıcı adı veya parola yanlış girildi.\nLütfen tekrar deneyin.");   //uyarı mesajı gösterilir
                }
            }
            catch(Exception l)
            {
                MessageBox.Show(l.Message);
            } 
            finally
            {
                textBoxhastşifre.Clear();   //textboxa yazılanlar temizlenir
            }
        }

        private void Çıkışbutonhastane_Click(object sender, EventArgs e)    //çıkış butonu
        {
            DialogResult onay = MessageBox.Show("Sistemden çıkış yapıyorsunuz.", "Çıkış ekranı", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            frm2.labelKurumad.Text = this.combohastaneadları.Text;     //bu formdaki comboboxtan seçilen hastane adı bilgisini hastane_talepgirme
        }                                                              //formuna göndermek için eklenen combobox eventi

        private void Hastane_Load(object sender, EventArgs e)
        {

        }
    }
}
