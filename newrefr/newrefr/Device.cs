using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newrefr
{
    public abstract class Device : IOnOff
    {
        public string Name { get; set; }
        public bool Onoff { get; set; }
        public Device(bool Onoff, string Name)
        {
            this.Onoff = Onoff;
            this.Name = Name;
        }
        public void On()
        {
            Onoff = true;
        }
        public void Off()
        {
            Onoff = false;
        }
        public override string ToString()
        {
            string sost;
            if ( Onoff == true)
            {
                sost = "On";
            }
            else
            {
                sost = "Off";
            }
            return sost;
        }
    }
}
