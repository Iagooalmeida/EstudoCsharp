
namespace Exe5_Funcionários
{
    partial class frmFuncionarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTerceirizado = new System.Windows.Forms.RadioButton();
            this.rbInterno = new System.Windows.Forms.RadioButton();
            this.lblValeAlimentacao = new System.Windows.Forms.Label();
            this.txtValeAlimentacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.txtValorPorHora = new System.Windows.Forms.TextBox();
            this.txtDespesaAdcional = new System.Windows.Forms.TextBox();
            this.lblDespesaAdcional = new System.Windows.Forms.Label();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FGTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTotalPagamentos = new System.Windows.Forms.Button();
            this.btnTotalFgts = new System.Windows.Forms.Button();
            this.lblTotalPagamentos = new System.Windows.Forms.Label();
            this.lblTotalFgts = new System.Windows.Forms.Label();
            this.btnCriarFuncionario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Trabalhadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "R$ por hora";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTerceirizado);
            this.groupBox1.Controls.Add(this.rbInterno);
            this.groupBox1.Location = new System.Drawing.Point(119, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(286, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rbTerceirizado
            // 
            this.rbTerceirizado.AutoSize = true;
            this.rbTerceirizado.Location = new System.Drawing.Point(141, 19);
            this.rbTerceirizado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbTerceirizado.Name = "rbTerceirizado";
            this.rbTerceirizado.Size = new System.Drawing.Size(108, 22);
            this.rbTerceirizado.TabIndex = 1;
            this.rbTerceirizado.TabStop = true;
            this.rbTerceirizado.Text = "Terceirizado";
            this.rbTerceirizado.UseVisualStyleBackColor = true;
            this.rbTerceirizado.CheckedChanged += new System.EventHandler(this.rbTerceirizado_CheckedChanged);
            // 
            // rbInterno
            // 
            this.rbInterno.AutoSize = true;
            this.rbInterno.Location = new System.Drawing.Point(22, 19);
            this.rbInterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbInterno.Name = "rbInterno";
            this.rbInterno.Size = new System.Drawing.Size(71, 22);
            this.rbInterno.TabIndex = 0;
            this.rbInterno.TabStop = true;
            this.rbInterno.Text = "Interno";
            this.rbInterno.UseVisualStyleBackColor = true;
            this.rbInterno.CheckedChanged += new System.EventHandler(this.rbInterno_CheckedChanged);
            // 
            // lblValeAlimentacao
            // 
            this.lblValeAlimentacao.AutoSize = true;
            this.lblValeAlimentacao.Location = new System.Drawing.Point(43, 167);
            this.lblValeAlimentacao.Name = "lblValeAlimentacao";
            this.lblValeAlimentacao.Size = new System.Drawing.Size(121, 18);
            this.lblValeAlimentacao.TabIndex = 4;
            this.lblValeAlimentacao.Text = "Vale Alimentação";
            this.lblValeAlimentacao.Visible = false;
            // 
            // txtValeAlimentacao
            // 
            this.txtValeAlimentacao.Location = new System.Drawing.Point(231, 167);
            this.txtValeAlimentacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValeAlimentacao.Name = "txtValeAlimentacao";
            this.txtValeAlimentacao.Size = new System.Drawing.Size(174, 24);
            this.txtValeAlimentacao.TabIndex = 5;
            this.txtValeAlimentacao.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(200, 13);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(247, 24);
            this.txtNome.TabIndex = 6;
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(200, 46);
            this.txtHorasTrabalhadas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(247, 24);
            this.txtHorasTrabalhadas.TabIndex = 7;
            // 
            // txtValorPorHora
            // 
            this.txtValorPorHora.Location = new System.Drawing.Point(200, 77);
            this.txtValorPorHora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValorPorHora.Name = "txtValorPorHora";
            this.txtValorPorHora.Size = new System.Drawing.Size(247, 24);
            this.txtValorPorHora.TabIndex = 8;
            // 
            // txtDespesaAdcional
            // 
            this.txtDespesaAdcional.Location = new System.Drawing.Point(231, 199);
            this.txtDespesaAdcional.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDespesaAdcional.Name = "txtDespesaAdcional";
            this.txtDespesaAdcional.Size = new System.Drawing.Size(174, 24);
            this.txtDespesaAdcional.TabIndex = 10;
            this.txtDespesaAdcional.Visible = false;
            // 
            // lblDespesaAdcional
            // 
            this.lblDespesaAdcional.AutoSize = true;
            this.lblDespesaAdcional.Location = new System.Drawing.Point(43, 202);
            this.lblDespesaAdcional.Name = "lblDespesaAdcional";
            this.lblDespesaAdcional.Size = new System.Drawing.Size(153, 18);
            this.lblDespesaAdcional.TabIndex = 9;
            this.lblDespesaAdcional.Text = "R$ Despesa Adicional";
            this.lblDespesaAdcional.Visible = false;
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Pagamento,
            this.FGTS});
            this.dgvFuncionario.Location = new System.Drawing.Point(46, 235);
            this.dgvFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(485, 171);
            this.dgvFuncionario.TabIndex = 11;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Pagamento
            // 
            this.Pagamento.HeaderText = "Pagamento";
            this.Pagamento.Name = "Pagamento";
            // 
            // FGTS
            // 
            this.FGTS.HeaderText = "FGTS";
            this.FGTS.Name = "FGTS";
            // 
            // btnTotalPagamentos
            // 
            this.btnTotalPagamentos.Location = new System.Drawing.Point(46, 417);
            this.btnTotalPagamentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTotalPagamentos.Name = "btnTotalPagamentos";
            this.btnTotalPagamentos.Size = new System.Drawing.Size(230, 32);
            this.btnTotalPagamentos.TabIndex = 12;
            this.btnTotalPagamentos.Text = "Total Pagamentos";
            this.btnTotalPagamentos.UseVisualStyleBackColor = true;
            this.btnTotalPagamentos.Click += new System.EventHandler(this.btnTotalPagamentos_Click);
            // 
            // btnTotalFgts
            // 
            this.btnTotalFgts.Location = new System.Drawing.Point(300, 417);
            this.btnTotalFgts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTotalFgts.Name = "btnTotalFgts";
            this.btnTotalFgts.Size = new System.Drawing.Size(230, 32);
            this.btnTotalFgts.TabIndex = 13;
            this.btnTotalFgts.Text = "Total FGTS";
            this.btnTotalFgts.UseVisualStyleBackColor = true;
            this.btnTotalFgts.Click += new System.EventHandler(this.btnTotalFgts_Click);
            // 
            // lblTotalPagamentos
            // 
            this.lblTotalPagamentos.AutoSize = true;
            this.lblTotalPagamentos.Location = new System.Drawing.Point(50, 456);
            this.lblTotalPagamentos.Name = "lblTotalPagamentos";
            this.lblTotalPagamentos.Size = new System.Drawing.Size(133, 18);
            this.lblTotalPagamentos.TabIndex = 14;
            this.lblTotalPagamentos.Text = "Total Pagamentos:";
            // 
            // lblTotalFgts
            // 
            this.lblTotalFgts.AutoSize = true;
            this.lblTotalFgts.Location = new System.Drawing.Point(298, 456);
            this.lblTotalFgts.Name = "lblTotalFgts";
            this.lblTotalFgts.Size = new System.Drawing.Size(89, 18);
            this.lblTotalFgts.TabIndex = 15;
            this.lblTotalFgts.Text = "Total FGTS:";
            // 
            // btnCriarFuncionario
            // 
            this.btnCriarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCriarFuncionario.Location = new System.Drawing.Point(411, 167);
            this.btnCriarFuncionario.Name = "btnCriarFuncionario";
            this.btnCriarFuncionario.Size = new System.Drawing.Size(120, 57);
            this.btnCriarFuncionario.TabIndex = 16;
            this.btnCriarFuncionario.Text = "Criar Funcionário";
            this.btnCriarFuncionario.UseVisualStyleBackColor = true;
            this.btnCriarFuncionario.Click += new System.EventHandler(this.btnCriarFuncionario_Click);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 504);
            this.Controls.Add(this.btnCriarFuncionario);
            this.Controls.Add(this.lblTotalFgts);
            this.Controls.Add(this.lblTotalPagamentos);
            this.Controls.Add(this.btnTotalFgts);
            this.Controls.Add(this.btnTotalPagamentos);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.txtDespesaAdcional);
            this.Controls.Add(this.lblDespesaAdcional);
            this.Controls.Add(this.txtValorPorHora);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtValeAlimentacao);
            this.Controls.Add(this.lblValeAlimentacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTerceirizado;
        private System.Windows.Forms.RadioButton rbInterno;
        private System.Windows.Forms.Label lblValeAlimentacao;
        private System.Windows.Forms.TextBox txtValeAlimentacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtValorPorHora;
        private System.Windows.Forms.TextBox txtDespesaAdcional;
        private System.Windows.Forms.Label lblDespesaAdcional;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FGTS;
        private System.Windows.Forms.Button btnTotalPagamentos;
        private System.Windows.Forms.Button btnTotalFgts;
        private System.Windows.Forms.Label lblTotalPagamentos;
        private System.Windows.Forms.Label lblTotalFgts;
        private System.Windows.Forms.Button btnCriarFuncionario;
    }
}

