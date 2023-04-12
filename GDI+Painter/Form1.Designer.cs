﻿namespace GDI_Painter
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
            btnDrawLine = new Button();
            btnDrawEllipse = new Button();
            btnDrawRectangle = new Button();
            btnFillRectangle = new Button();
            btnDrawFillEllipse = new Button();
            BtnSave = new Button();
            SuspendLayout();
            // 
            // btnDrawLine
            // 
            btnDrawLine.BackgroundImage = Properties.Resources.DrawLine;
            btnDrawLine.Location = new Point(70, 12);
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
            btnDrawEllipse.Location = new Point(175, 12);
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
            btnDrawRectangle.Location = new Point(280, 12);
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
            btnFillRectangle.Location = new Point(385, 12);
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
            btnDrawFillEllipse.Location = new Point(490, 12);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 728);
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
            ResumeLayout(false);
        }

        #endregion

        private Button btnDrawLine;
        private Button btnDrawEllipse;
        private Button btnDrawRectangle;
        private Button btnFillRectangle;
        private Button btnDrawFillEllipse;
        private Button BtnSave;
    }
}