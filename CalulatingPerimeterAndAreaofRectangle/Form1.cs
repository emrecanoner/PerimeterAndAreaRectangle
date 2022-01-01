using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalulatingPerimeterAndAreaofRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float line1, line2, area, perimeter;

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            perimeter = 2 * (line1 + line2);
            MessageBox.Show("Perimeter of Rectangle: " + perimeter);
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            area = line1 * line2;
            MessageBox.Show("Area of Rectangle: " + area);
        }

        private void tboxLine2_TextChanged(object sender, EventArgs e)
        {
            line2 = float.Parse(tboxLine2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            line1 = float.Parse(tboxLine1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
