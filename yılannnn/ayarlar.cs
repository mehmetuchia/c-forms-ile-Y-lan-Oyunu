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
    public partial class ayarlar : Form
    {

        public ayarlar()
        {
            InitializeComponent(); ;
            LoadSettings();
        }
        private void LoadSettings()
        {
            // Müzik durumu kontrolü
            chkMusic.Checked = MusicManager.Instance.IsPlaying();

            // Ses seviyesi
            trackVolume.Value = 50; // Varsayılan bir değer (50)
            lblVolume.Text = $"Ses Seviyesi: {trackVolume.Value}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anamenı ANA = new anamenı();
            ANA.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            lblVolume.Text = $"Ses Seviyesi: {trackVolume.Value}";

            // Burada ses seviyesini ayarlayabilirsiniz
            // Eğer ses kontrolü yapıyorsanız, bunu uygun bir API ile yapmalısınız.
            // Örneğin, Windows Media Player API veya başka bir ses oynatıcı kullanabilirsiniz.
        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMusic.Checked)
            {
                MusicManager.Instance.StartMusic();
            }
            else
            {
                MusicManager.Instance.StopMusic();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kaydetme işlemi burada yapılabilir.
            MessageBox.Show("Ayarlar kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
