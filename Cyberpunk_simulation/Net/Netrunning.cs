﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cyberpunk_simulation.Net.InterfaceAbilities;
using Cyberpunk_simulation.Net.Programs;
using Cyberpunk_simulation.Net.NetArchitecture.NetObjects;
using Cyberpunk_simulation.Net.NetArchitecture;


namespace Cyberpunk_simulation.Net
{
    // Classa ta jest łączneniem wszystkiego co jest związanego z umiejętnościami netrunningu, tworzysz obiekt tego by podłączyć się do Architektur
    class Netrunning
    {
        public int netrunnerInterfaceRank = 1;

        public int backdoormod = 0;
        public int pathfindermod = 0;

        NetArchitectureBody netArchitecture;

        NetProgram[] rezzedPrograms = new NetProgram[5];
        public void StartNetrunning(NetArchitectureBody net)
        {
            netArchitecture = net;
            netArchitecture.CheckForPassword();
            RefreshDisplay();
        }

        public void StopNetrunning()
        {
            ClearDisplay();
        }

        public string GetCommand()
        {
            Console.WriteLine("");
            Console.Write("C:\\ > ");
            return Console.ReadLine();
        }

        public void Command()
        {
            string commandtext = GetCommand();
            string[] commands = commandtext.Split(' ');
            SelectInterfaceAbility(commands);
        }

        public void SelectInterfaceAbility(string[] command)
        {
            switch (command[0])
            {
                case "backdoor":
                    Backdoor.Activate(netArchitecture, netrunnerInterfaceRank, backdoormod);
                    WaitForResponse();
                    break;
                case "eyedee":
                    if (command.Length > 1 && int.TryParse(command[1], out _))
                    {
                        EyeDee.Activate(netArchitecture, netrunnerInterfaceRank, int.Parse(command[1]));
                        WaitForResponse();
                        break;
                    }
                    EyeDee.Activate(netArchitecture, netrunnerInterfaceRank);
                    WaitForResponse();
                    break;
                case "jackout":
                    StopNetrunning();
                    break;
                case "open":
                    if (command.Length > 1 && int.TryParse(command[1], out _))
                    {
                        Open.Activate(netArchitecture, netrunnerInterfaceRank, int.Parse(command[1]));
                        WaitForResponse();
                        break;
                    }
                    Console.WriteLine("Choose ID");
                    WaitForResponse();
                    break;
                case "pathfinder":
                    Pathfinder.Activate(netArchitecture, netrunnerInterfaceRank, pathfindermod);
                    WaitForResponse();
                    break;
                case "seeya":
                    SeeYa seeya = new SeeYa();
                    seeya.Activate(ref pathfindermod);
                    WaitForResponse();
                    break;
                case "worm":
                    int i = 0;
                    foreach (NetProgram prog in rezzedPrograms)
                    {
                        if(prog == null)
                        {
                            rezzedPrograms[i] = new Worm();
                            rezzedPrograms[i].Activate(ref backdoormod);
                            break;
                        }
                        i++;
                    }
                    WaitForResponse();
                    break;
                default:
                    Console.WriteLine("Unknown command, try again");
                    Command();
                    break;
            }
        }

        public void ShowNetArchitecture(NetArchitectureBody net)
        {
            int i = 0;
            foreach (NetArchitectureObject netobject in net.architecture)
            {
                if (netobject.IsAccessed == true)
                {
                    Console.WriteLine("[{0}] {1}", i, netobject.Name);
                }
                else if (netobject.IsShowed == true)
                {
                    ShowTypeOfNetObject(netobject, i);
                }
                else
                {
                    break;
                }
                i++;
            }
        }

        public void ShowTypeOfNetObject(NetArchitectureObject obj, int i)
        {
            if (obj is NetObjectPassword)
            {
                Console.WriteLine("[{0}] password", i);
            }
            else if (obj is NetObjectFile)
            {
                Console.WriteLine("[{0}] file", i);
            }
            else
            {
                Console.WriteLine("[{0}] null", i);
            }
        }
        public void ClearDisplay()
        {
            Console.Clear();
        }

        public void WaitForResponse()
        {
            Console.ReadLine();
            RefreshDisplay();
        }
        public void RefreshDisplay()
        {
            ClearDisplay();
            InterfaceUI();
            ShowNetArchitecture(netArchitecture);
            Command();
        }
        public void InterfaceUI()
        {
            Console.WriteLine("Interface Rank: {0} | Net Actions: error | Netrunner: error |", netrunnerInterfaceRank);
            Console.WriteLine("-----------------------------------------------------------");
            if (rezzedPrograms[0] != null)
            {
                Console.WriteLine("Rezzed Programs:");
                foreach(NetProgram prog in rezzedPrograms)
                {
                    if (prog != null)
                    {
                        Console.WriteLine(prog.Name);
                    }
                }
            }
            Console.WriteLine("");
        }
    }
}