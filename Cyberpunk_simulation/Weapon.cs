using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    public enum WeaponType
    {
        Ranged,
        Mele
    }
    abstract class Weapon
    {
        public WeaponType WT{ get; set; }
        public string Name { get; set; }

        public int DMG { get; set; }
        public int LA { get; set; }

        public abstract bool IsAbleToShoot();
        public abstract int CalculateDamage();
        public abstract bool ChallangePT(int pt, int reforzw, int umj);
        public abstract int CalculatePT(int distance);
    }
}
