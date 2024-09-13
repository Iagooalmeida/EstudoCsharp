using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe1_OrdemCrescente
{
    public partial class frmOrdemCrescente : Form
    {
        public frmOrdemCrescente()
        {
            InitializeComponent();
            lblResultado.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text != string.Empty && txtValor2.Text != string.Empty && txtValor3.Text != string.Empty)
            {
                try
                {
                    int valor1 = Convert.ToInt32(txtValor1.Text);
                    int valor2 = Convert.ToInt32(txtValor2.Text);
                    int valor3 = Convert.ToInt32(txtValor3.Text);
                    string resultado;

                    if (valor3 > valor1 && valor3 > valor2)
                    {
                        if (valor2 > valor1)
                        {
                            resultado = "A:" + valor1 + " B:" + valor2 + " C:" + valor3;
                            lblResultado.Text = resultado;
                        }
                        else
                        {
                            resultado = "B:" + valor2 + " A:" + valor1 + " C:" + valor3;
                            lblResultado.Text = resultado;
                        }
                    }

                    if (valor2 > valor1 && valor2 > valor3)
                    {
                        if (valor3 > valor1)
                        {
                            resultado = "A:" + valor1 + " C:" + valor3 + " B:" + valor2;
                            lblResultado.Text = resultado;
                        }
                        else
                        {
                            resultado = "C:" + valor3 + " A:" + valor1 + " B:" + valor2;
                            lblResultado.Text = resultado;
                        }
                    }

                    if (valor1 > valor2 && valor1 > valor3)
                    {
                        if (valor3 > valor2)
                        {
                            resultado = "B:" + valor2 + " C:" + valor3 + " A:" + valor1;
                            lblResultado.Text = resultado;
                        }
                        else
                        {
                            resultado = "C:" + valor3 + " B:" + valor2 + " A:" + valor1;
                            lblResultado.Text = resultado;
                        }
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Informe apenas numeros inteiro","ATENÇÂO",MessageBoxButtons.OK ,MessageBoxIcon.Information);
                }               
            }
            else
                MessageBox.Show("Campo em branco, preencha todos os campos", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            LimparTela();
        }

        private void LimparTela()
        {
            txtValor1.Clear();
            txtValor2.Text = string.Empty;
            txtValor3.Text = "";
            txtValor1.Focus();
        }
    }
}
 
