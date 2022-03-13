using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{

    internal class Enemigo
    {
       
	    //PROPIEDADES

	        int fuerza = 0;
            int ubicación;
            Random aleatorio = new Random();
            Torres[] torreE = new Torres[5];

           public int Fuerza { get => fuerza; set => fuerza = value; }
            public int Ubicación { get => ubicación; set => ubicación = value; }
        internal Torres[] TorreE { get => torreE; set => torreE = value; }

        public Enemigo(int fuerza, Torres[] torreE)
        {
            this.fuerza = fuerza;
            this.torreE = torreE;
        }
        //MÉTODOS

        static void atacar()
            {
            Console.WriteLine("el enemigo está atacando");
            }

            static int AsignaFuerza(Random aleatorio, int fuerza)
            {
                fuerza = aleatorio.Next(1, 11);
                return fuerza;
            }
        }

}



