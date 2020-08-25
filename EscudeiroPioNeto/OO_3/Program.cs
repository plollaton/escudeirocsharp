using System;

namespace OO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Controle controleRemoto = new Controle();
            controleRemoto.LigarTV();
            controleRemoto.DesligarTV();
            controleRemoto.DesligarTV();
            controleRemoto.LigarTV();
            controleRemoto.AumentarVolume();
            controleRemoto.LigarTV();
            while (controleRemoto.AumentarVolume())
            {
                controleRemoto._Televisao.ImprimirSituacaoTV();
            }
            while (controleRemoto.BaixarVolume())
            {
                controleRemoto._Televisao.ImprimirSituacaoTV();
            }
            while (controleRemoto.ProximoCanal())
            {
                controleRemoto._Televisao.ImprimirSituacaoTV();
            }
            while (controleRemoto.PrevioCanal())
            {
                controleRemoto._Televisao.ImprimirSituacaoTV();
            }
            controleRemoto.IrParaCanal(7);
            controleRemoto._Televisao.ImprimirSituacaoTV();
            controleRemoto.IrParaCanal(110);
            controleRemoto._Televisao.ImprimirSituacaoTV();
        }
    }
}
