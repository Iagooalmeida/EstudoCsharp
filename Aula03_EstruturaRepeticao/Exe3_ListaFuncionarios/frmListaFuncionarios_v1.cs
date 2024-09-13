using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe3_ListaFuncionarios
{
    public partial class frmListaFuncionarios_v1 : Form
    {
        public frmListaFuncionarios_v1()
        {
            InitializeComponent();
            dgvFuncionarios.ColumnCount = 2;
            dgvFuncionarios.Columns[0].HeaderText = "Nome";
            dgvFuncionarios.Columns[0].Width = 230;
            dgvFuncionarios.Columns[1].HeaderText = "Salário";
            dgvFuncionarios.Columns[1].Width = 80;
        }

        private void btnCriarLinhas_Click(object sender, EventArgs e)
        {
            int numFuncionario = Convert.ToInt32(txtNumFuncionario.Text);

            int i = 0;

            do
            {
                dgvFuncionarios.Rows.Add();
                dgvFuncionarios[0, i].Value = String.Empty;
                dgvFuncionarios[1, i].Value = "0";
                i++;
            } while (i < numFuncionario);

            txtNumFuncionario.Enabled = false;
            btnCriarLinhas.Enabled = false;
            btnCriarArquivos.Enabled = true;
            btnReiniciar.Enabled = true;         
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.Rows.Clear();
            txtNumFuncionario.Text = string.Empty;
            txtNumFuncionario.Enabled = true;
            btnCriarLinhas.Enabled = true;
            btnCriarArquivos.Enabled = false;
            btnReiniciar.Enabled = false;
        }

        private void GerarArquivo()
        {
            StreamWriter wr = new StreamWriter(sfdGravacaoArquivos.FileName, true);

            for (int i = 0; i <dgvFuncionarios.Rows.Count - 1; i++)
            {
                wr.WriteLine(dgvFuncionarios[0, i].Value.ToString() + ";" + dgvFuncionarios[1, i].Value.ToString());
            }
            wr.Close();
        }

        private bool ValidarDados()
        {
            bool dadosValidos = true;
            int i = 0;
            double d;

            do
            {
                if (string.IsNullOrWhiteSpace(dgvFuncionarios[0, i].Value.ToString()))
                    dadosValidos = false;

                if (!Double.TryParse(dgvFuncionarios[1, i].Value.ToString(), out d))
                    dadosValidos = false;

                i++;

            } while (i < dgvFuncionarios.Rows.Count - 1);

            return dadosValidos;
        }

        private void btnCriarArquivos_Click(object sender, EventArgs e)
        {
            if (!ValidarDados())
            {
                MessageBox.Show("Os dados possuem problemas. verifique se não deixou nenhum nome em branco ou se existe um valor correto para os salarios de cada um");
            }
            else if(sfdGravacaoArquivos.ShowDialog() == DialogResult.OK)
            {
                GerarArquivo();
                MessageBox.Show("Arquivo gerado com sucesso");
            }
        }
    }
}
