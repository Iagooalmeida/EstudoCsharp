using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5_Funcionários
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdcional { get; set; }

        public FuncionarioTerceirizado(string nome, int horas, double valorHorasTrabalhadas, double despesaAdcional) : base(nome,horas,valorHorasTrabalhadas)
        {
            DespesaAdcional = despesaAdcional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + DespesaAdcional;
        }

        public override double Fgts()
        {
            return Pagamento() * 0.20;
        }
    }
}
