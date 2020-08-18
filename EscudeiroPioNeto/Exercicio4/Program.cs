using System;
using System.Collections.Generic;

namespace Exercicio4
{
    class Aluno
    {
        public Double Nota { get; set; }

        public String Nome { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            Console.WriteLine("Informe o nome e as notas, para encerrar deixe o nome em branco.");
            while (true)
            {
                Aluno aluno = new Aluno();
                Console.Write("Nome do aluno: ");
                aluno.Nome = Console.ReadLine();
                if (aluno.Nome.Trim().Equals(""))
                {
                    break;
                }
                Console.Write("Informe a nota do aluno: ");
                aluno.Nota = Double.Parse(Console.ReadLine());
                alunos.Add(aluno);
            }
            foreach (var item in alunos)
            {
                if (item.Nota >= 70)
                {
                    Console.WriteLine($"O aluno {item.Nome} atigiu nota maior que 70.");
                }
            }
        }
    }
}
