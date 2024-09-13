using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe2_ContaBancaria
{
    class Cliente_V3
    {
        public string Nome { get; set; }
        private string cpf;
        public string Rg { get; set; }
        public string Endereco { get; set; }

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
