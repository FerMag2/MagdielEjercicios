using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventanita
{
    public partial class Form1 : Form
    {
        double total;
        public Form1()
        {
            InitializeComponent();
            total = 0;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {

            double temporal=0.0;
            var r = Double.TryParse(txttexto.Text.Trim(),out temporal);
            if (r)
            {
                txttexto.Text= "";

                total += temporal;

            }
            else
            {
                MessageBox.Show("Debe ser un valor numerico");
                txttexto.Text = "";
            }
            
        }

        private void igual_Click(object sender, EventArgs e)
        {
            Resultado.AppendText(total.ToString());
        }
    }
}
