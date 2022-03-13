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

	        public int fuerza = 0;
            public int ubicación;
            Random aleatorio = new Random();

             int value;
            Torres[] torreE;


           public int Fuerza { get => fuerza; set => fuerza = value; }
            public int Ubicación { get => ubicación; set => ubicación = value; }
        internal Torres[] TorreE { get => torreE; set => torreE = value; }
        public int Value { get => value; set => this.value = value; }

        public Enemigo(int fuerza, Torres[] torreE, int value)
        {
            this.fuerza = fuerza;
            this.torreE = torreE;
            this.value = value;
            this.value = aleatorio.Next(1, 5);
            this.torreE = new Torres[value];

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
    public void DecrementaTamañoTorre(Enemigo fuerza , Enemigo ubicacion)
    {
        if (Enemigo.fuerza == 0)
        {
            Array.Resize(ref torres, torres.Length + 1);
        }
    }

}



