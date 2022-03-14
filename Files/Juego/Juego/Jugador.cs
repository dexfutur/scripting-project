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
        bool resultado;
        int vidas;

        Torres[] torre; 
        public int Fuerza { get => fuerza; set => fuerza = value; }
        internal Torres[] Torre { get => torre; set => torre = value; }
        public int Value { get => value1; set => this.value1 = value; }
        public int Vidas { get => vidas; set => vidas = value; }

        public Jugador(int fuerza, Torres[] torre, int value, int vidas)
        {
            this.fuerza = fuerza;
            this.torre = torre;
            this.value1 = value;
            this.value1 = aleatorio.Next(1, 5);
            this.torre = new Torres[value];
            this.vidas = vidas;
        }
        public void Victoria(Jugador value1, Enemigo fuerza, int vidas)
        {
            if (resultado == true)
            {
                Array.Resize(ref torre, torre.Length+1);   
            }
            else
            {
                vidas--;
            } 
                
        }

   
    }
}
