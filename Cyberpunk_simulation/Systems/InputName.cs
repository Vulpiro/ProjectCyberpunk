using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class InputName
    {
        public static string UserInputNameSetup()
        {
            Console.WriteLine("Wpisz nazwe dla postaci: ");
            return Console.ReadLine();
        }
    }
}
