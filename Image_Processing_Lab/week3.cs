using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Image_Processing_Lab
{
    public partial class week3 : Form
    {
        public week3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        Image<Bgr, Byte> My_Image;
        Image<Gray, Byte> Gray_Image;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                My_Image = new Image<Bgr, Byte>(ofd.FileName);
                pictBoxOriginal.Image = My_Image.ToBitmap();
            }
        }

        private void pictBoxOriginal_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictBoxOriginal.Image != null)
            {
                lblX.Text = "x = " + e.X.ToString();
                lblY.Text = "y = " + e.Y.ToString();
                lblValue.Text = "value = " + My_Image[e.X, e.Y].ToString();
            }
        }

        private void btnConvertToGray_Click(object sender, EventArgs e)
        {
            if (My_Image != null)
            {
                Gray_Image = My_Image.Convert<Gray, Byte>();
                pictBoxGray.Image = Gray_Image.ToBitmap();
            }
        }

        private void brnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.Title = "Converted Gray Image";
            saveImage.DefaultExt = "*.jpeg";
            saveImage.Filter = "Jpeg Files (*.jpg)|*.jpg|PNG files(*.png)|*.png|BMP files(*.bmp)|*.bmp";

            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                Gray_Image.Save(saveImage.FileName);
                MessageBox.Show("Saving Completed");
            }
        }
    }
}