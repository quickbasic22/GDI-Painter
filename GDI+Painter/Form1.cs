using System.Collections;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;

namespace GDI_Painter
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap = null;
        private Bitmap curBitmap = null;
        private bool dragMode = false;
        private int drawIndex = 1;
        private int curX, curY, x, y;
        private int diffX, diffY;
        private Graphics curGraphics;
        private Pen curPen;
        private SolidBrush curBrush;
        private Size fullSize;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the full size of the form
            fullSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            // Create a bitmap using full size
            bitmap = new Bitmap(fullSize.Width, fullSize.Height);
            // Create a Graphics object from Bitmap
            curGraphics = Graphics.FromImage(bitmap);
            // Set background color as form's color
            curGraphics.Clear(this.BackColor);
            // Create a new pen and brush as 
            // default pen and brush
            curPen = new Pen(Color.DarkBlue, 15f);
            curBrush = new SolidBrush(Color.Indigo);
        }

        private void btnDrawRectangle_Click(object sender, EventArgs e)
        {
            drawIndex = 3;
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            drawIndex = 1;
        }

        private void btnDrawEllipse_Click(object sender, EventArgs e)
        {
            drawIndex = 2;
        }

        private void btnFillRectangle_Click(object sender, EventArgs e)
        {
            drawIndex = 4;
        }

        private void btnDrawFillEllipse_Click(object sender, EventArgs e)
        {
            drawIndex = 5;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Save file dialog
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.Filter =
                "Image files (*.bmp) |*.bmp|All files (*.*)|*.*";
            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                // Create bitmap and call Save method
                // to save it
                Bitmap tmpBitmap = bitmap.Clone(new Rectangle(0, 0, this.Width, this.Height), bitmap.PixelFormat);
                tmpBitmap.Save(saveFileDlg.FileName, ImageFormat.Bmp);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Store the starting point of
            // the rectangle and set the drag mode to true
            curX = e.X;
            curY = e.Y;
            dragMode = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Find out the ending point of
            // the rectangle and calculate the 
            // difference between starting and ending
            // points to find out the height and width
            // of the rectangle
            x = e.X;
            y = e.Y;
            diffX = e.X - curX;
            diffY = e.Y - curY;
            // If dragMode is true, call refresh
            // to force the window to repaint
            if (dragMode)
            {
                this.Refresh();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            diffX = x - curX;
            diffY = y - curY;
            switch (drawIndex)
            {
                case 1:
                    {
                        // Draw a line
                        curGraphics.DrawLine(curPen, curX, curY, x, y);
                        break;
                    }
                case 2:
                    {
                        // Draw an ellipse
                        curGraphics.DrawEllipse(curPen, curX, curY, diffX, diffY);
                        break;
                    }
                case 3:
                    {
                        // Draw a rectange
                        curGraphics.DrawRectangle(curPen, curX, curY, diffX, diffY);
                        break;
                    }
                case 4:
                    {
                        // Fill the rectangle
                        curGraphics.FillRectangle(curBrush, curX, curY, diffX, diffY);
                        break;
                    }
                    case 5:
                    {
                        // Fill the ellipse
                        curGraphics.FillEllipse(curBrush, curX, curY, diffX, diffY);
                        break;
                    }
            }
            // Refresh
            RefreshFormBackground();
            dragMode = false;
        }

        private void RefreshFormBackground()
        {
            curBitmap = bitmap.Clone(new Rectangle(0, 0, this.Width, this.Height), bitmap.PixelFormat);
            this.BackgroundImage = curBitmap;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // If dragMode is true, draw the selected graphics shape
            if (dragMode)
            {
                switch (drawIndex)
                {
                    case 1:
                        {
                            g.DrawLine(curPen, curX, curY, x, y);
                            break;
                        }
                    case 2:
                        {
                            g.DrawEllipse(curPen, curX, curY, diffX, diffY);
                            break;
                        }
                    case 3:
                        {
                            g.DrawRectangle(curPen, curX, curY, diffX, diffY);
                            break;
                        }
                    case 4:
                        {
                            g.FillRectangle(curBrush, curX, curY, diffX, diffY);
                            break;
                        }
                    case 5:
                        {
                            g.FillEllipse(curBrush, curX, curY, diffX, diffY);
                            break;
                        }
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Dispose of all public objects
            curPen.Dispose();
            curBrush.Dispose();
            curGraphics.Dispose();
        }
    }
}