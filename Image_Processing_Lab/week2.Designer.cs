namespace Image_Processing_Lab

{
    partial class week2
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
            btnOrigin = new Button();
            button3 = new Button();
            btnBlackWhite = new Button();
            btnNegative = new Button();
            btnLogTransform = new Button();
            btnPowerLaw = new Button();
            button10 = new Button();
            button11 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnOpenPic = new Button();
            btnGrayScale1 = new Button();
            txtBoxThreshold = new TextBox();
            txtBoxCoef2 = new TextBox();
            txtBoxGamma = new TextBox();
            btnInvert = new Button();
            txtBoxCoef1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnOrigin
            // 
            btnOrigin.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrigin.ForeColor = Color.Navy;
            btnOrigin.Location = new Point(72, 45);
            btnOrigin.Margin = new Padding(3, 5, 3, 5);
            btnOrigin.Name = "btnOrigin";
            btnOrigin.Size = new Size(183, 66);
            btnOrigin.TabIndex = 0;
            btnOrigin.Text = "Origin";
            btnOrigin.UseVisualStyleBackColor = true;
            btnOrigin.Click += btnOrigin_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(489, 45);
            button3.Margin = new Padding(3, 5, 3, 5);
            button3.Name = "button3";
            button3.Size = new Size(210, 66);
            button3.TabIndex = 2;
            button3.Text = "Gray Scale 2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnBlackWhite
            // 
            btnBlackWhite.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBlackWhite.ForeColor = Color.Navy;
            btnBlackWhite.Location = new Point(720, 132);
            btnBlackWhite.Margin = new Padding(3, 5, 3, 5);
            btnBlackWhite.Name = "btnBlackWhite";
            btnBlackWhite.Size = new Size(206, 66);
            btnBlackWhite.TabIndex = 4;
            btnBlackWhite.Text = "Black_White 1";
            btnBlackWhite.UseVisualStyleBackColor = true;
            btnBlackWhite.Click += btnBlackWhite_Click;
            // 
            // btnNegative
            // 
            btnNegative.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNegative.ForeColor = Color.Navy;
            btnNegative.Location = new Point(720, 305);
            btnNegative.Margin = new Padding(3, 5, 3, 5);
            btnNegative.Name = "btnNegative";
            btnNegative.Size = new Size(206, 66);
            btnNegative.TabIndex = 5;
            btnNegative.Text = "Negative";
            btnNegative.UseVisualStyleBackColor = true;
            btnNegative.Click += btnNegative_Click;
            // 
            // btnLogTransform
            // 
            btnLogTransform.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogTransform.ForeColor = Color.Navy;
            btnLogTransform.Location = new Point(717, 502);
            btnLogTransform.Margin = new Padding(3, 5, 3, 5);
            btnLogTransform.Name = "btnLogTransform";
            btnLogTransform.Size = new Size(210, 66);
            btnLogTransform.TabIndex = 7;
            btnLogTransform.Text = "Log Transformation";
            btnLogTransform.UseVisualStyleBackColor = true;
            btnLogTransform.Click += btnLogTransform_Click;
            // 
            // btnPowerLaw
            // 
            btnPowerLaw.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPowerLaw.ForeColor = Color.Navy;
            btnPowerLaw.Location = new Point(724, 655);
            btnPowerLaw.Margin = new Padding(3, 5, 3, 5);
            btnPowerLaw.Name = "btnPowerLaw";
            btnPowerLaw.Size = new Size(201, 66);
            btnPowerLaw.TabIndex = 8;
            btnPowerLaw.Text = "Power Law";
            btnPowerLaw.UseVisualStyleBackColor = true;
            btnPowerLaw.Click += btnPowerLaw_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = Color.Navy;
            button10.Location = new Point(380, 811);
            button10.Margin = new Padding(3, 5, 3, 5);
            button10.Name = "button10";
            button10.Size = new Size(318, 66);
            button10.TabIndex = 9;
            button10.Text = "Median Filter";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = Color.Navy;
            button11.Location = new Point(72, 811);
            button11.Margin = new Padding(3, 5, 3, 5);
            button11.Name = "button11";
            button11.Size = new Size(291, 66);
            button11.TabIndex = 10;
            button11.Text = "Mean Filter";
            button11.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(72, 132);
            pictureBox1.Margin = new Padding(3, 5, 3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(626, 672);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(720, 231);
            label2.Name = "label2";
            label2.Size = new Size(114, 24);
            label2.TabIndex = 14;
            label2.Text = "Threshold = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(720, 751);
            label3.Name = "label3";
            label3.Size = new Size(41, 24);
            label3.TabIndex = 16;
            label3.Text = "C = ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(720, 820);
            label4.Name = "label4";
            label4.Size = new Size(95, 24);
            label4.TabIndex = 18;
            label4.Text = "Gamma = ";
            // 
            // btnOpenPic
            // 
            btnOpenPic.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenPic.ForeColor = Color.SteelBlue;
            btnOpenPic.Location = new Point(724, 45);
            btnOpenPic.Margin = new Padding(3, 5, 3, 5);
            btnOpenPic.Name = "btnOpenPic";
            btnOpenPic.Size = new Size(201, 66);
            btnOpenPic.TabIndex = 19;
            btnOpenPic.Text = "Open Picture";
            btnOpenPic.UseVisualStyleBackColor = true;
            btnOpenPic.Click += btnOpenPic_Click;
            // 
            // btnGrayScale1
            // 
            btnGrayScale1.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGrayScale1.ForeColor = Color.Navy;
            btnGrayScale1.Location = new Point(274, 45);
            btnGrayScale1.Margin = new Padding(3, 5, 3, 5);
            btnGrayScale1.Name = "btnGrayScale1";
            btnGrayScale1.Size = new Size(196, 66);
            btnGrayScale1.TabIndex = 21;
            btnGrayScale1.Text = "Gray Scale 1";
            btnGrayScale1.UseVisualStyleBackColor = true;
            btnGrayScale1.Click += btnGrayScale1_Click;
            // 
            // txtBoxThreshold
            // 
            txtBoxThreshold.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxThreshold.Location = new Point(836, 231);
            txtBoxThreshold.Margin = new Padding(3, 2, 3, 2);
            txtBoxThreshold.Name = "txtBoxThreshold";
            txtBoxThreshold.Size = new Size(89, 26);
            txtBoxThreshold.TabIndex = 22;
            txtBoxThreshold.Text = "0";
            // 
            // txtBoxCoef2
            // 
            txtBoxCoef2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCoef2.Location = new Point(768, 751);
            txtBoxCoef2.Margin = new Padding(3, 2, 3, 2);
            txtBoxCoef2.Name = "txtBoxCoef2";
            txtBoxCoef2.Size = new Size(159, 26);
            txtBoxCoef2.TabIndex = 23;
            txtBoxCoef2.Text = "0";
            // 
            // txtBoxGamma
            // 
            txtBoxGamma.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxGamma.Location = new Point(814, 820);
            txtBoxGamma.Margin = new Padding(3, 2, 3, 2);
            txtBoxGamma.Name = "txtBoxGamma";
            txtBoxGamma.Size = new Size(114, 26);
            txtBoxGamma.TabIndex = 24;
            txtBoxGamma.Text = "0";
            // 
            // btnInvert
            // 
            btnInvert.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvert.ForeColor = Color.Navy;
            btnInvert.Location = new Point(720, 406);
            btnInvert.Margin = new Padding(3, 5, 3, 5);
            btnInvert.Name = "btnInvert";
            btnInvert.Size = new Size(206, 66);
            btnInvert.TabIndex = 25;
            btnInvert.Text = "Invert";
            btnInvert.UseVisualStyleBackColor = true;
            btnInvert.Click += btnInvert_Click;
            // 
            // txtBoxCoef1
            // 
            txtBoxCoef1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCoef1.Location = new Point(764, 602);
            txtBoxCoef1.Margin = new Padding(3, 2, 3, 2);
            txtBoxCoef1.Name = "txtBoxCoef1";
            txtBoxCoef1.Size = new Size(159, 26);
            txtBoxCoef1.TabIndex = 27;
            txtBoxCoef1.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(716, 602);
            label1.Name = "label1";
            label1.Size = new Size(41, 24);
            label1.TabIndex = 26;
            label1.Text = "C = ";
            // 
            // week2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 911);
            Controls.Add(txtBoxCoef1);
            Controls.Add(label1);
            Controls.Add(btnInvert);
            Controls.Add(txtBoxGamma);
            Controls.Add(txtBoxCoef2);
            Controls.Add(txtBoxThreshold);
            Controls.Add(btnGrayScale1);
            Controls.Add(btnOpenPic);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(btnPowerLaw);
            Controls.Add(btnLogTransform);
            Controls.Add(btnNegative);
            Controls.Add(btnBlackWhite);
            Controls.Add(button3);
            Controls.Add(btnOrigin);
            Margin = new Padding(3, 5, 3, 5);
            Name = "week2";
            Text = "Week 2";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrigin;
        private Button button3;
        private Button btnBlackWhite;
        private Button btnNegative;
        private Button btnLogTransform;
        private Button btnPowerLaw;
        private Button button10;
        private Button button11;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnOpenPic;
        private Button btnGrayScale1;
        private TextBox txtBoxThreshold;
        private TextBox txtBoxCoef2;
        private TextBox txtBoxGamma;
        private Button btnInvert;
        private TextBox txtBoxCoef1;
        private Label label1;
    }
}

