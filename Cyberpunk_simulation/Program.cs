using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Net;
using Cyberpunk_simulation.Map;
using Cyberpunk_simulation.Map.MapObjects;
using Cyberpunk_simulation.Net.NetArchitecture;
using Cyberpunk_simulation.Net.NetArchitecture.NetObjects;

namespace Cyberpunk_simulation
{
    // Serce całego programu
    class Program
    {
        static void Main(string[] args)
        {
            //Area sunsetmotel = new Area("Sunset Motel", 10, 10);
            //sunsetmotel.SetObject(new MapObjectWall(), 2, 2);
            
            Netrunning net = new Netrunning();
            NetNetrunner satomi = new NetNetrunner(1, "Satomi");

            NetArchitectureBody warsztat = new NetArchitectureBody(6);
            warsztat.AddObject(new NetObjectPassword(6), 0);
            warsztat.AddObject(new NetObjectControlNode(8), 0);



            NetArchitectureBody laptop = new NetArchitectureBody(7);
            laptop.AddObject(new NetObjectPassword(6), 0);
            laptop.AddObject(new NetObjectFile(6, "messages", "Z wiadomosci wynika ze w Industrial czesci Heywood jest odcieta od wsparcia reszty gangu, fabryka przejeta przez malestron"), 1);
            laptop.AddObject(new NetObjectPassword(8), 2);
            laptop.AddObject(new NetObjectFile(8, "list", "Jest to lista przetrzymywanych osob, widac ludzi z innych gangow, widac czy sa rozkladani na czesci, czy odsylani na nagrywanie pojebanych BD, na pokladzie jest porwany medtech ktory jest zmuszany do rozkladania ludzi"), 3);
            laptop.AddObject(new NetObjectPassword(10), 4);
            laptop.AddObject(new NetObjectFile(10, "security", "Masz dostep do planow zabezpieczen budynku, widzisz ze ich zabezpieczenia sa silne, a wtargniecie sie na ich teren graniczy z cudem, przy waszym uzbrojeniu"), 5);
            laptop.AddBlackIce(new Net.BlackICE.NetBlackIce("aa", 1, 2, 2, 2, 2), 6);


            net.StartNetrunning(laptop, satomi);
            //ShowMapArea.ShowArea(sunsetmotel);

            #region old code
            //var director = new CharacterDirector();
            //var builder = new StreetratBuilder();
            //director.Builder = builder;

            //Console.WriteLine("Stworz nowa postac");
            //director.BuildStreetratCharacter();
            //Character user = builder.GetCharacter();

            //Area warehouse = new Area("Magazyn", 50, 50);

            // Streetrat characters
            //director.BuildStreetratCharacter("Vulpiro", CharacterRole.Netrunner);
            //Character vulpiro = builder.GetCharacter();
            //director.BuildStreetratCharacter("Fr0gger", CharacterRole.Nomad);
            //Character frogger = builder.GetCharacter();
            //director.BuildStreetratCharacter("Shu", CharacterRole.Netrunner);
            //Character shu = builder.GetCharacter();
            //director.BuildStreetratCharacter("Ingvild", CharacterRole.Medtech);
            //Character ingvild = builder.GetCharacter();


            //Character forty = new Character("Forty", CharacterRole.Rocker, 5, 6, 7, 5, 7, 8, 5, 7, 3, 6, 12);
            //Character ingvild = new Character("Ingvild", CharacterRole.Medtech, 7, 6, 5, 10, 5, 8, 2, 15, 3, 4);
            //Character vulpiro = new Character("Vulpiro", CharacterRole.Netrunner, 7, 6, 6, 6, 4, 4, 5, 6, 3, 7);
            //Character frogger = new Character("Fr0ger", CharaRole.Nomad,); // wszczepy na nogi by skakać wyżej bo wiecie żaba, i egzoszkielet na rece i kręgosłóp by przenosic rzeczy, poboczna broń magnetyczny bicz by zabierać jak żaba
            //Character shu = new Character("Shu", CharaRole.Netrunner,)

            //Combat.StartCombat(new Character[] {vulpiro, ingvild, frogger, shu});

            //Pistol barCiePis = new Pistol("Bardzo ciezki pisolet", 4, 8, 16, 1);

            //warehouse.SetObject(vulpiro, 10, 10);
            //warehouse.SetObject(ingvild, 10, 40);
            //warehouse.SetObject(frogger, 40, 10);
            //warehouse.SetObject(shu, 40, 40);

            //vulpiro.Weapon1 = barCiePis;
            //ingvild.Weapon1 = barCiePis;
            //frogger.Weapon1 = barCiePis;
            //shu.Weapon1 = barCiePis;

            //vulpiro.Attack(shu);
            //shu.Attack(frogger);
            //frogger.Attack(ingvild);
            //ingvild.Attack(vulpiro);
            #endregion
        }
    }
}
