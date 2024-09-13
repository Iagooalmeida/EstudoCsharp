using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_ContaBancaria
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(int numero, string titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }
        /*
        public void Saque(double valor)
        {
            this.Saldo -= valor;
        }
        */

        //Sobrescrever metodos

        public virtual void Saque(double valor)
        {
            this.Saldo -= valor + 5.0;
        }


        public void Deposito(double valor)
        {
            this.Saldo += valor;
        }
    }
}
