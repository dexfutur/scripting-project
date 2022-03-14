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
            bool resultado;

             int value1;
            Torres[] torreE;


           public int Fuerza { get => fuerza; set => fuerza = value; }
            public int Ubicación { get => ubicación; set => ubicación = value; }
        internal Torres[] TorreE { get => torreE; set => torreE = value; }
        public int Value { get => value1; set => this.value1 = value; }
        public bool Resultado { get => resultado; set => resultado = value; }

        public Enemigo(int fuerza, Torres[] torreE, int value, bool resultado)
        {
            this.fuerza = fuerza;
            this.torreE = torreE;
            this.value1 = value;
            this.value1 = aleatorio.Next(1, 5);
            this.torreE = new Torres[value];
            this.resultado = resultado;

        }
        //MÉTODOS
        public static void DecrementaTamañoTorre(Enemigo fuerza, Torres value1, Enemigo torreE, bool resultado)
        {
            if (resultado == false)
            {
                Array.Resize(ref torreE, Torres.Length - 1);
            }
        }

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



