using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Net.NetArchitecture;
using Cyberpunk_simulation.Net.NetArchitecture.NetObjects;

namespace Cyberpunk_simulation.Net.InterfaceAbilities
{
    class EyeDee
    {
        public static void Activate(NetArchitectureBody net, int netrunnerInterfaceRank)
        {
            int i = 0;
            foreach (NetArchitectureObject obj in net.architecture)
            {
                if (obj is NetObjectFile && obj.IsAccessed && !IsObjectDecrypted((NetObjectFile)obj))
                {
                    EyeDee.ChallangeFile(netrunnerInterfaceRank, (NetObjectFile)obj);
                    break;
                }
                i++;
            }
        }
        public static void Activate(NetArchitectureBody net, int netrunnerInterfaceRank, int id)
        {
            if (net.architecture[id] is NetObjectFile && net.architecture[id].IsAccessed && !IsObjectDecrypted((NetObjectFile)net.architecture[id]))
            {
                EyeDee.ChallangeFile(netrunnerInterfaceRank, (NetObjectFile)net.architecture[id]);
            }

        }

        public static void ChallangeFile(int netrunnerInterfaceRank, NetObjectFile file)
        {
            Console.WriteLine("Eye-dee tries to decrypt file...");
            Console.WriteLine("File protection level is {0}", file.dv);
            Console.WriteLine("Netrunners interface rank is {0}", netrunnerInterfaceRank);
            int roll = Dice.RollD10();
            Console.WriteLine("Netrunner rolls D10 for {0}", roll);
            roll = roll + netrunnerInterfaceRank;
            Console.WriteLine("Netrunner eye-dee attempt with {0} decrypt power vs {1} protection level", roll, file.dv);
            if (roll > file.dv)
            {
                Console.WriteLine("File decryption is successful");
                file.DecryptFile();
            }
            else
            {
                Console.WriteLine("Eye-dee failed...");
            }
        }

        public static bool IsObjectDecrypted(NetObjectFile file)
        {
            if (file.IsDecrypted)
            {
                return true;
            }
            return false;
        }
    }
}
