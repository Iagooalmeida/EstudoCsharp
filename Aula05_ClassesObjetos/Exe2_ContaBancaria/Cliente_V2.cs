using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe2_ContaBancaria
{
    class Cliente_V2
    {
        private string nome;
        private string cpf;
        private string rg;
        private string endereco;

        public string Nome
        {
            get
            {
                return this.nome;
            }

            set
            {
                this.nome = value;
            }
        }

        public string Cpf
        {
            get
            {
                return this.cpf;
            }

            set
            {
                this.cpf = value;
            }
        }

        public string Rg
        {
            get
            {
                return this.rg;
            }

            set
            {
                this.rg = value;
            }
        }

        public string Endereco
        {
            get
            {
                return this.endereco;
            }

            set
            {
                this.endereco = value;
            }
        }
    }
}
