using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation.Map
{
    class ShowMapArea
    {
        public static void ShowArea(Area area)
        {
            for (int x = 0; x < area.Map.GetLength(0); x++)
            {
                Console.WriteLine("");
                for (int y = 0; y < area.Map.GetLength(1); y++)
                {
                    if (area.Map[x, y] == null)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.BackgroundColor = area.Map[x, y].Color;
                        Console.Write(area.Map[x, y].TextImage);
                    }
                }
            }
        }
    }
}
