using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class frmTabuada_v1 : Form
    {
        public frmTabuada_v1()
        {
            InitializeComponent();
        }


        private void btnFor_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != string.Empty)
            {
                try
                {
                    int numero1 = int.Parse(txtNum.Text);
                    int resultado;

                    lbxResultado.Items.Clear();

                    for (int i = 0; i < 10; i++)
                    {
                        resultado = numero1 * i;

                        lbxResultado.Items.Add(numero1 + " X " + i + " = " + resultado);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Informe um valor numerico inteiro");
                }
                
            }
            else
                MessageBox.Show("Informe um valor numero");
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != string.Empty)
            {
                try
                {
                    int numero1 = int.Parse(txtNum.Text);
                    int resultado, i = 0;

                    lbxResultado.Items.Clear();

                    while (i <= 10)
                    {
                        resultado = numero1 * i;

                        lbxResultado.Items.Add(numero1 + " X " + i + " = " + resultado);
                        i++;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe um valor numerico inteiro");
                }

            }
            else
                MessageBox.Show("Informe um valor numero");

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {

            int numero1 = int.Parse(txtNum.Text);
            int resultado, i = 0;

            lbxResultado.Items.Clear();
            do
            {
                resultado = numero1 * i;

                lbxResultado.Items.Add(numero1 + " X " + i + " = " + resultado);
                i++;
            } while (i <= 10);
        }
    }
}
