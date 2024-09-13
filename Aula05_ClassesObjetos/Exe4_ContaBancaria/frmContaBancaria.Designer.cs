
namespace Exe4_ContaBancaria
{
    partial class frmContaBancaria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaqueConta = new System.Windows.Forms.Button();
            this.btnDepositoConta = new System.Windows.Forms.Button();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLimiteEmprestimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCriarContaEmpresarial = new System.Windows.Forms.Button();
            this.btnContaPoupanca = new System.Windows.Forms.Button();
            this.txtTaxaJuros = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaqueContaEmpresarial = new System.Windows.Forms.Button();
            this.btnSaqueContaPoupanca = new System.Windows.Forms.Button();
            this.btnDepositoContaPoupanca = new System.Windows.Forms.Button();
            this.btnDepositoContaEmpresarial = new System.Windows.Forms.Button();
            this.btnEmprestimoContaEmpresarial = new System.Windows.Forms.Button();
            this.txtEmprestimo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAtualizarSaldoPoupanca = new System.Windows.Forms.Button();
            this.lbxContas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(76, 31);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(131, 21);
            this.txtNumero.TabIndex = 3;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(76, 61);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(131, 21);
            this.txtTitular.TabIndex = 4;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(76, 91);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(131, 21);
            this.txtSaldo.TabIndex = 5;
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Location = new System.Drawing.Point(17, 124);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(190, 30);
            this.btnCriarConta.TabIndex = 6;
            this.btnCriarConta.Text = "Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // txtSaque
            // 
            this.txtSaque.Location = new System.Drawing.Point(297, 30);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(131, 21);
            this.txtSaque.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saque";
            // 
            // btnSaqueConta
            // 
            this.btnSaqueConta.Location = new System.Drawing.Point(238, 60);
            this.btnSaqueConta.Name = "btnSaqueConta";
            this.btnSaqueConta.Size = new System.Drawing.Size(190, 30);
            this.btnSaqueConta.TabIndex = 11;
            this.btnSaqueConta.Text = "Saque Conta";
            this.btnSaqueConta.UseVisualStyleBackColor = true;
            this.btnSaqueConta.Click += new System.EventHandler(this.btnSaqueConta_Click);
            // 
            // btnDepositoConta
            // 
            this.btnDepositoConta.Location = new System.Drawing.Point(460, 60);
            this.btnDepositoConta.Name = "btnDepositoConta";
            this.btnDepositoConta.Size = new System.Drawing.Size(193, 30);
            this.btnDepositoConta.TabIndex = 14;
            this.btnDepositoConta.Text = "Deposito Conta";
            this.btnDepositoConta.UseVisualStyleBackColor = true;
            this.btnDepositoConta.Click += new System.EventHandler(this.btnDepositoConta_Click);
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(522, 29);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(131, 21);
            this.txtDeposito.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Depósito";
            // 
            // txtLimiteEmprestimo
            // 
            this.txtLimiteEmprestimo.Location = new System.Drawing.Point(137, 166);
            this.txtLimiteEmprestimo.Name = "txtLimiteEmprestimo";
            this.txtLimiteEmprestimo.Size = new System.Drawing.Size(70, 21);
            this.txtLimiteEmprestimo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Limite Empréstimo";
            // 
            // btnCriarContaEmpresarial
            // 
            this.btnCriarContaEmpresarial.Location = new System.Drawing.Point(17, 196);
            this.btnCriarContaEmpresarial.Name = "btnCriarContaEmpresarial";
            this.btnCriarContaEmpresarial.Size = new System.Drawing.Size(190, 30);
            this.btnCriarContaEmpresarial.TabIndex = 17;
            this.btnCriarContaEmpresarial.Text = "Criar Conta Empresarial";
            this.btnCriarContaEmpresarial.UseVisualStyleBackColor = true;
            this.btnCriarContaEmpresarial.Click += new System.EventHandler(this.btnCriarContaEmpresarial_Click);
            // 
            // btnContaPoupanca
            // 
            this.btnContaPoupanca.Location = new System.Drawing.Point(17, 272);
            this.btnContaPoupanca.Name = "btnContaPoupanca";
            this.btnContaPoupanca.Size = new System.Drawing.Size(190, 30);
            this.btnContaPoupanca.TabIndex = 20;
            this.btnContaPoupanca.Text = "Criar Conta Poupança";
            this.btnContaPoupanca.UseVisualStyleBackColor = true;
            this.btnContaPoupanca.Click += new System.EventHandler(this.btnContaPoupanca_Click);
            // 
            // txtTaxaJuros
            // 
            this.txtTaxaJuros.Location = new System.Drawing.Point(137, 242);
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.Size = new System.Drawing.Size(70, 21);
            this.txtTaxaJuros.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Taxa Juros";
            // 
            // btnSaqueContaEmpresarial
            // 
            this.btnSaqueContaEmpresarial.Location = new System.Drawing.Point(238, 97);
            this.btnSaqueContaEmpresarial.Name = "btnSaqueContaEmpresarial";
            this.btnSaqueContaEmpresarial.Size = new System.Drawing.Size(190, 30);
            this.btnSaqueContaEmpresarial.TabIndex = 21;
            this.btnSaqueContaEmpresarial.Text = "Saque Conta Empresarial";
            this.btnSaqueContaEmpresarial.UseVisualStyleBackColor = true;
            this.btnSaqueContaEmpresarial.Click += new System.EventHandler(this.btnSaqueContaEmpresarial_Click);
            // 
            // btnSaqueContaPoupanca
            // 
            this.btnSaqueContaPoupanca.Location = new System.Drawing.Point(238, 135);
            this.btnSaqueContaPoupanca.Name = "btnSaqueContaPoupanca";
            this.btnSaqueContaPoupanca.Size = new System.Drawing.Size(190, 30);
            this.btnSaqueContaPoupanca.TabIndex = 22;
            this.btnSaqueContaPoupanca.Text = "Saque Conta Poupança";
            this.btnSaqueContaPoupanca.UseVisualStyleBackColor = true;
            this.btnSaqueContaPoupanca.Click += new System.EventHandler(this.btnSaqueContaPoupanca_Click);
            // 
            // btnDepositoContaPoupanca
            // 
            this.btnDepositoContaPoupanca.Location = new System.Drawing.Point(460, 135);
            this.btnDepositoContaPoupanca.Name = "btnDepositoContaPoupanca";
            this.btnDepositoContaPoupanca.Size = new System.Drawing.Size(193, 30);
            this.btnDepositoContaPoupanca.TabIndex = 24;
            this.btnDepositoContaPoupanca.Text = "Depósito Conta Poupança";
            this.btnDepositoContaPoupanca.UseVisualStyleBackColor = true;
            this.btnDepositoContaPoupanca.Click += new System.EventHandler(this.btnDepositoContaPoupanca_Click);
            // 
            // btnDepositoContaEmpresarial
            // 
            this.btnDepositoContaEmpresarial.Location = new System.Drawing.Point(460, 97);
            this.btnDepositoContaEmpresarial.Name = "btnDepositoContaEmpresarial";
            this.btnDepositoContaEmpresarial.Size = new System.Drawing.Size(193, 30);
            this.btnDepositoContaEmpresarial.TabIndex = 23;
            this.btnDepositoContaEmpresarial.Text = "Depósito Conta Empresarial";
            this.btnDepositoContaEmpresarial.UseVisualStyleBackColor = true;
            this.btnDepositoContaEmpresarial.Click += new System.EventHandler(this.btnDepositoContaEmpresarial_Click);
            // 
            // btnEmprestimoContaEmpresarial
            // 
            this.btnEmprestimoContaEmpresarial.Location = new System.Drawing.Point(238, 224);
            this.btnEmprestimoContaEmpresarial.Name = "btnEmprestimoContaEmpresarial";
            this.btnEmprestimoContaEmpresarial.Size = new System.Drawing.Size(190, 30);
            this.btnEmprestimoContaEmpresarial.TabIndex = 27;
            this.btnEmprestimoContaEmpresarial.Text = "Empréstimo C. Empresarial";
            this.btnEmprestimoContaEmpresarial.UseVisualStyleBackColor = true;
            this.btnEmprestimoContaEmpresarial.Click += new System.EventHandler(this.btnEmprestimoContaEmpresarial_Click);
            // 
            // txtEmprestimo
            // 
            this.txtEmprestimo.Location = new System.Drawing.Point(343, 195);
            this.txtEmprestimo.Name = "txtEmprestimo";
            this.txtEmprestimo.Size = new System.Drawing.Size(85, 21);
            this.txtEmprestimo.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Empréstimo";
            // 
            // btnAtualizarSaldoPoupanca
            // 
            this.btnAtualizarSaldoPoupanca.Location = new System.Drawing.Point(238, 272);
            this.btnAtualizarSaldoPoupanca.Name = "btnAtualizarSaldoPoupanca";
            this.btnAtualizarSaldoPoupanca.Size = new System.Drawing.Size(190, 30);
            this.btnAtualizarSaldoPoupanca.TabIndex = 28;
            this.btnAtualizarSaldoPoupanca.Text = "Atualizar Saldo Poupança";
            this.btnAtualizarSaldoPoupanca.UseVisualStyleBackColor = true;
            this.btnAtualizarSaldoPoupanca.Click += new System.EventHandler(this.btnAtualizarSaldoPoupanca_Click);
            // 
            // lbxContas
            // 
            this.lbxContas.FormattingEnabled = true;
            this.lbxContas.ItemHeight = 15;
            this.lbxContas.Location = new System.Drawing.Point(460, 181);
            this.lbxContas.Name = "lbxContas";
            this.lbxContas.Size = new System.Drawing.Size(431, 289);
            this.lbxContas.TabIndex = 29;
            // 
            // frmContaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 509);
            this.Controls.Add(this.lbxContas);
            this.Controls.Add(this.btnAtualizarSaldoPoupanca);
            this.Controls.Add(this.btnEmprestimoContaEmpresarial);
            this.Controls.Add(this.txtEmprestimo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDepositoContaPoupanca);
            this.Controls.Add(this.btnDepositoContaEmpresarial);
            this.Controls.Add(this.btnSaqueContaPoupanca);
            this.Controls.Add(this.btnSaqueContaEmpresarial);
            this.Controls.Add(this.btnContaPoupanca);
            this.Controls.Add(this.txtTaxaJuros);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCriarContaEmpresarial);
            this.Controls.Add(this.txtLimiteEmprestimo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDepositoConta);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSaqueConta);
            this.Controls.Add(this.txtSaque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Name = "frmContaBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta Bancária";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaqueConta;
        private System.Windows.Forms.Button btnDepositoConta;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLimiteEmprestimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCriarContaEmpresarial;
        private System.Windows.Forms.Button btnContaPoupanca;
        private System.Windows.Forms.TextBox txtTaxaJuros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaqueContaEmpresarial;
        private System.Windows.Forms.Button btnSaqueContaPoupanca;
        private System.Windows.Forms.Button btnDepositoContaPoupanca;
        private System.Windows.Forms.Button btnDepositoContaEmpresarial;
        private System.Windows.Forms.Button btnEmprestimoContaEmpresarial;
        private System.Windows.Forms.TextBox txtEmprestimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAtualizarSaldoPoupanca;
        private System.Windows.Forms.ListBox lbxContas;
    }
}

