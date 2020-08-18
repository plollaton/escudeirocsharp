using System;

namespace exercicio6
{
    class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }

    }
    class Program
    {
        public static void TrocaObjeto(ref Aluno aluno)
        {
            Aluno novoAluno = new Aluno();

            aluno = novoAluno;
        }

        public static void TrocaValor(Aluno aluno, out Aluno novoAluno)
        {
            novoAluno = aluno;
        }

        static void Main(string[] args)
        {
            unsafe
            {
                Aluno aluno = new Aluno();
                Aluno aluno1 = aluno;
                Console.WriteLine(aluno1.Equals(aluno));
                TrocaObjeto(ref aluno1);
                Console.WriteLine(aluno1.Equals(aluno));

                Aluno aluno2 = new Aluno();
                Aluno aluno3 = aluno2;
                Console.WriteLine(aluno3.Equals(aluno2));
                Aluno aluno4 = new Aluno();
                TrocaValor(aluno3, out aluno4);
                Console.WriteLine(aluno4.Equals(aluno2));

            }
        }
    }
}
