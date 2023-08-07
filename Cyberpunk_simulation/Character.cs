using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    enum CharaRole
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
    class Character
    {
        public string Name { get; set; }

        public CharaRole Role { get; set; }
        #region Main Stats
        public int INT { get; set; }
        public int REF { get; set; }
        public int ZW { get; set; }
        public int TECH { get; set; }
        public int CHA { get; set; }
        public int SW { get; set; }
        public int SZ { get; set; }
        public int RUCH { get; set; }
        public int BC { get; set; }
        public int EMP { get; set; }

        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        #endregion

        #region Items
        public Weapon Weapon1 { get; set; }
        public int ActiveWeapon { get; set; }
        #endregion

        public int Initiative { get; set; }

        public int PosX { get; set; }
        public int PosY { get; set; }

        public Character(string name, CharaRole role,
            int inte, int refl, int zw, int tech, int cha, int sw, int sz, int ruch, int bc, int emp)
        {
            Name = name;
            Role = role;
            INT = inte;
            REF = refl;
            ZW = zw;
            TECH = tech;
            CHA = cha;
            SW = sw;
            SZ = sz;
            RUCH = ruch;
            BC = bc;
            EMP = emp;
            SetMaxHP();
        }

        #region Stats Methods
        public void SetMaxHP()
        {
            MaxHP = (10 + (5 * (int)Math.Ceiling((double)(SW + BC) / 2)));
            CurrentHP = MaxHP;
        }

        public void GetDamage(int damage)
        {
            CurrentHP -= damage;
            Console.WriteLine("{0} Otrzymal obrazenia o wartosci {1} aktualny stan zdrowia wynosi {2}\n", Name, damage, CurrentHP);
        }

        public void GetInitiative()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int dice = rnd.Next(1, 11);
            Console.WriteLine(" REF = {0}, wynik rzutu kości = {1}, lacznie to {2}\n", REF, dice, REF + dice);
            Initiative = REF + dice;
        }

        #endregion
        public void Attack(Character chara)
        {
            if (Weapon1.WT == WeaponType.Ranged)
            {
                if (Weapon1.IsAbleToShoot())
                {
                    if(Weapon1.ChallangePT(Weapon1.CalculatePT(Battle.CalculateDistance(PosX, PosY, chara.PosX, chara.PosY)), REF, 12))
                    {
                        chara.GetDamage(Weapon1.CalculateDamage());
                    }
                }
                
            }
            else if (Weapon1.WT == WeaponType.Mele)
            {

            }
            
        }
    }
}
