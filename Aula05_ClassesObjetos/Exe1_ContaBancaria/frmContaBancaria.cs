using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe1_ContaBancaria
{
    public partial class frmContaBancaria : Form
    {
        Conta_V1 conta_V1;
        Conta_V2 conta_V2_1;
        Conta_V2 conta_V2_2;

        Cliente cliente;
        Conta_V3 conta_V3;
        public frmContaBancaria()
        {
            InitializeComponent();
        }

        private void btnCriarConta_V1_Click_1(object sender, EventArgs e)
        {
            // Instanciar objetos
            conta_V1 = new Conta_V1();

            //atribuir valores
            conta_V1.numero = 1002;
            conta_V1.titular = "Maria da Silva";
            conta_V1.saldo = 1000.00;

            // Mostrar o conteúdo do objeto
            MessageBox.Show("Nova conta: Número " + conta_V1.numero.ToString() + " / Titular: " + conta_V1.titular + " / Saldo: " + conta_V1.saldo.ToString());
        }

        private void btnSaqueConta_V1_Click(object sender, EventArgs e)
        {
            if (conta_V1.saldo < 500)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            else
            {
                conta_V1.saldo -= 500;
                MessageBox.Show("Atualização conta: Número " + conta_V1.numero.ToString() + " / Titular: " + conta_V1.titular + " / Saldo: " + conta_V1.saldo.ToString());
            }
        }

        private void btnCriarContaV1_1_Click(object sender, EventArgs e)
        {
            conta_V2_1 = new Conta_V2();

            conta_V2_1.numero = Convert.ToInt32(txtNumeroV2_1.Text);
            conta_V2_1.titular = txtTitularV2_1.Text;
            conta_V2_1.saldo = Convert.ToDouble(txtSaldoV1_1.Text);

            MessageBox.Show("Nova conta: Número " + conta_V2_1.numero.ToString() + " / Titular: " + conta_V2_1.titular + " / Saldo: " + conta_V2_1.saldo.ToString());
        }

        private void btnSaqueContaV1_1_Click(object sender, EventArgs e)
        {
            if (conta_V2_1.Saque(Convert.ToDouble(txtSaqueV2_1.Text)))
            {
                MessageBox.Show("Atualição conta: Número " + conta_V2_1.numero.ToString() + " / Titular: " + conta_V2_1.titular + " / Saldo: " + conta_V2_1.saldo.ToString());
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }          
        }

        private void btnDepositoContaV1_1_Click(object sender, EventArgs e)
        {
            conta_V2_1.Deposito(Convert.ToDouble(txtDepositoV2_1.Text));

            MessageBox.Show("Atualização conta: Número " + conta_V2_1.numero.ToString() + " / Titular: " + conta_V2_1.titular + " / Saldo: " + conta_V2_1.saldo.ToString());
        }

        private void btnCriarContaV2_2_Click(object sender, EventArgs e)
        {
            conta_V2_2 = new Conta_V2();

            conta_V2_2.numero = Convert.ToInt32(txtNumeroV2_2.Text);
            conta_V2_2.titular = txtTitularV2_2.Text;
            conta_V2_2.saldo = Convert.ToDouble(txtSaldoV2_2.Text);

            MessageBox.Show("Nova conta: Número " + conta_V2_2.numero.ToString() + " / Titular: " + conta_V2_2.titular + " / Saldo: " + conta_V2_2.saldo.ToString());
        }

        private void btnTranferenciaConta_V2_2_Click(object sender, EventArgs e)
        {
            if (conta_V2_2.Transfere(Convert.ToDouble(txtTransferenciaV2_2.Text), conta_V2_1))
            {
                MessageBox.Show("Atualização conta: Número " + conta_V2_1.numero.ToString() + " / Titular: " + conta_V2_1.titular + " / Saldo: " + conta_V2_1.saldo.ToString());

                MessageBox.Show("Atualização conta: Número " + conta_V2_2.numero.ToString() + " / Titular: " + conta_V2_2.titular + " / Saldo: " + conta_V2_2.saldo.ToString());
            }
            else
                MessageBox.Show("Saldo insuficiente");
        }

        private void btnCriarCliente_Click(object sender, EventArgs e)
        {
            cliente = new Cliente();
            cliente.nome = txtNomeCliente.Text;
            cliente.cpf = txtCpfCliente.Text;
            cliente.rg = txtRgCliente.Text;
            cliente.endereco = txtEnderecoCliente.Text;

            MessageBox.Show("Novo Cliente: nome " + cliente.nome + " / CPF: " + cliente.cpf + " / RG: " + cliente.cpf + " / Endereço: " + cliente.endereco);
        }
    }
}
