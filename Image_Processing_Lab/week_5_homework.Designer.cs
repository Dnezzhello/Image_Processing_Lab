namespace Image_Processing_Lab
{
    partial class week_5_homework
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
            imgInput = new Emgu.CV.UI.ImageBox();
            imgOutput = new Emgu.CV.UI.ImageBox();
            histogram = new Emgu.CV.UI.HistogramBox();
            btnLoad = new Button();
            groupBox1 = new GroupBox();
            radioB = new RadioButton();
            radioG = new RadioButton();
            radioR = new RadioButton();
            groupBox2 = new GroupBox();
            comboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)imgInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)histogram).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // imgInput
            // 
            imgInput.BorderStyle = BorderStyle.FixedSingle;
            imgInput.Location = new Point(16, 12);
            imgInput.Name = "imgInput";
            imgInput.Size = new Size(393, 296);
            imgInput.SizeMode = PictureBoxSizeMode.StretchImage;
            imgInput.TabIndex = 2;
            imgInput.TabStop = false;
            // 
            // imgOutput
            // 
            imgOutput.BorderStyle = BorderStyle.FixedSingle;
            imgOutput.Location = new Point(16, 324);
            imgOutput.Name = "imgOutput";
            imgOutput.Size = new Size(393, 296);
            imgOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            imgOutput.TabIndex = 3;
            imgOutput.TabStop = false;
            // 
            // histogram
            // 
            histogram.BorderStyle = BorderStyle.FixedSingle;
            histogram.Location = new Point(422, 13);
            histogram.Name = "histogram";
            histogram.Size = new Size(700, 606);
            histogram.SizeMode = PictureBoxSizeMode.StretchImage;
            histogram.TabIndex = 2;
            histogram.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(1139, 13);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(162, 48);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Load Image";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioB);
            groupBox1.Controls.Add(radioG);
            groupBox1.Controls.Add(radioR);
            groupBox1.Location = new Point(1140, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(164, 142);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Histogram";
            // 
            // radioB
            // 
            radioB.AutoSize = true;
            radioB.Location = new Point(20, 102);
            radioB.Name = "radioB";
            radioB.Size = new Size(59, 24);
            radioB.TabIndex = 7;
            radioB.TabStop = true;
            radioB.Text = "Blue";
            radioB.UseVisualStyleBackColor = true;
            radioB.CheckedChanged += radioB_CheckedChanged;
            // 
            // radioG
            // 
            radioG.AutoSize = true;
            radioG.Location = new Point(20, 72);
            radioG.Name = "radioG";
            radioG.Size = new Size(69, 24);
            radioG.TabIndex = 6;
            radioG.TabStop = true;
            radioG.Text = "Green";
            radioG.UseVisualStyleBackColor = true;
            radioG.CheckedChanged += radioG_CheckedChanged;
            // 
            // radioR
            // 
            radioR.AutoSize = true;
            radioR.Location = new Point(20, 42);
            radioR.Name = "radioR";
            radioR.Size = new Size(56, 24);
            radioR.TabIndex = 0;
            radioR.TabStop = true;
            radioR.Text = "Red";
            radioR.UseVisualStyleBackColor = true;
            radioR.CheckedChanged += radioR_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox);
            groupBox2.Location = new Point(1145, 244);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(163, 89);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Color Channel";
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Red", "Green", "Blue" });
            comboBox.Location = new Point(15, 38);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(136, 28);
            comboBox.TabIndex = 0;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // week_5_homework
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 634);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLoad);
            Controls.Add(histogram);
            Controls.Add(imgOutput);
            Controls.Add(imgInput);
            Name = "week_5_homework";
            Text = "week_5_homework";
            Load += week_5_homework_Load;
            ((System.ComponentModel.ISupportInitialize)imgInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)histogram).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox imgInput;
        private Emgu.CV.UI.ImageBox imgOutput;
        private Emgu.CV.UI.HistogramBox histogram;
        private Button btnLoad;
        private GroupBox groupBox1;
        private RadioButton radioB;
        private RadioButton radioG;
        private RadioButton radioR;
        private GroupBox groupBox2;
        private ComboBox comboBox;
    }
}