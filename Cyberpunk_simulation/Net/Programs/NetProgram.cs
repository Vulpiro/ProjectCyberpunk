using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation.Net.Programs
{
    class NetProgram
    {
        public string Name { get; set; }
        public virtual void Activate()
        {

        }
        public virtual void Activate(ref int mod)
        {

        }
        public void Deactivate()
        {

        }
    }
}
