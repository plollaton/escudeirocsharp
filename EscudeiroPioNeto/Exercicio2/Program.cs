using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio2
{
    class Funcionario
    {
        public Funcionario()
        {
            Nome = new string("");
            Salario = 0;
        }
        public string Nome { get; set; }
        public double Salario { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            while (true)
            {
                Console.Write("Informe o nome do funcioário, para encerrar, deixe em branco: ");
                string funcNome = Console.ReadLine();
                if (funcNome.Trim().Length == 0)
                {
                    break;
                }
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = funcNome;
                Console.Write("Informe o salário: ");
                funcionario.Salario = Double.Parse(Console.ReadLine());
                funcionarios.Add(funcionario);
            }
            if(funcionarios.Count() == 0)
            {
                Console.WriteLine("Não foram cadastrados funcionários.");
                return;
            }

            Funcionario menorSalario = new Funcionario();
            Funcionario maiorSalario = new Funcionario();

            for(int i = 0; i <= funcionarios.Count() - 1; i++)
            {
                if (i == 0)
                {
                    menorSalario = funcionarios[i];
                    maiorSalario = funcionarios[i];
                    continue;
                }
                if(funcionarios[i].Salario < menorSalario.Salario)
                {
                    menorSalario = funcionarios[i];
                }
                if(funcionarios[i].Salario > maiorSalario.Salario)
                {
                    maiorSalario = funcionarios[i];
                }
            }
            Console.WriteLine($"{menorSalario.Nome} é o funcionário de menor salário, e o valor do salário é: {menorSalario.Salario}.");
            Console.WriteLine($"{maiorSalario.Nome} é o funcionário de maior salário, e o valor do salário é: {maiorSalario.Salario}.");
        }
    }
}
