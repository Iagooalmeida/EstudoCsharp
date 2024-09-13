using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe5_DiferencaMaiorMenor
{
    public partial class frmMaiorMenor : Form
    {
        public frmMaiorMenor()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            if (txtValor1.Text != string.Empty && txtValor2.Text != string.Empty)
            {
                int A = Convert.ToInt32(txtValor1.Text);
                int B = Convert.ToInt32(txtValor2.Text);

                if (A > B)
                    lblResultado.Text = "O resultado é: " + (A - B);
                else
                    lblResultado.Text = "O resultado é: " + (B - A);
            }
            else
                MessageBox.Show("Preencha todos os campos em branco!!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {           
            Calcular();
            txtValor1.Clear();
            txtValor2.Clear();
            txtValor1.Focus();
        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Informe um número válido!!");
            }
        }
    }
}
