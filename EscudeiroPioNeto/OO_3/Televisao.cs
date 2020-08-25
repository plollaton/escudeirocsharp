using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OO_3
{
    class Televisao
    {
        public int Volume { get; private set; }
        public int Canal { get; private set; }
        public Boolean Ligada { get; private set; }
        private int UltimoCanal { get; set; }

        public Televisao()
        {
            Volume = 5;
            Canal = 2;
            Ligada = false;
            AjustarCanais();
        }

        public void Ligar()
        {
            if (Ligada)
            {
                Console.WriteLine("TV estava ligada, desligando TV...");
                Desligar();
                return;
            }
            Console.WriteLine("Ligando TV...");
            Ligada = true;
        }

        public void Desligar()
        {
            if (!Ligada)
            {
                Console.WriteLine("TV estava desligada, ligando TV...");
                Ligar();
                return;
            }
            Console.WriteLine("Desligando TV...");
            Ligada = false;
        }

        internal bool IrParaCanal(int canal)
        {
            if (!ValidarTVLigada())
            {
                return false;
            }
            if (canal > UltimoCanal)
            {
                Console.WriteLine($"O canal {canal} está acima do limite de canais da TV.");
                return false;
            }
            Canal = canal;
            return true;
        }

        public Boolean AumentarVolume()
        {
            if (!ValidarTVLigada())
            {
                return false;
            }
            if (Volume >= 10)
            {
                Console.WriteLine("Volume já está no máximo.");
                return false;
            }
            Volume += 1;
            return true;
        }

        public Boolean AbaixarVolume()
        {
            if (!ValidarTVLigada())
            {
                return false;
            }
            if (Volume <= 0)
            {
                Console.WriteLine("Volume já está no mínimo.");
                return false;
            }
            Volume -= 1;
            return true;
        }

        public Boolean MudarProximoCanal()
        {
            if (!ValidarTVLigada())
            {
                return false;
            }
            if (Canal >= UltimoCanal)
            {
                Console.WriteLine("Este é o ultimo canal.");
                return false;
            }
            Canal += 1;
            return true;
        }

        public Boolean MudarPrevioCanal()
        {
            if (!ValidarTVLigada())
            {
                return false;
            }
            if (Canal <= 1)
            {
                Console.WriteLine("Este é o primeiro canal.");
                return false;
            }
            Canal -= 1;
            return true;
        }

        public void MudarCanalNumero(int canal)
        {
            if (!ValidarTVLigada())
            {
                return;
            }
            Canal = canal;
        }

        public void ImprimirSituacaoTV()
        {
            Console.WriteLine($"O canal é: {Canal}, e o volume é {Volume}.");
        }

        private Boolean ValidarTVLigada()
        {
            if (!Ligada)
            {
                Console.WriteLine("TV está desligada, ligue para realizar a operação.");
            }
            return Ligada;
        }

        private void AjustarCanais()
        {
            Random r = new Random();
            UltimoCanal = r.Next(15, 100);
        }
    }
}
