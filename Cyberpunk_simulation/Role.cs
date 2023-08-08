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
        public static CharacterRole UserRoleSetup()
        {
            Console.WriteLine("Wpisz nazwe wybranej roli: ");
            CharacterRole cr = CharacterRole.None;
            switch (Console.ReadLine())
            {
                default:
                    Console.WriteLine("Nie poprawna nazwa roli sprobuj jeszcze raz");
                    break;
            }
            return cr;
        }
    }
}
