using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for (var x = 0; x < txtTexto.Text.Length -1; x++)
            {
                if (Char.IsNumber(txtTexto.Text[x]))
                {
                    contador += 1;
                }
            }

            MessageBox.Show("Caracteres Numéricos:" + contador);
        }

        private void btnAlfabetico_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (char c in txtTexto.Text)
            {
                if (Char.IsLetter(c))
                {
                    contador += 1;
                }
            }
            MessageBox.Show("Caracteres Alfabéticos:" + contador);
        }

        private void btnBranco_Click_1(object sender, EventArgs e)
        {
            int x = 0;

            while (x < txtTexto.Text.Length)
            {
                if (Char.IsWhiteSpace(txtTexto.Text[x]))
                {
                    MessageBox.Show("Primeiro Caracter Branco :" + (x + 1));
                    break;
                }
                x += 1;
            }
        }
    }
}
