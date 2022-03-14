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
        Random aleatorio = new Random();
        int value1;

        Torres[] torre; 
        public int Fuerza { get => fuerza; set => fuerza = value; }
        internal Torres[] Torre { get => torre; set => torre = value; }
        public int Value { get => value1; set => this.value1 = value; }

        public Jugador(int fuerza, Torres[] torre, int value)
        {
            this.fuerza = fuerza;
            this.torre = torre;
            this.value1 = value;
            this.value1 = aleatorio.Next(1, 5);
            this.torre = new Torres[value];
        }
        public void AumentaTamañoTorre(Jugador value1, Enemigo fuerza)
        {
            if ()
            {
                Array.Resize(ref torre, torre.Length+1);   
            }
        }

   
    }
}
