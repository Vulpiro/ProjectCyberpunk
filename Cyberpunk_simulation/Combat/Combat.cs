using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Characters;

namespace Cyberpunk_simulation
{
    class Combat
    {

        public static void StartCombat(Character[] characterArray)
        {
            RollForInitiative(characterArray);
            //characterArray = SortByInitiative(characterArray);
        }

        public static void RollForInitiative(Character[] characters)
        {
            foreach (Character c in characters)
            {
                Console.WriteLine("{0} Rzuca za iinicjatywe!", c.Name);
                c.GetInitiative();
            }
        }

        public static Character[] SortByInitiative(Character[] characters)
        {
            Character[] sortedCharaArr = characters.OrderByDescending(c => c.Initiative).ToArray();
            return sortedCharaArr;
        }
    }
}
