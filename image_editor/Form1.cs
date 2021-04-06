using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_editor
{
    public struct CrNewDialogRes
    {
        public int width;
        public int heidth;
        public bool ready;
    }
    public partial class F_Form1 : Form
    {
        public static bool ImageFieldOpened = false;
        F_draw imageField = null;
        Bitmap image = null;

        public static ImageEditor imageEditor = new ImageEditor();
        public static CrNewDialogRes diagRes = new CrNewDialogRes();
        public F_Form1()
        {
            InitializeComponent();
            panel2.BackColor = Color.White;
            CreateField();
            openFileDialog1.Filter = "All files (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";
            saveFileDialog1.Filter = "All files (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";
        }

        
        private void mb_createNew_Click(object sender, EventArgs e)
        {
            F_CreateNewElementForm createNewElementForm = new F_CreateNewElementForm();
            createNewElementForm.ShowDialog();
            if (diagRes.ready)
            {
                imageEditor = new ImageEditor(diagRes.width, diagRes.heidth);
                imageField.Refresh();
                panel2.BackColor = Color.White;
                numericUpDown1.Value = 30;
            }
        }
        public void CreateField()
        {
            imageField = new F_draw();
            imageField.MdiParent = this;
            imageField.Show();
            ImageFieldOpened = true;
        }

        private void mb_OpenWDraw_Click(object sender, EventArgs e)
        {
            if (!ImageFieldOpened)
            {
                CreateField();
            }
        }

        private void mb_CloseWDraw_Click(object sender, EventArgs e)
        {
            if (ImageFieldOpened)
            {
                imageField.Close();
                ImageFieldOpened = false;
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel2.BackColor = colorDialog1.Color;
                imageEditor.SetBrushColor(colorDialog1.Color);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            imageEditor.SetBrushRadius(Convert.ToInt32(numericUpDown1.Value));
        }



        private void mb_load_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                imageEditor.LoadImage(filePath);
                imageField.Refresh();
            }
        }

        private void mb_saveAs_Click(object sender, EventArgs e)
        {
            
        }
    }
}
