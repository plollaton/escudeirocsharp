using System;

namespace OO_1
{
    class Pessoa
    {
        private DateTime _dataNascimento;
        private int _idade;

        public string Nome { get; set; }
        public DateTime DataNascimento
        {
            get
            {
                return _dataNascimento;
            }

            set
            {
                _dataNascimento = value;
                Idade = DateTime.Now.Year - _dataNascimento.Year;
            }
        }

        public double Altura { get; set; }

        public int Idade
        {
            get
            {
                return _idade;
            }

            private set
            {
                _idade = value;
            }
        }

        public Pessoa(string nome, DateTime dataNascimento, double altura)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Altura = altura;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, data de nascimento: {DataNascimento.ToShortDateString()}, altura: {Altura} e tem a idade de {Idade} anos.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Pio", new DateTime(1979, 02, 24), 1.8);
            Console.WriteLine(pessoa1.ToString());
        }
    }
}
