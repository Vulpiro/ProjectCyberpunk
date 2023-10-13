using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation.Net.Programs
{
    class SeeYa : NetProgram
    {
        public SeeYa()
        {
            Name = "See Ya.exe";
        }

        public void Activate(ref int mod)
        {
            mod = mod + 2;
        }
    }
}
