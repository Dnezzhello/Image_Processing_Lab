namespace Image_Processing_Lab
{
    partial class week9
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            morphoToolStripMenuItem = new ToolStripMenuItem();
            dilationToolStripMenuItem = new ToolStripMenuItem();
            erosionToolStripMenuItem = new ToolStripMenuItem();
            openingToolStripMenuItem = new ToolStripMenuItem();
            closingToolStripMenuItem = new ToolStripMenuItem();
            gradientToolStripMenuItem = new ToolStripMenuItem();
            topToolStripMenuItem = new ToolStripMenuItem();
            blackHatToolStripMenuItem = new ToolStripMenuItem();
            morphologicalBinaryToolStripMenuItem = new ToolStripMenuItem();
            dilationToolStripMenuItem1 = new ToolStripMenuItem();
            erosionToolStripMenuItem1 = new ToolStripMenuItem();
            openingToolStripMenuItem1 = new ToolStripMenuItem();
            closingToolStripMenuItem1 = new ToolStripMenuItem();
            pictBox1 = new PictureBox();
            pictBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, morphoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1362, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(128, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // morphoToolStripMenuItem
            // 
            morphoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dilationToolStripMenuItem, erosionToolStripMenuItem, openingToolStripMenuItem, closingToolStripMenuItem, gradientToolStripMenuItem, topToolStripMenuItem, blackHatToolStripMenuItem, morphologicalBinaryToolStripMenuItem });
            morphoToolStripMenuItem.Name = "morphoToolStripMenuItem";
            morphoToolStripMenuItem.Size = new Size(105, 24);
            morphoToolStripMenuItem.Text = "Morphology";
            // 
            // dilationToolStripMenuItem
            // 
            dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            dilationToolStripMenuItem.Size = new Size(235, 26);
            dilationToolStripMenuItem.Text = "Dilation";
            dilationToolStripMenuItem.Click += dilationToolStripMenuItem_Click;
            // 
            // erosionToolStripMenuItem
            // 
            erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            erosionToolStripMenuItem.Size = new Size(235, 26);
            erosionToolStripMenuItem.Text = "Erosion";
            erosionToolStripMenuItem.Click += erosionToolStripMenuItem_Click;
            // 
            // openingToolStripMenuItem
            // 
            openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            openingToolStripMenuItem.Size = new Size(235, 26);
            openingToolStripMenuItem.Text = "Opening";
            openingToolStripMenuItem.Click += openingToolStripMenuItem_Click;
            // 
            // closingToolStripMenuItem
            // 
            closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            closingToolStripMenuItem.Size = new Size(235, 26);
            closingToolStripMenuItem.Text = "Closing";
            closingToolStripMenuItem.Click += closingToolStripMenuItem_Click;
            // 
            // gradientToolStripMenuItem
            // 
            gradientToolStripMenuItem.Name = "gradientToolStripMenuItem";
            gradientToolStripMenuItem.Size = new Size(235, 26);
            gradientToolStripMenuItem.Text = "Gradient";
            gradientToolStripMenuItem.Click += gradientToolStripMenuItem_Click;
            // 
            // topToolStripMenuItem
            // 
            topToolStripMenuItem.Name = "topToolStripMenuItem";
            topToolStripMenuItem.Size = new Size(235, 26);
            topToolStripMenuItem.Text = "Top Hat";
            topToolStripMenuItem.Click += topToolStripMenuItem_Click;
            // 
            // blackHatToolStripMenuItem
            // 
            blackHatToolStripMenuItem.Name = "blackHatToolStripMenuItem";
            blackHatToolStripMenuItem.Size = new Size(235, 26);
            blackHatToolStripMenuItem.Text = "Black Hat";
            blackHatToolStripMenuItem.Click += blackHatToolStripMenuItem_Click;
            // 
            // morphologicalBinaryToolStripMenuItem
            // 
            morphologicalBinaryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dilationToolStripMenuItem1, erosionToolStripMenuItem1, openingToolStripMenuItem1, closingToolStripMenuItem1 });
            morphologicalBinaryToolStripMenuItem.Name = "morphologicalBinaryToolStripMenuItem";
            morphologicalBinaryToolStripMenuItem.Size = new Size(235, 26);
            morphologicalBinaryToolStripMenuItem.Text = "Morphological Binary";
            // 
            // dilationToolStripMenuItem1
            // 
            dilationToolStripMenuItem1.Name = "dilationToolStripMenuItem1";
            dilationToolStripMenuItem1.Size = new Size(149, 26);
            dilationToolStripMenuItem1.Text = "Dilation";
            dilationToolStripMenuItem1.Click += dilationToolStripMenuItem1_Click;
            // 
            // erosionToolStripMenuItem1
            // 
            erosionToolStripMenuItem1.Name = "erosionToolStripMenuItem1";
            erosionToolStripMenuItem1.Size = new Size(149, 26);
            erosionToolStripMenuItem1.Text = "Erosion";
            erosionToolStripMenuItem1.Click += erosionToolStripMenuItem1_Click;
            // 
            // openingToolStripMenuItem1
            // 
            openingToolStripMenuItem1.Name = "openingToolStripMenuItem1";
            openingToolStripMenuItem1.Size = new Size(149, 26);
            openingToolStripMenuItem1.Text = "Opening";
            openingToolStripMenuItem1.Click += openingToolStripMenuItem1_Click;
            // 
            // closingToolStripMenuItem1
            // 
            closingToolStripMenuItem1.Name = "closingToolStripMenuItem1";
            closingToolStripMenuItem1.Size = new Size(149, 26);
            closingToolStripMenuItem1.Text = "Closing";
            closingToolStripMenuItem1.Click += closingToolStripMenuItem1_Click;
            // 
            // pictBox1
            // 
            pictBox1.BorderStyle = BorderStyle.FixedSingle;
            pictBox1.Location = new Point(25, 75);
            pictBox1.Margin = new Padding(2, 2, 2, 2);
            pictBox1.Name = "pictBox1";
            pictBox1.Size = new Size(646, 566);
            pictBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBox1.TabIndex = 1;
            pictBox1.TabStop = false;
            // 
            // pictBox2
            // 
            pictBox2.BorderStyle = BorderStyle.FixedSingle;
            pictBox2.Location = new Point(698, 75);
            pictBox2.Margin = new Padding(2, 2, 2, 2);
            pictBox2.Name = "pictBox2";
            pictBox2.Size = new Size(646, 566);
            pictBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBox2.TabIndex = 2;
            pictBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 3;
            label1.Text = "Original Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1004, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 4;
            label2.Text = "Processed Image";
            // 
            // week9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 664);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictBox2);
            Controls.Add(pictBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "week9";
            Text = "Morphology";
            Load += week9_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem morphoToolStripMenuItem;
        private ToolStripMenuItem dilationToolStripMenuItem;
        private ToolStripMenuItem erosionToolStripMenuItem;
        private ToolStripMenuItem openingToolStripMenuItem;
        private ToolStripMenuItem closingToolStripMenuItem;
        private ToolStripMenuItem gradientToolStripMenuItem;
        private ToolStripMenuItem topToolStripMenuItem;
        private ToolStripMenuItem blackHatToolStripMenuItem;
        private ToolStripMenuItem morphologicalBinaryToolStripMenuItem;
        private ToolStripMenuItem dilationToolStripMenuItem1;
        private ToolStripMenuItem erosionToolStripMenuItem1;
        private PictureBox pictBox1;
        private PictureBox pictBox2;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem openingToolStripMenuItem1;
        private ToolStripMenuItem closingToolStripMenuItem1;
    }
}