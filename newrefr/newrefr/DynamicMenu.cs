using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newrefr
{
    public class DynamicMenu
    {
        public void ShowDinMenu(Device devices)
        {
            if (devices is IOnOff)
            {
                Console.WriteLine("For On / Off please 0 or 1");
            }
            if (devices is IOpenClose)
            {
                Console.WriteLine("For Open / Close please 'O' or 'C'");
            }
            if (devices is ISetTemp)
            {
                Console.WriteLine("Set temperature, please 'S' ");
            }
            if (devices is IVolume)
            {
                Console.WriteLine("Set volume, please 'V' ");
            }
            char v = Console.ReadKey().KeyChar;

            switch (v)
            {
                case '1':
                    devices.On();
                    break;
                case '0':
                    devices.Off();
                    break;
                case 'o':
                    ((IOpenClose)devices).Open();
                    break;
                case 'c':
                    ((IOpenClose)devices).Close();
                    break;
                case 's':
                    Console.WriteLine("Input temperature: ");
                    int t = Int32.Parse(Console.ReadLine());
                    ((ISetTemp)devices).SetTemp(t);
                    break;
                case 'v':
                    Console.WriteLine("Input volume: ");
                    int vol = Int32.Parse(Console.ReadLine());
                    ((IVolume)devices).SetVolume(vol);
                    break;
                
                    
            }  
            
        }
    }
}
