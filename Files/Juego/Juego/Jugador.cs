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

        Torres[] torre = new Torres[5];
        public int Fuerza { get => fuerza; set => fuerza = value; }
        internal Torres[] Torre { get => torre; set => torre = value; }

        public Jugador(int fuerza, Torres[] torre)
        {
            this.fuerza = fuerza;
            this.torre = torre;
        }

   
    }
}
