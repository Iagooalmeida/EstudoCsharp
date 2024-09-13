
namespace Exe01_Cadastro
{
    partial class frmConsultaFornecedores
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
            this.rbnCnpj = new System.Windows.Forms.RadioButton();
            this.rbnNome = new System.Windows.Forms.RadioButton();
            this.rbnId = new System.Windows.Forms.RadioButton();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnTodos);
            this.groupBox1.Controls.Add(this.rbnCnpj);
            this.groupBox1.Controls.Add(this.rbnNome);
            this.groupBox1.Controls.Add(this.rbnId);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rbnTodos
            // 
            this.rbnTodos.AutoSize = true;
            this.rbnTodos.Location = new System.Drawing.Point(392, 30);
            this.rbnTodos.Name = "rbnTodos";
            this.rbnTodos.Size = new System.Drawing.Size(66, 21);
            this.rbnTodos.TabIndex = 3;
            this.rbnTodos.TabStop = true;
            this.rbnTodos.Text = "Todos";
            this.rbnTodos.UseVisualStyleBackColor = true;
            this.rbnTodos.CheckedChanged += new System.EventHandler(this.rbnTodos_CheckedChanged);
            // 
            // rbnCnpj
            // 
            this.rbnCnpj.AutoSize = true;
            this.rbnCnpj.Location = new System.Drawing.Point(274, 30);
            this.rbnCnpj.Name = "rbnCnpj";
            this.rbnCnpj.Size = new System.Drawing.Size(61, 21);
            this.rbnCnpj.TabIndex = 2;
            this.rbnCnpj.TabStop = true;
            this.rbnCnpj.Text = "CNPJ";
            this.rbnCnpj.UseVisualStyleBackColor = true;
            // 
            // rbnNome
            // 
            this.rbnNome.AutoSize = true;
            this.rbnNome.Location = new System.Drawing.Point(150, 30);
            this.rbnNome.Name = "rbnNome";
            this.rbnNome.Size = new System.Drawing.Size(63, 21);
            this.rbnNome.TabIndex = 1;
            this.rbnNome.TabStop = true;
            this.rbnNome.Text = "Nome";
            this.rbnNome.UseVisualStyleBackColor = true;
            // 
            // rbnId
            // 
            this.rbnId.AutoSize = true;
            this.rbnId.Location = new System.Drawing.Point(50, 30);
            this.rbnId.Name = "rbnId";
            this.rbnId.Size = new System.Drawing.Size(39, 21);
            this.rbnId.TabIndex = 0;
            this.rbnId.TabStop = true;
            this.rbnId.Text = "ID";
            this.rbnId.UseVisualStyleBackColor = true;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(22, 88);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(549, 23);
            this.txtConsulta.TabIndex = 1;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Location = new System.Drawing.Point(22, 121);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.Size = new System.Drawing.Size(549, 217);
            this.dgvFornecedores.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(309, 346);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(260, 38);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(22, 346);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(260, 38);
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Visible = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // frmConsultaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 413);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultaFornecedores";
            this.Text = "Consulta Fornecedores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnTodos;
        private System.Windows.Forms.RadioButton rbnCnpj;
        private System.Windows.Forms.RadioButton rbnNome;
        private System.Windows.Forms.RadioButton rbnId;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSelecionar;
    }
}