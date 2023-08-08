using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    enum CharacterRole
    {
        None,
        Rocker,
        Solo,
        Netrunner,
        Tech,
        Medtech,
        Media,
        Exec,
        Lawmen,
        Fixer,
        Nomad
    }
    class Role
    {
        public static CharacterRole UserInputRoleSetup()
        {
            Console.WriteLine("Wpisz nazwe wybranej roli: ");
            CharacterRole cr = CharacterRole.None;
            switch (Console.ReadLine())
            {
                case "Rocker":
                    cr = CharacterRole.Rocker;
                    break;
                case "Solo":
                    cr = CharacterRole.Solo;
                    break;
                case "Netrunner":
                    cr = CharacterRole.Netrunner;
                    break;
                case "Tech":
                    cr = CharacterRole.Tech;
                    break;
                case "Medtech":
                    cr = CharacterRole.Medtech;
                    break;
                case "Media":
                    cr = CharacterRole.Media;
                    break;
                case "Exec":
                    cr = CharacterRole.Exec;
                    break;
                case "Lawmen":
                    cr = CharacterRole.Lawmen;
                    break;
                case "Fixer":
                    cr = CharacterRole.Fixer;
                    break;
                case "Nomad":
                    cr = CharacterRole.Nomad;
                    break;
                default:
                    Console.WriteLine("Nie poprawna nazwa roli sprobuj jeszcze raz");
                    break;
            }
            return cr;
        }
    }
}
