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
using Emgu.Util;
using Emgu.CV.CvEnum;

namespace Image_Processing_Lab
{
    public partial class week6 : Form
    {
        public week6()
        {
            InitializeComponent();
        }

        private void week_6_Load(object sender, EventArgs e)
        {
            txtBoxGrayValue.Text = "255";
            txtBoxBlockSize.Text = "9";
        }

        Image<Bgr, byte> oriImage;
        Image<Gray, byte> grayImage, binaryImage;
        int grayMaxValue, blockSize, param1, comboBoxIndex;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                oriImage = new Image<Bgr, byte>(ofd.FileName);
                imgInput.Image = oriImage;
                grayImage = oriImage.Convert<Gray, byte>();
                imgGray.Image = grayImage;
                imgBinary.Image = null;
                comboBox1.Text = "";
                comboBox1.SelectedText = "Choose Gray Format";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thresholding(int index, int grayMaxValue = 255, int blockSize = 9, int param1 = 0)
        {
            switch (index)
            {
                case 0:
                    binaryImage = grayImage.ThresholdBinary(new Gray(100), new Gray(grayMaxValue));
                    imgBinary.Image = binaryImage;
                    break;
                case 1:
                    binaryImage = grayImage.ThresholdBinaryInv(new Gray(100), new Gray(grayMaxValue));
                    imgBinary.Image = binaryImage;
                    break;
                case 2:
                    binaryImage = grayImage.ThresholdToZero(new Gray(100));
                    imgBinary.Image = binaryImage;
                    break;
                case 3:
                    binaryImage = grayImage.ThresholdAdaptive(new Gray(256), AdaptiveThresholdType.GaussianC,
                    ThresholdType.Binary, blockSize, new Gray(param1));
                    imgBinary.Image = binaryImage;
                    break;
                case 4:
                    binaryImage = grayImage.ThresholdAdaptive(new Gray(256), AdaptiveThresholdType.MeanC,
                    ThresholdType.Binary, blockSize, new Gray(param1));
                    imgBinary.Image = binaryImage;
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (comboBox1.SelectedIndex == 0)
            {
                binaryImage = grayImage.ThresholdBinary(new Gray(100), new Gray(255));
                imgBinary.Image = binaryImage;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                binaryImage = grayImage.ThresholdBinaryInv(new Gray(100), new Gray(255));
                imgBinary.Image = binaryImage;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                binaryImage = grayImage.ThresholdToZero(new Gray(100));
                imgBinary.Image = binaryImage;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                binaryImage = grayImage.ThresholdAdaptive(new Gray(256), AdaptiveThresholdType.GaussianC,
                    ThresholdType.Binary, 9, new Gray(0));
                imgBinary.Image = binaryImage;
            }
            else
            {
                binaryImage = grayImage.ThresholdAdaptive(new Gray(256), AdaptiveThresholdType.MeanC,
                    ThresholdType.Binary, 9, new Gray(0));
                imgBinary.Image = binaryImage;
            }
            */
            comboBoxIndex = comboBox1.SelectedIndex;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image<Gray, Byte> filteredImage = (Image<Gray, Byte>)imgBinary.Image;
            SaveFileDialog saveFilteredImg = new SaveFileDialog();
            saveFilteredImg.Title = "Image Equalization and Filtering";
            saveFilteredImg.Filter = "Jpeg Files(*.jpg)|*.jpg|Bitmap Files(*.bmp)|*.bmp";

            if (saveFilteredImg.ShowDialog() == DialogResult.OK)
            {
                filteredImage.Save(saveFilteredImg.FileName);
            }
        }

        private void txtBoxGrayValue_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            grayMaxValue = int.Parse(txtBoxGrayValue.Text);
            blockSize = int.Parse(txtBoxBlockSize.Text);
            param1 = (int) numericUpDownParam.Value;

            thresholding(comboBoxIndex, grayMaxValue, blockSize, param1);
        }
    }
}
