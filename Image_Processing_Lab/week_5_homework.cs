using Emgu.CV.Structure;
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
using System.Drawing.Imaging;

namespace Image_Processing_Lab
{
    public partial class week_5_homework : Form
    {
        public week_5_homework()
        {
            InitializeComponent();
        }

        Image<Bgr, Byte> oriImage;
        Image<Gray, Byte> R, G, B;

        private void radioBtnCheckStatus(bool value)
        {
            radioB.Checked = value;
            radioR.Checked = value;
            radioG.Checked = value;
        }

        private void outputAndHistogram(Image<Gray, Byte> image)
        {
            imgOutput.Image = image;
            histogram.ClearHistogram();
            histogram.GenerateHistograms(image, 255);
            histogram.Refresh();
        }

        private void week_5_homework_Load(object sender, EventArgs e)
        {
            radioR.Enabled = false;
            radioG.Enabled = false;
            radioB.Enabled = false;
            comboBox.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (imgInput.Image != null)
            {
                imgInput.Image = null;
                imgOutput.Image = null;
                histogram.ClearHistogram();
                histogram.Refresh();

                radioBtnCheckStatus(false);

                comboBox.SelectedIndex = -1;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                oriImage = new Image<Bgr, Byte>(ofd.FileName);
                B = oriImage[0];
                G = oriImage[1];
                R = oriImage[2];
                imgInput.Image = oriImage;

                radioR.Enabled = true;
                radioG.Enabled = true;
                radioB.Enabled = true;
                comboBox.Enabled = true;
            }

        }

        private void radioR_CheckedChanged(object sender, EventArgs e)
        {
            if (radioR.Checked)
            {
                outputAndHistogram(R);
                MessageBox.Show("A gray image from red channel");
            }
        }

        private void radioG_CheckedChanged(object sender, EventArgs e)
        {
            if (radioG.Checked)
            {
                outputAndHistogram(G);
                MessageBox.Show("A gray image from green channel");
            }
        }

        private void radioB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioB.Checked)
            {
                outputAndHistogram(B);
                MessageBox.Show("A gray image from blue channel");
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                radioBtnCheckStatus(false);
                outputAndHistogram(R);
                MessageBox.Show("A gray image from red channel");
            } else if (comboBox.SelectedIndex == 1)
            {
                radioBtnCheckStatus(false);
                outputAndHistogram(G);
                MessageBox.Show("A gray image from green channel");
            } else if (comboBox.SelectedIndex == 2)
            {
                radioBtnCheckStatus(false);
                outputAndHistogram(B);
                MessageBox.Show("A gray image from blue channel");
            } else { }
        }
    }
}
