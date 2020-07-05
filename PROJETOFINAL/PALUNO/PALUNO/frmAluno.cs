using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PALUNO
{
    public partial class frmAluno : Form
    {
        private BindingSource bnAluno = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsAluno = new DataSet();
        private DataSet dsCidade = new DataSet();

        public frmAluno()
        {
            InitializeComponent();
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            try
            {

                Aluno Alu = new Aluno();
                dsAluno.Tables.Add(Alu.Listar());
                bnAluno.DataSource = dsAluno.Tables["TBALUNO"];
                dgvAluno.DataSource = bnAluno;
                bnvAluno.BindingSource = bnAluno;

                txtRa.DataBindings.Add("TEXT", bnAluno, "RA_ALUNO");
                txtNomeAluno.DataBindings.Add("TEXT", bnAluno, "NOME_ALUNO");

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());

                cbxCidade.DataSource = dsCidade.Tables["TBCIDADE"];

                //CAMPO QUE SERÁ MOSTRADO PARA O USUÁRIO

                cbxCidade.DisplayMember = "NOME_CIDADE";

                //CAMPO QUE É A CHAVE DA TABELA CIDADE E QUE LIGA COM A TABELA ALUNO

                cbxCidade.ValueMember = "ID_CIDADE";

                //NO MOMENTO DE LINKAR OS COMPONENTES COM O BINDING SOURCE LINKAR TAMBÉM

                cbxCidade.DataBindings.Add("SelectedValue", bnAluno, "CIDADE_ID_CIDADE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }

            bnAluno.AddNew();
            txtRa.Enabled = true;
            txtNomeAluno.Enabled = true;
            cbxCidade.Enabled = true;
            cbxCidade.SelectedIndex = 0;
            txtNomeAluno.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true; ;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }


            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Aluno RegAlu = new Aluno();

                RegAlu.RaAluno = Convert.ToInt16(txtRa.Text);
                RegAlu.NomeAluno = txtNomeAluno.Text;
                RegAlu.Cidade = Convert.ToInt32(cbxCidade.SelectedValue);

                if (RegAlu.Excluir() > 0)
                {
                    MessageBox.Show("Aluno excluído com sucesso!");
                    Aluno R = new Aluno();
                    dsAluno.Tables.Clear();
                    dsAluno.Tables.Add(R.Listar());
                    bnAluno.DataSource = dsAluno.Tables["TBALUNO"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir aluno!");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados
            if (txtNomeAluno.Text == "")
            {
                MessageBox.Show("Aluno inválido!");
            }
            else
            {
                Aluno RegAlu = new Aluno();

                RegAlu.RaAluno = Convert.ToInt32(txtRa.Text);
                RegAlu.NomeAluno = txtNomeAluno.Text;
                RegAlu.Cidade = Convert.ToInt32(cbxCidade.SelectedValue);

                if (bInclusao)
                {
                    if (RegAlu.Salvar() > 0)
                    {
                        MessageBox.Show("Aluno adicionado com sucesso!");

                        btnSalvar.Enabled = false;
                        txtRa.Enabled = false;
                        txtNomeAluno.Enabled = false;
                        cbxCidade.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAlu.Listar());
                        bnAluno.DataSource = dsAluno.Tables["TBALUNO"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar aluno!");
                    }
                }
                else
                {
                    if (RegAlu.Alterar() > 0)
                    {
                        MessageBox.Show("Aluno alterado com sucesso!");

                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAlu.Listar());
                        txtRa.Enabled = false;
                        txtNomeAluno.Enabled = false;
                        cbxCidade.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar aluno!");
                    }

                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }

            txtNomeAluno.Enabled = true;
            cbxCidade.Enabled = true;
            txtNomeAluno.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnAluno.CancelEdit();

            btnSalvar.Enabled = false;
            txtNomeAluno.Enabled = false;
            cbxCidade.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
