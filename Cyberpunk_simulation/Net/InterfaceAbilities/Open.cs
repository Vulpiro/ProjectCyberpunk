using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Net.NetArchitecture;
using Cyberpunk_simulation.Net.NetArchitecture.NetObjects;

namespace Cyberpunk_simulation.Net.InterfaceAbilities
{
    class Open
    {
        public static void Activate(NetArchitectureBody net, int netrunnerInterfaceRank, int id)
        {
            if (net.architecture[id] is NetObjectFile && net.architecture[id].IsAccessed && EyeDee.IsObjectDecrypted((NetObjectFile)net.architecture[id]))
            {
                Open.OpenFile((NetObjectFile)net.architecture[id]);
            }
        }
        public static void OpenFile(NetObjectFile file)
        {
            Console.WriteLine(file.Text);
        }
    }
}
