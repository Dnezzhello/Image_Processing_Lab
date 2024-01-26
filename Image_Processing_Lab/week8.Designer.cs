namespace Image_Processing_Lab
{
    partial class week8
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectionToolStripMenuItem = new ToolStripMenuItem();
            cannyToolStripMenuItem = new ToolStripMenuItem();
            sobelToolStripMenuItem = new ToolStripMenuItem();
            laplacianToolStripMenuItem = new ToolStripMenuItem();
            imgBoxInput = new Emgu.CV.UI.ImageBox();
            label1 = new Label();
            label2 = new Label();
            pictBox = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBoxInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, edgeDetectionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1844, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(206, 44);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(206, 44);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(206, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // edgeDetectionToolStripMenuItem
            // 
            edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cannyToolStripMenuItem, sobelToolStripMenuItem, laplacianToolStripMenuItem });
            edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            edgeDetectionToolStripMenuItem.Size = new Size(198, 36);
            edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            // 
            // cannyToolStripMenuItem
            // 
            cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            cannyToolStripMenuItem.Size = new Size(245, 44);
            cannyToolStripMenuItem.Text = "Canny";
            cannyToolStripMenuItem.Click += cannyToolStripMenuItem_Click;
            // 
            // sobelToolStripMenuItem
            // 
            sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            sobelToolStripMenuItem.Size = new Size(245, 44);
            sobelToolStripMenuItem.Text = "Sobel";
            sobelToolStripMenuItem.Click += sobelToolStripMenuItem_Click;
            // 
            // laplacianToolStripMenuItem
            // 
            laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            laplacianToolStripMenuItem.Size = new Size(245, 44);
            laplacianToolStripMenuItem.Text = "Laplacian";
            laplacianToolStripMenuItem.Click += laplacianToolStripMenuItem_Click;
            // 
            // imgBoxInput
            // 
            imgBoxInput.BorderStyle = BorderStyle.FixedSingle;
            imgBoxInput.Location = new Point(30, 173);
            imgBoxInput.Margin = new Padding(6);
            imgBoxInput.Name = "imgBoxInput";
            imgBoxInput.Size = new Size(837, 640);
            imgBoxInput.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxInput.TabIndex = 2;
            imgBoxInput.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(366, 105);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 39);
            label1.TabIndex = 4;
            label1.Text = "Original Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1248, 105);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 39);
            label2.TabIndex = 5;
            label2.Text = "Output Image";
            // 
            // pictBox
            // 
            pictBox.BorderStyle = BorderStyle.FixedSingle;
            pictBox.Location = new Point(937, 173);
            pictBox.Name = "pictBox";
            pictBox.Size = new Size(803, 640);
            pictBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBox.TabIndex = 6;
            pictBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1844, 849);
            Controls.Add(pictBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imgBoxInput);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Edge Detection";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgBoxInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private ToolStripMenuItem cannyToolStripMenuItem;
        private ToolStripMenuItem sobelToolStripMenuItem;
        private ToolStripMenuItem laplacianToolStripMenuItem;
        private Emgu.CV.UI.ImageBox imgBoxInput;
        private Label label1;
        private Label label2;
        private PictureBox pictBox;
    }
}