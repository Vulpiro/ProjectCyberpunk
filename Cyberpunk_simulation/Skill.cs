using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class Skill
    {
        public string Name { get; set; }
        public int Base { get; set; }
        public int Level { get; set; }

        public Skill(string name, int stat){
            Name = name;
            Level = 0;
            Base = stat;
        }

        public void SetLevel(int lvl, int stat)
        {
            Level = lvl;
            Base = stat + lvl;
        }

        public void LevelUP(int stat)
        {
            Level++;
            Base = stat + Level;
        }
    }
}
