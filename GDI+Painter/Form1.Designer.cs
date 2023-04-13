namespace GDI_Painter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnDrawLine = new Button();
            btnDrawEllipse = new Button();
            btnDrawRectangle = new Button();
            btnFillRectangle = new Button();
            btnDrawFillEllipse = new Button();
            BtnSave = new Button();
            btnPenSettings = new Button();
            btnBrushSettings = new Button();
            PenWidthCounter = new NumericUpDown();
            TransCounter = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PenWidthCounter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransCounter).BeginInit();
            SuspendLayout();
            // 
            // btnDrawLine
            // 
            btnDrawLine.BackgroundImage = Properties.Resources.DrawLine;
            btnDrawLine.Location = new Point(12, 12);
            btnDrawLine.Name = "btnDrawLine";
            btnDrawLine.Size = new Size(80, 72);
            btnDrawLine.TabIndex = 0;
            btnDrawLine.Text = "Draw Line";
            btnDrawLine.UseVisualStyleBackColor = true;
            btnDrawLine.Click += btnDrawLine_Click;
            // 
            // btnDrawEllipse
            // 
            btnDrawEllipse.BackgroundImage = Properties.Resources.Ellipse;
            btnDrawEllipse.Location = new Point(98, 12);
            btnDrawEllipse.Name = "btnDrawEllipse";
            btnDrawEllipse.Size = new Size(80, 72);
            btnDrawEllipse.TabIndex = 1;
            btnDrawEllipse.Text = "Draw Ellipse";
            btnDrawEllipse.UseVisualStyleBackColor = true;
            btnDrawEllipse.Click += btnDrawEllipse_Click;
            // 
            // btnDrawRectangle
            // 
            btnDrawRectangle.BackgroundImage = Properties.Resources.Rectangle;
            btnDrawRectangle.Location = new Point(184, 12);
            btnDrawRectangle.Name = "btnDrawRectangle";
            btnDrawRectangle.Size = new Size(80, 72);
            btnDrawRectangle.TabIndex = 2;
            btnDrawRectangle.Text = "Draw Rectangle";
            btnDrawRectangle.UseVisualStyleBackColor = true;
            btnDrawRectangle.Click += btnDrawRectangle_Click;
            // 
            // btnFillRectangle
            // 
            btnFillRectangle.BackgroundImage = Properties.Resources.FillRectangle;
            btnFillRectangle.Location = new Point(270, 12);
            btnFillRectangle.Name = "btnFillRectangle";
            btnFillRectangle.Size = new Size(80, 72);
            btnFillRectangle.TabIndex = 3;
            btnFillRectangle.Text = "Fill Rectangle";
            btnFillRectangle.UseVisualStyleBackColor = true;
            btnFillRectangle.Click += btnFillRectangle_Click;
            // 
            // btnDrawFillEllipse
            // 
            btnDrawFillEllipse.BackgroundImage = Properties.Resources.FillEllipse;
            btnDrawFillEllipse.Location = new Point(356, 12);
            btnDrawFillEllipse.Name = "btnDrawFillEllipse";
            btnDrawFillEllipse.Size = new Size(80, 72);
            btnDrawFillEllipse.TabIndex = 4;
            btnDrawFillEllipse.Text = "FillEllipse";
            btnDrawFillEllipse.UseVisualStyleBackColor = true;
            btnDrawFillEllipse.Click += btnDrawFillEllipse_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.Red;
            BtnSave.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSave.ForeColor = SystemColors.Control;
            BtnSave.Location = new Point(906, 12);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(183, 72);
            BtnSave.TabIndex = 5;
            BtnSave.Text = "Save Image";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // btnPenSettings
            // 
            btnPenSettings.BackgroundImage = (Image)resources.GetObject("btnPenSettings.BackgroundImage");
            btnPenSettings.Location = new Point(568, 12);
            btnPenSettings.Name = "btnPenSettings";
            btnPenSettings.Size = new Size(80, 72);
            btnPenSettings.TabIndex = 6;
            btnPenSettings.Text = "Pen Settings";
            btnPenSettings.UseVisualStyleBackColor = true;
            btnPenSettings.Click += btnPenSettings_Click;
            // 
            // btnBrushSettings
            // 
            btnBrushSettings.BackColor = Color.FromArgb(0, 0, 192);
            btnBrushSettings.BackgroundImage = (Image)resources.GetObject("btnBrushSettings.BackgroundImage");
            btnBrushSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrushSettings.ForeColor = Color.DarkMagenta;
            btnBrushSettings.Location = new Point(761, 12);
            btnBrushSettings.Name = "btnBrushSettings";
            btnBrushSettings.Size = new Size(80, 72);
            btnBrushSettings.TabIndex = 7;
            btnBrushSettings.Text = "Brush Settings";
            btnBrushSettings.UseVisualStyleBackColor = false;
            btnBrushSettings.Click += btnBrushSettings_Click;
            // 
            // PenWidthCounter
            // 
            PenWidthCounter.Location = new Point(472, 61);
            PenWidthCounter.Name = "PenWidthCounter";
            PenWidthCounter.Size = new Size(64, 23);
            PenWidthCounter.TabIndex = 8;
            // 
            // TransCounter
            // 
            TransCounter.Location = new Point(666, 61);
            TransCounter.Name = "TransCounter";
            TransCounter.Size = new Size(64, 23);
            TransCounter.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(462, 12);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 10;
            label1.Text = "Pen Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(654, 12);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 11;
            label2.Text = "Transparency";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 728);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TransCounter);
            Controls.Add(PenWidthCounter);
            Controls.Add(btnBrushSettings);
            Controls.Add(btnPenSettings);
            Controls.Add(BtnSave);
            Controls.Add(btnDrawFillEllipse);
            Controls.Add(btnFillRectangle);
            Controls.Add(btnDrawRectangle);
            Controls.Add(btnDrawEllipse);
            Controls.Add(btnDrawLine);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Paint += Form1_Paint;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)PenWidthCounter).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransCounter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDrawLine;
        private Button btnDrawEllipse;
        private Button btnDrawRectangle;
        private Button btnFillRectangle;
        private Button btnDrawFillEllipse;
        private Button BtnSave;
        private Button btnPenSettings;
        private Button btnBrushSettings;
        private NumericUpDown PenWidthCounter;
        private NumericUpDown TransCounter;
        private Label label1;
        private Label label2;
    }
}