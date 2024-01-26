namespace Image_Processing_Lab
{
    partial class week4
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnLoad = new Button();
            imageBoxR = new Emgu.CV.UI.ImageBox();
            imageBoxG = new Emgu.CV.UI.ImageBox();
            imageBoxB = new Emgu.CV.UI.ImageBox();
            histBoxR = new Emgu.CV.UI.HistogramBox();
            histBoxG = new Emgu.CV.UI.HistogramBox();
            histBoxB = new Emgu.CV.UI.HistogramBox();
            btnShowHist = new Button();
            ((System.ComponentModel.ISupportInitialize)imageBoxR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)histBoxR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)histBoxG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)histBoxB).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoad.Location = new Point(10, 29);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(230, 56);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load Image";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // imageBoxR
            // 
            imageBoxR.BorderStyle = BorderStyle.FixedSingle;
            imageBoxR.Location = new Point(11, 101);
            imageBoxR.Name = "imageBoxR";
            imageBoxR.Size = new Size(319, 241);
            imageBoxR.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBoxR.TabIndex = 2;
            imageBoxR.TabStop = false;
            // 
            // imageBoxG
            // 
            imageBoxG.BorderStyle = BorderStyle.FixedSingle;
            imageBoxG.Location = new Point(334, 101);
            imageBoxG.Name = "imageBoxG";
            imageBoxG.Size = new Size(315, 241);
            imageBoxG.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBoxG.TabIndex = 3;
            imageBoxG.TabStop = false;
            // 
            // imageBoxB
            // 
            imageBoxB.BorderStyle = BorderStyle.FixedSingle;
            imageBoxB.Location = new Point(654, 101);
            imageBoxB.Name = "imageBoxB";
            imageBoxB.Size = new Size(328, 241);
            imageBoxB.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBoxB.TabIndex = 4;
            imageBoxB.TabStop = false;
            // 
            // histBoxR
            // 
            histBoxR.BorderStyle = BorderStyle.FixedSingle;
            histBoxR.Location = new Point(11, 353);
            histBoxR.Name = "histBoxR";
            histBoxR.Size = new Size(319, 238);
            histBoxR.SizeMode = PictureBoxSizeMode.StretchImage;
            histBoxR.TabIndex = 2;
            histBoxR.TabStop = false;
            histBoxR.Click += histogramBox1_Click;
            // 
            // histBoxG
            // 
            histBoxG.BorderStyle = BorderStyle.FixedSingle;
            histBoxG.Location = new Point(334, 353);
            histBoxG.Name = "histBoxG";
            histBoxG.Size = new Size(315, 238);
            histBoxG.SizeMode = PictureBoxSizeMode.StretchImage;
            histBoxG.TabIndex = 5;
            histBoxG.TabStop = false;
            // 
            // histBoxB
            // 
            histBoxB.BorderStyle = BorderStyle.FixedSingle;
            histBoxB.Location = new Point(654, 353);
            histBoxB.Name = "histBoxB";
            histBoxB.Size = new Size(328, 238);
            histBoxB.SizeMode = PictureBoxSizeMode.StretchImage;
            histBoxB.TabIndex = 6;
            histBoxB.TabStop = false;
            // 
            // btnShowHist
            // 
            btnShowHist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowHist.Location = new Point(246, 29);
            btnShowHist.Name = "btnShowHist";
            btnShowHist.Size = new Size(210, 56);
            btnShowHist.TabIndex = 8;
            btnShowHist.Text = "Show Histogram";
            btnShowHist.UseVisualStyleBackColor = true;
            btnShowHist.Click += btnShowHist_Click;
            // 
            // week4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 604);
            Controls.Add(btnShowHist);
            Controls.Add(histBoxB);
            Controls.Add(histBoxG);
            Controls.Add(histBoxR);
            Controls.Add(imageBoxB);
            Controls.Add(imageBoxG);
            Controls.Add(imageBoxR);
            Controls.Add(btnLoad);
            Name = "week4";
            Text = "Week 4";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imageBoxR).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxG).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxB).EndInit();
            ((System.ComponentModel.ISupportInitialize)histBoxR).EndInit();
            ((System.ComponentModel.ISupportInitialize)histBoxG).EndInit();
            ((System.ComponentModel.ISupportInitialize)histBoxB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoad;
        private Emgu.CV.UI.ImageBox imageBoxR;
        private Emgu.CV.UI.ImageBox imageBoxG;
        private Emgu.CV.UI.ImageBox imageBoxB;
        private Emgu.CV.UI.HistogramBox histBoxR;
        private Emgu.CV.UI.HistogramBox histBoxG;
        private Emgu.CV.UI.HistogramBox histBoxB;
        private Button btnShowHist;
    }
}