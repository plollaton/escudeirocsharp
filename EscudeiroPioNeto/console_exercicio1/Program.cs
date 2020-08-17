using System;
using System.Linq;

namespace console_exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = new double[] { 0, 0 };
            string ordemNumero = "primeiro";
            int idx = 0;
            while(true)
            {
                Console.Write($"Informe o {ordemNumero} número para cálculo: ");
                var valor = Console.ReadLine();
                try 
                { 
                    valores[idx] = Double.Parse(valor);
                }
                catch(FormatException)
                {
                    Console.WriteLine("O valor informado não é um número, por favor, informe novamente.");
                    continue;
                }
                if (idx == 0)
                {
                    ordemNumero = "próximo";
                }
                if (idx == 1)
                {
                    break;
                }
                idx += 1;
            }
            for (int i = 0; i <= valores.Count() - 1; i++)
            {
                var tipoNumero = valores[i] % 2 == 0 ? "par" : "impar";
                Console.WriteLine($"O {i + 1} numero informado é { tipoNumero }");
            }
            Console.WriteLine("Informe o tipo de operação que deseja realizar:");
            Console.WriteLine("1) Subtração (A - B)");
            Console.WriteLine("2) Multiplicação (A * B)");
            Console.WriteLine("3) Divisão (B / A");
            Console.Write("Operação: ");
            string operacao = "";
            while(true)
            {
                operacao = Console.ReadLine();
                if(operacao.Equals("1") || operacao.Equals("2") || operacao.Equals("3"))
                {
                    break;
                }
                Console.WriteLine("Opção inválida, escolha entre as opções disponíveis.");
            }
            var res = new Double();
            string tpOperacao = new String("");
            switch (operacao)
            {
                case "1":
                    tpOperacao = "subtração";
                    res = valores[0] - valores[1];
                    break;
                case "2":
                    tpOperacao = "multiplicação";
                    res = valores[0] * valores[1];
                    break;
                case "3":
                    tpOperacao = "divisão";
                    res = valores[1] / valores[0];
                    break;
                default:
                    break;
            }
            Console.WriteLine($"O resultado da {tpOperacao} é {res}.");
            Console.Read();
        }
    }
}
