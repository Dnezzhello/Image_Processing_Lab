namespace Image_Processing_Lab
{
    partial class week5
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
            pictBoxOrigin = new PictureBox();
            pictBoxOutput = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            simpleThresholdToolStripMenuItem = new ToolStripMenuItem();
            binaryToolStripMenuItem = new ToolStripMenuItem();
            binaryInvertToolStripMenuItem = new ToolStripMenuItem();
            oTSUToolStripMenuItem = new ToolStripMenuItem();
            adaptiveThresholdToolStripMenuItem = new ToolStripMenuItem();
            guassianToolStripMenuItem = new ToolStripMenuItem();
            meanToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictBoxOrigin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxOutput).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictBoxOrigin
            // 
            pictBoxOrigin.BorderStyle = BorderStyle.FixedSingle;
            pictBoxOrigin.Location = new Point(14, 59);
            pictBoxOrigin.Name = "pictBoxOrigin";
            pictBoxOrigin.Size = new Size(497, 430);
            pictBoxOrigin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBoxOrigin.TabIndex = 0;
            pictBoxOrigin.TabStop = false;
            // 
            // pictBoxOutput
            // 
            pictBoxOutput.BorderStyle = BorderStyle.FixedSingle;
            pictBoxOutput.Location = new Point(517, 59);
            pictBoxOutput.Name = "pictBoxOutput";
            pictBoxOutput.Size = new Size(497, 430);
            pictBoxOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBoxOutput.TabIndex = 1;
            pictBoxOutput.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1030, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, simpleThresholdToolStripMenuItem, adaptiveThresholdToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(221, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // simpleThresholdToolStripMenuItem
            // 
            simpleThresholdToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { binaryToolStripMenuItem, binaryInvertToolStripMenuItem, oTSUToolStripMenuItem });
            simpleThresholdToolStripMenuItem.Name = "simpleThresholdToolStripMenuItem";
            simpleThresholdToolStripMenuItem.Size = new Size(221, 26);
            simpleThresholdToolStripMenuItem.Text = "Simple Threshold";
            // 
            // binaryToolStripMenuItem
            // 
            binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            binaryToolStripMenuItem.Size = new Size(174, 26);
            binaryToolStripMenuItem.Text = "Binary";
            binaryToolStripMenuItem.Click += binaryToolStripMenuItem_Click;
            // 
            // binaryInvertToolStripMenuItem
            // 
            binaryInvertToolStripMenuItem.Name = "binaryInvertToolStripMenuItem";
            binaryInvertToolStripMenuItem.Size = new Size(174, 26);
            binaryInvertToolStripMenuItem.Text = "Binary Invert";
            binaryInvertToolStripMenuItem.Click += binaryInvertToolStripMenuItem_Click;
            // 
            // oTSUToolStripMenuItem
            // 
            oTSUToolStripMenuItem.Name = "oTSUToolStripMenuItem";
            oTSUToolStripMenuItem.Size = new Size(174, 26);
            oTSUToolStripMenuItem.Text = "OT'SU";
            oTSUToolStripMenuItem.Click += oTSUToolStripMenuItem_Click;
            // 
            // adaptiveThresholdToolStripMenuItem
            // 
            adaptiveThresholdToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guassianToolStripMenuItem, meanToolStripMenuItem });
            adaptiveThresholdToolStripMenuItem.Name = "adaptiveThresholdToolStripMenuItem";
            adaptiveThresholdToolStripMenuItem.Size = new Size(221, 26);
            adaptiveThresholdToolStripMenuItem.Text = "Adaptive Threshold";
            // 
            // guassianToolStripMenuItem
            // 
            guassianToolStripMenuItem.Name = "guassianToolStripMenuItem";
            guassianToolStripMenuItem.Size = new Size(150, 26);
            guassianToolStripMenuItem.Text = "Guassian";
            guassianToolStripMenuItem.Click += guassianToolStripMenuItem_Click;
            // 
            // meanToolStripMenuItem
            // 
            meanToolStripMenuItem.Name = "meanToolStripMenuItem";
            meanToolStripMenuItem.Size = new Size(150, 26);
            meanToolStripMenuItem.Text = "Mean";
            meanToolStripMenuItem.Click += meanToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(221, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // week_5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 507);
            Controls.Add(pictBoxOutput);
            Controls.Add(pictBoxOrigin);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "week_5";
            Text = "Image Binarisation";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictBoxOrigin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxOutput).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictBoxOrigin;
        private PictureBox pictBoxOutput;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem simpleThresholdToolStripMenuItem;
        private ToolStripMenuItem binaryToolStripMenuItem;
        private ToolStripMenuItem binaryInvertToolStripMenuItem;
        private ToolStripMenuItem oTSUToolStripMenuItem;
        private ToolStripMenuItem adaptiveThresholdToolStripMenuItem;
        private ToolStripMenuItem guassianToolStripMenuItem;
        private ToolStripMenuItem meanToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}