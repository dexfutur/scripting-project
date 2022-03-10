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

            public int Fuerza { get => fuerza; set => fuerza = value; }
            public int Ubicación { get => ubicación; set => ubicación = value; }

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
}

