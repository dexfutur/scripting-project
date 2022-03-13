using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Jugador
    {

        int fuerza = 2;
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public Jugador(int fuerza)
        {
            this.fuerza = fuerza;
        }
    }
}
