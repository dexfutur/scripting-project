using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    internal class Unit
    {
        string typeOfunit;
        int value;
        Random aleatorio = new Random();

        
        public Unit(string typeOfunit, int value)
        {
            this.typeOfunit = typeOfunit;
            this.value = value;            
        }


        static int AsignaFuerza(Random aleatorio, int fuerza)
        {
            fuerza = aleatorio.Next(1, 11);
            return fuerza;
        }

        public static void Combat(Unit enemy, Unit player)
        {
            if(enemy.typeOfunit=="character"){
                if (player.value > enemy.value)
                {
                    player.value += enemy.value;
                    enemy.value = 0;
                    Console.WriteLine(player.value+"  " ,enemy.value);
                }
                else
                {
                    enemy.value+=player.value;
                    player.value = 0;
                    Console.WriteLine(player.value + "  ", enemy.value);

                }
            }
            else if(enemy.typeOfunit=="obstacle"){
                player.value+=enemy.value;
                Console.WriteLine(player.value + "  ", enemy.value);

            }
            else
            {
                return;
            }
        }
    }
}
