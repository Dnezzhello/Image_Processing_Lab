using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace Image_Processing_Lab
{
    public partial class week4 : Form
    {


        private Image<Bgr, byte> originalImage;
        private Image<Gray, byte> R;
        private Image<Gray, byte> G;
        private Image<Gray, byte> B;

        public week4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void histogramBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Image<Bgr, byte>(ofd.FileName);
                B = originalImage[0];
                G = originalImage[1];
                R = originalImage[2];


                imageBoxR.Image = R;
                imageBoxG.Image = G;
                imageBoxB.Image = B;
            }
        }

        private void btnShowHist_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please Insert an Image");
                return;
            }

            DenseHistogram[] histograms = new DenseHistogram[3];

            histBoxB.ClearHistogram();
            histBoxR.ClearHistogram();
            histBoxG.ClearHistogram();

            histBoxB.GenerateHistograms(B, 255);
            histBoxG.GenerateHistograms(G, 255);
            histBoxR.GenerateHistograms(R, 255);

            histBoxR.Refresh();
            histBoxG.Refresh();
            histBoxB.Refresh();
                

        }
    }
}