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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje2
{
    public partial class OnaylananCıkıs : Form
    {
        public OnaylananCıkıs()        //onaylanan kan çıkışlarının stoktan düşülmesi için hazırlanan form
        {
            InitializeComponent();
        }

        OleDbConnection bağlantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =.accdb");
        void dbgör()
        {
            bağlantı.Open();
            OleDbCommand kom = new OleDbCommand();
            kom.Connection = bağlantı;
            kom.CommandText = ("select * from hastane_talep");
            OleDbDataReader okuyucu = kom.ExecuteReader();
            while (okuyucu.Read())
            {
                ListViewItem cık = new ListViewItem();
                cık.Text = okuyucu["Talep"].ToString();
                cık.SubItems.Add(okuyucu["Miktar"].ToString());
                cık.SubItems.Add(okuyucu["Onay durumu"].ToString());
                cık.SubItems.Add(okuyucu["Ana tabloya işlenme"].ToString());
                listViewonaylı.Items.Add(cık);
            }
            bağlantı.Close();
        }
                  //kullanıcının hangi satırı işaretlediğini anlamak için yazılan komutlar
        private string TalepVal = "";         //satırlardan alınacak bilgilerin atanacağı string değişkenleri
        private string MiktarVal = "";
        private string odVal = "";
        private void lv_SelectedIndexChanged(object sender, EventArgs e)   //listviewdeki değişikliklerin kullanıldığı event
        {
            try
            {
                if (listViewonaylı.SelectedItems.Count > 0)     //tablodan seçilen eleman varsa
                {
                    TalepVal = listViewonaylı.SelectedItems[0].SubItems[0].Text;      //seçilen ilk satırın ilk elemanını okur ve değişkene atar
                    MiktarVal = listViewonaylı.SelectedItems[0].SubItems[1].Text;     //seçilen ilk satırın ikinci elemanını okur ve değişkene atar
                    odVal = listViewonaylı.SelectedItems[0].SubItems[2].Text;       //seçilen ilk satırın üçüncü elemanını okur ve değişkene atar
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message);
            }
        }

        void Dbişle()               //onaylar listviewde görünür ve stok düşürüldükçe işlenme kısmına "+" konur
        {
            bağlantı.Open();
            OleDbCommand olekom = new OleDbCommand();
            olekom.Connection = bağlantı;
            olekom.CommandText = "update hastane_talep set [Ana tabloya işlenme] = '" + "+" + "' where [Onay durumu] = '" + odVal + "' and Talep = '" + TalepVal + "' and Miktar = '"+MiktarVal+"' ";
            olekom.ExecuteNonQuery();
            bağlantı.Close();
        }
        private void OnaylananCıkıs_Load(object sender, EventArgs e)
        {
            dbgör();
        }

        private void İşaretKayıtbuton_Click(object sender, EventArgs e)
        {
            try
            {
                Dbişle();
                listViewonaylı.Items.Clear();
                dbgör();
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
                bağlantı.Close();
            }
        }

        
    }
}
