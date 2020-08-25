using System;
using System.Collections.Generic;
using System.Text;

namespace OO_2
{
    class ContaCorrente : ContaBase, Imprimivel
    {
        public decimal TaxaDeOperacao { get; set; }
        public ContaCorrente(string conta, decimal saldoInicial = 0) : base(conta, saldoInicial)
        {
            TaxaDeOperacao = 0.10m;
            MostrarDados();
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
            DebitarTarifa();
            MostrarDados();
        }

        public override void Sacar(decimal valor)
        {
            if (!ValidarSaldo(valor + TaxaDeOperacao))
            {
                return;
            }
            DebitarTarifa();
            Saldo -= valor;
            MostrarDados();
        }

        private void DebitarTarifa()
        {
            Saldo -= TaxaDeOperacao;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"A conta especial {Conta}, possui um saldo de {Saldo}.");
        }
    }
}
