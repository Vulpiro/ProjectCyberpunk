using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class Gun : Weapon
    {

        public int MaxAmmoInMag { get; set; }
        public int AmmoInMag { get; set; }
        public int AmmoInRes { get; set; }


        public Gun(string name, int dmg, int aim, int air, int la)
        {
            Name = name;
            DMG = dmg;
            MaxAmmoInMag = aim;
            AmmoInMag = aim;
            AmmoInRes = air;
            LA = la;
            WT = WeaponType.Ranged;
        }

        // Chcesz rozłożyć to na wiele method i się zastanawiasz by pistolet strzelba i karabin miały osobne klasy i dziedziczyły z Gun
        public override bool IsAbleToShoot()
        {
            if (AmmoInMag != 0)
            {
                return true;
            }
            return false;
        }

        public void ReloadGun()
        {

        }

        public override int CalculatePT(int distance)
        {
            return 1000;
        }
        public override bool ChallangePT(int pt, int reforzw, int umj)
        {
            int dice = Dice.RollD10();
            Console.WriteLine("Rzut kosci wynosi {0} + REF {1} + Umiejetnosci strzeleckie {2} = {3} vs PT {4} ", dice, reforzw, umj, dice + reforzw + umj, pt);
            if (dice + reforzw + umj > pt)
            {
                Console.WriteLine("Trafiony");
                return true;
            }
            Console.WriteLine("Pudlo");
            return false;
        }
        public override int CalculateDamage()
        {
            int dmg = 0;
            for (int i = 0; i < DMG; i++)
            {
                int dice = Dice.RollD6();
                Console.WriteLine("Wynik rzutu koscia d6 = {0}", dice);
                dmg += dice;
            }

            Console.WriteLine("{0} strzela za {1}\n", Name, dmg);
            return dmg;
        }
    }
}
