using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp_for_Larning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cRectangel_Click(object sender, EventArgs e)
        {
            string text = Convert.ToString(rectangelDate.Text);
            string[] data = text.Split(',');
            int l = Convert.ToInt32(data[0]);
            int w = Convert.ToInt32(data[1]);
            int h = Convert.ToInt32(data[2]);

            geometric_shapes gsh = new geometric_shapes();
            gsh.Length = l;
            gsh.Width = w;
            gsh.Height = h;
        }
        private void CalRectangle_Click(object sender, EventArgs e)
        {
            
        }

        private void clearL_Click(object sender, EventArgs e)
        {
            textBoxRectangle.Text = "";
            textBoxCircle.Text = "";
            rectangelDate.Text = "";
            
        }

    }
}
