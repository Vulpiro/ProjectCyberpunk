﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Area warehouse = new Area("Magazyn", 50, 50);

            Character forty = new Character("Forty", CharaRole.Rocker, 5, 6, 7, 5, 7, 8, 5, 7, 3, 6);
            Character ingvild = new Character("Ingvild", CharaRole.Medtech, 7, 6, 5, 10, 5, 8, 2, 15, 3, 4);
            Character vulpiro = new Character("Vulpiro", CharaRole.Netrunner, 7, 6, 6, 6, 4, 4, 5, 6, 3, 7);
            //Character frogger = new Character("Fr0ger", CharaRole.Nomad);

            Battle.StartFight(new Character[] {forty, vulpiro}, warehouse);

            Pistol barCiePis = new Pistol("Bardzo ciezki pisolet", 4, 8, 16, 1);

            warehouse.SetObject(forty, 10, 10);
            warehouse.SetObject(vulpiro, 40, 40);

            forty.Weapon1 = barCiePis;
            forty.Attack(vulpiro);

        }
    }
}
