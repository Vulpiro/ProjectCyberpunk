using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_simulation
{
    class GenerateSTATS
    {
        public static void GenerateRockerRNDSTATS(out int intt, out int reff, out int dex, out int tech,
            out int cool, out int will, out int luck, out int move, out int body, out int emp)
        {
            intt = 0;
            reff = 0;
            dex = 0;
            tech = 0;
            cool = 0;
            will = 0;
            luck = 0;
            move = 0;
            body = 0;
            emp = 0;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int dice = rnd.Next(1, 11);
            switch (dice)
            {
                case 1:
                    intt = 7;
                    reff = 6;
                    dex = 6;
                    tech = 5;
                    cool = 6;
                    will = 8;
                    luck = 7;
                    move = 7;
                    body = 3;
                    emp = 8;
                    break;
                case 2:
                    intt = 7;
                    reff = 6;
                    dex = 6;
                    tech = 5;
                    cool = 6;
                    will = 8;
                    luck = 7;
                    move = 7;
                    body = 3;
                    emp = 8;
                    break;
                case 3:
                    intt = 7;
                    reff = 6;
                    dex = 6;
                    tech = 5;
                    cool = 6;
                    will = 8;
                    luck = 7;
                    move = 7;
                    body = 3;
                    emp = 8;
                    break;
                case 4:
                    intt = 7;
                    reff = 6;
                    dex = 6;
                    tech = 5;
                    cool = 6;
                    will = 8;
                    luck = 7;
                    move = 7;
                    body = 3;
                    emp = 8;
                    break;
                case 5:
                    intt = 7;
                    reff = 6;
                    dex = 6;
                    tech = 5;
                    cool = 6;
                    will = 8;
                    luck = 7;
                    move = 7;
                    body = 3;
                    emp = 8;
                    break;
                case 6:
                    intt = 7;
                    reff = 6;
                    dex = 6;
                    tech = 5;
                    cool = 6;
                    will = 8;
                    luck = 7;
                    move = 7;
                    body = 3;
                    emp = 8;
                    break;
                case 7:
                    intt = 7;
                    reff = 6;
                    dex = 6;
                    tech = 5;
                    cool = 6;
                    will = 8;
                    luck = 7;
                    move = 7;
                    body = 3;
                    emp = 8;
                    break;
                case 8:
                    intt = 7;
                    reff = 6;
                    dex = 6;
                    tech = 5;
                    cool = 6;
                    will = 8;
                    luck = 7;
                    move = 7;
                    body = 3;
                    emp = 8;
                    break;
                case 9:
                    intt = 7;
                    reff = 6;
                    dex = 6;
                    tech = 5;
                    cool = 6;
                    will = 8;
                    luck = 7;
                    move = 7;
                    body = 3;
                    emp = 8;
                    break;
                case 10:
                    intt = 7;
                    reff = 6;
                    dex = 6;
                    tech = 5;
                    cool = 6;
                    will = 8;
                    luck = 7;
                    move = 7;
                    body = 3;
                    emp = 8;
                    break;
            }

        }
    }
}
