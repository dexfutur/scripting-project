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
        bool victoria;


        public Unit(string typeOfunit, int value, bool victoria)
        {
            this.typeOfunit = typeOfunit;
            this.value = value;
            this.victoria = victoria;
        }

        static int AsignaFuerza(Random aleatorio, int value)
        {
            value = aleatorio.Next(1, 11);
            return value;
        }

        public static void Combat(Unit enemy, Unit player)
        {
            if (enemy.typeOfunit == "character")
            {
                if (player.value >= enemy.value)
                {
                    player.value += enemy.value;
                    enemy.value = 0;
                    player.victoria = true;

                    //Console.WriteLine(player.value+"  " ,enemy.value);
                }
                else if (player.value <= enemy.value)
                {
                    enemy.value += player.value;
                    player.value = 0;
                    player.victoria = false;
                    // Console.WriteLine(player.value + "  ", enemy.value);

                }
                else if (player.value == enemy.value)
                {
                    enemy.value += player.value;
                    player.value = 0;
                    player.victoria = false;

                    //Console.WriteLine(player.value + "  ", enemy.value);

                }

            }
            else if (enemy.typeOfunit == "obstacle")
            {
                player.value += enemy.value;
                player.victoria = true;

                //Console.WriteLine(player.value + "  ", enemy.value);

            }
            else
            {
                return;
            }
        }
    }
}
