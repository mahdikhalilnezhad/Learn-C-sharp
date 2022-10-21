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
            string text = Convert.ToString(rectangelDate.Text);
            string[] data = text.Split(',');
            int l = Convert.ToInt32(data[0]);
            int w = Convert.ToInt32(data[1]);
            int h = Convert.ToInt32(data[2]);

            geometric_shapes gsh = new geometric_shapes();
            gsh.Length = l;
            gsh.Width = w;
            gsh.Height = h;

            double area = gsh.Length * gsh.Width;
            double space = area * gsh.Height;

            textBoxRectangle.Text = area.ToString() + " , " + space.ToString();
        }

        private void clearL_Click(object sender, EventArgs e)
        {
            textBoxRectangle.Text = "";
            rectangelDate.Text = "";
            
        }

        private void enum_test_Click(object sender, EventArgs e)
        {
            typeOfsahpe x = (typeOfsahpe)1;
            textBoxEnum_test.Text = x.ToString();
        }

        private void static_test_Click(object sender, EventArgs e)
        {
            geometric_shapes x = new geometric_shapes();
            geometric_shapes.districts = (typeOfsahpe)3;
            x.Height = 12;
            x.Length = 3;
            x.Width = 53;

            MessageBox.Show("districts is:" + geometric_shapes.districts);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = "VIII";
            Solution solution = new Solution();

            
            solution.S = text;


            MessageBox.Show(solution.RomanToInt(text).ToString());
        }
    }
}
