using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace João_Gomes_F348148
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string RA { get; set; }

        public Pessoa (string Nome, string RA)
        {
            this.Nome = Nome;
            this.RA = RA;
        }
    }
}
