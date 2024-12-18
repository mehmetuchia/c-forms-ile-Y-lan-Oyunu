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
    public partial class NASILOYNANIR : Form
    {
        public NASILOYNANIR()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NASILOYNANIR_Load(object sender, EventArgs e)
        {
            // RichTextBox metnini ayarlıyoruz
            richTextBox1.Text =
                "Yılan Oyunu Kuralları:\n\n" +
                "1. Zorluk Seviyesi Seçimi:\n" +
                "- Oyuncu oyuna başlamadan önce zorluk seviyesini seçer. (Kolay, Orta, Zor)\n" +
                "- Zorluk seviyesi yılanın hareket hızını belirler.\n\n" +
                "2. Oyun Başlatma:\n" +
                "- 'Başla' butonuna basıldığında yılan hareket eder.\n" +
                "- Yön tuşlarıyla yılanı kontrol edebilirsiniz.\n\n" +
                "3. Skor ve Yem Mekaniği:\n" +
                "- Yılan kırmızı yemlere ulaşırsa:\n" +
                "  * Skor artar.\n" +
                "  * Yılanın boyu uzar.\n\n" +
                "4. Oyun Sonlanma Koşulları:\n" +
                "- Yılan, ekranın kenarlarına (duvarlara) çarparsa oyun biter.\n" +
                "- Yılan, kendi gövdesine temas ederse oyun sona erer.";

            // Ek estetik ayarlar (isteğe bağlı)
            richTextBox1.Font = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.ForeColor = Color.DarkBlue;
            richTextBox1.BackColor = Color.LightGray;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anamenı ANA = new anamenı();
            ANA.Show();
            this.Hide();
        }
    }
}
