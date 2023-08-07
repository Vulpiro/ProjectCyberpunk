using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class Battle
    {
        public static int CalculateDistance(int x1, int y1, int x2, int y2)
        {
            double distance = Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));

            Console.WriteLine("Dystans pomiedzy postaciami rowna sie {0}", Convert.ToInt32(distance));
            return Convert.ToInt32(distance);
        }
        public static void StartFight(Character[] characterArray, Area area)
        {
            foreach (Character c in characterArray)
            {
                Console.WriteLine("{0} Rzuca za iinicjatywe!", c.Name);
                c.GetInitiative();
            }
            Character[] sortedCharaArr = characterArray.OrderByDescending(c => c.Initiative).ToArray();

        }


    }
}
