using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Net.NetArchitecture;

namespace Cyberpunk_simulation.Net.NetArchitecture.NetObjects
{
    class NetObjectPassword : NetArchitectureObject
    {
        
        public NetObjectPassword()
        {
            Name = "password Backdoor DV" + dv;
            IsAccessed = true;
            IsShowed = false;
        }
        public NetObjectPassword(int diff)
        {
            dv = diff;
            Name = "password Backdoor DV" + dv;
            IsAccessed = true;
            IsShowed = false;
        }
    }
}
