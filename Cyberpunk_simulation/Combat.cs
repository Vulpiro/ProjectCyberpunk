using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class Combat
    {
        
        public static void StartFight(Character[] characterArray)
        {
            RollForInitiative(characterArray);

        }

        public static void RollForInitiative(Character[] characters)
        {
            foreach (Character c in characters)
            {
                Console.WriteLine("{0} Rzuca za iinicjatywe!", c.Name);
                c.GetInitiative();
            }
            Character[] sortedCharaArr = characters.OrderByDescending(c => c.Initiative).ToArray();
        }

    }
}
