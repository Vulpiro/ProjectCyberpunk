using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class StreetratCreator
    {
        public static void CreateStreetratRNDCharacter(string name, CharacterRole egr)
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
                case CharacterRole.None:
                    break;
                case CharacterRole.Rocker:
                    GenerateSTATS.GenerateRockerRNDSTATS(out intt, out reff, out dex, out tech, out cool, out will, out luck, out move, out body, out emp);
                    break;
                case CharacterRole.Solo:
                    break;
                case CharacterRole.Netrunner:
                    break;
                case CharacterRole.Tech:
                    break;
                case CharacterRole.Medtech:
                    break;
                case CharacterRole.Media:
                    break;
                case CharacterRole.Exec:
                    break;
                case CharacterRole.Lawmen:
                    break;
                case CharacterRole.Fixer:
                    break;
                case CharacterRole.Nomad:
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

        public static void CreateStreetratUserInputCharacter()
        {
            CharacterRole outputRole = Role.UserInputRoleSetup();
        }
        
    }
}
