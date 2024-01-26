namespace Image_Processing_Lab
{
    partial class week10
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
            groupBox1 = new GroupBox();
            btnSave = new Button();
            btnStart = new Button();
            btnCapture = new Button();
            btnBinary = new Button();
            btnGray = new Button();
            btnStop = new Button();
            groupBox2 = new GroupBox();
            imgBoxCapture = new PictureBox();
            imgBoxVDO = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBoxCapture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxVDO).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnStart);
            groupBox1.Controls.Add(btnCapture);
            groupBox1.Controls.Add(btnBinary);
            groupBox1.Controls.Add(btnGray);
            groupBox1.Controls.Add(btnStop);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(137, 38);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(868, 138);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controller Buttons";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(729, 66);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 51);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(20, 66);
            btnStart.Margin = new Padding(2, 2, 2, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(120, 51);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCapture
            // 
            btnCapture.Location = new Point(591, 66);
            btnCapture.Margin = new Padding(2, 2, 2, 2);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(120, 51);
            btnCapture.TabIndex = 3;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // btnBinary
            // 
            btnBinary.Location = new Point(451, 66);
            btnBinary.Margin = new Padding(2, 2, 2, 2);
            btnBinary.Name = "btnBinary";
            btnBinary.Size = new Size(120, 51);
            btnBinary.TabIndex = 2;
            btnBinary.Text = "Binary";
            btnBinary.UseVisualStyleBackColor = true;
            btnBinary.Click += btnBinary_Click;
            // 
            // btnGray
            // 
            btnGray.Location = new Point(306, 66);
            btnGray.Margin = new Padding(2, 2, 2, 2);
            btnGray.Name = "btnGray";
            btnGray.Size = new Size(120, 51);
            btnGray.TabIndex = 2;
            btnGray.Text = "Gray";
            btnGray.UseVisualStyleBackColor = true;
            btnGray.Click += btnGray_Click_1;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(164, 66);
            btnStop.Margin = new Padding(2, 2, 2, 2);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(120, 51);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(imgBoxCapture);
            groupBox2.Controls.Add(imgBoxVDO);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(20, 190);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(1102, 481);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Video";
            // 
            // imgBoxCapture
            // 
            imgBoxCapture.Location = new Point(567, 41);
            imgBoxCapture.Margin = new Padding(2, 2, 2, 2);
            imgBoxCapture.Name = "imgBoxCapture";
            imgBoxCapture.Size = new Size(518, 421);
            imgBoxCapture.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxCapture.TabIndex = 1;
            imgBoxCapture.TabStop = false;
            // 
            // imgBoxVDO
            // 
            imgBoxVDO.Location = new Point(25, 41);
            imgBoxVDO.Margin = new Padding(2, 2, 2, 2);
            imgBoxVDO.Name = "imgBoxVDO";
            imgBoxVDO.Size = new Size(518, 421);
            imgBoxVDO.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxVDO.TabIndex = 0;
            imgBoxVDO.TabStop = false;
            // 
            // week10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 681);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "week10";
            Text = "Week 10";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgBoxCapture).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxVDO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCapture;
        private Button btnBinary;
        private Button btnGray;
        private Button btnStop;
        private GroupBox groupBox2;
        private Button btnStart;
        private PictureBox imgBoxCapture;
        private PictureBox imgBoxVDO;
        private Button btnSave;
    }
}