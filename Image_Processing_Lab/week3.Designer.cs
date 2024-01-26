namespace Image_Processing_Lab
{
    partial class week3
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
            pictBoxOriginal = new PictureBox();
            pictBoxGray = new PictureBox();
            btnLoad = new Button();
            btnConvertToGray = new Button();
            brnSave = new Button();
            lblX = new Label();
            lblY = new Label();
            lblValue = new Label();
            ((System.ComponentModel.ISupportInitialize)pictBoxOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxGray).BeginInit();
            SuspendLayout();
            // 
            // pictBoxOriginal
            // 
            pictBoxOriginal.BorderStyle = BorderStyle.FixedSingle;
            pictBoxOriginal.Location = new Point(21, 19);
            pictBoxOriginal.Name = "pictBoxOriginal";
            pictBoxOriginal.Size = new Size(458, 373);
            pictBoxOriginal.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBoxOriginal.TabIndex = 0;
            pictBoxOriginal.TabStop = false;
            pictBoxOriginal.MouseMove += pictBoxOriginal_MouseMove;
            // 
            // pictBoxGray
            // 
            pictBoxGray.BorderStyle = BorderStyle.FixedSingle;
            pictBoxGray.Location = new Point(485, 19);
            pictBoxGray.Name = "pictBoxGray";
            pictBoxGray.Size = new Size(458, 373);
            pictBoxGray.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBoxGray.TabIndex = 1;
            pictBoxGray.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(19, 484);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(228, 45);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnConvertToGray
            // 
            btnConvertToGray.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvertToGray.Location = new Point(361, 484);
            btnConvertToGray.Name = "btnConvertToGray";
            btnConvertToGray.Size = new Size(228, 45);
            btnConvertToGray.TabIndex = 3;
            btnConvertToGray.Text = "Convert to Gray";
            btnConvertToGray.UseVisualStyleBackColor = true;
            btnConvertToGray.Click += btnConvertToGray_Click;
            // 
            // brnSave
            // 
            brnSave.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            brnSave.Location = new Point(713, 484);
            brnSave.Name = "brnSave";
            brnSave.Size = new Size(228, 45);
            brnSave.TabIndex = 4;
            brnSave.Text = "Save";
            brnSave.UseVisualStyleBackColor = true;
            brnSave.Click += brnSave_Click;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblX.Location = new Point(289, 425);
            lblX.Name = "lblX";
            lblX.Size = new Size(44, 25);
            lblX.TabIndex = 5;
            lblX.Text = "x = ";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblY.Location = new Point(430, 425);
            lblY.Name = "lblY";
            lblY.Size = new Size(44, 25);
            lblY.TabIndex = 6;
            lblY.Text = "y = ";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblValue.Location = new Point(569, 425);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(79, 25);
            lblValue.TabIndex = 7;
            lblValue.Text = "value = ";
            // 
            // week3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 550);
            Controls.Add(lblValue);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Controls.Add(brnSave);
            Controls.Add(btnConvertToGray);
            Controls.Add(btnLoad);
            Controls.Add(pictBoxGray);
            Controls.Add(pictBoxOriginal);
            Name = "week3";
            Text = "Week 3";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictBoxOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxGray).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictBoxOriginal;
        private PictureBox pictBoxGray;
        private Button btnLoad;
        private Button btnConvertToGray;
        private Button brnSave;
        private Label lblX;
        private Label lblY;
        private Label lblValue;
    }
}