using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5_Funcionários
{
    class FuncionarioInterno : Funcionario
    {
        public double ValeAlimentacao { get; set; }

        public FuncionarioInterno(string nome, int horas, double valorHorasTrabalhadas, double valeAlimentacao) : base(nome, horas, valorHorasTrabalhadas)
        {
            ValeAlimentacao = valeAlimentacao;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + ValeAlimentacao;
        }

        public override double Fgts()
        {
            return Pagamento() * 0.15;
        }
    }
}
