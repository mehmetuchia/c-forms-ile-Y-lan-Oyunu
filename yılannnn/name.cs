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
    public partial class name : Form
    {


        public name()
        {
            InitializeComponent();
            string oyuncuadı = textBox1.Text;
            // Müzik dosyasını başlat
            MusicManager.Instance.StartMusic();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void isimatama_Click(object sender, EventArgs e)
        {

            string oyuncuadı = textBox1.Text;
            if (!string.IsNullOrEmpty(oyuncuadı))
            {
                GlobalData.oyuncuadı = oyuncuadı;

                // Ana Menü formuna geç
                zorluk zorluk = new zorluk();
                zorluk.Show();
                this.Hide();
                
            }



        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void name_Load(object sender, EventArgs e)
        {
            
        }


    }
}
