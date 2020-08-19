using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int idx = 0;
            while(idx <= 3)
            {
                Console.Write($"Informe o numero {idx + 1}: ");
                try
                {
                    numeros.Add(int.Parse(Console.ReadLine()));
                    idx++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("O valor informado não é um número inteiro, informe novamente.");
                    continue;
                }
            }
            int soma = 0;
            soma = (from x in numeros where x % 2 == 0 select x).Sum();

            Console.WriteLine($"A soma dos itens pares é: {soma}.");
        }
    }
}
