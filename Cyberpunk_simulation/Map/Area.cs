using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Characters;
using Cyberpunk_simulation.Map.MapObjects;

namespace Cyberpunk_simulation.Map
{
    // To ma być klasa która tworzy przestrzenie w których będą egzystować postacie
    class Area
    {
        public string Name { get; set; }
        public MapObject[,] Map { get; set; }
        

        public Area(string name, int x, int y)
        {
            Name = name;
            Map = new MapObject[x, y];
        }

        public bool CheckIfEmpty(int x, int y)
        {
            if (Map[x, y] != null)
            {
                return false;
            }
            return true;
        }

        public void SetObject(MapObject obj, int x, int y)
        {
            if(CheckIfEmpty(x, y))
            {
                Map[x, y] = obj;
            }
        }

        public MapObject GetObject(int x, int y)
        {
            return Map[x, y]; 
        }

        

        public static int CalculateDistance(int x1, int y1, int x2, int y2)
        {
            double distance = Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));

            Console.WriteLine("Dystans pomiedzy postaciami rowna sie {0}", Convert.ToInt32(distance));
            return Convert.ToInt32(distance);
        }
    }
}
