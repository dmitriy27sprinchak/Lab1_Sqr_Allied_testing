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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)                                   //Creating the calc form
            {                                                           //Better use switch
                TriangleParam fp = new TriangleParam();
                fp.ShowDialog();
            }

            else if (radioButton2.Checked || radioButton7.Checked)
            {
                SquareParam fp = new SquareParam();
                fp.ShowDialog();
            }

            else if (radioButton3.Checked)
                {
                    ParallelogrammParam fp = new ParallelogrammParam();
                    fp.ShowDialog();
                }

            else if (radioButton4.Checked)
            {
                TrapeziumParam fp = new TrapeziumParam();
                fp.ShowDialog();
            }

            else if (radioButton5.Checked)
            {
                RhombParam fp = new RhombParam();
                fp.ShowDialog();
            }

            else if (radioButton6.Checked)
            {
                ElipseParam fp = new ElipseParam();
                fp.ShowDialog();
            }

            else if (radioButton8.Checked)
            {
                CircleParam fp = new CircleParam();
                fp.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
