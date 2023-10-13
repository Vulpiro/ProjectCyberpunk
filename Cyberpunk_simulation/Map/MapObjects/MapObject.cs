using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation.Map.MapObjects
{
    class MapObject
    {
        public string Name { get; set; }
        public string TextImage { get; set; }
        public ConsoleColor Color { get; set; }

        public MapObject()
        {
            Name = "Placeholder";
            TextImage = " p ";
            Color = ConsoleColor.Black;
        }
    }
}
