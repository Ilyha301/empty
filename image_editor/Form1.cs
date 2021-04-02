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

        public static ImageEditor imageEditor = new ImageEditor();
        public static CrNewDialogRes diagRes = new CrNewDialogRes();
        public F_Form1()
        {
            InitializeComponent();
            CreateField();
        }

        
        private void mb_createNew_Click(object sender, EventArgs e)
        {
            F_CreateNewElementForm createNewElementForm = new F_CreateNewElementForm();
            createNewElementForm.ShowDialog();
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
    }
}
