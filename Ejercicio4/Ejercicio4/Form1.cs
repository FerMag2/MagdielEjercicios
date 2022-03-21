using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz1 = new Pen(Color.Peru);
            papel.DrawEllipse(lapiz1, 30,50,100,100);
        }
    }
}
