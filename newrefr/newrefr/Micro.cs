using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newrefr
{
    public class Micro : Device, IOpenClose
    {
        public bool Microdoor { get; set; }
        public Micro(string Name, bool Onoff, bool Microdoor)
            : base(Onoff,Name)
        {
            this.Onoff = Onoff;
            this.Microdoor = Microdoor;
            this.Name = Name;
        }
       
        public void Open()
        {
            Microdoor = true;
        }
        public void Close()
        {
            Microdoor = false;
        }
        public override string ToString()
        {
            string sd;
            
            if (Microdoor == true)
            {
                sd = "Open";
            }
            else
            {
                sd = "Close";
            }
            return "Micro " + Name + " " + base.ToString() + " " + sd;
        }
    }
}
