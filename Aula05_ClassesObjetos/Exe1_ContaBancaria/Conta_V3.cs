using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1_ContaBancaria
{
    class Conta_V3
    {
        public int numero;
        public Cliente titular;
        public double saldo;

        public bool Saque(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Deposito(double Valor)
        {
            this.saldo += Valor;
        }

        public bool Transfere(double valor, Conta_V2 destino)
        {
            if (this.Saque(valor))
            {
                destino.Deposito(valor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
