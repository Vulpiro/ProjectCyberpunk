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
            Name = "SeeYa.exe";
        }

        public override void Activate(ref int mod)
        {
            Console.WriteLine("SeeYa.exe Activated");
            mod = mod + 2;
        }
    }
}
