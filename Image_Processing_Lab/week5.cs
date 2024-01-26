using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;

namespace Image_Processing_Lab
{
    public partial class week5 : Form
    {
        Image<Bgr, byte> imageInput;
        Image<Gray, byte> imageGray;
        Image<Gray, byte> imageBinarise;

        public week5()
        {
            InitializeComponent();
        }

        private void adaptiveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageInput = new Image<Bgr, byte>(ofd.FileName);
                pictBoxOrigin.Image = imageInput.ToBitmap();
            }
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictBoxOrigin.Image = imageGray.Convert<Bgr, byte>().ToBitmap();

            imageBinarise = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));
            CvInvoke.Threshold(imageGray, imageBinarise, 100, 255, ThresholdType.Binary);
            pictBoxOutput.Image = imageBinarise.ToBitmap();
        }

        private void binaryInvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictBoxOrigin.Image = imageGray.ToBitmap();

            imageBinarise = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));
            CvInvoke.Threshold(imageGray, imageBinarise, 100, 255, ThresholdType.BinaryInv);
            pictBoxOutput.Image = imageBinarise.ToBitmap();
        }

        private void oTSUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictBoxOrigin.Image = imageGray.ToBitmap();

            imageBinarise = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));
            CvInvoke.Threshold(imageGray, imageBinarise, 100, 255, ThresholdType.Otsu);
            pictBoxOutput.Image = imageBinarise.ToBitmap();
        }

        private void guassianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictBoxOrigin.Image = imageGray.ToBitmap();

            imageBinarise = imageGray.ThresholdAdaptive(new Gray(256.0), AdaptiveThresholdType.GaussianC,
                ThresholdType.Binary, 3, new Gray(0.0));
            pictBoxOutput.Image = imageBinarise.ToBitmap();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictBoxOrigin.Image = imageGray.ToBitmap();

            imageBinarise = imageGray.ThresholdAdaptive(new Gray(256.0), AdaptiveThresholdType.MeanC,
                ThresholdType.Binary, 3, new Gray(0.0));
            pictBoxOutput.Image = imageBinarise.ToBitmap();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}