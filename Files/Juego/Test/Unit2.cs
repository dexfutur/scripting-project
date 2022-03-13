using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Unit2
    {
        string typeOfunit;
        int value;
        Random aleatorio = new Random();


        public Unit2(string typeOfunit, int value)
        {
            this.typeOfunit = typeOfunit;
            this.value = value;
        }

        static int AsignaFuerza(Random aleatorio, int value)
        {
            value = aleatorio.Next(1, 11);
            return value;
        }

        public static void Combat(Unit2 enemy, Unit2 player)
        {
            if (enemy.typeOfunit == "character")
            {
                if (player.value >= enemy.value)
                {
                    player.value += enemy.value;
                    enemy.value = 0;
                    //Console.WriteLine(player.value+"  " ,enemy.value);
                }
                else if (player.value <= enemy.value)
                {
                    enemy.value += player.value;
                    player.value = 0;
                    // Console.WriteLine(player.value + "  ", enemy.value);

                }
                else if (player.value == enemy.value)
                {
                    enemy.value += player.value;
                    player.value = 0;
                    //Console.WriteLine(player.value + "  ", enemy.value);

                }

            }
            else if (enemy.typeOfunit == "obstacle")
            {
                player.value += enemy.value;
                Console.WriteLine(player.value + "  ", enemy.value);

            }
            else
            {
                return;
            }
        }
    }
}
