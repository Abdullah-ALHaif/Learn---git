using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X - 5, label1.Location.Y);
            if (label1.Location.X < 12)
            {
                label1.Location = new Point(12, label1.Location.Y);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X, label1.Location.Y-5);
            if (label1.Location.Y < 9)
            {
                label1.Location = new Point(label1.Location.X,9);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X, label1.Location.Y + 5);
            if (label1.Location.Y > 289)
            {
                label1.Location = new Point(label1.Location.X, 289);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X+5, label1.Location.Y);
            if (label1.Location.X > 307)
            {
                label1.Location = new Point(307, label1.Location.Y);
            }
        }
    }
}
