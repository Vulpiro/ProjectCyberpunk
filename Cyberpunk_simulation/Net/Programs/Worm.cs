using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation.Net.Programs
{
    class Worm : NetProgram
    {
        public Worm()
        {
            Name = "Worm.exe";
        }

        public void Activate(ref int mod)
        {
            Console.WriteLine("Worm activated");
            mod = mod + 2;
        }
    }
}
