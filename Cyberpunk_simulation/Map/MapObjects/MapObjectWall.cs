using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation.Map.MapObjects
{
    class MapObjectWall : MapObject
    {
        public MapObjectWall()
        {
            Name = "Wall";
            TextImage = "===";
            Color = ConsoleColor.Gray;
        }
    }
}
