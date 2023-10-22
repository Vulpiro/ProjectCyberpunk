using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Net.NetArchitecture;
using Cyberpunk_simulation.Net.NetArchitecture.NetObjects;

namespace Cyberpunk_simulation.Net.InterfaceAbilities
{
    class Control
    {
        public static void Activate(NetArchitectureBody net, int netrunnerInterfaceRank)
        {
            int i = 0;
            foreach (NetArchitectureObject obj in net.architecture)
            {
                if (obj is NetObjectControlNode && obj.IsAccessed)
                {
                    if (Control.ChallangeControlNode(netrunnerInterfaceRank, (NetObjectControlNode)obj))
                    {
                        net.architecture[i] = new NetArchitectureObject("null");
                    }
                    break;
                }
                i++;
            }
        }

        public static bool ChallangeControlNode (int netrunnerInterfaceRank, NetObjectControlNode controlNode)
        {
            Console.WriteLine("Control tries to take control of {0}", controlNode.Name);
            Console.WriteLine("Node protection level is {0}", controlNode.dv);
            Console.WriteLine("Netrunner's interface rank is {0}", netrunnerInterfaceRank);
            int roll = Dice.RollD10();
            Console.WriteLine("Netrunners roll D10 for {0}", roll);
            roll = roll + netrunnerInterfaceRank;
            Console.WriteLine("Netrunner backdoor attempt with {0} control power vs {1} protection level", roll, controlNode.dv);
            if (roll > controlNode.dv)
            {
                Console.WriteLine("Control is successful");
                return true;
            }
            Console.WriteLine("Control failed...");
            return false;
        }
    }
}
