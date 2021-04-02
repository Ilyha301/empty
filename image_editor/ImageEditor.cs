using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
