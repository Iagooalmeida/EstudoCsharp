using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe1_ConsumoEnergia
{
    public partial class FrmConsumoEnergia_V1 : Form
    {
        int numLinha = 0;

        public FrmConsumoEnergia_V1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(!TemRegistroCasa(txtNumCasa.Text, numLinha))
            {
                dgvLeituras.Rows.Add();
                dgvLeituras[0, numLinha].Value = txtNumCasa.Text;
                dgvLeituras[1, numLinha].Value = txtConsumo.Text;
                dgvLeituras[2, numLinha].Value = (Convert.ToDouble(txtConsumo.Text) * 0.2).ToString();

                numLinha++;

                txtNumCasa.Clear();
                txtConsumo.Clear();
                txtNumCasa.Focus();
            }          
        }

        private bool TemRegistroCasa(string casa, int numLinha)
        {
            bool registro = false;

            for (int i = 0; 1 < numLinha; i++)
            {
                if (dgvLeituras[0, i].Value.Equals(casa))
                {
                    MessageBox.Show("A Leitura para essa casa ja foi registrada","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    registro = true;
                }
            }

            return registro;
        }

        private void ProcessarDados(int numLinha)
        {
            double totalConsumo = 0;
            double totalDesconto = 0;

            for (int i = 0; i < numLinha; i++)
            {
                totalConsumo += Convert.ToDouble(dgvLeituras[1, i].Value);
                totalDesconto += Convert.ToDouble(dgvLeituras[2, i].Value);
            }

            dgvLeituras[0, numLinha].Value = "Total";
            dgvLeituras[1, numLinha].Value = totalConsumo.ToString();
            dgvLeituras[2, numLinha].Value = totalDesconto.ToString();

            lblTotalConsumo.Text = "Total Consumo com desconto: " + (totalConsumo - totalDesconto).ToString();
        }

        private void btnProcessarDados_Click(object sender, EventArgs e)
        {
            ProcessarDados(numLinha);
        }
    }
}
