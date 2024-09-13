using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5_Funcionários
{
    abstract class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHorasTrabalhadas { get; set; }

        public Funcionario(string nome, int horas, double valorHorasTrabalhadas)
        {
            Nome = nome;
            Horas = horas;
            ValorHorasTrabalhadas = valorHorasTrabalhadas;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorHorasTrabalhadas;
        }

        public abstract double Fgts();
    }
}
