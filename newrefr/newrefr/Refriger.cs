using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newrefr
{
    public class Refriger : Device, IOpenClose, ISetTemp
    {
        public bool Refrdoor { get; set; }
        public int Refrtemp { get; set; }
        public Refriger(string Name, bool Onoff, bool Openclose, int Temp)
            : base(Onoff,Name)
        {
            this.Onoff = Onoff;
            this.Refrdoor = Refrdoor;
            this.Refrtemp = Temp;
            this.Name = Name;
        }
        
        public void Open()
        {
            Refrdoor = true;
        }
        public void Close()
        {
            Refrdoor = false;
        }
        public void SetTemp(int temp)
        {
            this.Refrtemp = temp;
        }
        public int Currenttemp
        {
            get
            {
                return Refrtemp;
            }
            set
            {
                Refrtemp = value;
            }
        }
        public override string ToString()
        {
           string sd;

            if (Refrdoor == true)
            {
                sd = "Open";
            }
            else 
            {
                sd = "Close";
            }
                return "Refrigerator" + " " + Name + " " + base.ToString() + " " + sd + " " + Refrtemp;
        }
    }
}
