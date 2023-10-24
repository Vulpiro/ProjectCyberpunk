using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Net.NetArchitecture.NetObjects;
using Cyberpunk_simulation.Net.BlackICE;

namespace Cyberpunk_simulation.Net.NetArchitecture
{
    class NetArchitectureBody
    {
        public NetArchitectureObject[] architecture;
        public NetArchitectureBody(int size)
        {
            architecture = new NetArchitectureObject[size];
        }

        public void AddObject(NetArchitectureObject obj, int position)
        {
            architecture[position] = obj;
        }

        public void AddBlackIce(NetBlackIce obj, int position)
        {
            if(architecture[position] == null)
            {
                NetArchitectureObject temp = new NetArchitectureObject();
                temp.blackIceObjs.Add(obj);
                architecture[position] = temp;
            }
            else
            {
                architecture[position].blackIceObjs.Add(obj);
            }
            
        }

        public void CheckForPassword()
        {
            bool access = true;
            int i = 0;
            foreach (NetArchitectureObject obj in architecture)
            {
                if (obj != null)
                {
                    obj.IsAccessed = access;
                }
                else
                {
                    architecture[i] = new NetArchitectureObject("null", access);
                }
                if (obj is NetObjectPassword)
                {
                    access = false;
                }
                i++;
            }
        }

        public void CheckForVisibility(int roll)
        {
            bool show = true;
            int highestdv = 0;
            int i = 0;
            foreach (NetArchitectureObject obj in architecture)
            {
                if (obj != null)
                {
                    if (obj.dv > highestdv)
                    {
                        highestdv = obj.dv;
                    }
                    if (highestdv >= roll)
                    {
                        show = false;
                    }
                    if (obj.IsShowed == false)
                    {
                        obj.IsShowed = show;
                    }
                }
                i++;
            }
        }
    }
}
