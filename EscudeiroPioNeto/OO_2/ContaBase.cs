using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OO_2
{
    abstract class ContaBase
    {
        protected decimal _saldo;

        public string Conta { get; protected set; }
        public virtual decimal Saldo 
        {
            get
            {
                return _saldo;
            }
            protected set 
            {
                _saldo = value;
            } 
        }

        public ContaBase(string conta, decimal saldoInicial)
        {
            Conta = conta;
            Saldo = saldoInicial;
        }

        public abstract void Sacar(decimal valor);

        public abstract void Depositar(decimal valor);

        protected Boolean ValidarSaldo(Decimal valorSaque)
        {
            if (valorSaque <= Saldo) {
                return true;
            }
            Console.WriteLine("SALDO INSUFICIENTE para realizar o saque.");
            return false;
        }
    }
}
