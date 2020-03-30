using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLadosTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if ((double.TryParse(txtA.Text, out a) &&
                 double.TryParse(txtB.Text, out b) &&
                 double.TryParse(txtC.Text, out c)))
            {
                if (Math.Abs(b-c) < a && a < (b+c) && Math.Abs(a-c) < b &&
                    b < (a+c) && Math.Abs(a-b) < c && c < (a+b))
                {
                    MessageBox.Show("Valores pertencem aos lados de um triângulo");
                    if(a == b && b == c)
                    {
                        MessageBox.Show("Triângulo Equilátero");
                    }
                    else
                    if (a == b && b != c || a == c && c != b || b == c && c != a)
                    {
                        MessageBox.Show("Triângulo Isosceles");
                    }
                    else
                    if (a != b && b != c && a != c)
                    {
                        MessageBox.Show("Triângulo Escaleno");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Valores não pertencem aos lados de um triângulo");
                }
            }
            else
            {
                MessageBox.Show("Informe apenas valores válidos");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
        }
    }
}
