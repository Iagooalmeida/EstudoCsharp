using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_ContaBancaria
{
    class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca(int numero, string titular, double saldo, double taxajuros) : base(numero,titular,saldo)
        {
            this.TaxaJuros = taxajuros;
        }

        public void AtualizaSaldo()
        {
            this.Saldo += this.Saldo * this.TaxaJuros;
        }

        public override void Saque(double valor)
        {
            // this.Saldo -= valor;
            base.Saque(valor);
            this.Saldo -= 2.0;
        }
    }
}
