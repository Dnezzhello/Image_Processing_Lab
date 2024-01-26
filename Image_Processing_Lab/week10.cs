using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Diagnostics;
using System.IO.Pipes;
using System.Text.RegularExpressions;

namespace Image_Processing_Lab
{
    public partial class week10 : Form
    {

        public week10()
        {
            InitializeComponent();
        }

        Image<Gray, Byte> grayVdo, binaryVdo;
        VideoCapture capture;
        bool turnOn;

        private void Form1_Load(object sender, EventArgs e)
        {
            turnOn = false;
            capture = new VideoCapture();
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            if (imgBoxCapture != null)
            {
                var img = capture.QueryFrame();
                var bmp = img.ToBitmap();
                imgBoxVDO.Image?.Dispose();
                imgBoxVDO.Image = bmp;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            turnOn = true;
            imgBoxCapture.Image = null;
            Application.Idle += Application_Idle;
        }


        private void Application_Idle1(object sender, EventArgs e)
        {
            grayVdo = capture.QueryFrame().ToImage<Gray, byte>();
            var bmp = grayVdo.ToBitmap();
            imgBoxVDO.Image?.Dispose();
            imgBoxVDO.Image = bmp;
        }

        private void btnGray_Click_1(object sender, EventArgs e)
        {
            if (turnOn == true)
            {
                Application.Idle += Application_Idle1;
            }
            else
            {
                MessageBox.Show("Please Start the WebCam");
            }

        }

        private void Application_Idle2(object sender, EventArgs e)
        {
            grayVdo = capture.QueryFrame().ToImage<Gray, byte>();
            binaryVdo = grayVdo.ThresholdBinary(new Gray(150), new Gray(255));
            imgBoxVDO.Image?.Dispose();
            imgBoxVDO.Image = binaryVdo.ToBitmap();
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            if (turnOn == true)
            {
                Application.Idle += Application_Idle2;
            }
            else
            {
                MessageBox.Show("Please Start the WebCam");
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            imgBoxCapture.Image?.Dispose();
            imgBoxCapture.Image = imgBoxVDO.Image;
        }



        private void btnStop_Click(object sender, EventArgs e)
        {
            turnOn = false;
            Application.Idle -= Application_Idle;
            Application.Idle -= Application_Idle1;
            Application.Idle -= Application_Idle2;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Title = "Save Capture Image";
            svf.DefaultExt = "*.Jpg";
            svf.Filter = "Jpeg Files (*.jpg)|*.jpg";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                imgBoxCapture.Image.Save(svf.FileName);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            capture?.Dispose();
            grayVdo?.Dispose();
            binaryVdo?.Dispose();
        }

    }
}