using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDescontosSalario
{
    public partial class Form1 : Form
    {
        double salarioBruto, filho, descINSS, descIRPF, salarioFamilia, salarioLiq;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            

            if ((double.TryParse(txtSalBruto.Text, out salarioBruto) &&
                double.TryParse(txtNFilhos.Text, out filho)))
            {
                if (salarioBruto <= 800.47)
                {
                    txtAliqINSS.Text = "7,65%";
                    descINSS = (7.65 / 100) * salarioBruto;
                    txtDescINSS.Text = descINSS.ToString("N2");
                }
                else if (salarioBruto <= 1050)
                {
                    txtAliqINSS.Text = "8,65%";
                    descINSS = (8.65 / 100) * salarioBruto;
                    txtDescINSS.Text = descINSS.ToString("N2");
                }
                else if (salarioBruto <= 1400.77)
                {
                    txtAliqINSS.Text = "9,00%";
                    descINSS = (9.00 / 100) * salarioBruto;
                    txtDescINSS.Text = descINSS.ToString("N2");
                }
                else if (salarioBruto <=2801.56)
                {
                    txtAliqINSS.Text = "11,00%";
                    descINSS = (11.00 / 100) * salarioBruto;
                    txtDescINSS.Text = descINSS.ToString("N2");
                }
                else if (salarioBruto > 2801.56)
                {
                    txtAliqINSS.Text = "308,17";
                    descINSS = 308.17;
                    txtDescINSS.Text = descINSS.ToString("N2");
                }



                if (salarioBruto <= 1257.12)
                {
                    txtAliqIRPF.Text = "0";
                    descIRPF = 0;
                    txtDescIRPF.Text = descIRPF.ToString("N2");
                }
                else if (salarioBruto <= 2512.08)
                {
                    txtAliqIRPF.Text = "15,00%";
                    descIRPF = (15.00 / 100) * salarioBruto;
                    txtDescIRPF.Text = descIRPF.ToString("N2");
                }
                else if (salarioBruto > 2512.08)
                {
                    txtAliqIRPF.Text = "27,50%";
                    descIRPF = (27.50 / 100) * salarioBruto;
                    txtDescIRPF.Text = descIRPF.ToString("N2");
                }



                if (salarioBruto <= 435.52)
                {
                    salarioFamilia = 22.33 * filho;
                    txtSalFami.Text = salarioFamilia.ToString("N2");
                }
                else if (salarioBruto <= 654.61)
                {
                    salarioFamilia = 15.74 * filho;
                    txtSalFami.Text = salarioFamilia.ToString("N2");
                }
                else
                {
                    salarioFamilia = 0;
                    txtSalFami.Text = salarioFamilia.ToString("N2");
                }

            }
            else
            {
                MessageBox.Show("Informe Salário e/ou número de filhos válidos");
                return;
            }

            if (rbMasculino.Checked)
            {
                if (cbCasado.Checked)
                {
                    txtDados.Text = "Os descontos do Salário do Funcionário," +
                        txtNome.Text + ", que é Casado e que tem " + txtNFilhos.Text + 
                                    " filhos, são:";
                }
                else
                {
                    txtDados.Text = "Os descontos do Salário do Funcionário," +
                        txtNome.Text + ", que é Solteiro e que tem " + txtNFilhos.Text +
                                    " filhos, são:";
                }

            }
            if (rbFeminino.Checked)
            {
                if (cbCasado.Checked)
                {
                    txtDados.Text = "Os descontos do Salário da Funcionária," +
                        txtNome.Text + ", que é Casada e que tem " + txtNFilhos.Text +
                                    " filhos, são:";
                }
                else
                {
                    txtDados.Text = "Os descontos do Salário da Funcionária," +
                        txtNome.Text + ", que é Solteira e que tem " + txtNFilhos.Text +
                                    " filhos, são:";
                }
            }

            salarioLiq = salarioBruto - descINSS - descIRPF + salarioFamilia;
            txtSalLiq.Text = salarioLiq.ToString("N2");

        }
    }
}
