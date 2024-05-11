namespace WinFormsApp1
{
    partial class Form1
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
            splitContainer1 = new SplitContainer();
            BStop = new Button();
            BStart = new Button();
            label2 = new Label();
            NumDensity = new NumericUpDown();
            label1 = new Label();
            NumResolution = new NumericUpDown();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumDensity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumResolution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BStop);
            splitContainer1.Panel1.Controls.Add(BStart);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(NumDensity);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(NumResolution);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 137;
            splitContainer1.TabIndex = 0;
            // 
            // BStop
            // 
            BStop.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BStop.Location = new Point(3, 151);
            BStop.Name = "BStop";
            BStop.Size = new Size(75, 39);
            BStop.TabIndex = 6;
            BStop.Text = "Stop";
            BStop.UseVisualStyleBackColor = true;
            BStop.Click += BStop_Click;
            // 
            // BStart
            // 
            BStart.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BStart.Location = new Point(0, 101);
            BStart.Name = "BStart";
            BStart.Size = new Size(75, 34);
            BStart.TabIndex = 5;
            BStart.Text = "start";
            BStart.UseVisualStyleBackColor = true;
            BStart.Click += BStart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(-2, 49);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Density";
            // 
            // NumDensity
            // 
            NumDensity.Location = new Point(0, 72);
            NumDensity.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            NumDensity.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            NumDensity.Name = "NumDensity";
            NumDensity.Size = new Size(120, 23);
            NumDensity.TabIndex = 3;
            NumDensity.TextAlign = HorizontalAlignment.Right;
            NumDensity.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 6);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "resolution";
            // 
            // NumResolution
            // 
            NumResolution.Location = new Point(3, 29);
            NumResolution.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            NumResolution.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            NumResolution.Name = "NumResolution";
            NumResolution.Size = new Size(120, 23);
            NumResolution.TabIndex = 1;
            NumResolution.TextAlign = HorizontalAlignment.Right;
            NumResolution.Value = new decimal(new int[] { 2, 0, 0, 0 });
            NumResolution.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(655, 446);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NumDensity).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumResolution).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private NumericUpDown NumResolution;
        private Label label2;
        private NumericUpDown NumDensity;
        private Label label1;
        private Button BStart;
        private PictureBox pictureBox1;
        internal Button BStop;
        private System.Windows.Forms.Timer timer1;
    }
}
