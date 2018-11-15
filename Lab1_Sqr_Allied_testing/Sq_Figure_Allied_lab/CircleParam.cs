using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sq_Figure_Allied_lab
{
    public partial class CircleParam : Form
    {
        string s;
        double r,r2;
        double PI = 3.14;

        
        public CircleParam()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
            r = Convert.ToDouble(s);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
   

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
              
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            r2 = (r * r) * PI;
            textBox2.Text = Convert.ToString(r2);
        }
    }
}
