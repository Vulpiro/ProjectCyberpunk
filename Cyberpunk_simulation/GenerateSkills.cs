using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class GenerateSkills
    {
        public static void GenerateStreetratSkills(Character character)
        {
            switch (character.Role)
            {
                case CharacterRole.None:
                    
                    break;
                case CharacterRole.Rocker:
                    GenerateStreetratRockerSkills(character);
                    break;
                case CharacterRole.Solo:
                    GenerateStreetratSoloSkills(character);
                    break;
                case CharacterRole.Netrunner:
                    GenerateStreetratNetrunnerSkills(character);
                    break;
                case CharacterRole.Tech:
                    GenerateStreetratTechSkills(character);
                    break;
                case CharacterRole.Medtech:
                    GenerateStreetratMedtechSkills(character);
                    break;
                case CharacterRole.Media:
                    GenerateStreetratMediaSkills(character);
                    break;
                case CharacterRole.Exec:
                    GenerateStreetratExecSkills(character);
                    break;
                case CharacterRole.Lawmen:
                    GenerateStreetratLawmenSkills(character);
                    break;
                case CharacterRole.Fixer:
                    GenerateStreetratFixerSkills(character);
                    break;
                case CharacterRole.Nomad:
                    GenerateStreetratNomadSkills(character);
                    break;
                default:
                    break;
            }
        }
        public static void GenerateStreetratRockerSkills(Character character)
        {

        }
        public static void GenerateStreetratSoloSkills(Character character)
        {

        }
        public static void GenerateStreetratNetrunnerSkills(Character character)
        {

        }
        public static void GenerateStreetratTechSkills(Character character)
        {

        }
        public static void GenerateStreetratMedtechSkills(Character character)
        {

        }
        public static void GenerateStreetratMediaSkills(Character character)
        {

        }
        public static void GenerateStreetratExecSkills(Character character)
        {

        }
        public static void GenerateStreetratLawmenSkills(Character character)
        {

        }
        public static void GenerateStreetratFixerSkills(Character character)
        {

        }
        public static void GenerateStreetratNomadSkills(Character character)
        {

        }
        

    }
}
