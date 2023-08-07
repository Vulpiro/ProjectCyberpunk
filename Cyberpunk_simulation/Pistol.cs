using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class Pistol : Gun
    {
        public Pistol(string name, int obr, int aim, int air, int la) : base(name, obr, aim, air, la)
        {
            Name = name;
            OBR = obr;
            MaxAmmoInMag = aim;
            AmmoInMag = aim;
            AmmoInRes = air;
            LA = la;
        }

        public override int CalculatePT(int distance)
        {
            if (distance >= 0 && distance <= 6)
            {
                return 13;
            }
            else if (distance >= 7 && distance <= 12)
            {
                return 15;
            }
            else if (distance >= 13 && distance <= 25)
            {
                return 20;
            }
            else if (distance >= 26 && distance <= 50)
            {
                return 25;
            }
            else if (distance >= 51 && distance <= 100)
            {
                return 30;
            }
            else if (distance >= 101 && distance <= 200)
            {
                return 30;
            }
            else if (distance >= 201 && distance <= 400)
            {
                return 10000;
            }
            else if (distance >= 401 && distance <= 800)
            {
                return 10000;
            }
            return 10000;
        }
    }
}
