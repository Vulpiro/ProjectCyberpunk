using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class MeleWeapon : Weapon
    {
        public MeleWeapon(string name, int obr, int la)
        {
            Name = name;
            OBR = obr;
            LA = la;
            WT = WeaponType.Mele;
        }
        public override int CalculatePT(int distance)
        {
            throw new NotImplementedException();
        }

        public override bool ChallangePT(int pt, int reforzw, int umj)
        {
            throw new NotImplementedException();
        }

        public override int CalculateDamage()
        {
            throw new NotImplementedException();
        }

        public override bool IsAbleToShoot()
        {
            return false;
        }
    }
}
