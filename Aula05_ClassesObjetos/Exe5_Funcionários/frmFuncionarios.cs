using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe5_Funcionários
{
    public partial class frmFuncionarios : Form
    {
        List<Funcionario> listaFuncionario = new List<Funcionario>();

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        public void CarregarGrid()
        {
            int numLinha = 0;
            dgvFuncionario.Rows.Clear();

            foreach(Funcionario funcionario in listaFuncionario)
            {
                dgvFuncionario.Rows.Add();
                dgvFuncionario[0, numLinha].Value = funcionario.Nome;
                dgvFuncionario[1, numLinha].Value = funcionario.Pagamento();
                dgvFuncionario[2, numLinha].Value = funcionario.Fgts();
                numLinha++;
            }
        }

        private void rbInterno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInterno.Checked)
            {
                lblValeAlimentacao.Visible = true;
                txtValeAlimentacao.Visible = true;
                txtValeAlimentacao.Clear();

                lblDespesaAdcional.Visible = false;
                txtDespesaAdcional.Visible = false;
                txtDespesaAdcional.Clear();
            }
        }

        private void rbTerceirizado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTerceirizado.Checked)
            {
                lblValeAlimentacao.Visible = false;
                txtValeAlimentacao.Visible = false;
                txtValeAlimentacao.Clear();

                lblDespesaAdcional.Visible = true;
                txtDespesaAdcional.Visible = true;
                txtDespesaAdcional.Clear();
            }
        }

        private void btnCriarFuncionario_Click(object sender, EventArgs e)
        {
            if (rbInterno.Checked)
            {
                listaFuncionario.Add(new FuncionarioInterno(txtNome.Text, Convert.ToInt32(txtHorasTrabalhadas.Text), Convert.ToDouble(txtValorPorHora.Text), Convert.ToDouble(txtValeAlimentacao.Text)));

                CarregarGrid();
            }

            if (rbTerceirizado.Checked)
            {
                listaFuncionario.Add(new FuncionarioTerceirizado(txtNome.Text, Convert.ToInt32(txtHorasTrabalhadas.Text), Convert.ToDouble(txtValorPorHora.Text), Convert.ToDouble(txtDespesaAdcional.Text)));

                CarregarGrid();
            }
        }

        private void btnTotalPagamentos_Click(object sender, EventArgs e)
        {
            double totalPagamento = 0;
            foreach (Funcionario funcionario in listaFuncionario)
            {
                totalPagamento += funcionario.Pagamento();
            }

            lblTotalPagamentos.Text = "Total Pagamentos: " + totalPagamento;
        }

        private void btnTotalFgts_Click(object sender, EventArgs e)
        {
            double totalFgts = 0;
            foreach (Funcionario funcionario in listaFuncionario)
            {
                totalFgts += funcionario.Fgts();
            }

            lblTotalPagamentos.Text = "Total Pagamentos: " + totalFgts;
        }
    }
}
