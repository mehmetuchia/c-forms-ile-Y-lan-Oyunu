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
    public partial class anamenı : Form
    {
        public anamenı()
        {
            InitializeComponent();
        }

        private void oynBasla_Click(object sender, EventArgs e)
        {
            // Oyun formunu aç
            Form1 oyun = new Form1(); // Oyun formunun adı bu örnekte "OyunFormu"
            oyun.Show();
            this.Hide(); // Ana menüyü gizle
        }

        private void ayarlar_Click(object sender, EventArgs e)
        {
            ayarlar ayar = new ayarlar();
            ayar.Show();
            this.Hide();
        }

        private void nasılOYN_Click(object sender, EventArgs e)
        {
            NASILOYNANIR nasıl = new NASILOYNANIR();
            nasıl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
 