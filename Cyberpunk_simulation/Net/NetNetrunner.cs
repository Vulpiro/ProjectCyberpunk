using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation.Net
{
    class NetNetrunner
    {
        public string Name { get; set; }
        public int InterfaceRank { get; set; }

        public int NetActions { get; set; }

        public int NetrunnerNetPos { get; set; }

        public NetNetrunner(int ifr)
        {
            InterfaceRank = ifr;
            Name = "Unknown";
            RefillNetActions();
        }

        public NetNetrunner(int ifr, string name)
        {
            InterfaceRank = ifr;
            Name = name;
            RefillNetActions();
        }

        public void RefillNetActions()
        {
            switch (InterfaceRank)
            {
                case 1:
                case 2:
                case 3:
                    NetActions = 2;
                    break;
                case 4:
                case 5:
                case 6:
                    NetActions = 3;
                    break;
                case 7:
                case 8:
                case 9:
                    NetActions = 4;
                    break;
                case 10:
                    NetActions = 5;
                    break;
            }
        }

        public void TakeDamage(int damage)
        {

        }
    }
}
