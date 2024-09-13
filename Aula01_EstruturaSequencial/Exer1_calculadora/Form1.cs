using System;
using System.Windows.Forms;

namespace Exer1_calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtPrimeiroNumero.Text == string.Empty || txtSegundoNumero.Text == string.Empty)
            {
                MessageBox.Show("Erro, informe um numero!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrimeiroNumero.Focus();
            }
            else
            {
                int N1 = Convert.ToInt32(txtPrimeiroNumero.Text);
                int N2 = Convert.ToInt32(txtSegundoNumero.Text);
                int resultado = N1 + N2;
                txtResultado.Text = Convert.ToString(resultado);
                txtPrimeiroNumero.Clear();
                txtSegundoNumero.Clear();
                txtPrimeiroNumero.Focus();
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (txtPrimeiroNumero.Text == string.Empty || txtSegundoNumero.Text == string.Empty)
            {
                MessageBox.Show("Erro, informe um numero!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrimeiroNumero.Focus();
            }
            else
            {
                int N1 = Convert.ToInt32(txtPrimeiroNumero.Text);
                int N2 = Convert.ToInt32(txtSegundoNumero.Text);
                int resultado = N1 - N2;
                txtResultado.Text = Convert.ToString(resultado);
                txtPrimeiroNumero.Clear();
                txtSegundoNumero.Clear();
                txtPrimeiroNumero.Focus();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtPrimeiroNumero.Text == string.Empty || txtSegundoNumero.Text == string.Empty)
            {
                MessageBox.Show("Erro, informe um numero valido!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrimeiroNumero.Focus();
            }
            else
            {
                int N1, N2, resultado;
                N1 = int.Parse(txtPrimeiroNumero.Text);
                N2 = int.Parse(txtSegundoNumero.Text);
                resultado = N1 * N2;
                txtResultado.Text = resultado.ToString();
                txtPrimeiroNumero.Clear();
                txtSegundoNumero.Clear();
                txtPrimeiroNumero.Focus();
            }

        }

        private void BtnDivisao(object sender, EventArgs e)
        {
            if (txtPrimeiroNumero.Text == string.Empty || txtSegundoNumero.Text == string.Empty)
            {
                MessageBox.Show("Erro, informe um numero valido!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrimeiroNumero.Focus();
            }
            else
            {
                float N1, N2, Resultado;
                N1 = float.Parse(txtPrimeiroNumero.Text);
                N2 = float.Parse(txtSegundoNumero.Text);
                if (N2 == 0)
                {
                    MessageBox.Show("ERRO - Divisão zero!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSegundoNumero.Clear();
                    txtSegundoNumero.Focus();
                }
                else
                {
                    Resultado = N1 / N2;
                    txtResultado.Text = Resultado.ToString();
                    txtPrimeiroNumero.Clear();
                    txtSegundoNumero.Clear();
                    txtPrimeiroNumero.Focus();
                }
            }
        }
    }
}
