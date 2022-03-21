using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz1 = new Pen(Color.Peru);
            papel.DrawEllipse(lapiz1, 30, 50, 100, 100);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            if (e.KeyChar=='a' || e.KeyChar == 'A')
            {
                x -= 10;
            }
            if(e.KeyChar == 'd' || e.KeyChar == 'D')
            {
                x += 10;
            }
            if (e.KeyChar == 'w' || e.KeyChar == 'W')
            {
                y -= 10;
            }
            if (e.KeyChar == 's' || e.KeyChar == 'S')
            {
                y += 10;
            }
            Point punto = new Point(x, y);
            pictureBox1.Location = punto;
        }
    }
}
