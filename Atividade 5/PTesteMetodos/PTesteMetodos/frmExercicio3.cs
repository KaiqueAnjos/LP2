﻿using System;
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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            int posicao;
            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            while (posicao >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                    txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length,
                    txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            /*string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = "";
            foreach (char c in arr)
                s = s + c.ToString();
            MessageBox.Show(s);*/

            //ou

            string ss = txtPalavra1.Text;
            char[] arr = ss.ToCharArray();
            Array.Reverse(arr);
            ss = new string(arr);
            MessageBox.Show(ss);

            //exemplo new string
            //string s1 = new string('a', 7);
        }
    }
}
