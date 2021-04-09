using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_editor
{
    public class ImageEditor
    {
        Bitmap image = null;
        Color brushColor = Color.White;
        int brushRadius;
       
        public Bitmap Image { get => image; }
        public int BrushRadius { get => brushRadius; }
        public Color BrushColor { get => BrushColor; }
        public ImageEditor()
        {
            image = new Bitmap(1024, 1024);
            for (int i = 0; i < 1024; i++)
            {
                for(int j = 0; j < 1024; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
                }
            }
            brushRadius = 30;
        }
        public ImageEditor(int widht, int heidth)
        {
            image = new Bitmap(widht, heidth);
            for (int i = 0; i < widht; i++)
            {
                for (int j = 0; j < heidth; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
                }
            }
            brushRadius = 30;
        }
        public void SetBrushColor(Color color)
        {
            brushColor = color;
        }
        public void SetBrushRadius(int radius)
        {
            brushRadius = radius;
        }

        public void LoadImage(string ImagePath)
        {
            image = new Bitmap(ImagePath);
        }

        public Point ConvertCoordinates(PictureBox pic, int x, int y)
        {
            Point res = new Point(x, y);

            if (pic != null && pic.Image != null)
            {
                int picHgt = pic.ClientSize.Height;
                int picWid = pic.ClientSize.Width;
                int imgHgt = pic.Image.Height;
                int imgWid = pic.Image.Width;

                float picAspect = picWid / (float)picHgt;
                float imgAspect = imgWid / (float)imgHgt;
                if (picAspect > imgAspect)
                {
                    res.Y = (int)(imgHgt * y / (float)picHgt);
                    float scaled_width = imgWid * picHgt / imgHgt;
                    float dx = (picWid - scaled_width) / 2;
                    res.X = (int)((x - dx) * imgHgt / (float)picHgt);
                }
                else
                {
                    res.X = (int)(imgWid * x / (float)picWid);
                    float scaled_height = imgHgt * picWid / imgWid;
                    float dy = (picHgt - scaled_height) / 2;
                    res.Y = (int)((y - dy) * imgWid / picWid);
                }

                if (res.X < 0)
                    res.X = 0;

                if (res.Y < 0)
                    res.Y = 0;

                if (res.X >= image.Width)
                    res.X = image.Width - 1;

                if (res.Y >= image.Height)
                    res.Y = image.Height - 1;
            }

            return res;
        }
    }
}
