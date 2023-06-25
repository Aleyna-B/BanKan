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
    public partial class seçimform : Form
    {
        public seçimform()
        {
            InitializeComponent();
        }
        OleDbConnection bağlantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =.accdb");
        private void button1_Click(object sender, EventArgs e)      //çıkış butonu
        {
            DialogResult onay = MessageBox.Show("Sistemden çıkış yapıyorsunuz.", "Çıkış ekranı", MessageBoxButtons.OKCancel);   ////çıkış butonuna tıklanınca mesaj kutusu çıkar
            if (onay == DialogResult.OK)        //"tamam"a tıklanırsa 
            {
                Application.Exit();     //uygulamayı kapatır
            }
        }

        private void stokgörbuton_Click(object sender, EventArgs e)  //stok görme butonuna tıklanırsa
        {
            stoktablosu stt = new stoktablosu(); //stt adlı stoktablosu objesi oluşturulur
            stt.Show();     //stt formunu gösterir
            this.Close();   //seçimform formunu gizler
        }

        private void hastanetalepgörbuton_Click(object sender, EventArgs e)    //hastane taleplerini görme butonuna tıklanırsa
        {
            Hastanetalep ht = new Hastanetalep(); //ht adlı Hastanetalep objesi oluşturulur
            ht.Show();      //ht formunu gösterir
            this.Close();
        }

        private void başvurugörbuton_Click(object sender, EventArgs e)  //gönüllü başvurusu görme butonuna tıklanırsa
        {
            Başvurular bv = new Başvurular();    //bv adlı Başvurular objesi oluşturulur
            bv.Show();      //bv formunu gösterir
            this.Close();
        }

        private void sonuçgirbuton_Click(object sender, EventArgs e)    //sonuç girme/görme butonuna tıklanırsa
        {
            Testsonuç tst = new Testsonuç();     //tst adlı Testsonuç objesi oluşturulur
            tst.Show();     //tst formunu gösterir
            this.Close();
        }

        private void seçimform_Load(object sender, EventArgs e)
        {

        }
    }
}
