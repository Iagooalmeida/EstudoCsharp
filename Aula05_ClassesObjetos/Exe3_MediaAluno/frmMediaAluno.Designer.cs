
namespace Exe3_MediaAluno
{
    partial class frmMediaAluno
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
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotaMensal = new System.Windows.Forms.TextBox();
            this.txtBimenstral = new System.Windows.Forms.TextBox();
            this.btnCriarAlunos = new System.Windows.Forms.Button();
            this.btnNota = new System.Windows.Forms.Button();
            this.dgvMediaFinal = new System.Windows.Forms.DataGridView();
            this.NomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaMensal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bimestral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediaFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curso";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(132, 44);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(143, 20);
            this.txtNomeAluno.TabIndex = 2;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(132, 80);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(143, 20);
            this.txtCurso.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota Mensal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nota Bimenstral";
            // 
            // txtNotaMensal
            // 
            this.txtNotaMensal.Location = new System.Drawing.Point(132, 157);
            this.txtNotaMensal.Name = "txtNotaMensal";
            this.txtNotaMensal.Size = new System.Drawing.Size(143, 20);
            this.txtNotaMensal.TabIndex = 6;
            // 
            // txtBimenstral
            // 
            this.txtBimenstral.Location = new System.Drawing.Point(132, 193);
            this.txtBimenstral.Name = "txtBimenstral";
            this.txtBimenstral.Size = new System.Drawing.Size(143, 20);
            this.txtBimenstral.TabIndex = 7;
            // 
            // btnCriarAlunos
            // 
            this.btnCriarAlunos.Location = new System.Drawing.Point(64, 114);
            this.btnCriarAlunos.Name = "btnCriarAlunos";
            this.btnCriarAlunos.Size = new System.Drawing.Size(194, 24);
            this.btnCriarAlunos.TabIndex = 8;
            this.btnCriarAlunos.Text = "Criar Aluno";
            this.btnCriarAlunos.UseVisualStyleBackColor = true;
            this.btnCriarAlunos.Click += new System.EventHandler(this.btnCriarAlunos_Click);
            // 
            // btnNota
            // 
            this.btnNota.Location = new System.Drawing.Point(64, 231);
            this.btnNota.Name = "btnNota";
            this.btnNota.Size = new System.Drawing.Size(194, 24);
            this.btnNota.TabIndex = 9;
            this.btnNota.Text = "Nota";
            this.btnNota.UseVisualStyleBackColor = true;
            this.btnNota.Click += new System.EventHandler(this.btnNota_Click);
            // 
            // dgvMediaFinal
            // 
            this.dgvMediaFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMediaFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeAluno,
            this.Curso,
            this.NotaMensal,
            this.Bimestral,
            this.MediaFinal});
            this.dgvMediaFinal.Location = new System.Drawing.Point(316, 44);
            this.dgvMediaFinal.Name = "dgvMediaFinal";
            this.dgvMediaFinal.Size = new System.Drawing.Size(540, 384);
            this.dgvMediaFinal.TabIndex = 11;
            // 
            // NomeAluno
            // 
            this.NomeAluno.HeaderText = "Nome Aluno";
            this.NomeAluno.Name = "NomeAluno";
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            // 
            // NotaMensal
            // 
            this.NotaMensal.HeaderText = "Nota mensal";
            this.NotaMensal.Name = "NotaMensal";
            // 
            // Bimestral
            // 
            this.Bimestral.HeaderText = "Nota bimestral";
            this.Bimestral.Name = "Bimestral";
            // 
            // MediaFinal
            // 
            this.MediaFinal.HeaderText = "Média final";
            this.MediaFinal.Name = "MediaFinal";
            // 
            // frmMediaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 494);
            this.Controls.Add(this.dgvMediaFinal);
            this.Controls.Add(this.btnNota);
            this.Controls.Add(this.btnCriarAlunos);
            this.Controls.Add(this.txtBimenstral);
            this.Controls.Add(this.txtNotaMensal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMediaAluno";
            this.Text = "Media Final";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediaFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotaMensal;
        private System.Windows.Forms.TextBox txtBimenstral;
        private System.Windows.Forms.Button btnCriarAlunos;
        private System.Windows.Forms.Button btnNota;
        private System.Windows.Forms.DataGridView dgvMediaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaMensal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bimestral;
        private System.Windows.Forms.DataGridViewTextBoxColumn MediaFinal;
    }
}

