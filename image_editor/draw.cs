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
    }
}
