using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Map;

namespace Cyberpunk_simulation.Characters
{
    // Klasa postaci niezależnie czy grywalnych czy npc
    class Character
    {
        public string Name { get; set; }

        #region Role 
        // Do przebudowania w przyszłości ponieważ każda postać może mieć wiele roli o różnej randze
        public CharacterRole Role { get; set; }
        public int RoleRank { get; set; }
        #endregion
        #region Main Stats
        public int INT { get; set; }
        public int REF { get; set; }
        public int DEX { get; set; }
        public int TECH { get; set; }
        public int COOL { get; set; }
        public int WILL { get; set; }
        public int LUCK { get; set; }
        public int MOVE { get; set; }
        public int BODY { get; set; }
        public int EMP { get; set; }

        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        #endregion

        #region Skills
        #region Awareness Skills
        #endregion
        #region Body Skills
        #endregion
        #region Control Skills
        #endregion
        #region Education Skills
        #endregion
        #region Fighting Skills
        #endregion
        #region Performance Skills
        #endregion
        #region Ranged Weapon Skills
        public Skill handgun;

        #endregion
        #region Social Skills
        #endregion
        #region Technique Skills
        #endregion
        #endregion

        #region Items
        // Itemy do przebudowania całkowicie
        public Weapon Weapon1 { get; set; }
        public int ActiveWeapon { get; set; }
        #endregion

        public int Initiative { get; set; }

        #region Constructors
        public Character()
        {
            RoleRank = 4;
        }
        public Character(string name, CharacterRole role)
        {
            Name = name;
            Role = role;

            RoleRank = 4;
        }
        public Character(string name, CharacterRole role,
            int inte, int refl, int dex, int tech, int cool, int will, int luck, int move, int body, int emp)
        {
            Name = name;
            Role = role;
            INT = inte;
            REF = refl;
            DEX = dex;
            TECH = tech;
            COOL = cool;
            WILL = will;
            LUCK = luck;
            MOVE = move;
            BODY = body;
            EMP = emp;

            SetMaxHP();
            SetSkills();
            RoleRank = 4;
        }
        //public Character(string name, CharacterRole role,
        //    int inte, int refl, int dex, int tech, int cool, int will, int luck, int move, int body, int emp, int handgun)
        //{
        //    Name = name;
        //    Role = role;
        //    INT = inte;
        //    REF = refl;
        //    DEX = dex;
        //    TECH = tech;
        //    COOL = cool;
        //    WILL = will;
        //    LUCK = luck;
        //    MOVE = move;
        //    BODY = body;
        //    EMP = emp; 

        //    SetMaxHP();
        //    SetSkills();
        //    RoleRank = 4;
        //}
        #endregion

        #region Stats Methods

        public void SetSkills()
        {
            handgun = new Skill("handgun", REF);
        }
        public void SetMaxHP()
        {
            MaxHP = (10 + (5 * (int)Math.Ceiling((double)(WILL + BODY) / 2)));
            CurrentHP = MaxHP;
        }

        public void GetDamage(int damage)
        {
            CurrentHP -= damage;
            Console.WriteLine("{0} Otrzymal obrazenia o wartosci {1} aktualny stan zdrowia wynosi {2}\n", Name, damage, CurrentHP);
        }

        public void GetInitiative()
        {
            int dice = Dice.RollD10();
            Console.WriteLine(" REF = {0}, wynik rzutu kości = {1}, lacznie to {2}\n", REF, dice, REF + dice);
            Initiative = REF + dice;
        }

        #endregion
        //public void Attack(Character chara)
        //{
        //    if (Weapon1.WT == WeaponType.Ranged)
        //    {
        //        if (Weapon1.IsAbleToShoot())
        //        {
        //            if(Weapon1.ChallangePT(Weapon1.CalculatePT(Area.CalculateDistance(PosX, PosY, chara.PosX, chara.PosY)), REF, handgun.Base))
        //            {
        //                chara.GetDamage(Weapon1.CalculateDamage());
        //            }
        //        }
                
        //    }
        //    else if (Weapon1.WT == WeaponType.Mele)
        //    {

        //    }
            
        //}
    }
}
