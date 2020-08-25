using System;
using System.Collections.Generic;
using System.Text;

namespace OO_2
{
    class ContaEspecial : ContaBase, Imprimivel
    {
        public decimal LimiteCredito { get; set; }
        public override decimal Saldo
        {
            get
            {
                return _saldo + LimiteCredito;
            }

            protected set
            {
                _saldo = value;
            }
        }

        public ContaEspecial(string conta, decimal saldoInicial = 0, decimal limiteCredito = 100) : base(conta, saldoInicial)
        {
            LimiteCredito = limiteCredito;
            MostrarDados();
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
            MostrarDados();
        }

        public override void Sacar(decimal valor)
        {
            if(!ValidarSaldo(valor))
            {
                return;
            }
            Saldo -= valor;
            MostrarDados();
        }

        private decimal SaldoReal()
        {
            return Saldo - LimiteCredito;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"A conta especial {Conta}, possui um saldo de {SaldoReal()}, e possui um limite de crédito de {LimiteCredito}. Saldo final {SaldoReal()}."); 
        }
    }
}
