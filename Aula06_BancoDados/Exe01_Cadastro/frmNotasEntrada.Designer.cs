
namespace Exe01_Cadastro
{
    partial class frmNotasEntrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoCustoProduto = new System.Windows.Forms.TextBox();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.btnCancelarProduto = new System.Windows.Forms.Button();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLocalizarFornecedor = new System.Windows.Forms.Button();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.btnLocalizarProdutos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalNota = new System.Windows.Forms.TextBox();
            this.btnInserirNotaEntrada = new System.Windows.Forms.Button();
            this.btnCancelarNotaEntrada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(267, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTA DE ENTRADA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fornecedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preço Custo:";
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Location = new System.Drawing.Point(121, 41);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(127, 23);
            this.txtIdFornecedor.TabIndex = 5;
            this.txtIdFornecedor.Leave += new System.EventHandler(this.txtIdFornecedor_Leave);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(121, 70);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(127, 23);
            this.txtNumero.TabIndex = 6;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(121, 138);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(127, 23);
            this.txtIdProduto.TabIndex = 7;
            this.txtIdProduto.Leave += new System.EventHandler(this.txtIdProduto_Leave);
            // 
            // txtPrecoCustoProduto
            // 
            this.txtPrecoCustoProduto.Location = new System.Drawing.Point(121, 169);
            this.txtPrecoCustoProduto.Name = "txtPrecoCustoProduto";
            this.txtPrecoCustoProduto.Size = new System.Drawing.Size(127, 23);
            this.txtPrecoCustoProduto.TabIndex = 8;
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Location = new System.Drawing.Point(33, 215);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(150, 41);
            this.btnInserirProduto.TabIndex = 9;
            this.btnInserirProduto.Text = "Inserir Produto";
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.Location = new System.Drawing.Point(189, 215);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(169, 41);
            this.btnCancelarProduto.TabIndex = 10;
            this.btnCancelarProduto.Text = "Cancelar Produtos";
            this.btnCancelarProduto.UseVisualStyleBackColor = true;
            this.btnCancelarProduto.Click += new System.EventHandler(this.btnCancelarProduto_Click);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(271, 41);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.ReadOnly = true;
            this.txtNomeFornecedor.Size = new System.Drawing.Size(279, 23);
            this.txtNomeFornecedor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Emissão:";
            // 
            // btnLocalizarFornecedor
            // 
            this.btnLocalizarFornecedor.Location = new System.Drawing.Point(556, 37);
            this.btnLocalizarFornecedor.Name = "btnLocalizarFornecedor";
            this.btnLocalizarFornecedor.Size = new System.Drawing.Size(110, 30);
            this.btnLocalizarFornecedor.TabIndex = 13;
            this.btnLocalizarFornecedor.Text = "Localizar";
            this.btnLocalizarFornecedor.UseVisualStyleBackColor = true;
            this.btnLocalizarFornecedor.Click += new System.EventHandler(this.btnLocalizarFornecedor_Click);
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(341, 70);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(118, 23);
            this.dtpEmissao.TabIndex = 14;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(549, 71);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(118, 23);
            this.dtpEntrada.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Entrada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(250, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "PRODUTOS COMPRADOS";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(271, 140);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.ReadOnly = true;
            this.txtDescricaoProduto.Size = new System.Drawing.Size(279, 23);
            this.txtDescricaoProduto.TabIndex = 18;
            // 
            // btnLocalizarProdutos
            // 
            this.btnLocalizarProdutos.Location = new System.Drawing.Point(557, 135);
            this.btnLocalizarProdutos.Name = "btnLocalizarProdutos";
            this.btnLocalizarProdutos.Size = new System.Drawing.Size(110, 30);
            this.btnLocalizarProdutos.TabIndex = 19;
            this.btnLocalizarProdutos.Text = "Localizar";
            this.btnLocalizarProdutos.UseVisualStyleBackColor = true;
            this.btnLocalizarProdutos.Click += new System.EventHandler(this.btnLocalizarProdutos_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Quantidade:";
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(364, 171);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(186, 23);
            this.txtQuantidadeProduto.TabIndex = 21;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Id,
            this.Descricao,
            this.Quantidade,
            this.PrecoCusto,
            this.Total});
            this.dgvProdutos.Location = new System.Drawing.Point(33, 265);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(650, 190);
            this.dgvProdutos.TabIndex = 22;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Width = 50;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 40;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 160;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // PrecoCusto
            // 
            this.PrecoCusto.HeaderText = "Preço custo";
            this.PrecoCusto.Name = "PrecoCusto";
            this.PrecoCusto.Width = 110;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Total Nota:";
            // 
            // txtTotalNota
            // 
            this.txtTotalNota.Location = new System.Drawing.Point(122, 465);
            this.txtTotalNota.Name = "txtTotalNota";
            this.txtTotalNota.Size = new System.Drawing.Size(148, 23);
            this.txtTotalNota.TabIndex = 24;
            // 
            // btnInserirNotaEntrada
            // 
            this.btnInserirNotaEntrada.Location = new System.Drawing.Point(287, 461);
            this.btnInserirNotaEntrada.Name = "btnInserirNotaEntrada";
            this.btnInserirNotaEntrada.Size = new System.Drawing.Size(162, 32);
            this.btnInserirNotaEntrada.TabIndex = 25;
            this.btnInserirNotaEntrada.Text = "Inserir Nota Entrada";
            this.btnInserirNotaEntrada.UseVisualStyleBackColor = true;
            this.btnInserirNotaEntrada.Click += new System.EventHandler(this.btnInserirNotaEntrada_Click);
            // 
            // btnCancelarNotaEntrada
            // 
            this.btnCancelarNotaEntrada.Location = new System.Drawing.Point(464, 461);
            this.btnCancelarNotaEntrada.Name = "btnCancelarNotaEntrada";
            this.btnCancelarNotaEntrada.Size = new System.Drawing.Size(162, 32);
            this.btnCancelarNotaEntrada.TabIndex = 26;
            this.btnCancelarNotaEntrada.Text = "Cancelar Nota Entrada";
            this.btnCancelarNotaEntrada.UseVisualStyleBackColor = true;
            this.btnCancelarNotaEntrada.Click += new System.EventHandler(this.btnCancelarNotaEntrada_Click);
            // 
            // frmNotasEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 511);
            this.Controls.Add(this.btnCancelarNotaEntrada);
            this.Controls.Add(this.btnInserirNotaEntrada);
            this.Controls.Add(this.txtTotalNota);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.txtQuantidadeProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLocalizarProdutos);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpEmissao);
            this.Controls.Add(this.btnLocalizarFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.btnCancelarProduto);
            this.Controls.Add(this.btnInserirProduto);
            this.Controls.Add(this.txtPrecoCustoProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNotasEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas de Entrada de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPrecoCustoProduto;
        private System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.Button btnCancelarProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLocalizarFornecedor;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLocalizarProdutos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalNota;
        private System.Windows.Forms.Button btnInserirNotaEntrada;
        private System.Windows.Forms.Button btnCancelarNotaEntrada;
        public System.Windows.Forms.TextBox txtIdFornecedor;
        public System.Windows.Forms.TextBox txtIdProduto;
        public System.Windows.Forms.TextBox txtNomeFornecedor;
        public System.Windows.Forms.TextBox txtDescricaoProduto;
    }
}