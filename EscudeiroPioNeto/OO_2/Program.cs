using System;

namespace OO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente corrente1 = new ContaCorrente("corrente1", 100);
            corrente1.Depositar(300m);
            corrente1.Sacar(399.8m);
            ContaCorrente corrente2 = new ContaCorrente("corrente2", 200);
            corrente2.Depositar(100m);
            corrente2.Sacar(401m);
            ContaEspecial especial1 = new ContaEspecial("especial1", 100);
            especial1.Sacar(200);
            ContaEspecial especial2 = new ContaEspecial("especial2", 200);
            //especial2.Depositar(200);
            //especial2.Sacar(500);
        }
    }
}
