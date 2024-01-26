using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace Image_Processing_Lab
{
    public partial class week9 : Form
    {
        public week9()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> inputImage;
        Image<Bgr, byte> coloredImage;
        Image<Gray, byte> binaryImage, morphoImage;

        private void fiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputImage = new Image<Bgr, byte>(ofd.FileName);
                pictBox1.Image = inputImage.ToBitmap();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.Title = "Save Gray Image";
            saveImage.DefaultExt = "*.jpg";
            saveImage.Filter = "Jpeg Files (*.jpg)|*.jpg|PNG files(*.png)| *.png | BMP files(*.bmp) | *.bmp";
            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                pictBox2.Image.Save(saveImage.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                coloredImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                coloredImage = inputImage.Dilate(3);
                pictBox2.Image = coloredImage.ToBitmap();
            }
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                coloredImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                coloredImage = inputImage.Erode(3);
                pictBox2.Image = coloredImage.ToBitmap();
            }
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                coloredImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                coloredImage = inputImage.MorphologyEx(MorphOp.Open, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                pictBox2.Image = coloredImage.ToBitmap();
            }
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                coloredImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                coloredImage = inputImage.MorphologyEx(MorphOp.Close, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                pictBox2.Image = coloredImage.ToBitmap();
            }
        }

        private void gradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                coloredImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                coloredImage = inputImage.MorphologyEx(MorphOp.Gradient, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                pictBox2.Image = coloredImage.ToBitmap();
            }
        }

        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                coloredImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                coloredImage = inputImage.MorphologyEx(MorphOp.Tophat, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                pictBox2.Image = coloredImage.ToBitmap();
            }
        }

        private void blackHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                coloredImage = new Image<Bgr, byte>(inputImage.Width, inputImage.Height);
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                coloredImage = inputImage.MorphologyEx(MorphOp.Blackhat, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                pictBox2.Image = coloredImage.ToBitmap();
            }
        }

        private void dilationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                binaryImage = new Image<Gray, byte>(inputImage.Width, inputImage.Height);
                binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255)).Dilate(1);
                pictBox2.Image = binaryImage.ToBitmap();
            }
        }

        private void erosionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                binaryImage = new Image<Gray, byte>(inputImage.Width, inputImage.Height);
                binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255)).Erode(1);
                pictBox2.Image = binaryImage.ToBitmap();
            }
        }

        private void openingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                morphoImage = binaryImage.MorphologyEx(MorphOp.Open, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                pictBox2.Image = morphoImage.ToBitmap();
            }
        }

        private void closingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (inputImage != null)
            {
                binaryImage = inputImage.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
                Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));
                morphoImage = binaryImage.MorphologyEx(MorphOp.Close, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                pictBox2.Image = morphoImage.ToBitmap();
            }
        }

        private void week9_Load(object sender, EventArgs e)
        {

        }
    }
}