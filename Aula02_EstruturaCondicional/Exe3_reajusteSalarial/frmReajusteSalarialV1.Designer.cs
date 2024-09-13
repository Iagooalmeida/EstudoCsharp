namespace Exe3_reajusteSalarial
{
    partial class frmCalculoSalario
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
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.rdbVeterano = new System.Windows.Forms.RadioButton();
            this.rdbCalouro = new System.Windows.Forms.RadioButton();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.rdbNoturno = new System.Windows.Forms.RadioButton();
            this.rdbVespertino = new System.Windows.Forms.RadioButton();
            this.rdbMatutino = new System.Windows.Forms.RadioButton();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.lblSituacaoSalarial = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbxCategoria.SuspendLayout();
            this.gbxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Mínimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Trabalhadas:";
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(182, 38);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioMinimo.TabIndex = 2;
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(182, 70);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTrabalhadas.TabIndex = 3;
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.rdbVeterano);
            this.gbxCategoria.Controls.Add(this.rdbCalouro);
            this.gbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.gbxCategoria.Location = new System.Drawing.Point(45, 107);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(236, 57);
            this.gbxCategoria.TabIndex = 4;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // rdbVeterano
            // 
            this.rdbVeterano.AutoSize = true;
            this.rdbVeterano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbVeterano.Location = new System.Drawing.Point(128, 23);
            this.rdbVeterano.Name = "rdbVeterano";
            this.rdbVeterano.Size = new System.Drawing.Size(84, 21);
            this.rdbVeterano.TabIndex = 1;
            this.rdbVeterano.TabStop = true;
            this.rdbVeterano.Text = "Veterano";
            this.rdbVeterano.UseVisualStyleBackColor = true;
            // 
            // rdbCalouro
            // 
            this.rdbCalouro.AutoSize = true;
            this.rdbCalouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbCalouro.Location = new System.Drawing.Point(30, 23);
            this.rdbCalouro.Name = "rdbCalouro";
            this.rdbCalouro.Size = new System.Drawing.Size(75, 21);
            this.rdbCalouro.TabIndex = 0;
            this.rdbCalouro.TabStop = true;
            this.rdbCalouro.Text = "Calouro";
            this.rdbCalouro.UseVisualStyleBackColor = true;
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.rdbNoturno);
            this.gbxTurno.Controls.Add(this.rdbVespertino);
            this.gbxTurno.Controls.Add(this.rdbMatutino);
            this.gbxTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.gbxTurno.Location = new System.Drawing.Point(300, 32);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(145, 132);
            this.gbxTurno.TabIndex = 5;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // rdbNoturno
            // 
            this.rdbNoturno.AutoSize = true;
            this.rdbNoturno.Location = new System.Drawing.Point(32, 90);
            this.rdbNoturno.Name = "rdbNoturno";
            this.rdbNoturno.Size = new System.Drawing.Size(73, 20);
            this.rdbNoturno.TabIndex = 2;
            this.rdbNoturno.TabStop = true;
            this.rdbNoturno.Text = "Noturno";
            this.rdbNoturno.UseVisualStyleBackColor = true;
            // 
            // rdbVespertino
            // 
            this.rdbVespertino.AutoSize = true;
            this.rdbVespertino.Location = new System.Drawing.Point(32, 60);
            this.rdbVespertino.Name = "rdbVespertino";
            this.rdbVespertino.Size = new System.Drawing.Size(91, 20);
            this.rdbVespertino.TabIndex = 1;
            this.rdbVespertino.TabStop = true;
            this.rdbVespertino.Text = "Vespertino";
            this.rdbVespertino.UseVisualStyleBackColor = true;
            // 
            // rdbMatutino
            // 
            this.rdbMatutino.AutoSize = true;
            this.rdbMatutino.Location = new System.Drawing.Point(32, 30);
            this.rdbMatutino.Name = "rdbMatutino";
            this.rdbMatutino.Size = new System.Drawing.Size(76, 20);
            this.rdbMatutino.TabIndex = 0;
            this.rdbMatutino.TabStop = true;
            this.rdbMatutino.Text = "Matutino";
            this.rdbMatutino.UseVisualStyleBackColor = true;
            // 
            // lbxResumo
            // 
            this.lbxResumo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.25F);
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 16;
            this.lbxResumo.Location = new System.Drawing.Point(45, 179);
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.Size = new System.Drawing.Size(400, 148);
            this.lbxResumo.TabIndex = 6;
            // 
            // lblSituacaoSalarial
            // 
            this.lblSituacaoSalarial.BackColor = System.Drawing.Color.Yellow;
            this.lblSituacaoSalarial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSituacaoSalarial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.lblSituacaoSalarial.Location = new System.Drawing.Point(44, 342);
            this.lblSituacaoSalarial.Name = "lblSituacaoSalarial";
            this.lblSituacaoSalarial.Size = new System.Drawing.Size(275, 33);
            this.lblSituacaoSalarial.TabIndex = 7;
            this.lblSituacaoSalarial.Text = "Situação Salarial";
            this.lblSituacaoSalarial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCalcular.Location = new System.Drawing.Point(330, 340);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 35);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCalculoSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 386);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSituacaoSalarial);
            this.Controls.Add(this.lbxResumo);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.gbxCategoria);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCalculoSalario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Salário";
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.RadioButton rdbVeterano;
        private System.Windows.Forms.RadioButton rdbCalouro;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton rdbNoturno;
        private System.Windows.Forms.RadioButton rdbVespertino;
        private System.Windows.Forms.RadioButton rdbMatutino;
        private System.Windows.Forms.ListBox lbxResumo;
        private System.Windows.Forms.Label lblSituacaoSalarial;
        private System.Windows.Forms.Button btnCalcular;
    }
}

