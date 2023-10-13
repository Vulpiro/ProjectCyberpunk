using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Net.NetArchitecture;

namespace Cyberpunk_simulation.Net.NetArchitecture.NetObjects
{
    class NetObjectFile : NetArchitectureObject
    {
        
        public bool IsDecrypted { get; set; }
        public string Text { get; set; }
        public NetObjectFile()
        {
            Name = "File Eye-dee DV" + dv;
            IsAccessed = true;
            IsShowed = false;
            IsDecrypted = false;
            Text = "Empty";
        }
        public NetObjectFile(int diff)
        {
            dv = diff;
            Name = "File Eye-dee DV" + dv;
            IsAccessed = true;
            IsShowed = false;
            IsDecrypted = false;
            Text = "Empty";
        }
        public NetObjectFile(int diff, string name)
        {
            dv = diff;
            Name = name + " File Eye-dee DV" + dv;
            IsAccessed = true;
            IsShowed = false;
            IsDecrypted = false;
            Text = "Empty";
        }

        public NetObjectFile(int diff, string name, string text)
        {
            dv = diff;
            Name = name + " File Eye-dee DV" + dv;
            IsAccessed = true;
            IsShowed = false;
            IsDecrypted = false;
            Text = text;
        }

        public void DecryptFile()
        {
            string[] words = Name.Split(' ');
            Name = words[0];
            IsDecrypted = true;
        }
    }
}
