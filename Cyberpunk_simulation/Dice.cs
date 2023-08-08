using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class Dice
    {
        public static int RollD10()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(1, 11);
        }
        public static int RollD6()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return rnd.Next(1, 7);
        }
    }
}
