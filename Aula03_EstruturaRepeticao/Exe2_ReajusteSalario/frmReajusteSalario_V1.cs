using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe2_ReajusteSalario
{
    public partial class frmReajusteSalario_V1 : Form
    {
        int numLinha = 0;

        public frmReajusteSalario_V1()
        {
            InitializeComponent();
        }

        private void ProcessarArquivo(string nomeArquivo)
        {
            string linhaLida;
            int codigo = 0;
            double salario = 0;
            double percentual = 0;
            double novoSalario = 0;

            var arquivo = new System.IO.StreamReader(nomeArquivo);

            while ((linhaLida = arquivo.ReadLine()) != null)
            {
                var dadosLidos = linhaLida.Split(';');
                codigo = Convert.ToInt32(dadosLidos[0]);
                salario = Convert.ToDouble(dadosLidos[1]);
                percentual = GetCalcPercentual(salario);
                novoSalario = salario * percentual + salario; 

                dgvSalarios.Rows.Add();
                dgvSalarios[0, numLinha].Value = codigo.ToString();
                dgvSalarios[1, numLinha].Value = salario.ToString();
                dgvSalarios[2, numLinha].Value = percentual.ToString();
                dgvSalarios[3, numLinha].Value = novoSalario;

                numLinha++;
            }         
        }

        private void totalValores()
        {
            double totalSemReajuste = 0;
            double totalComReajuste = 0;
            double percentualReajuste;

            for (int i = 0; i < numLinha; i++)
            {
               totalSemReajuste += Convert.ToDouble(dgvSalarios[1, i].Value);
                totalComReajuste += Convert.ToDouble(dgvSalarios[3, i].Value);
            }

            lblTotalSemReajuste.Text = totalSemReajuste.ToString();
            lblTotalComRejuste.Text = totalComReajuste.ToString();
            percentualReajuste = (totalComReajuste - totalSemReajuste) * 100 / totalSemReajuste;
            lblPercentualReajuste.Text = percentualReajuste.ToString("N2");
        }

        private double GetCalcPercentual(double salario)
        {
            double percentual;

                if (salario < 1000)
                {
                    percentual = 0.15;
                }
                else if (salario >= 1000 && salario <= 1500)
                {
                    percentual = 0.10;
                }
                else
                    percentual = 0.05;
            
            
            return percentual;
        } 

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            if (ofdListaFuncionarios.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = ofdListaFuncionarios.FileName;
                ProcessarArquivo(txtArquivo.Text);
            }

            totalValores();
        }
    }
}
