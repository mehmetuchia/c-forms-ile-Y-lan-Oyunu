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
    public partial class oyunsonu : Form
    {
        public oyunsonu()
        {
            InitializeComponent();
        }

        private void yenıoyun_Click(object sender, EventArgs e)
        {
            Form1 oyun = new Form1();
            oyun.Show();
            this.Hide();


        }

        private void don_Click(object sender, EventArgs e)
        {
            anamenı ana = new anamenı();
            ana.Show();
            this.Hide();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
