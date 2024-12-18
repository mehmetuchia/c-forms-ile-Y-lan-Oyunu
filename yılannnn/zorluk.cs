using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yılannnn
{
    public partial class zorluk : Form
    {
        private Form1 mainForm; // Form1'e referans
        public zorluk()
        {
            InitializeComponent();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void kolay_Click(object sender, EventArgs e)
        {
            Form1.sutunAdet = 40;
            Form1.satirAdet = 40;
            Form1.hız = 300;

            anamenı aaa = new anamenı();
            aaa.Show();
            this.Hide();
        }

        private void orta_Click(object sender, EventArgs e)
        {
            Form1.sutunAdet = 30;
            Form1.satirAdet = 30;
            Form1.hız = 200;

            anamenı aç = new anamenı();
            aç.Show();
            this.Hide();
        }

        private void zor_Click(object sender, EventArgs e)
        {
            Form1.sutunAdet = 20;
            Form1.satirAdet = 20;
            Form1.hız = 100;
            anamenı a = new anamenı();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
