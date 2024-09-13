using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe2_ContaBancaria
{
    class Cliente_V1
    {
        private string nome;
        private string cpf;
        private string rg;
        private string endereco;

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public void SetRg(string rg)
        {
            this.rg = rg;
        }

        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetCpf()
        {
            return this.cpf;
        }

        public string GetRg()
        {
            return this.rg;
        }

        public string GetEndereco()
        {
            return this.endereco;
        }
    }
}
