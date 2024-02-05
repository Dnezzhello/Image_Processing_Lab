namespace Image_Processing_Lab
{
    partial class week11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            findContourToolStripMenuItem = new ToolStripMenuItem();
            imgInput = new Emgu.CV.UI.ImageBox();
            imgOutput = new Emgu.CV.UI.ImageBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgOutput).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(774, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, findContourToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // findContourToolStripMenuItem
            // 
            findContourToolStripMenuItem.Name = "findContourToolStripMenuItem";
            findContourToolStripMenuItem.Size = new Size(224, 26);
            findContourToolStripMenuItem.Text = "Find Contour";
            findContourToolStripMenuItem.Click += findContourToolStripMenuItem_Click;
            // 
            // imgInput
            // 
            imgInput.BorderStyle = BorderStyle.FixedSingle;
            imgInput.Location = new Point(22, 50);
            imgInput.Name = "imgInput";
            imgInput.Size = new Size(342, 335);
            imgInput.SizeMode = PictureBoxSizeMode.StretchImage;
            imgInput.TabIndex = 2;
            imgInput.TabStop = false;
            // 
            // imgOutput
            // 
            imgOutput.BorderStyle = BorderStyle.FixedSingle;
            imgOutput.Location = new Point(406, 50);
            imgOutput.Name = "imgOutput";
            imgOutput.Size = new Size(342, 335);
            imgOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            imgOutput.TabIndex = 3;
            imgOutput.TabStop = false;
            // 
            // week11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 406);
            Controls.Add(imgOutput);
            Controls.Add(imgInput);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "week11";
            Text = "week11";
            Load += week11_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem findContourToolStripMenuItem;
        private Emgu.CV.UI.ImageBox imgInput;
        private Emgu.CV.UI.ImageBox imgOutput;
    }
}