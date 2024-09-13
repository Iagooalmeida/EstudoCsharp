namespace Exe3_ListaFuncionarios
{
    partial class frmListaFuncionarios_v1
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
            this.txtNumFuncionario = new System.Windows.Forms.TextBox();
            this.btnCriarLinhas = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnCriarArquivos = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.sfdGravacaoArquivos = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Funcionários";
            // 
            // txtNumFuncionario
            // 
            this.txtNumFuncionario.Location = new System.Drawing.Point(171, 59);
            this.txtNumFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumFuncionario.Name = "txtNumFuncionario";
            this.txtNumFuncionario.Size = new System.Drawing.Size(132, 23);
            this.txtNumFuncionario.TabIndex = 1;
            // 
            // btnCriarLinhas
            // 
            this.btnCriarLinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnCriarLinhas.Location = new System.Drawing.Point(363, 53);
            this.btnCriarLinhas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarLinhas.Name = "btnCriarLinhas";
            this.btnCriarLinhas.Size = new System.Drawing.Size(231, 35);
            this.btnCriarLinhas.TabIndex = 2;
            this.btnCriarLinhas.Text = "Criar regristros para linha";
            this.btnCriarLinhas.UseVisualStyleBackColor = true;
            this.btnCriarLinhas.Click += new System.EventHandler(this.btnCriarLinhas_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(64, 103);
            this.dgvFuncionarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(527, 240);
            this.dgvFuncionarios.TabIndex = 3;
            // 
            // btnCriarArquivos
            // 
            this.btnCriarArquivos.Enabled = false;
            this.btnCriarArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnCriarArquivos.Location = new System.Drawing.Point(64, 360);
            this.btnCriarArquivos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarArquivos.Name = "btnCriarArquivos";
            this.btnCriarArquivos.Size = new System.Drawing.Size(279, 43);
            this.btnCriarArquivos.TabIndex = 4;
            this.btnCriarArquivos.Text = "Criar Arquivos";
            this.btnCriarArquivos.UseVisualStyleBackColor = true;
            this.btnCriarArquivos.Click += new System.EventHandler(this.btnCriarArquivos_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnReiniciar.Location = new System.Drawing.Point(363, 360);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(228, 43);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // sfdGravacaoArquivos
            // 
            this.sfdGravacaoArquivos.DefaultExt = "*.txt";
            this.sfdGravacaoArquivos.Filter = "Arquivos Textos|*.txt";
            this.sfdGravacaoArquivos.Title = "Dados para geração de arquivos";
            // 
            // frmListaFuncionarios_v1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 481);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCriarArquivos);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnCriarLinhas);
            this.Controls.Add(this.txtNumFuncionario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListaFuncionarios_v1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados para geração de arquivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumFuncionario;
        private System.Windows.Forms.Button btnCriarLinhas;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Button btnCriarArquivos;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.SaveFileDialog sfdGravacaoArquivos;
    }
}

