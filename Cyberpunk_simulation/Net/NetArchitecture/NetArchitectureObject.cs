using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Net.BlackICE;

namespace Cyberpunk_simulation.Net.NetArchitecture
{
    class NetArchitectureObject
    {
        public string Name { get; set; }
        public bool IsAccessed { get; set; }
        public bool IsShowed { get; set; }

        public int dv = 0;

        public List<NetBlackIce> blackIceObjs = new List<NetBlackIce>(); 

        public void CheckForBlackIce(NetNetrunner runner)
        {
            if(blackIceObjs[0] != null)
            {
                NetCombat.StartNetCombat(runner, blackIceObjs);
            }
        }

        #region Constructors
        public NetArchitectureObject()
        {
            Name = "empty";
            IsAccessed = true;
            IsShowed = false;
        }
        public NetArchitectureObject(string name)
        {
            Name = name;
            IsAccessed = true;
            IsShowed = false;
        }

        public NetArchitectureObject(string name, bool access)
        {
            Name = name;
            IsAccessed = access;
            IsShowed = false;
        }

        public NetArchitectureObject(string name, bool access, bool show)
        {
            Name = name;
            IsAccessed = access;
            IsShowed = show;
        }
        #endregion
    }
}
