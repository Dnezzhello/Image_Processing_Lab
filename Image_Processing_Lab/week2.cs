//using lab_w2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Image_Processing_Lab

{
    public partial class week2 : Form
    {
        public week2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = pict_O;
            pictureBox1.Refresh();
        }

        Bitmap pict_C;
        Bitmap pict_O;
        bool is_blackWhite;

        //Gray Scale 1
        public Bitmap ConvertToGrayScale_1(Bitmap src)
        {
            Bitmap bmp = new Bitmap(src.Width, src.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color c = src.GetPixel(i, j);
                    int avg = (int)(c.R + c.G + c.B) / 3;
                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }

        //Gray Scale 2
        public Bitmap ConvertToGrayScale_2(Bitmap src)
        {
            Bitmap bmp = new Bitmap(src.Width, src.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color c = src.GetPixel(i, j);
                    //Luminance
                    int nP = (int)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
                    bmp.SetPixel(i, j, Color.FromArgb(nP, nP, nP));
                }
            }
            return bmp;
        }

        // Black and White
        public Bitmap Thresholding(Bitmap src)
        {
            Bitmap bmp = new Bitmap(src.Width, src.Height);
            int t = int.Parse(txtBoxThreshold.Text.Trim());

            if (t < 0 || t > 255)
            {
                MessageBox.Show("Threshold value should be between 0 and 255");
                return src;
            }

            for (int i = 0; i < src.Width; i++)
            {
                for (int j = 0; j < src.Height; j++)
                {
                    Color c = src.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);

                    if (avg > t)
                    {
                        avg = 255;
                    }
                    else
                    {
                        avg = 0;
                    }

                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }

            is_blackWhite = true;

            return bmp;
        }

        // Invert
        public Bitmap Invert(Bitmap src)
        {
            Bitmap pict = new Bitmap(src.Width, src.Height);

            if (!is_blackWhite)
            {
                pict = Thresholding(src);
                is_blackWhite = true;
            }
            else
            {
                pict = src;
            }

            for (int i = 0; i < src.Width; i++)
            {
                for (int j = 0; j < src.Height; j++)
                {
                    Color c = pict.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);

                    if (avg == 255)
                    {
                        pict.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        pict.SetPixel(i, j, Color.White);
                    }
                }
            }
            return pict;

        }

        // Negative
        public Bitmap Negative(Bitmap src)
        {
            Bitmap bmp = new Bitmap(src.Width, src.Height);

            for (int i = 0; i < src.Width; i++)
            {
                for (int j = 0; j < src.Height; j++)
                {
                    Color c = src.GetPixel(i, j);
                    bmp.SetPixel(i, j, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
            return bmp;
        }

        // Log Transformation
        public Bitmap LogTransformation(Bitmap src)
        {
            Bitmap bmp = new Bitmap(src.Width, src.Height);
            double c = double.Parse(txtBoxCoef1.Text.Trim());


            for (int i = 0; i < src.Width; i++)
            {
                for (int j = 0; j < src.Height; j++)
                {
                    Color color = src.GetPixel(i, j);
                    int R, G, B;

                    R = (int)(c * Math.Log(1 + color.R));
                    G = (int)(c * Math.Log(1 + color.G));
                    B = (int)(c * Math.Log(1 + color.B));

                    R = Math.Max(0, Math.Min(255, R));
                    G = Math.Max(0, Math.Min(255, R));
                    B = Math.Max(0, Math.Min(255, R));

                    bmp.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            return bmp;
        }

        // Power Law Transformation
        public Bitmap PowerLawTransformation(Bitmap src)
        {
            Bitmap bmp = new Bitmap(src.Width, src.Height);
            double c = double.Parse(txtBoxCoef2.Text.Trim());
            double gamma = double.Parse(txtBoxGamma.Text.Trim());

            for (int i = 0; i < src.Width; i++)
            {
                for (int j = 0; j < src.Height; j++)
                {
                    Color color = src.GetPixel(i, j);
                    int R, G, B;

                    R = (int)(c * Math.Pow(color.R / 255.0, gamma));
                    G = (int)(c * Math.Pow(color.G / 255.0, gamma));
                    B = (int)(c * Math.Pow(color.B / 255.0, gamma));

                    R = Math.Max(0, Math.Min(255, R));
                    G = Math.Max(0, Math.Min(255, R));
                    B = Math.Max(0, Math.Min(255, R));

                    bmp.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            return bmp;
        }

        private void btnGrayScale1_Click(object sender, EventArgs e)
        {
            Bitmap pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = ConvertToGrayScale_1(pict_C);
        }

        private void btnOpenPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pict_C = new Bitmap(openFileDialog.FileName);
                pict_O = pict_C;
                pictureBox1.Image = pict_C;
            }
        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pict_O;
            is_blackWhite = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = ConvertToGrayScale_2(pict_C);
        }

        private void btnBlackWhite_Click(object sender, EventArgs e)
        {
            Bitmap pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Thresholding(pict_C);
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            Bitmap pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Invert(pict_C);
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            Bitmap pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Negative(pict_C);
        }

        private void btnLogTransform_Click(object sender, EventArgs e)
        {
            Bitmap pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = LogTransformation(pict_C);
        }

        private void btnPowerLaw_Click(object sender, EventArgs e)
        {
            Bitmap pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = PowerLawTransformation(pict_C);
        }
    }
}
