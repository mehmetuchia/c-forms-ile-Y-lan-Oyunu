

using System.Drawing.Printing;
using System.Media;

namespace yılannnn
{
    public partial class Form1 : Form
    {
        List<Point> yilan;
        int hucreGen, hucreYuk, yonX, yonY, skor;
        Random rnd = new Random();
        Point yem;
        bool yonDegisti = false;



        
        public Form1()
        {
            InitializeComponent();
            OyunuHazirla();






        }

        public void OyunuHazirla()
        {
            skor = 0;
            lblSkor.Text = skor.ToString("000");


            hucreGen = pnlOyun.Width / sutunAdet;
            hucreYuk = pnlOyun.Height / satirAdet;

            int basX = sutunAdet / 2;
            int basY = satirAdet / 2;

            yilan = new List<Point>()
                {
                new Point(basX,basY),
                new Point(basX-1,basY),
                new Point(basX-2,basY)
            };
            yonX = +1;
            yonY = 0;

            yemUret();
        }



        private void yemUret()
        {
            do
            {
                yem = new Point(rnd.Next(sutunAdet), rnd.Next(satirAdet));
            }
            while (yilan.Any(bogum => bogum.X == yem.X && bogum.Y == yem.Y));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = GlobalData.oyuncuadı;

        }


        private void pnlOyun_Paint(object sender, PaintEventArgs e)
        {

            bool basMi = true;
            foreach (Point bogum in yilan)
            {
                HucreBoya(e.Graphics, bogum, basMi ? Brushes.LawnGreen : Brushes.Green);
                basMi = false;
            }

            HucreBoya(e.Graphics, yem, Brushes.Red);
        }

        private void HucreBoya(Graphics graphics, Point bogum, Brush firca)
        {
            int x = bogum.X * hucreGen;
            int y = bogum.Y * hucreYuk;
            graphics.FillRectangle(firca, x, y, hucreGen, hucreYuk);
            graphics.DrawRectangle(Pens.Black, x, y, hucreGen, hucreYuk);
        }
        public static int hız = 100; // yılanın hızının belirlendiği değişken


        public void timer1_Tick(object sender, EventArgs e)
        {

            tmrOyun.Interval = hız;
            yonDegisti = false;
            Point yeniBas = new Point(yilan[0].X + yonX, yilan[0].Y + yonY);

            // oyunu sonlandırma 
            if (yeniBas.X >= sutunAdet || yeniBas.X < 0 || yeniBas.Y < 0 || yeniBas.Y >= satirAdet || yilan.Any(bogum => bogum == yeniBas))
            {
                tmrOyun.Stop();
                oyunsonu oyunsonu = new oyunsonu();
                oyunsonu.Show();
                this.Hide();



                string oyuncu = label1.Text;
                string skorrr = lblSkor.Text;

                OyunuHazirla();
                pnlOyun.Refresh();
                return;
            }


            yilan.Insert(0, yeniBas);

            if (yeniBas == yem)
            {
                skor++;
                lblSkor.Text = skor.ToString("000");
                yemUret();

            }
            else
            {
                yilan.RemoveAt(yilan.Count - 1);
            }
            pnlOyun.Refresh();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (yonDegisti)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }


            int x = 0, y = 0;
            if (keyData == Keys.Up)
                y = -1;
            else if (keyData == Keys.Down)
                y = 1;
            else if (keyData == Keys.Right)
                x = 1;
            else if (keyData == Keys.Left)
                x = -1;




            if (yonX != -x && yonY != -y)
            {
                yonX = x;
                yonY = y;
                yonDegisti = true;
            }
            return base.ProcessCmdKey(ref msg, keyData);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmrOyun.Start();
        }

        public void label1_Click_1(object sender, EventArgs e)
        {

        }
        public static int sutunAdet = 0;
        public static int satirAdet = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            anamenı AA = new anamenı();
            AA.Show();
            this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
        
        
    }
}
    