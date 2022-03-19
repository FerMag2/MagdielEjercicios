using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Ventana : Form
    {
        Graphics g;
        int posMouseFormX, posMouseFormY;
        int posMouseBotonX, posMouseBotonY;
        int posActBotonX, posActBotonY;

        int posMouseFormOX, posMouseFormOY;
        int posMouseBotonOX, posMouseBotonOY;
        int posActBotonOX, posActBotonOY;

        int posMouseFormRX, posMouseFormRY;
        int posMouseBotonRX, posMouseBotonRY;
        int posActBotonRX, posActBotonRY;

        bool btnpresionado = false;

        private void Orange_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormRX = posActBotonRX + e.Location.X;
            posMouseFormRY = posActBotonRY + e.Location.Y;
            if (btnpresionado) moverBotonR();
        }

        private void Orange_MouseDown(object sender, MouseEventArgs e)
        {
            posMouseBotonRX = e.Location.X;
            posMouseBotonRY = e.Location.Y;
            btnpresionado = true;
        }

        private void Orange_MouseUp(object sender, MouseEventArgs e)
        {
            btnpresionado = false;
            if (posActBotonRX > 179 || posActBotonRY < 110)
            {
                Orange.Location = new System.Drawing.Point(458, 218);
            }
        }

        private void Blue_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormOX = posActBotonOX + e.Location.X;
            posMouseFormOY = posActBotonOY + e.Location.Y;
            if (btnpresionado) moverBotonO();
        }

        private void Ventana_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = e.Location.X;
            posMouseFormY = e.Location.Y;

            posMouseFormRX = e.Location.X;
            posMouseFormRY = e.Location.Y;

            posMouseFormOX = e.Location.X;
            posMouseFormOY = e.Location.Y;
        }

        private void Blue_MouseDown(object sender, MouseEventArgs e)
        {
            posMouseBotonOX = e.Location.X;
            posMouseBotonOY = e.Location.Y;
            btnpresionado = true;
        }

        private void Blue_MouseUp(object sender, MouseEventArgs e)
        {
            btnpresionado = false;
            if (posActBotonOX > 210 || posActBotonOY < 110)
            {
                Blue.Location = new System.Drawing.Point(450, 265);
            }
        }

        private void botonCircular_Click(object sender, EventArgs e)
        {
            if(botonCircular.BackColor == Color.Purple)
            {
                this.botonCircular.BackColor = System.Drawing.Color.LimeGreen;
            }
            else
            {
                this.botonCircular.BackColor = System.Drawing.Color.Purple;
            }
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Yellow_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = posActBotonX + e.Location.X;
            posMouseFormY = posActBotonY + e.Location.Y;
            if (btnpresionado) moverBoton();
        }

        public Ventana()
        {
            InitializeComponent();
        }

        private void Yellow_MouseDown(object sender, MouseEventArgs e)
        {
            posMouseBotonX = e.Location.X;
            posMouseBotonY = e.Location.Y;
            btnpresionado = true;
        }

        private void Yellow_MouseUp(object sender, MouseEventArgs e)
        {
            btnpresionado = false;
            if(posActBotonX > 242 || posActBotonY < 110)
            {
                Yellow.Location = new System.Drawing.Point(410, 220);
            }
        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            posActBotonX = Yellow.Location.X;
            posActBotonY = Yellow.Location.Y;

            posActBotonRX = Orange.Location.X;
            posActBotonRY = Orange.Location.Y;

            posActBotonOX = Blue.Location.X;
            posActBotonOY = Blue.Location.Y;
        }

        private void Ventana_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Point[] puntos = { new Point(350,260), new Point(485, 165), new Point(620,260), new Point(485,350)};
            g.DrawPolygon(Pens.Black, puntos);
        }

        private void moverBoton()
        {
            Yellow.Location = new System.Drawing.Point(posMouseFormX - posMouseBotonX, posMouseFormY - posMouseBotonY);
            posActBotonX = Yellow.Location.X;
            posActBotonY = Yellow.Location.Y;
        }

        private void moverBotonR()
        {
            Orange.Location = new System.Drawing.Point(posMouseFormRX - posMouseBotonRX, posMouseFormRY - posMouseBotonRY);
            posActBotonRX = Orange.Location.X;
            posActBotonRY = Orange.Location.Y;
        }

        private void moverBotonO()
        {
            Blue.Location = new System.Drawing.Point(posMouseFormOX - posMouseBotonOX, posMouseFormOY - posMouseBotonOY);
            posActBotonOX = Blue.Location.X;
            posActBotonOY = Blue.Location.Y;
        }
    }
}
