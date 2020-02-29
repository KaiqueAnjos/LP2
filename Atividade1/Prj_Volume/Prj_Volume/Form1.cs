using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Volume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtRaio.Clear();
            txtVolume.Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double raio, altura;
                if ((double.TryParse(txtRaio.Text, out raio) &&
                    double.TryParse(txtAltura.Text, out altura)))
                {
                    double calc = Math.PI * Math.Pow(raio, raio) * altura;
                    txtVolume.Text = calc.ToString("N2");
                }
	{
		 
	}
        }
    }
}
