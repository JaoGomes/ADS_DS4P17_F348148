using System;

namespace João_Gomes_F348148
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome = "João Gomes";
            string RA = "F348148";

            Aluno aluno = new Aluno(Nome, RA);

            Console.WriteLine(aluno.ApresentarAluno("Análise e Desenvolvimento de Sistemas"));
            Console.ReadKey();
        }
    }
}