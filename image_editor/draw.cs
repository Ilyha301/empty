using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_editor
{
    public partial class F_draw : Form
    {
        Point currentPoint;
        
        public F_draw()
        {
            InitializeComponent();
        }

        public System.Drawing.Imaging.ImageFormat getFormat (string filePath)
        {
            string extension = Path.GetExtension(filePath);

            switch (extension)
            {
                case (".jpg"):
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                case (".jpeg"):
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                case (".png"):
                    return System.Drawing.Imaging.ImageFormat.Png;
                default:
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
            }
        }

        private void F_draw_FormClosed(object sender, FormClosedEventArgs e)
        {
            F_Form1.ImageFieldOpened = false;
        }

        private void F_draw_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Image = F_Form1.imageEditor.Image;
        }
        public void savePbImage(string filePath)
        {
            try
            {
                pictureBox1.Image.Save(filePath, getFormat(filePath));
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = F_Form1.imageEditor.ConvertCoordinates(pictureBox1, e.X, e.Y);
            textb_x.Text = Convert.ToString(currentPoint.X);
            textb_y.Text = Convert.ToString(currentPoint.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int brushRadius = F_Form1.imageEditor.BrushRadius;
            for (int i = currentPoint.X - brushRadius; i <= currentPoint.X + brushRadius; i++)
            {
                for(int j = currentPoint.Y - brushRadius; j <= currentPoint.Y + brushRadius; j++)
                {
                    double dist = Math.Sqrt(Math.Pow(i - currentPoint.X, 2) + Math.Pow(j - currentPoint.Y, 2));
                    if (dist <= brushRadius && i >= 0 && j >= 0
                        && i < F_Form1.imageEditor.Image.Width
                        && j < F_Form1.imageEditor.Image.Height)

                    F_Form1.imageEditor.Image.SetPixel(i, j, F_Form1.imageEditor.BrushColor);
                }
            }
            Invalidate();
        }
    }
}
