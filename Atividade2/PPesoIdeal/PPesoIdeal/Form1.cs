using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double peso, altura, pesoIdeal;
            if ((double.TryParse(txtPesoAtual.Text, out peso) &&
                 double.TryParse(txtAltura.Text, out altura)))
            {
                
                if (rbMasculino.Checked)
                {
                    pesoIdeal = (72.7 * altura) - 58;
                    pesoIdeal = Math.Round(pesoIdeal, 2);
                    txtPesoIdeal.Text = pesoIdeal.ToString("N2");

                    if (peso > pesoIdeal)
                    {
                        txtSituacao.Text = "Regime Obrigatório Já!!";
                    }
                    else if(peso < pesoIdeal)
                    {
                        txtSituacao.Text = "Coma Bastante Massas e Doces!!";
                    }
                    else
                    {
                        txtSituacao.Text = "Você está no peso Ideal!!";
                    }
                }

                else if (rbFeminino.Checked)
                {
                    pesoIdeal = (62.1 * altura) - 58;
                    pesoIdeal = Math.Round(pesoIdeal, 2);
                    txtPesoIdeal.Text = pesoIdeal.ToString("N2");

                    if (peso > pesoIdeal)
                    {
                        txtSituacao.Text = "Regime Obrigatório Já!!";
                    }
                    else if (peso < pesoIdeal)
                    {
                        txtSituacao.Text = "Coma Bastante Massas e Doces!!";
                    }
                    else
                    {
                        txtSituacao.Text = "Você está no peso Ideal!!";
                    }
                }
                else
                {
                    MessageBox.Show("INFORME O SEXO!");
                }
            }
            else
            {
                MessageBox.Show("Informe uma altura e/ou peso válidos");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPesoAtual.Clear();
            txtPesoIdeal.Clear();
            txtSituacao.Clear();
            rbMasculino.Checked = false;
            rbFeminino.Checked = false;
        }



    }

        
}

