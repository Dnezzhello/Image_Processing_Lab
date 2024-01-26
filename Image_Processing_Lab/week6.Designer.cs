namespace Image_Processing_Lab
{
    partial class week6
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
            imgBinary = new Emgu.CV.UI.ImageBox();
            imgGray = new Emgu.CV.UI.ImageBox();
            btnOpen = new Button();
            btnSave = new Button();
            btnClose = new Button();
            groupBox1 = new GroupBox();
            numericUpDownParam = new NumericUpDown();
            txtBoxBlockSize = new TextBox();
            txtBoxGrayValue = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            lblBlockSize = new Label();
            lblGrayMaxValue = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnOutput = new Button();
            ((System.ComponentModel.ISupportInitialize)imgInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBinary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgGray).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownParam).BeginInit();
            SuspendLayout();
            // 
            // imgInput
            // 
            imgInput.BorderStyle = BorderStyle.FixedSingle;
            imgInput.Location = new Point(16, 44);
            imgInput.Margin = new Padding(3, 4, 3, 4);
            imgInput.Name = "imgInput";
            imgInput.Size = new Size(385, 363);
            imgInput.SizeMode = PictureBoxSizeMode.StretchImage;
            imgInput.TabIndex = 2;
            imgInput.TabStop = false;
            // 
            // imgBinary
            // 
            imgBinary.BorderStyle = BorderStyle.FixedSingle;
            imgBinary.Location = new Point(16, 455);
            imgBinary.Margin = new Padding(3, 4, 3, 4);
            imgBinary.Name = "imgBinary";
            imgBinary.Size = new Size(385, 363);
            imgBinary.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBinary.TabIndex = 4;
            imgBinary.TabStop = false;
            // 
            // imgGray
            // 
            imgGray.BorderStyle = BorderStyle.FixedSingle;
            imgGray.Location = new Point(408, 44);
            imgGray.Margin = new Padding(3, 4, 3, 4);
            imgGray.Name = "imgGray";
            imgGray.Size = new Size(385, 363);
            imgGray.SizeMode = PictureBoxSizeMode.StretchImage;
            imgGray.TabIndex = 6;
            imgGray.TabStop = false;
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpen.Location = new Point(408, 455);
            btnOpen.Margin = new Padding(3, 4, 3, 4);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(120, 52);
            btnOpen.TabIndex = 7;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(539, 455);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 52);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(673, 455);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 52);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOutput);
            groupBox1.Controls.Add(numericUpDownParam);
            groupBox1.Controls.Add(txtBoxBlockSize);
            groupBox1.Controls.Add(txtBoxGrayValue);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(lblBlockSize);
            groupBox1.Controls.Add(lblGrayMaxValue);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(411, 520);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(385, 297);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thresholding";
            // 
            // numericUpDownParam
            // 
            numericUpDownParam.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownParam.Location = new Point(289, 173);
            numericUpDownParam.Margin = new Padding(3, 4, 3, 4);
            numericUpDownParam.Name = "numericUpDownParam";
            numericUpDownParam.Size = new Size(89, 29);
            numericUpDownParam.TabIndex = 14;
            // 
            // txtBoxBlockSize
            // 
            txtBoxBlockSize.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxBlockSize.Location = new Point(107, 172);
            txtBoxBlockSize.Margin = new Padding(3, 4, 3, 4);
            txtBoxBlockSize.Name = "txtBoxBlockSize";
            txtBoxBlockSize.Size = new Size(86, 29);
            txtBoxBlockSize.TabIndex = 18;
            // 
            // txtBoxGrayValue
            // 
            txtBoxGrayValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxGrayValue.Location = new Point(159, 113);
            txtBoxGrayValue.Margin = new Padding(3, 4, 3, 4);
            txtBoxGrayValue.Name = "txtBoxGrayValue";
            txtBoxGrayValue.Size = new Size(131, 29);
            txtBoxGrayValue.TabIndex = 17;
            txtBoxGrayValue.TextChanged += txtBoxGrayValue_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(192, 180);
            label6.Name = "label6";
            label6.Size = new Size(102, 23);
            label6.TabIndex = 16;
            label6.Text = "Parameter : ";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Binary", "Binary Invert", "OT'Su", "Guassian", "Mean" });
            comboBox1.Location = new Point(13, 41);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(365, 36);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblBlockSize
            // 
            lblBlockSize.AutoSize = true;
            lblBlockSize.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlockSize.Location = new Point(13, 180);
            lblBlockSize.Name = "lblBlockSize";
            lblBlockSize.Size = new Size(99, 23);
            lblBlockSize.TabIndex = 15;
            lblBlockSize.Text = "Block Size : ";
            // 
            // lblGrayMaxValue
            // 
            lblGrayMaxValue.AutoSize = true;
            lblGrayMaxValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblGrayMaxValue.Location = new Point(13, 119);
            lblGrayMaxValue.Name = "lblGrayMaxValue";
            lblGrayMaxValue.Size = new Size(143, 23);
            lblGrayMaxValue.TabIndex = 14;
            lblGrayMaxValue.Text = "Gray Max Value : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(160, 12);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 11;
            label1.Text = "Original Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(539, 12);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 12;
            label2.Text = "Gray Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(160, 421);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 13;
            label3.Text = "Binary Image";
            // 
            // btnOutput
            // 
            btnOutput.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOutput.Location = new Point(13, 239);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(365, 38);
            btnOutput.TabIndex = 19;
            btnOutput.Text = "Output";
            btnOutput.UseVisualStyleBackColor = true;
            btnOutput.Click += btnOutput_Click;
            // 
            // week_6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 823);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Controls.Add(imgGray);
            Controls.Add(imgBinary);
            Controls.Add(imgInput);
            Margin = new Padding(3, 4, 3, 4);
            Name = "week_6";
            Text = "week_6";
            Load += week_6_Load;
            ((System.ComponentModel.ISupportInitialize)imgInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBinary).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgGray).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownParam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Emgu.CV.UI.ImageBox imgInput;
        private Emgu.CV.UI.ImageBox imgBinary;
        private Emgu.CV.UI.ImageBox imgGray;
        private Button btnOpen;
        private Button btnSave;
        private Button btnClose;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label6;
        private Label lblBlockSize;
        private Label lblGrayMaxValue;
        private Label label2;
        private Label label3;
        private TextBox txtBoxGrayValue;
        private NumericUpDown numericUpDownParam;
        private TextBox txtBoxBlockSize;
        private Button btnOutput;
    }
}