using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;

namespace Image_Processing_Lab
{
    public partial class week8 : Form
    {
        public week8()
        {
            InitializeComponent();
        }
        Image<Bgr, byte> inputImage;
        Image<Gray, byte> cannyOutput;
        Image<Gray, float> sobelOutput, laplacianOutput;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputImage = new Image<Bgr, byte>(ofd.FileName);
                imgBoxInput.Image = inputImage;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                cannyOutput = inputImage.Convert<Gray, byte>().Canny(150, 10);
                pictBox.Image = cannyOutput.ToBitmap();
            }
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                /*
                 * Image<Gray, byte> ImgGray = inputImage.Convert<Gray, byte>();
                Image<Gray, float> sobelImg = new Image<Gray, float>(ImgGray.Width, ImgGray.Height, new Gray(0));
                sobelImg = ImgGray.Sobel(1, 1, 7);
                */

                sobelOutput = inputImage.Convert<Gray, float>().Sobel(1, 1, 5);
                pictBox.Image = sobelOutput.ToBitmap();
            }
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                /*
                Image<Gray, byte> ImgGray = inputImage.Convert<Gray, byte>();
                Image<Gray, float> LaplacianImg = new Image<Gray, float>(ImgGray.Width, ImgGray.Height, new Gray(0));
                LaplacianImg = ImgGray.Laplace(5);
                */
                laplacianOutput = inputImage.Convert<Gray, float>().Laplace(5);
                pictBox.Image = laplacianOutput.ToBitmap();
            }
        }
    }
}