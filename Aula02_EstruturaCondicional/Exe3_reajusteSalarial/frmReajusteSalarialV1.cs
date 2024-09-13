using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe3_reajusteSalarial
{
    public partial class frmCalculoSalario : Form
    {
        public frmCalculoSalario()
        {
            InitializeComponent();
        }

        private void RealizarProcessamento(RadioButton rdbTurno, RadioButton rdbCategoria, double horasTrabalhadas, double valorSalarioMinimo)
        {
            double valorCoeficiente = GetCoeficiente(rdbTurno, valorSalarioMinimo);
            double valorSalarioBruto = GetSalarioBruto(valorCoeficiente, horasTrabalhadas);
            double valorImposto = GetImposto(rdbCategoria, valorSalarioBruto);
            double valorGratificacao = GetvalorGratificacao(rdbTurno, horasTrabalhadas);
            double auxilioAlimentacao = GetauxilioAlimentacao(rdbCategoria, valorSalarioMinimo, valorSalarioBruto);
            double valorSalarioLiquido = GetSalarioLiquido(valorSalarioBruto, valorImposto, valorGratificacao, auxilioAlimentacao);
            string situacaoSalarial = GetSituacaoSalarial(valorSalarioLiquido);

            ApresentarResultado(valorCoeficiente, valorSalarioBruto, valorImposto, valorGratificacao, auxilioAlimentacao, valorSalarioLiquido, situacaoSalarial);
        }

        private void ApresentarResultado(double valorCoeficiente, double valorSalarioBruto, double valorImposto, double valorGratificacao, double auxilioAlimentacao, double valorSalarioLiquido, string situacaoSalarial)
        {
            lbxResumo.Items.Clear();
            lbxResumo.Items.Add(String.Format("{0, -29}{1,12:C}", "Valor do coeficiente:", valorCoeficiente));
            lbxResumo.Items.Add(String.Format("{0, -29}{1,12:C}", "Valor do salário bruto:", valorSalarioBruto));
            lbxResumo.Items.Add(String.Format("{0, -29}{1,12:C}", "Valor do imposto:", valorImposto));
            lbxResumo.Items.Add(String.Format("{0, -29}{1,12:C}", "Valor da gratificação:", valorGratificacao));
            lbxResumo.Items.Add(String.Format("{0, -29}{1,12:C}", "Valor da alimentação:", auxilioAlimentacao));
            lbxResumo.Items.Add(String.Format("{0, -29}{1,12:C}", "Valor do salario liquido:", valorSalarioLiquido));
            lblSituacaoSalarial.Text = situacaoSalarial.ToString();
        }
        private double GetCoeficiente(RadioButton rdbTurno, double valorSalarioMinimo)
        {
            double valorCoeficiente = 0;

            switch (rdbTurno.Text)
            {
                case "Matutino":
                    valorCoeficiente = valorSalarioMinimo * 0.01;
                    break;
                case "Vespertino":
                    valorCoeficiente = valorSalarioMinimo * 0.02;
                    break;
                case "Noturno":
                    valorCoeficiente = valorSalarioMinimo * 0.03;
                    break;
            }

            return valorCoeficiente;
        }

        private double GetSalarioBruto(double valorCoeficiente, double horasTrabalhadas)
        {
            double valorSalarioBruto;

            valorSalarioBruto = valorCoeficiente * horasTrabalhadas;

            return valorSalarioBruto;
        }

        private double GetImposto(RadioButton rdbCategoria, double valorSalarioBruto)
        {
            double valorImposto = 0;

            switch(rdbCategoria.Text)
            {
                case "Calouro":
                    if (valorSalarioBruto < 300)
                        valorImposto = valorSalarioBruto * 0.01;
                    else
                        valorImposto = valorSalarioBruto * 0.02;
                    break;

                case "Veterano":
                    if (valorSalarioBruto < 400)
                        valorImposto = valorSalarioBruto * 0.03;
                    else
                        valorImposto = valorSalarioBruto * 0.04;
                    break;
            }

            return valorImposto;
        }

        private double GetvalorGratificacao(RadioButton rdbTurno, double horasTrabalhadas)
        {
            double valorGratificacao;

            if (rdbTurno.Text.Equals ("Noturno") && horasTrabalhadas > 80)
                valorGratificacao = 50;
            else
                valorGratificacao = 30;

            return valorGratificacao;
        }

        private double GetauxilioAlimentacao(RadioButton rdbCategoria, double valorSalarioMinimo, double valorSalarioBruto)
        {
            double auxilioAlimentacao;

            if (rdbCategoria.Text.Equals("Calouro") || valorSalarioBruto < valorSalarioMinimo / 2)
                auxilioAlimentacao = valorSalarioBruto / 3;
            else
                auxilioAlimentacao = (valorSalarioBruto / 3) / 2;

            return auxilioAlimentacao;
        }

        private double GetSalarioLiquido(double valorSalarioBruto, double valorImposto, double valorGratificacao, double auxilioAlimentacao)
        {
            double valorSalarioLiquido;

            valorSalarioLiquido = valorSalarioBruto + valorGratificacao + auxilioAlimentacao - valorImposto;

            return valorSalarioLiquido;
        }

        private string GetSituacaoSalarial(double valorSalarioLiquido)
        {
            string situacaoSalarial;

            if (valorSalarioLiquido > 600)
                situacaoSalarial = "Situação: Bem remunerado";
            else if (valorSalarioLiquido >= 350 && valorSalarioLiquido <= 600)
                situacaoSalarial = "Situação: Remuneração normal";
            else
                situacaoSalarial = "Situação: Mal remunerado";

            return situacaoSalarial;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            RadioButton rdbTurno = gbxTurno.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);

            RadioButton rdbCategoria = gbxCategoria.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);

            RealizarProcessamento(rdbTurno, rdbCategoria, Convert.ToDouble(txtHorasTrabalhadas.Text), Convert.ToDouble(txtSalarioMinimo.Text));
        }
    }
}
