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
    public partial class frmEscolaNatacaoV2 : Form
    {
        public frmEscolaNatacaoV2()
        {
            InitializeComponent();
            lblDataAtual.Text = "Hoje é " + DateTime.Now.ToShortDateString();
        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty || dtpDataNascimento.Text == string.Empty)
            {
                MessageBox.Show("Todos os dados solicitados devem ser informados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                TimeSpan tsQuantidadeDias = DateTime.Now.Date - dtpDataNascimento.Value;

                int idade = tsQuantidadeDias.Days / 365;

                MessageBox.Show("Sua idade é: " + idade, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (idade > 17)
                {
                    lblCategoria.Text = "Adulto";
                }
                else if (idade > 13)
                {
                    lblCategoria.Text = "Juvenil B";

                }
                else if (idade > 10)
                {
                    lblCategoria.Text = "Juvenil A";

                }
                else if (idade > 7)
                {

                    lblCategoria.Text = "Infantil B";

                }
                else if (idade >= 5)
                {

                    lblCategoria.Text = "Infantil A";

                }
                else
                {
                    lblCategoria.Text = "Sem categoria";
                }

            }
        }
    }
}
