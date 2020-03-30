namespace PDescontosSalario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNFilhos = new System.Windows.Forms.Label();
            this.txtSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.txtNFilhos = new System.Windows.Forms.MaskedTextBox();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.cbCasado = new System.Windows.Forms.CheckBox();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblSalFam = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.lblDINSS = new System.Windows.Forms.Label();
            this.lblDIRPF = new System.Windows.Forms.Label();
            this.txtAliqINSS = new System.Windows.Forms.MaskedTextBox();
            this.txtAliqIRPF = new System.Windows.Forms.MaskedTextBox();
            this.txtSalFami = new System.Windows.Forms.MaskedTextBox();
            this.txtSalLiq = new System.Windows.Forms.MaskedTextBox();
            this.txtDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.txtDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.txtDados = new System.Windows.Forms.RichTextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.gpbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(31, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(96, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Funcionário:";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(31, 58);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(70, 13);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Salário Bruto:";
            // 
            // lblNFilhos
            // 
            this.lblNFilhos.AutoSize = true;
            this.lblNFilhos.Location = new System.Drawing.Point(31, 92);
            this.lblNFilhos.Name = "lblNFilhos";
            this.lblNFilhos.Size = new System.Drawing.Size(92, 13);
            this.lblNFilhos.TabIndex = 2;
            this.lblNFilhos.Text = "Número de Filhos:";
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Location = new System.Drawing.Point(133, 55);
            this.txtSalBruto.Mask = "9999.00";
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(129, 20);
            this.txtSalBruto.TabIndex = 5;
            this.txtSalBruto.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // txtNFilhos
            // 
            this.txtNFilhos.Location = new System.Drawing.Point(133, 89);
            this.txtNFilhos.Mask = "09";
            this.txtNFilhos.Name = "txtNFilhos";
            this.txtNFilhos.Size = new System.Drawing.Size(129, 20);
            this.txtNFilhos.TabIndex = 6;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbFeminino);
            this.gpbSexo.Controls.Add(this.rbMasculino);
            this.gpbSexo.Location = new System.Drawing.Point(339, 20);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(115, 100);
            this.gpbSexo.TabIndex = 7;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo:";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(6, 68);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 9;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(6, 34);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 8;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // cbCasado
            // 
            this.cbCasado.AutoSize = true;
            this.cbCasado.Location = new System.Drawing.Point(345, 137);
            this.cbCasado.Name = "cbCasado";
            this.cbCasado.Size = new System.Drawing.Size(62, 17);
            this.cbCasado.TabIndex = 10;
            this.cbCasado.Text = "Casado";
            this.cbCasado.UseVisualStyleBackColor = true;
            // 
            // btnDesconto
            // 
            this.btnDesconto.Location = new System.Drawing.Point(171, 173);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(144, 21);
            this.btnDesconto.TabIndex = 11;
            this.btnDesconto.Text = "Verificar Desconto";
            this.btnDesconto.UseVisualStyleBackColor = true;
            this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(22, 305);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(76, 13);
            this.lblINSS.TabIndex = 9;
            this.lblINSS.Text = "Aliquota INSS:";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Location = new System.Drawing.Point(22, 344);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(75, 13);
            this.lblIRPF.TabIndex = 10;
            this.lblIRPF.Text = "Aliquota IRPF:";
            // 
            // lblSalFam
            // 
            this.lblSalFam.AutoSize = true;
            this.lblSalFam.Location = new System.Drawing.Point(22, 379);
            this.lblSalFam.Name = "lblSalFam";
            this.lblSalFam.Size = new System.Drawing.Size(79, 13);
            this.lblSalFam.TabIndex = 11;
            this.lblSalFam.Text = "Salário Família:";
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Location = new System.Drawing.Point(22, 415);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(81, 13);
            this.lblSalLiq.TabIndex = 12;
            this.lblSalLiq.Text = "Salário Líquido:";
            // 
            // lblDINSS
            // 
            this.lblDINSS.AutoSize = true;
            this.lblDINSS.Location = new System.Drawing.Point(264, 305);
            this.lblDINSS.Name = "lblDINSS";
            this.lblDINSS.Size = new System.Drawing.Size(84, 13);
            this.lblDINSS.TabIndex = 13;
            this.lblDINSS.Text = "Desconto INSS:";
            // 
            // lblDIRPF
            // 
            this.lblDIRPF.AutoSize = true;
            this.lblDIRPF.Location = new System.Drawing.Point(264, 344);
            this.lblDIRPF.Name = "lblDIRPF";
            this.lblDIRPF.Size = new System.Drawing.Size(83, 13);
            this.lblDIRPF.TabIndex = 14;
            this.lblDIRPF.Text = "Desconto IRPF:";
            // 
            // txtAliqINSS
            // 
            this.txtAliqINSS.Enabled = false;
            this.txtAliqINSS.Location = new System.Drawing.Point(104, 302);
            this.txtAliqINSS.Name = "txtAliqINSS";
            this.txtAliqINSS.Size = new System.Drawing.Size(121, 20);
            this.txtAliqINSS.TabIndex = 15;
            // 
            // txtAliqIRPF
            // 
            this.txtAliqIRPF.Enabled = false;
            this.txtAliqIRPF.Location = new System.Drawing.Point(104, 341);
            this.txtAliqIRPF.Name = "txtAliqIRPF";
            this.txtAliqIRPF.Size = new System.Drawing.Size(121, 20);
            this.txtAliqIRPF.TabIndex = 16;
            // 
            // txtSalFami
            // 
            this.txtSalFami.Enabled = false;
            this.txtSalFami.Location = new System.Drawing.Point(104, 376);
            this.txtSalFami.Name = "txtSalFami";
            this.txtSalFami.Size = new System.Drawing.Size(121, 20);
            this.txtSalFami.TabIndex = 17;
            // 
            // txtSalLiq
            // 
            this.txtSalLiq.Enabled = false;
            this.txtSalLiq.Location = new System.Drawing.Point(104, 412);
            this.txtSalLiq.Name = "txtSalLiq";
            this.txtSalLiq.Size = new System.Drawing.Size(121, 20);
            this.txtSalLiq.TabIndex = 18;
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Enabled = false;
            this.txtDescINSS.Location = new System.Drawing.Point(354, 302);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.Size = new System.Drawing.Size(100, 20);
            this.txtDescINSS.TabIndex = 19;
            // 
            // txtDescIRPF
            // 
            this.txtDescIRPF.Enabled = false;
            this.txtDescIRPF.Location = new System.Drawing.Point(353, 341);
            this.txtDescIRPF.Name = "txtDescIRPF";
            this.txtDescIRPF.Size = new System.Drawing.Size(101, 20);
            this.txtDescIRPF.TabIndex = 20;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(133, 20);
            this.txtNome.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL" +
    "LLLLLLLLLLLLLLLLLLLLLLLL";
            this.txtNome.Name = "txtNome";
            this.txtNome.PromptChar = ' ';
            this.txtNome.Size = new System.Drawing.Size(129, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtDados
            // 
            this.txtDados.Enabled = false;
            this.txtDados.Location = new System.Drawing.Point(25, 224);
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(269, 58);
            this.txtDados.TabIndex = 22;
            this.txtDados.Text = "";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(24, 209);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(41, 13);
            this.lblDados.TabIndex = 23;
            this.lblDados.Text = "Dados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtDescIRPF);
            this.Controls.Add(this.txtDescINSS);
            this.Controls.Add(this.txtSalLiq);
            this.Controls.Add(this.txtSalFami);
            this.Controls.Add(this.txtAliqIRPF);
            this.Controls.Add(this.txtAliqINSS);
            this.Controls.Add(this.lblDIRPF);
            this.Controls.Add(this.lblDINSS);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblSalFam);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.cbCasado);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.txtNFilhos);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.lblNFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNFilhos;
        private System.Windows.Forms.MaskedTextBox txtSalBruto;
        private System.Windows.Forms.MaskedTextBox txtNFilhos;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.CheckBox cbCasado;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblSalFam;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label lblDINSS;
        private System.Windows.Forms.Label lblDIRPF;
        private System.Windows.Forms.MaskedTextBox txtAliqINSS;
        private System.Windows.Forms.MaskedTextBox txtAliqIRPF;
        private System.Windows.Forms.MaskedTextBox txtSalFami;
        private System.Windows.Forms.MaskedTextBox txtSalLiq;
        private System.Windows.Forms.MaskedTextBox txtDescINSS;
        private System.Windows.Forms.MaskedTextBox txtDescIRPF;
        private System.Windows.Forms.MaskedTextBox txtNome;
        private System.Windows.Forms.RichTextBox txtDados;
        private System.Windows.Forms.Label lblDados;
    }
}

