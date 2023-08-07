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
            double distance = 0;
            double x = 0;
            double y = 0;
            if (x1 > x2)
            {
                x = x1 - x2;
            }
            else if (x1 < x2)
            {
                x = x2 - x1;
            }

            if (y1 > y2)
            {
                y = y1 - y2;
            }
            else if (y1 < y2)
            {
                y = y2 - y1;
            }

            if (x == 0)
            {
                distance = y;
            }
            else if (y == 0)
            {
                distance = x;
            }
            else
            {
                x = x * x;
                y = y * y;
                double temp = x + y;
                distance = Math.Sqrt(temp);
            }

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
