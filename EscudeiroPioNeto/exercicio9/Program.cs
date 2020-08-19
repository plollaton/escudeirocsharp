using System; 
using System.Collections.Generic;
using System.Linq;

namespace exercicio9
{
    class Program
    {
        static void Imprime(string titulo, IEnumerable<int> lista)
        {
            Console.WriteLine(titulo);
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        static void Imprime(string titulo, int valor)
        {
            Console.WriteLine(titulo);
            Console.WriteLine(valor);
        }

        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 1, 3, 2 };
            Imprime("Imprimir todos os números da lista.", numeros.AsEnumerable());
            Imprime("Imprimir todos os números da lista na ordem crescente.", numeros.OrderBy(n => n));
            Imprime("Imprimir todos os números da lista na ordem decrescente.", numeros.OrderByDescending(n => n));
            Imprime("Imprima apenas o primeiro número da lista.", numeros.First());
            Imprime("Imprima apenas o ultimo número da lista.", numeros.Last());
            var listaInicio = numeros.Prepend(0);
            Imprime("Inserir numero na primeira posição.", listaInicio.AsEnumerable());
            var listaFinal = listaInicio.Append(999);
            Imprime("Inserir numero na ultima posição.", listaFinal.AsEnumerable());
            var listaSemPrimeiro = listaFinal.Skip(1);
            Imprime("Remover primeira posição.", listaSemPrimeiro.AsEnumerable());
            var listaSemUltimo = listaSemPrimeiro.SkipLast(1);
            Imprime("Remover ultima posição.", listaSemUltimo);
            Imprime("Retorne apenas os número pares.", listaSemUltimo.Where(n => n % 2 == 0));
            Imprime("Retorne apenas o número informado.", listaSemUltimo.ElementAt(1));
            Imprime("Transforme todos os numero da lista em um array.", listaSemUltimo.ToArray());
        }
    }
}
