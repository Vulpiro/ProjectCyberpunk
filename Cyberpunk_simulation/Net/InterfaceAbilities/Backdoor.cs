using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Net.NetArchitecture;
using Cyberpunk_simulation.Net.NetArchitecture.NetObjects;

namespace Cyberpunk_simulation.Net.InterfaceAbilities
{
    class Backdoor
    {
        public static void Activate(NetArchitectureBody net, int netrunnerInterfaceRank, int mod)
        {
            int i = 0;
            foreach (NetArchitectureObject obj in net.architecture)
            {
                if(obj is NetObjectPassword && obj.IsAccessed)
                {
                    if (Backdoor.ChallangePassword(netrunnerInterfaceRank, (NetObjectPassword)obj, mod))
                    {
                        net.architecture[i] = new NetArchitectureObject("null");
                    }
                    net.CheckForPassword();
                    break;
                }
                i++;
            }
        }

        public static bool ChallangePassword(int netrunnerInterfaceRank, NetObjectPassword password, int mod)
        {
            Console.WriteLine("Backdoor tries to decrypt password...");
            Console.WriteLine("Password protection level is {0}", password.dv);
            Console.WriteLine("Netrunners interface rank is {0}", netrunnerInterfaceRank);
            Console.WriteLine("Adds to roll: {0}", mod);
            int roll = Dice.RollD10();
            Console.WriteLine("Netrunners roll D10 for {0}", roll);
            roll = roll + netrunnerInterfaceRank + mod;
            Console.WriteLine("Netrunner backdoor attempt with {0} decrypt power vs {1} protection level", roll, password.dv);
            if (roll > password.dv)
            {
                Console.WriteLine("Password decryption is successful");
                return true;
            }
            Console.WriteLine("Backdoor failed...");
            return false;
        }
    }
}
