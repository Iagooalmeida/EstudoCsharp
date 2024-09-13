using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe2_Bhaskara
{
    public partial class frmFormulaBhaskaraV1 : Form
    {
        public frmFormulaBhaskaraV1()
        {
            InitializeComponent();
        }

        private void Raizes(double a, double b, double c)
        {

            double x1, x2;

            if (a != 0 && b != 0 && c != 0)
            {
                double Delta = Math.Pow(b, 2) - (4 * a * c);

                if (Delta == 0)
                {
                    x1 = -b / (2 * a);
                    lblResultado.Text = "Existe apenas uma raiz: " + x1;
                }
                else if (Delta < 0)
                {                   
                    lblResultado.Text = "Não será possivel obter as raises";
                    MessageBox.Show("Delta menor que 0", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(Delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(Delta)) / (2 * a);

                    lblResultado.Text = ("A raiz 1 é: " + x1 + "\r\n" + "A raiz 2  é: " + x2);
                }
            }
            else 
            {
                lblResultado.Text = "";
                MessageBox.Show("O valor A, B, C devem ser diferente de zero!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValorA.Text != string.Empty && txtValorB.Text != string.Empty && txtValorC.Text != string.Empty)
            {
                try
                {
                    double a = Convert.ToDouble(txtValorA.Text);
                    double b = Convert.ToDouble(txtValorB.Text);
                    double c = Convert.ToDouble(txtValorC.Text);
                    Raizes(a, b, c);
                }
                catch (Exception)
                {
                    MessageBox.Show("Informe apenas valores numericos","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }              
            }
            else
                MessageBox.Show("Por favor, preencher todos os campos!!");
        }
    }
}
