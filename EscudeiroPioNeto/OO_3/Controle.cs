using System;
using System.Collections.Generic;
using System.Text;

namespace OO_3
{
    class Controle
    {
        public Televisao _Televisao { get; set; }
        public Controle()
        {
            _Televisao = new Televisao();
        }

        public void LigarTV()
        {
            _Televisao.Ligar();
        }

        public void DesligarTV()
        {
            _Televisao.Desligar();
        }

        public Boolean ProximoCanal()
        {
            return _Televisao.MudarProximoCanal();
        }

        public Boolean PrevioCanal()
        {
            return _Televisao.MudarPrevioCanal();
        }

        public Boolean AumentarVolume()
        {
            return _Televisao.AumentarVolume();
        }

        public Boolean BaixarVolume()
        {
            return _Televisao.AbaixarVolume();
        }

        public Boolean IrParaCanal(Int32 canal)
        {
            return _Televisao.IrParaCanal(canal);
        }
    }
}
