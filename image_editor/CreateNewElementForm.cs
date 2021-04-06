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
    public partial class F_CreateNewElementForm : Form
    {
        public F_CreateNewElementForm()
        {
            InitializeComponent();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            F_Form1.diagRes.width = Convert.ToInt32(num_widht.Value);
            F_Form1.diagRes.heidth = Convert.ToInt32(num_heigh.Value);
            F_Form1.diagRes.ready = true;
            this.Close();
        }

        private void b_otmen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
