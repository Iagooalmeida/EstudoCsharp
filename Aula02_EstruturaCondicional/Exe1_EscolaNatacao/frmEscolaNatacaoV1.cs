using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe1_EscolaNatacao
{
    public partial class frmEscolaNatacaoV1 : Form
    {
        public frmEscolaNatacaoV1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == string.Empty || txtAnoNascimento.Text == string.Empty || txtUltimoAno.Text == string.Empty)
            {
                MessageBox.Show("Todos os dados solicitados devem ser informados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 

                int idade = Convert.ToInt32(txtUltimoAno.Text) - Convert.ToInt32(txtAnoNascimento.Text);

                if (idade > 17)
                {
                    lblCategoria.Text = "Adulto";
                }
                else if (idade > 13)
                {
                    lblCategoria.Text = "Juvenil B";

                } else if (idade > 10)
                {
                    lblCategoria.Text = "Juvenil A";

                } else if (idade > 7) {

                    lblCategoria.Text = "Infantil B";

                } else if (idade >= 5) {

                    lblCategoria.Text = "Infantil A";

                }
                else
                {
                    lblCategoria.Text = "Sem categoria";
                }

            }
        }

        private void txtUltimoAno_Enter(object sender, EventArgs e)
        {
            if (txtAnoNascimento.Text.Trim().Length != 4)
            {
                MessageBox.Show("É preciso verificar o ANO de NASCIMENTO com 4 digitos","Atenção", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }
        }

        private void txtUltimoAno_Validated(object sender, EventArgs e)
        {
            if (txtAnoNascimento.Text != string.Empty && txtUltimoAno.Text != string.Empty)
            {
                if (Convert.ToInt32(txtUltimoAno.Text) <= Convert.ToInt32(txtAnoNascimento.Text))
                {
                    MessageBox.Show("O ANO DO ÚLTIMO ANIVERSÁRIO deve ser superior ao ANO DE NASCIMENTO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //e.Cancel = true;             
                }
            }
        }
    }
}
