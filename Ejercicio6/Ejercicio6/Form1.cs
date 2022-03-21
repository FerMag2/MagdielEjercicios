using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Graphics papel2;
            papel2 = pictureBox2.CreateGraphics();
            Pen lapiz2 = new Pen(Color.Peru);
            papel2.DrawEllipse(lapiz2, 30, 50, 100, 100);
 
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            int x2 = pictureBox2.Location.X;
            int y2 = pictureBox2.Location.Y;

            if (e.KeyChar == 'a' || e.KeyChar == 'A')
            {
                x -= 10;
            }
            if (e.KeyChar == 'd' || e.KeyChar == 'D')
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
            if ((pictureBox2.Location.X >= pictureBox1.Location.X) && ((pictureBox2.Location.X + 50) <= (pictureBox1.Location.X + 100)) && (pictureBox2.Location.Y >= pictureBox1.Location.Y) && ((pictureBox2.Location.Y + 50) <= (pictureBox1.Location.Y + 100)))
            {
                x2 = 150;
                y2 = 150;
                Point punto2 = new Point(x2, y2);
                pictureBox2.Location = punto2;
            }

        }
    }
}
