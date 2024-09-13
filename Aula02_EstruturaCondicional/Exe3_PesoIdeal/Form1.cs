using System;
using System.Windows.Forms;

namespace Exe2_PesoIdeal
{
    public partial class frmPesoIdeal : Form
    {
        public frmPesoIdeal()
        {
            InitializeComponent();
            txtAltura.Focus();
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            if (txtAltura.Text != string.Empty)
            {
                double altura = double.Parse(txtAltura.Text);

                if (rbnMasculino.Checked)
                {
                    double masculino = (72.7 * altura) - 58;
                    lblResultado.Text = masculino.ToString("N") + " " + "Kg";
                }
                else if (rbnFeminino.Checked)
                {
                    double feminino = (62.1 * altura) - 44.7;
                    lblResultado.Text = feminino.ToString("N") + " " + "Kg";
                }
            }
            else
            {
                lblResultado.Text = "";
            }
        }

        private void rbnFeminino_Click(object sender, EventArgs e)
        {
            if (txtAltura.Text != string.Empty)
            {
                double altura = Convert.ToDouble(txtAltura.Text);

                if (rbnMasculino.Checked)
                {
                    double masculino = (72.7 * altura) - 58;
                    lblResultado.Text = masculino.ToString("N") + " " + "Kg";
                }
                else if (rbnFeminino.Checked)
                {
                    double feminino = (62.1 * altura) - 44.7;
                    lblResultado.Text = feminino.ToString("N") + " " + "Kg";
                }
            }

            /*if (rbnFeminino.Checked || rbnMasculino.Checked)
            {
                txtAltura.Clear();
            }*/
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
