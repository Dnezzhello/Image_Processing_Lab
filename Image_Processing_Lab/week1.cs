using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing_Lab
{
    public partial class week1 : Form
    {
        public week1()
        {
            InitializeComponent();
        }

        Bitmap oriImage;
        public Bitmap ConvertToGray(Bitmap src)
        {
            Bitmap bmp = new Bitmap(src.Width, src.Height);
            int avg;
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = src.GetPixel(x, y);
                    avg = ((c.R + c.G + c.B) / 3);
                    bmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }

            return bmp;

        }

        private void week1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitmap srcBitmap = new Bitmap(pictureBox1.Image);
            for (int i = 1; i < (int) srcBitmap.Height/2; i++)
            {
                srcBitmap.SetPixel(i, 10 + i, Color.Red);
            }
            pictureBox1.Image = srcBitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap src = new Bitmap(pictureBox1.Image);
            pictureBox2.Image = ConvertToGray(src);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (oriImage != null)
            {
                Bitmap bmp = (Bitmap) pictureBox1.Image;
                Color clr = bmp.GetPixel(e.X, e.Y);
                label3.Text = "R: " + clr.R.ToString();
                label4.Text = "G: " + clr.G.ToString();
                label5.Text = "B: " + clr.B.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                oriImage = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = oriImage;
            }
        }
    }
}
