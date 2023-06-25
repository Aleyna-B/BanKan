using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yonetici yonetici = new Yonetici();
            yonetici.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hastane hastane = new Hastane();
            hastane.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gonullu gonullu = new Gonullu();
            gonullu.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
