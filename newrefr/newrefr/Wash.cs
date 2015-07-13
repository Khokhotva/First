using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newrefr
{
    public class Wash : Device, IOpenClose, ISetTemp
    {
        public int Washtemp { get; set; }
        public bool Washdoor { get; set; }
        public Wash(string Name, bool Onoff, bool Openclose, int Temp)
            : base(Onoff,Name)
        {
            this.Onoff = Onoff;
            this.Washdoor = Openclose;
            this.Washtemp = Temp;
            this.Name = Name;
        }
        
        public void Open()
        {
            Washdoor = true;
        }
        public void Close()
        {
            Washdoor = false;
        }
        public void SetTemp(int temp)
        {
            this.Washtemp = temp;
        }
        public int Currenttemp
        {
            get
            {
                return Washtemp;
            }
            set
            {
                Washtemp = value;
            }
        }
        public override string ToString()
        {
            string sd;
            if (Washdoor == true)
            {
                sd = "Open";
            }
            else 
            {
                sd = "Close";
            }
            return "Wash" + " " + Name + " " + base.ToString() + " " + sd + " " + Washtemp;
        }
    }
}
