using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;

namespace Image_Processing_Lab
{
    public partial class week11 : Form
    {
        public week11()
        {
            InitializeComponent();
        }

        private void week11_Load(object sender, EventArgs e)
        {

        }

        Image<Bgr, byte> inputImage;
        Image<Gray, byte> grayImage, binaryImage;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputImage = new Image<Bgr, byte>(ofd.FileName);
                imgInput.Image = inputImage;
            }
        }

        private void findContourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grayImage = inputImage.Convert<Gray, byte>();
            binaryImage = grayImage.ThresholdBinaryInv(new Gray(150), new Gray(255));

            VectorOfVectorOfPoint contour = new VectorOfVectorOfPoint();
            Mat heir = new Mat();
            CvInvoke.FindContours(binaryImage, contour, heir, RetrType.External, ChainApproxMethod.ChainApproxSimple);
            
            Image<Gray, byte> outputImage = new Image<Gray, byte>(inputImage.Width, inputImage.Height, new Gray(0));
            CvInvoke.DrawContours(outputImage, contour, -1, new MCvScalar(255, 0, 255), 2);
            imgOutput.Image = outputImage;
        }
    }
}
