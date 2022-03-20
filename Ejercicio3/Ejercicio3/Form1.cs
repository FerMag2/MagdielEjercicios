using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length <= 0) return;
            char last = txt.Text[txt.Text.Length-1];
            bool isRigth = Double.TryParse(txt.Text, out _);
            if (!isRigth)
            {
                MessageBox.Show("Dato no valido");
                string res = "";
                for(int i = 0; i < txt.Text.Length; i++)
                {
                    switch (txt.Text[i])
                    {
                        case '.':
                        case '0':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                            res += txt.Text[i];
                            break;

                    }
         
                }
                txt.Text = res;
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&& !(e.KeyChar=='.'));
            {
                e.Handled = false;
            }
        }
    }
}
