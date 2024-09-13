
namespace Exe01_Cadastro
{
    partial class frmConsultaProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnTodos = new System.Windows.Forms.RadioButton();
            this.rbnDescricao = new System.Windows.Forms.RadioButton();
            this.rbnId = new System.Windows.Forms.RadioButton();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnTodos);
            this.groupBox1.Controls.Add(this.rbnDescricao);
            this.groupBox1.Controls.Add(this.rbnId);
            this.groupBox1.Location = new System.Drawing.Point(24, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rbnTodos
            // 
            this.rbnTodos.AutoSize = true;
            this.rbnTodos.Location = new System.Drawing.Point(449, 30);
            this.rbnTodos.Name = "rbnTodos";
            this.rbnTodos.Size = new System.Drawing.Size(66, 21);
            this.rbnTodos.TabIndex = 3;
            this.rbnTodos.TabStop = true;
            this.rbnTodos.Text = "Todos";
            this.rbnTodos.UseVisualStyleBackColor = true;
            this.rbnTodos.CheckedChanged += new System.EventHandler(this.rbnTodos_CheckedChanged);
            // 
            // rbnDescricao
            // 
            this.rbnDescricao.AutoSize = true;
            this.rbnDescricao.Location = new System.Drawing.Point(212, 30);
            this.rbnDescricao.Name = "rbnDescricao";
            this.rbnDescricao.Size = new System.Drawing.Size(89, 21);
            this.rbnDescricao.TabIndex = 1;
            this.rbnDescricao.TabStop = true;
            this.rbnDescricao.Text = "Descrição";
            this.rbnDescricao.UseVisualStyleBackColor = true;
            // 
            // rbnId
            // 
            this.rbnId.AutoSize = true;
            this.rbnId.Location = new System.Drawing.Point(31, 30);
            this.rbnId.Name = "rbnId";
            this.rbnId.Size = new System.Drawing.Size(39, 21);
            this.rbnId.TabIndex = 0;
            this.rbnId.TabStop = true;
            this.rbnId.Text = "ID";
            this.rbnId.UseVisualStyleBackColor = true;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(24, 94);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(549, 23);
            this.txtConsulta.TabIndex = 2;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(24, 131);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(549, 217);
            this.dgvProdutos.TabIndex = 3;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(315, 361);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(258, 34);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(24, 361);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(255, 34);
            this.btnSelecionar.TabIndex = 5;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Visible = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // frmConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 411);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultaProdutos";
            this.Text = "Consulta Produtos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnTodos;
        private System.Windows.Forms.RadioButton rbnDescricao;
        private System.Windows.Forms.RadioButton rbnId;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSelecionar;
    }
}