using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Net.NetArchitecture;

namespace Cyberpunk_simulation.Net.BlackICE
{
    class NetBlackIce
    {
        public string Name { get; set; }

        public int PER { get; set; }
        public int SPD { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public int REZ { get; set; }
        

        public NetBlackIce(string name, int per, int spd, int atk, int def, int rez)
        {
            Name = name;
            //IsAccessed = true;
            //IsShowed = false;

            PER = per;
            SPD = spd;
            ATK = atk;
            DEF = def;
            REZ = rez;
        }
    }
}
