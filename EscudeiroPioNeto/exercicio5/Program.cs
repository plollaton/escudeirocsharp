using System;


namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os valores para o cálculo da formula de baskara.");
            Console.Write("Informe o valor de A: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Informe o valor de B: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Informe o valor de C: ");
            int c = Int32.Parse(Console.ReadLine());

            var delta = Math.Pow(b, 2) - (4 * a * c);
            if(delta <= 0)
            {
                Console.WriteLine("Não é possível calcular o valor da equação, pois o delta é negativo.");
                return;
            }

            var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}
