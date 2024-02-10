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
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.Util;

namespace Image_Processing_Lab
{
    public partial class week7 : Form
    {
        public week7()
        {
            InitializeComponent();
        }

        Image<Bgr, Byte> originalImage;
        Image<Gray, Byte> imgBeforeE, imgAfterE, imgFilter;
        bool isGray;
        int ksize;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Image<Bgr, byte>(ofd.FileName);
                imgBoxInput.Image = originalImage;

                imgBeforeE = originalImage.Convert<Gray, Byte>();
                imgBoxGray.Image = imgBeforeE;

                htgGray.GenerateHistograms(imgBeforeE, 255);
                htgGray.Refresh();
            }
        }

        private void btnEqualisation_Click(object sender, EventArgs e)
        {
            imgAfterE = new Image<Gray, Byte>(imgBeforeE.Width, imgBeforeE.Height);
            CvInvoke.EqualizeHist(imgBeforeE, imgAfterE);
            imgBoxOutput.Image = imgAfterE;

            htgOutput.ClearHistogram();
            htgOutput.GenerateHistograms(imgAfterE, 255);
            htgOutput.Refresh();
        }

        private void performEqualisation()
        {
            imgAfterE = new Image<Gray, Byte>(imgBeforeE.Width, imgBeforeE.Height);
            CvInvoke.EqualizeHist(imgBeforeE, imgAfterE);
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {

            ksize = int.Parse(txtBoxKSize.Text);

            if (isGray)
            {
                performEqualisation();
                imgFilter = new Image<Gray, Byte>(imgAfterE.Width, imgAfterE.Height);
                CvInvoke.MedianBlur(imgAfterE, imgFilter, ksize);
                imgBoxOutput.Image = imgFilter;
                imgBoxOutput.Refresh();
                htgOutput.ClearHistogram();
                htgOutput.GenerateHistograms(imgFilter, 255);
                htgOutput.Refresh();
            }
            else
            {
                Image<Bgr, Byte> imgFilter = new Image<Bgr, Byte>(originalImage.Width, originalImage.Height);
                CvInvoke.MedianBlur(originalImage, imgFilter, ksize);
                imgBoxOutput.Image = imgFilter;
                imgBoxOutput.Refresh();
                htgOutput.ClearHistogram();
                htgOutput.GenerateHistograms(imgFilter, 255);
                htgOutput.Refresh();
            }
        }

        private void btnGuassian_Click(object sender, EventArgs e)
        {

            ksize = int.Parse(txtBoxKSize.Text);

            if (isGray)
            {
                performEqualisation();
                imgFilter = new Image<Gray, Byte>(imgAfterE.Width, imgAfterE.Height);
                CvInvoke.GaussianBlur(imgAfterE, imgFilter, new Size(ksize, ksize), 0, 0, BorderType.Default);
                imgBoxOutput.Image = imgFilter;
                imgBoxOutput.Refresh();
                htgOutput.ClearHistogram();
                htgOutput.GenerateHistograms(imgFilter, 255);
                htgOutput.Refresh();
            }
            else
            {
                Image<Bgr, Byte> imgFilter = new Image<Bgr, Byte>(originalImage.Width, originalImage.Height);
                CvInvoke.GaussianBlur(originalImage, imgFilter, new Size(ksize, ksize), 0, 0, BorderType.Default);
                imgBoxOutput.Image = imgFilter;
                imgBoxOutput.Refresh();
                htgOutput.ClearHistogram();
                htgOutput.GenerateHistograms(imgFilter, 255);
                htgOutput.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image<Gray, Byte> filteredImage1;
            Image<Bgr, Byte> filteredImage2;

            SaveFileDialog saveFilteredImg = new SaveFileDialog();
            saveFilteredImg.Title = "Image Equalization and Filtering";
            saveFilteredImg.Filter = "Jpeg Files(*.jpg)|*.jpg|Bitmap Files(*.bmp)|*.bmp";

            if (isGray)
            {
                filteredImage1 = (Image<Gray, Byte>)imgBoxOutput.Image;
                if (saveFilteredImg.ShowDialog() == DialogResult.OK)
                {
                    filteredImage1.Save(saveFilteredImg.FileName);
                }


            }
            else
            {
                filteredImage2 = (Image<Bgr, Byte>)imgBoxOutput.Image;
                if (saveFilteredImg.ShowDialog() == DialogResult.OK)
                {
                    filteredImage2.Save(saveFilteredImg.FileName);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void week_7_Load(object sender, EventArgs e)
        {
            txtBoxKSize.Text = "3";
            rdBtnGray.Checked = true;
        }

        private void txtBoxKSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdBtnGray_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnGray.Checked)
            {
                isGray = true;
            }
        }

        private void rdBtnColor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnColor.Checked)
            {
                isGray = false;
            }
        }
    }
}
