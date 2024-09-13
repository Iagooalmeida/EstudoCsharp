using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe2_ContaBancaria
{
    class Cliente_V4
    {
        public string Nome { get; set; }
        private string cpf;
        public string Rg { get; set; }
        public string Endereco { get; set; }

        //Construtor da classe
        public Cliente_V4(string nome)
        {
            this.Nome = nome;
        }

        public Cliente_V4(string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }

        public Cliente_V4(string nome, string cpf, string rg)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Rg = rg;
        }

        public Cliente_V4(string nome, string cpf, string rg, string endereco)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Endereco = endereco;
        }

        public string Cpf
        {
            get
            {
                return this.cpf;
            }

            set
            {
                if (value.Length == 5)
                    this.cpf = value;
                else
                    this.cpf = "";
            }
        }
    }
}
