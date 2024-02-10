namespace Image_Processing_Lab
{
    partial class week7
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
            imgBoxInput = new Emgu.CV.UI.ImageBox();
            imgBoxGray = new Emgu.CV.UI.ImageBox();
            label1 = new Label();
            label2 = new Label();
            htgGray = new Emgu.CV.UI.HistogramBox();
            btnLoad = new Button();
            label3 = new Label();
            label4 = new Label();
            btnGuassian = new Button();
            btnSave = new Button();
            btnExit = new Button();
            btnEqualisation = new Button();
            btnMedian = new Button();
            label5 = new Label();
            htgOutput = new Emgu.CV.UI.HistogramBox();
            label6 = new Label();
            imgBoxOutput = new Emgu.CV.UI.ImageBox();
            groupBox1 = new GroupBox();
            txtBoxKSize = new TextBox();
            label7 = new Label();
            rdBtnGray = new RadioButton();
            rdBtnColor = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)imgBoxInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxGray).BeginInit();
            ((System.ComponentModel.ISupportInitialize)htgGray).BeginInit();
            ((System.ComponentModel.ISupportInitialize)htgOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxOutput).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // imgBoxInput
            // 
            imgBoxInput.BorderStyle = BorderStyle.FixedSingle;
            imgBoxInput.Location = new Point(11, 66);
            imgBoxInput.Margin = new Padding(6, 6, 6, 6);
            imgBoxInput.Name = "imgBoxInput";
            imgBoxInput.Size = new Size(637, 544);
            imgBoxInput.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxInput.TabIndex = 2;
            imgBoxInput.TabStop = false;
            // 
            // imgBoxGray
            // 
            imgBoxGray.BorderStyle = BorderStyle.FixedSingle;
            imgBoxGray.Location = new Point(11, 683);
            imgBoxGray.Margin = new Padding(6, 6, 6, 6);
            imgBoxGray.Name = "imgBoxGray";
            imgBoxGray.Size = new Size(637, 544);
            imgBoxGray.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxGray.TabIndex = 3;
            imgBoxGray.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(249, 19);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 6;
            label1.Text = "Original Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(249, 631);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 32);
            label2.TabIndex = 7;
            label2.Text = "Gray Image";
            // 
            // htgGray
            // 
            htgGray.BorderStyle = BorderStyle.FixedSingle;
            htgGray.Location = new Point(669, 683);
            htgGray.Margin = new Padding(6, 6, 6, 6);
            htgGray.Name = "htgGray";
            htgGray.Size = new Size(758, 546);
            htgGray.SizeMode = PictureBoxSizeMode.StretchImage;
            htgGray.TabIndex = 8;
            htgGray.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(1449, 64);
            btnLoad.Margin = new Padding(6, 6, 6, 6);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(201, 87);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load Image";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(897, 19);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(897, 631);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(279, 32);
            label4.TabIndex = 11;
            label4.Text = "Histogram of Gray Image";
            // 
            // btnGuassian
            // 
            btnGuassian.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuassian.Location = new Point(1449, 454);
            btnGuassian.Margin = new Padding(6, 6, 6, 6);
            btnGuassian.Name = "btnGuassian";
            btnGuassian.Size = new Size(201, 87);
            btnGuassian.TabIndex = 13;
            btnGuassian.Text = "Guassian Filter";
            btnGuassian.UseVisualStyleBackColor = true;
            btnGuassian.Click += btnGuassian_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(1449, 576);
            btnSave.Margin = new Padding(6, 6, 6, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(201, 87);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save Image";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(1449, 702);
            btnExit.Margin = new Padding(6, 6, 6, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(201, 87);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEqualisation
            // 
            btnEqualisation.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEqualisation.Location = new Point(1449, 183);
            btnEqualisation.Margin = new Padding(6, 6, 6, 6);
            btnEqualisation.Name = "btnEqualisation";
            btnEqualisation.Size = new Size(201, 102);
            btnEqualisation.TabIndex = 16;
            btnEqualisation.Text = "Histogram Equalisation";
            btnEqualisation.UseVisualStyleBackColor = true;
            btnEqualisation.Click += btnEqualisation_Click;
            // 
            // btnMedian
            // 
            btnMedian.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMedian.Location = new Point(1449, 318);
            btnMedian.Margin = new Padding(6, 6, 6, 6);
            btnMedian.Name = "btnMedian";
            btnMedian.Size = new Size(201, 102);
            btnMedian.TabIndex = 17;
            btnMedian.Text = "Median Filter";
            btnMedian.UseVisualStyleBackColor = true;
            btnMedian.Click += btnMedian_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(897, 1237);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(311, 32);
            label5.TabIndex = 21;
            label5.Text = "Histogram of Filtered Image";
            // 
            // htgOutput
            // 
            htgOutput.BorderStyle = BorderStyle.FixedSingle;
            htgOutput.Location = new Point(669, 1289);
            htgOutput.Margin = new Padding(6, 6, 6, 6);
            htgOutput.Name = "htgOutput";
            htgOutput.Size = new Size(758, 546);
            htgOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            htgOutput.TabIndex = 20;
            htgOutput.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(249, 1237);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(168, 32);
            label6.TabIndex = 19;
            label6.Text = "Filtered Image";
            // 
            // imgBoxOutput
            // 
            imgBoxOutput.BorderStyle = BorderStyle.FixedSingle;
            imgBoxOutput.Location = new Point(11, 1289);
            imgBoxOutput.Margin = new Padding(6, 6, 6, 6);
            imgBoxOutput.Name = "imgBoxOutput";
            imgBoxOutput.Size = new Size(637, 544);
            imgBoxOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBoxOutput.TabIndex = 18;
            imgBoxOutput.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBoxKSize);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(rdBtnGray);
            groupBox1.Controls.Add(rdBtnColor);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(669, 58);
            groupBox1.Margin = new Padding(6, 4, 6, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 4, 6, 4);
            groupBox1.Size = new Size(760, 555);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Setting";
            // 
            // txtBoxKSize
            // 
            txtBoxKSize.Location = new Point(175, 273);
            txtBoxKSize.Margin = new Padding(6, 4, 6, 4);
            txtBoxKSize.Name = "txtBoxKSize";
            txtBoxKSize.Size = new Size(164, 50);
            txtBoxKSize.TabIndex = 26;
            txtBoxKSize.TextChanged += txtBoxKSize_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 279);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 45);
            label7.TabIndex = 25;
            label7.Text = "KSize : ";
            // 
            // rdBtnGray
            // 
            rdBtnGray.AutoSize = true;
            rdBtnGray.Location = new Point(43, 177);
            rdBtnGray.Margin = new Padding(6, 4, 6, 4);
            rdBtnGray.Name = "rdBtnGray";
            rdBtnGray.Size = new Size(213, 49);
            rdBtnGray.TabIndex = 24;
            rdBtnGray.TabStop = true;
            rdBtnGray.Text = "Gray Image";
            rdBtnGray.UseVisualStyleBackColor = true;
            rdBtnGray.CheckedChanged += rdBtnGray_CheckedChanged;
            // 
            // rdBtnColor
            // 
            rdBtnColor.AutoSize = true;
            rdBtnColor.Location = new Point(43, 92);
            rdBtnColor.Margin = new Padding(6, 4, 6, 4);
            rdBtnColor.Name = "rdBtnColor";
            rdBtnColor.Size = new Size(280, 49);
            rdBtnColor.TabIndex = 23;
            rdBtnColor.TabStop = true;
            rdBtnColor.Text = "Colourful Image";
            rdBtnColor.UseVisualStyleBackColor = true;
            rdBtnColor.CheckedChanged += rdBtnColor_CheckedChanged;
            // 
            // week7
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1914);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(htgOutput);
            Controls.Add(label6);
            Controls.Add(imgBoxOutput);
            Controls.Add(btnMedian);
            Controls.Add(btnEqualisation);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnGuassian);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnLoad);
            Controls.Add(htgGray);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imgBoxGray);
            Controls.Add(imgBoxInput);
            Margin = new Padding(6, 6, 6, 6);
            Name = "week7";
            Text = "week_7";
            Load += week_7_Load;
            ((System.ComponentModel.ISupportInitialize)imgBoxInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxGray).EndInit();
            ((System.ComponentModel.ISupportInitialize)htgGray).EndInit();
            ((System.ComponentModel.ISupportInitialize)htgOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBoxOutput).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox imgBoxInput;
        private Emgu.CV.UI.ImageBox imgBoxGray;
        private Label label1;
        private Label label2;
        private Emgu.CV.UI.HistogramBox htgGray;
        private Button btnLoad;
        private Label label3;
        private Label label4;
        private Button btnGuassian;
        private Button btnSave;
        private Button btnExit;
        private Button btnEqualisation;
        private Button btnMedian;
        private Label label5;
        private Emgu.CV.UI.HistogramBox htgOutput;
        private Label label6;
        private Emgu.CV.UI.ImageBox imgBoxOutput;
        private GroupBox groupBox1;
        private RadioButton rdBtnGray;
        private RadioButton rdBtnColor;
        private TextBox txtBoxKSize;
        private Label label7;
    }
}