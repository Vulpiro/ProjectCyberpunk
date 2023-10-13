using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation.Characters
{
    class GenerateSTATS
    {
        // Masz dużo do uzupełnienia w statach każdych -_- 
        public static void GenerateStreetratSTATS(Character character)
        {
            
            switch (character.Role)
            {
                case CharacterRole.None:
                    break;
                case CharacterRole.Rocker:
                    GenerateStreetratRockerSTATS(character);
                    break;
                case CharacterRole.Solo:
                    GenerateStreetratSoloSTATS(character);
                    break;
                case CharacterRole.Netrunner:
                    GenerateStreetratNetrunnerSTATS(character);
                    break;
                case CharacterRole.Tech:
                    GenerateStreetratTechSTATS(character);
                    break;
                case CharacterRole.Medtech:
                    GenerateStreetratMedtechSTATS(character);
                    break;
                case CharacterRole.Media:
                    GenerateStreetratMediaSTATS(character);
                    break;
                case CharacterRole.Exec:
                    GenerateStreetratExecSTATS(character);
                    break;
                case CharacterRole.Lawmen:
                    GenerateStreetratLawmenSTATS(character);
                    break;
                case CharacterRole.Fixer:
                    GenerateStreetratFixerSTATS(character);
                    break;
                case CharacterRole.Nomad:
                    GenerateStreetratNomadSTATS(character);
                    break;
                default:
                    break;
            }

        }
        public static void GenerateStreetratRockerSTATS(Character character)
        {// Done
            switch (Dice.RollD10())
            {
                case 1:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 2:
                    character.INT = 3;
                    character.REF = 7;
                    character.DEX = 7;
                    character.TECH = 7;
                    character.COOL = 7;
                    character.WILL = 6;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 5;
                    character.EMP = 8;
                    break;
                case 3:
                    character.INT = 4;
                    character.REF = 5;
                    character.DEX = 7;
                    character.TECH = 7;
                    character.COOL = 6;
                    character.WILL = 6;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 5;
                    character.EMP = 8;
                    break;
                case 4:
                    character.INT = 4;
                    character.REF = 5;
                    character.DEX = 7;
                    character.TECH = 7;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 6;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 5:
                    character.INT = 3;
                    character.REF = 7;
                    character.DEX = 7;
                    character.TECH = 7;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 6;
                    character.MOVE = 5;
                    character.BODY = 4;
                    character.EMP = 7;
                    break;
                case 6:
                    character.INT = 5;
                    character.REF = 6;
                    character.DEX = 7;
                    character.TECH = 5;
                    character.COOL = 7;
                    character.WILL = 8;
                    character.LUCK = 5;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 7;
                    break;
                case 7:
                    character.INT = 5;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 7;
                    character.COOL = 7;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 6;
                    character.BODY = 3;
                    character.EMP = 6;
                    break;
                case 8:
                    character.INT = 5;
                    character.REF = 7;
                    character.DEX = 7;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 6;
                    character.LUCK = 6;
                    character.MOVE = 6;
                    character.BODY = 4;
                    character.EMP = 8;
                    break;
                case 9:
                    character.INT = 3;
                    character.REF = 5;
                    character.DEX = 5;
                    character.TECH = 6;
                    character.COOL = 7;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 5;
                    character.BODY = 5;
                    character.EMP = 7;
                    break;
                case 10:
                    character.INT = 4;
                    character.REF = 5;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 8;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 6;
                    character.BODY = 4;
                    character.EMP = 7;
                    break;
            }
            
        }
        public static void GenerateStreetratSoloSTATS(Character character)
        {
            switch (Dice.RollD10())
            { //Done
                case 1:
                    character.INT = 6;
                    character.REF = 7;
                    character.DEX = 7;
                    character.TECH = 3;
                    character.COOL = 8;
                    character.WILL = 6;
                    character.LUCK = 5;
                    character.MOVE = 5;
                    character.BODY = 6;
                    character.EMP = 5;
                    break;
                case 2:
                    character.INT = 7;
                    character.REF = 8;
                    character.DEX = 6;
                    character.TECH = 3;
                    character.COOL = 6;
                    character.WILL = 6;
                    character.LUCK = 7;
                    character.MOVE = 5;
                    character.BODY = 6;
                    character.EMP = 6;
                    break;
                case 3:
                    character.INT = 5;
                    character.REF = 8;
                    character.DEX = 7;
                    character.TECH = 4;
                    character.COOL = 7;
                    character.WILL = 7;
                    character.LUCK = 6;
                    character.MOVE = 7;
                    character.BODY = 8;
                    character.EMP = 5;
                    break;
                case 4:
                    character.INT = 5;
                    character.REF = 8;
                    character.DEX = 6;
                    character.TECH = 4;
                    character.COOL = 6;
                    character.WILL = 7;
                    character.LUCK = 6;
                    character.MOVE = 5;
                    character.BODY = 7;
                    character.EMP = 6;
                    break;
                case 5:
                    character.INT = 6;
                    character.REF = 6;
                    character.DEX = 7;
                    character.TECH = 5;
                    character.COOL = 7;
                    character.WILL = 6;
                    character.LUCK = 7;
                    character.MOVE = 6;
                    character.BODY = 8;
                    character.EMP = 4;
                    break;
                case 6:
                    character.INT = 7;
                    character.REF = 7;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 7;
                    character.WILL = 6;
                    character.LUCK = 6;
                    character.MOVE = 7;
                    character.BODY = 7;
                    character.EMP = 5;
                    break;
                case 7:
                    character.INT = 7;
                    character.REF = 7;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 7;
                    character.LUCK = 7;
                    character.MOVE = 6;
                    character.BODY = 6;
                    character.EMP = 6;
                    break;
                case 8:
                    character.INT = 7;
                    character.REF = 8;
                    character.DEX = 7;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 6;
                    character.LUCK = 5;
                    character.MOVE = 6;
                    character.BODY = 8;
                    character.EMP = 4;
                    break;
                case 9:
                    character.INT = 7;
                    character.REF = 7;
                    character.DEX = 6;
                    character.TECH = 4;
                    character.COOL = 6;
                    character.WILL = 6;
                    character.LUCK = 6;
                    character.MOVE = 5;
                    character.BODY = 6;
                    character.EMP = 5;
                    break;
                case 10:
                    character.INT = 6;
                    character.REF = 6;
                    character.DEX = 8;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 6;
                    character.LUCK = 5;
                    character.MOVE = 6;
                    character.BODY = 6;
                    character.EMP = 5;
                    break;
            }
        }
        public static void GenerateStreetratNetrunnerSTATS(Character character)
        {
            switch (Dice.RollD10())
            { // Done
                case 1:
                    character.INT = 5;
                    character.REF = 8;
                    character.DEX = 7;
                    character.TECH = 7;
                    character.COOL = 7;
                    character.WILL = 4;
                    character.LUCK = 8;
                    character.MOVE = 7;
                    character.BODY = 7;
                    character.EMP = 4;
                    break;
                case 2:
                    character.INT = 5;
                    character.REF = 6;
                    character.DEX = 7;
                    character.TECH = 5;
                    character.COOL = 8;
                    character.WILL = 3;
                    character.LUCK = 8;
                    character.MOVE = 7;
                    character.BODY = 5;
                    character.EMP = 5;
                    break;
                case 3:
                    character.INT = 5;
                    character.REF = 6;
                    character.DEX = 8;
                    character.TECH = 6;
                    character.COOL = 6;
                    character.WILL = 4;
                    character.LUCK = 7;
                    character.MOVE = 6;
                    character.BODY = 7;
                    character.EMP = 4;
                    break;
                case 4:
                    character.INT = 5;
                    character.REF = 7;
                    character.DEX = 7;
                    character.TECH = 7;
                    character.COOL = 7;
                    character.WILL = 5;
                    character.LUCK = 8;
                    character.MOVE = 6;
                    character.BODY = 5;
                    character.EMP = 5;
                    break;
                case 5:
                    character.INT = 5;
                    character.REF = 8;
                    character.DEX = 8;
                    character.TECH = 5;
                    character.COOL = 7;
                    character.WILL = 3;
                    character.LUCK = 7;
                    character.MOVE = 5;
                    character.BODY = 5;
                    character.EMP = 6;
                    break;
                case 6:
                    character.INT = 6;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 7;
                    character.COOL = 8;
                    character.WILL = 4;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 6;
                    character.EMP = 6;
                    break;
                case 7:
                    character.INT = 6;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 7;
                    character.COOL = 6;
                    character.WILL = 5;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 7;
                    character.EMP = 6;
                    break;
                case 8:
                    character.INT = 5;
                    character.REF = 7;
                    character.DEX = 8;
                    character.TECH = 6;
                    character.COOL = 8;
                    character.WILL = 4;
                    character.LUCK = 8;
                    character.MOVE = 5;
                    character.BODY = 7;
                    character.EMP = 4;
                    break;
                case 9:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 7;
                    character.TECH = 7;
                    character.COOL = 6;
                    character.WILL = 3;
                    character.LUCK = 6;
                    character.MOVE = 5;
                    character.BODY = 6;
                    character.EMP = 5;
                    break;
                case 10:
                    character.INT = 7;
                    character.REF = 8;
                    character.DEX = 6;
                    character.TECH = 6;
                    character.COOL = 6;
                    character.WILL = 4;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 5;
                    character.EMP = 6;
                    break;
            }
        }
        public static void GenerateStreetratTechSTATS(Character character)
        {
            switch (Dice.RollD10())
            {
                case 1:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 2:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 3:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 4:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 5:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 6:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 7:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 8:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 9:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 10:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
            }
        }
        public static void GenerateStreetratMedtechSTATS(Character character)
        {
            switch (Dice.RollD10())
            {
                case 1:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 2:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 3:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 4:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 5:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 6:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 7:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 8:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 9:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 10:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
            }
        }
        public static void GenerateStreetratMediaSTATS(Character character)
        {
            switch (Dice.RollD10())
            {
                case 1:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 2:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 3:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 4:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 5:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 6:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 7:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 8:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 9:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 10:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
            }
        }
        public static void GenerateStreetratExecSTATS(Character character)
        {
            switch (Dice.RollD10())
            {
                case 1:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 2:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 3:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 4:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 5:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 6:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 7:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 8:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 9:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 10:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
            }
        }
        public static void GenerateStreetratLawmenSTATS(Character character)
        {
            switch (Dice.RollD10())
            {
                case 1:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 2:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 3:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 4:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 5:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 6:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 7:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 8:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 9:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 10:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
            }
        }
        public static void GenerateStreetratFixerSTATS(Character character)
        {
            switch (Dice.RollD10())
            {
                case 1:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 2:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 3:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 4:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 5:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 6:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 7:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 8:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 9:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 10:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
            }
        }
        public static void GenerateStreetratNomadSTATS(Character character)
        {
            switch (Dice.RollD10())
            {
                case 1:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 2:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 3:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 4:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 5:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 6:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 7:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 8:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 9:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
                case 10:
                    character.INT = 7;
                    character.REF = 6;
                    character.DEX = 6;
                    character.TECH = 5;
                    character.COOL = 6;
                    character.WILL = 8;
                    character.LUCK = 7;
                    character.MOVE = 7;
                    character.BODY = 3;
                    character.EMP = 8;
                    break;
            }
        }
    }
}

