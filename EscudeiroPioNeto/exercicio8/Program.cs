using System;
using System.Collections.Generic;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numeros = new List<decimal>();
            Console.WriteLine("Informe valores decimais, para ordenação, pressione <Enter> para encerrar.");
            while (true)
            {
                Console.Write("Informe o valor: ");
                try
                {
                    string valor = Console.ReadLine();
                    if (valor.Trim().Equals(""))
                    {
                        break;
                    }
                    numeros.Add(Decimal.Parse(valor));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor informado não pode ser convertido em decimal.");
                }
            }

            numeros.Sort();
            Console.WriteLine("Ordem crescente:");
            for(int i = 0; i <= numeros.Count - 1; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("Ordem decrescente:");
            for (int x = numeros.Count - 1; x >= 0; x--)
            {
                Console.WriteLine(numeros[x]);
            }
        }
    }
}
