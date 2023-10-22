using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation.Net.NetArchitecture.NetObjects
{
    class NetObjectControlNode : NetArchitectureObject
    {
        public NetObjectControlNode()
        {
            Name = "control node Control DV" + dv;
            IsAccessed = true;
            IsShowed = false;
        }

        public NetObjectControlNode(int diff)
        {
            dv = diff;
            Name = "control node Control DV" + dv;
            IsAccessed = true;
            IsShowed = false;
            
        }
        public NetObjectControlNode(int diff, string name)
        {
            dv = diff;
            Name = name + " Control DV" + dv;
            IsAccessed = true;
            IsShowed = false;

        }
    }
}
