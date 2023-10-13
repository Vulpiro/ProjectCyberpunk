using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Net.NetArchitecture;
using Cyberpunk_simulation.Net.NetArchitecture.NetObjects;

namespace Cyberpunk_simulation.Net.InterfaceAbilities
{
    class Pathfinder
    {
        public static void Activate(NetArchitectureBody net, int netrunnerInterfaceRank, int mod)
        {
            int roll = Dice.RollD10() + netrunnerInterfaceRank;
            Console.WriteLine("Pathfinder roll: {0}", roll - netrunnerInterfaceRank);
            Console.WriteLine("Adds to roll: {0}", mod);
            roll = roll + mod;
            Console.WriteLine("With Netrunner's power pathfinder scans for power {0}", roll);
            net.CheckForVisibility(roll);
        }
    }
}
