using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newrefr
{
    public class Menu
    {

        List<Device> devices = new List<Device>();
        DynamicMenu dm = new DynamicMenu();
        
        
        public void ShowMainMenu()
        {
            Console.Clear();
           // dm.ShowDinMenu(new Micro("sd", false, false));
            
            foreach (Device d in devices)
            {
                Console.WriteLine(d.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Please input a command");
            string command = Console.ReadLine();
            string[] comm = command.Split(' ');
            

            switch (comm[0])
            {
                case "add":
                                    
                    switch (comm[1])
                    {
                        case "micro":
                            Micro micro = new Micro(comm[2], false, false);
                            devices.Add(micro);
                            break;
                        case "music":
                            Music music = new Music(comm[2], false, 0);
                            devices.Add(music);
                            break;
                        case "refr":
                            Refriger refr = new Refriger(comm[2], false, false, 0);
                            devices.Add(refr);
                            break;
                        case "tv":
                            Television tv = new Television(comm[2], false, 0);
                            devices.Add(tv);
                            break;
                        case"wash":
                            Wash wash = new Wash(comm[2], false, false, 0);
                            devices.Add(wash);
                            break;
                    }
                    break;
                
                
                case "delete":
                    foreach (Device f in devices)
                    {
                        if (f.Name == comm[2])
                        {
                            switch (comm[1])
                            {
                                case "micro":
                                    devices.Remove(f as Micro);
                                    break;
                                case "music":
                                    devices.Remove(f as Music);
                                    break;
                                case "refr":
                                    devices.Remove(f as Refriger);
                                    break;
                                case "tv":
                                    devices.Remove(f as Television);
                                    break;
                                case "wash":
                                    devices.Remove(f as Wash);
                                    break;
                            }
                            break;
                        }
                       
                    }
                    
                    break;

                case "edit":
                   /* var dev = from d in devices where d.Name == comm[2] select d;
                    foreach (var de in dev)
                    {
                        dm.ShowDinMenu(de);
                    }*/
                    foreach (Device e in devices)
                    {
                        if (e.Name == comm[2])
                        {
                            dm.ShowDinMenu(e);
                           
                        }
                    }

                    break;

               

            }
            

        }
        
    }
}
