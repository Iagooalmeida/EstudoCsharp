namespace Exe2_ReajusteSalario
{
    partial class frmReajusteSalario_V1
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
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPercentualReajuste = new System.Windows.Forms.Label();
            this.lblPercentual = new System.Windows.Forms.Label();
            this.lblTotalComRejuste = new System.Windows.Forms.Label();
            this.lblTotalReajuste = new System.Windows.Forms.Label();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSalarios = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NovoSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(12, 21);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(528, 20);
            this.txtArquivo.TabIndex = 0;
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAbrirArquivo.Location = new System.Drawing.Point(546, 14);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(92, 31);
            this.btnAbrirArquivo.TabIndex = 1;
            this.btnAbrirArquivo.Text = "...";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPercentualReajuste);
            this.panel1.Controls.Add(this.lblPercentual);
            this.panel1.Controls.Add(this.lblTotalComRejuste);
            this.panel1.Controls.Add(this.lblTotalReajuste);
            this.panel1.Controls.Add(this.lblTotalSemReajuste);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 101);
            this.panel1.TabIndex = 2;
            // 
            // lblPercentualReajuste
            // 
            this.lblPercentualReajuste.AutoSize = true;
            this.lblPercentualReajuste.Location = new System.Drawing.Point(455, 49);
            this.lblPercentualReajuste.Name = "lblPercentualReajuste";
            this.lblPercentualReajuste.Size = new System.Drawing.Size(28, 13);
            this.lblPercentualReajuste.TabIndex = 5;
            this.lblPercentualReajuste.Text = "0,00";
            // 
            // lblPercentual
            // 
            this.lblPercentual.AutoSize = true;
            this.lblPercentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPercentual.Location = new System.Drawing.Point(347, 20);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(136, 17);
            this.lblPercentual.TabIndex = 4;
            this.lblPercentual.Text = "Percentual Reajuste";
            // 
            // lblTotalComRejuste
            // 
            this.lblTotalComRejuste.AutoSize = true;
            this.lblTotalComRejuste.Location = new System.Drawing.Point(286, 51);
            this.lblTotalComRejuste.Name = "lblTotalComRejuste";
            this.lblTotalComRejuste.Size = new System.Drawing.Size(28, 13);
            this.lblTotalComRejuste.TabIndex = 3;
            this.lblTotalComRejuste.Text = "0,00";
            // 
            // lblTotalReajuste
            // 
            this.lblTotalReajuste.AutoSize = true;
            this.lblTotalReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTotalReajuste.Location = new System.Drawing.Point(190, 20);
            this.lblTotalReajuste.Name = "lblTotalReajuste";
            this.lblTotalReajuste.Size = new System.Drawing.Size(122, 17);
            this.lblTotalReajuste.TabIndex = 2;
            this.lblTotalReajuste.Text = "Total com Rejuste";
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.AutoSize = true;
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(133, 49);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(28, 13);
            this.lblTotalSemReajuste.TabIndex = 1;
            this.lblTotalSemReajuste.Text = "0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total sem reajuste";
            // 
            // dgvSalarios
            // 
            this.dgvSalarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Salario,
            this.Percentual,
            this.NovoSalario});
            this.dgvSalarios.Location = new System.Drawing.Point(12, 173);
            this.dgvSalarios.Name = "dgvSalarios";
            this.dgvSalarios.Size = new System.Drawing.Size(626, 219);
            this.dgvSalarios.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Sálario";
            this.Salario.Name = "Salario";
            // 
            // Percentual
            // 
            this.Percentual.HeaderText = "Percentual";
            this.Percentual.Name = "Percentual";
            // 
            // NovoSalario
            // 
            this.NovoSalario.HeaderText = "Novo Sálario";
            this.NovoSalario.Name = "NovoSalario";
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "salario.txt";
            this.ofdListaFuncionarios.Filter = "Arquivos textos|*.txt";
            this.ofdListaFuncionarios.Title = "Seleção de arquivos com dados de funcionários";
            // 
            // frmReajusteSalario_V1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.dgvSalarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAbrirArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Name = "frmReajusteSalario_V1";
            this.Text = "Leitura de arquivos para reajuste de salario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPercentualReajuste;
        private System.Windows.Forms.Label lblPercentual;
        private System.Windows.Forms.Label lblTotalComRejuste;
        private System.Windows.Forms.Label lblTotalReajuste;
        private System.Windows.Forms.Label lblTotalSemReajuste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSalarios;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentual;
        private System.Windows.Forms.DataGridViewTextBoxColumn NovoSalario;
    }
}

