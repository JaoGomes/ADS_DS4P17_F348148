using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace João_Gomes_F348148
{
    internal class Aluno : Pessoa
    {

        public Aluno(string Nome, string RA) : base(Nome, RA)
        {
        }

        public string ApresentarAluno(string Curso)
        {
            if(Curso.Equals("Análise e Desenvolvimento de Sistemas"))
            {
                return "O aluno matriculado no curso de " + Curso + " é " + this.Nome + ", com o RA " + this.RA + ".";
            }
            else
            {
                return "Aluno não encontrado para o curso: " + Curso;
            }
            
        }
    }
}
