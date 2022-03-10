using System;

namespace Program
{
	public MainClass()
	{
		public static void Main(string[] args)
        {

        }

	}
	class Enemigo
    {  
	Console.WriteLine("Presente")
	//PROPIEDADES

	 int fuerza = 0;
     int ubicación;
	Random aleatorio = new Random();

        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Ubicación { get => ubicación; set => ubicación = value; }

        //MÉTODOS

        static void atacar()
        {
			Console.WriteLine("el enemigo está atacando")
        }

	static void AsignaFuerza(Random aleatorio, int fuerza)
        {
			fuerza = aleatorio.Next(1,11);
			return fuerza;
        }
	}
}
