using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class Area
    {
        public string Name { get; set; }
        public Character[,] Map { get; set; }
        

        public Area(string name, int x, int y)
        {
            Name = name;
            Map = new Character[x, y];
        }

        public bool CheckIfEmpty(int x, int y)
        {
            if (Map[x, y] != null)
            {
                return false;
            }
            return true;
        }

        public void SetObject(Character obj, int x, int y)
        {
            if(CheckIfEmpty(x, y))
            {
                Map[x, y] = obj;
                obj.PosX = x;
                obj.PosY = y;
                Console.WriteLine("{0} Zmienil pozycje", obj.Name);
            }
            else
            {
                Console.WriteLine("Nie mozesz tam pojsc");
            }
        }

        public Character GetObject(int x, int y)
        {
            return Map[x, y]; 
        }

        
    }
}
