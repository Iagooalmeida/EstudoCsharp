namespace Exe2_ContaBancaria
{
    partial class frmClientes
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRgCliente = new System.Windows.Forms.TextBox();
            this.txtCpfCliente = new System.Windows.Forms.TextBox();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.btnCriarCliente_V1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCriarCliente_V2 = new System.Windows.Forms.Button();
            this.btnCriarcliente_V3 = new System.Windows.Forms.Button();
            this.btnCriarCliente_V4_1 = new System.Windows.Forms.Button();
            this.btnCriarCliente_V4_2 = new System.Windows.Forms.Button();
            this.btnCriarCliente_V4_3 = new System.Windows.Forms.Button();
            this.btnCriarCliente_V4_4 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCriarCliente_V4_4);
            this.groupBox3.Controls.Add(this.btnCriarCliente_V4_3);
            this.groupBox3.Controls.Add(this.btnCriarCliente_V4_2);
            this.groupBox3.Controls.Add(this.btnCriarCliente_V4_1);
            this.groupBox3.Controls.Add(this.btnCriarcliente_V3);
            this.groupBox3.Controls.Add(this.btnCriarCliente_V2);
            this.groupBox3.Controls.Add(this.txtRgCliente);
            this.groupBox3.Controls.Add(this.txtCpfCliente);
            this.groupBox3.Controls.Add(this.txtEnderecoCliente);
            this.groupBox3.Controls.Add(this.btnCriarCliente_V1);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtNomeCliente);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 397);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // txtRgCliente
            // 
            this.txtRgCliente.Location = new System.Drawing.Point(113, 87);
            this.txtRgCliente.Name = "txtRgCliente";
            this.txtRgCliente.Size = new System.Drawing.Size(135, 21);
            this.txtRgCliente.TabIndex = 8;
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Location = new System.Drawing.Point(113, 57);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(135, 21);
            this.txtCpfCliente.TabIndex = 7;
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Location = new System.Drawing.Point(113, 114);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(135, 21);
            this.txtEnderecoCliente.TabIndex = 6;
            // 
            // btnCriarCliente_V1
            // 
            this.btnCriarCliente_V1.Location = new System.Drawing.Point(41, 145);
            this.btnCriarCliente_V1.Name = "btnCriarCliente_V1";
            this.btnCriarCliente_V1.Size = new System.Drawing.Size(207, 25);
            this.btnCriarCliente_V1.TabIndex = 5;
            this.btnCriarCliente_V1.Text = "Criar Cliente V1";
            this.btnCriarCliente_V1.UseVisualStyleBackColor = true;
            this.btnCriarCliente_V1.Click += new System.EventHandler(this.btnCriarCliente_V1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Endereço";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "RG";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "CPF";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(113, 29);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(135, 21);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nome";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF,
            this.RG,
            this.Endereco});
            this.dgvClientes.Location = new System.Drawing.Point(357, 30);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(558, 437);
            this.dgvClientes.TabIndex = 25;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            // 
            // btnCriarCliente_V2
            // 
            this.btnCriarCliente_V2.Location = new System.Drawing.Point(41, 176);
            this.btnCriarCliente_V2.Name = "btnCriarCliente_V2";
            this.btnCriarCliente_V2.Size = new System.Drawing.Size(207, 25);
            this.btnCriarCliente_V2.TabIndex = 9;
            this.btnCriarCliente_V2.Text = "Criar Cliente V2";
            this.btnCriarCliente_V2.UseVisualStyleBackColor = true;
            this.btnCriarCliente_V2.Click += new System.EventHandler(this.btnCriarCliente_V2_Click);
            // 
            // btnCriarcliente_V3
            // 
            this.btnCriarcliente_V3.Location = new System.Drawing.Point(41, 209);
            this.btnCriarcliente_V3.Name = "btnCriarcliente_V3";
            this.btnCriarcliente_V3.Size = new System.Drawing.Size(207, 25);
            this.btnCriarcliente_V3.TabIndex = 10;
            this.btnCriarcliente_V3.Text = "Criar Cliente V3";
            this.btnCriarcliente_V3.UseVisualStyleBackColor = true;
            this.btnCriarcliente_V3.Click += new System.EventHandler(this.btnCriarcliente_V3_Click);
            // 
            // btnCriarCliente_V4_1
            // 
            this.btnCriarCliente_V4_1.Location = new System.Drawing.Point(41, 241);
            this.btnCriarCliente_V4_1.Name = "btnCriarCliente_V4_1";
            this.btnCriarCliente_V4_1.Size = new System.Drawing.Size(207, 25);
            this.btnCriarCliente_V4_1.TabIndex = 11;
            this.btnCriarCliente_V4_1.Text = "Criar Cliente V4_1";
            this.btnCriarCliente_V4_1.UseVisualStyleBackColor = true;
            this.btnCriarCliente_V4_1.Click += new System.EventHandler(this.btnCriarCliente_V4_1_Click);
            // 
            // btnCriarCliente_V4_2
            // 
            this.btnCriarCliente_V4_2.Location = new System.Drawing.Point(41, 274);
            this.btnCriarCliente_V4_2.Name = "btnCriarCliente_V4_2";
            this.btnCriarCliente_V4_2.Size = new System.Drawing.Size(207, 25);
            this.btnCriarCliente_V4_2.TabIndex = 12;
            this.btnCriarCliente_V4_2.Text = "Criar Cliente V4_2";
            this.btnCriarCliente_V4_2.UseVisualStyleBackColor = true;
            this.btnCriarCliente_V4_2.Click += new System.EventHandler(this.btnCriarCliente_V4_2_Click);
            // 
            // btnCriarCliente_V4_3
            // 
            this.btnCriarCliente_V4_3.Location = new System.Drawing.Point(41, 308);
            this.btnCriarCliente_V4_3.Name = "btnCriarCliente_V4_3";
            this.btnCriarCliente_V4_3.Size = new System.Drawing.Size(207, 25);
            this.btnCriarCliente_V4_3.TabIndex = 13;
            this.btnCriarCliente_V4_3.Text = "Criar Cliente V4_3";
            this.btnCriarCliente_V4_3.UseVisualStyleBackColor = true;
            this.btnCriarCliente_V4_3.Click += new System.EventHandler(this.btnCriarCliente_V4_3_Click);
            // 
            // btnCriarCliente_V4_4
            // 
            this.btnCriarCliente_V4_4.Location = new System.Drawing.Point(41, 343);
            this.btnCriarCliente_V4_4.Name = "btnCriarCliente_V4_4";
            this.btnCriarCliente_V4_4.Size = new System.Drawing.Size(207, 25);
            this.btnCriarCliente_V4_4.TabIndex = 14;
            this.btnCriarCliente_V4_4.Text = "Criar Cliente V4_4";
            this.btnCriarCliente_V4_4.UseVisualStyleBackColor = true;
            this.btnCriarCliente_V4_4.Click += new System.EventHandler(this.btnCriarCliente_V4_4_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 505);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClientes";
            this.Text = "Cliente";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRgCliente;
        private System.Windows.Forms.TextBox txtCpfCliente;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.Button btnCriarCliente_V1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.Button btnCriarCliente_V2;
        private System.Windows.Forms.Button btnCriarcliente_V3;
        private System.Windows.Forms.Button btnCriarCliente_V4_1;
        private System.Windows.Forms.Button btnCriarCliente_V4_4;
        private System.Windows.Forms.Button btnCriarCliente_V4_3;
        private System.Windows.Forms.Button btnCriarCliente_V4_2;
    }
}

