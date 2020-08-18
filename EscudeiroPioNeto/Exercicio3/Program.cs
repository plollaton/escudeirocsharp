using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int step = 1;
            while(num < 100)
            {
                if(step == 3)
                {
                    Console.WriteLine(num);
                    step = 1;
                    num += 1;
                }
                step += 1;
                num += 1;
            }
        }
    }
}
