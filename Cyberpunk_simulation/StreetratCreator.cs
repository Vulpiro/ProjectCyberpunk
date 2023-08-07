using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class StreetratCreator
    {
        public static void CreateSRRNDCharacter(string name, CharaRole egr)
        {
            int intt = 0;
            int reff = 0;
            int dex = 0;
            int tech = 0;
            int cool = 0;
            int will = 0;
            int luck = 0;
            int move = 0;
            int body = 0;
            int emp = 0;
            //Pick a role

            //Run your Lifepath

            //Roll Your STATS
            switch (egr)
            {
                case CharaRole.None:
                    break;
                case CharaRole.Rocker:
                    GenerateSTATS.GenerateRockerRNDSTATS(out intt, out reff, out dex, out tech, out cool, out will, out luck, out move, out body, out emp);
                    break;
                case CharaRole.Solo:
                    break;
                case CharaRole.Netrunner:
                    break;
                case CharaRole.Tech:
                    break;
                case CharaRole.Medtech:
                    break;
                case CharaRole.Media:
                    break;
                case CharaRole.Exec:
                    break;
                case CharaRole.Lawmen:
                    break;
                case CharaRole.Fixer:
                    break;
                case CharaRole.Nomad:
                    break;
                default:
                    break;
            }
            //Calculate Derived Statistics

            //Set Your Skills

            //Record Weapons, Armor

            //Record Outfit

            //Record Cyberware

        }

        
    }
}
