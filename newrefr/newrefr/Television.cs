using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newrefr
{
    public class Television : Device, IVolume
    {
        public int Tvolume { get; set; }
        public Television(string Name, bool Onoff, int Volume)
            : base(Onoff,Name)
        {
            this.Onoff = Onoff;
            this.Tvolume = Volume;
            this.Name = Name;
        }
        
        public void SetVolume(int vol)
        {
            this.Tvolume = vol;
        }
        public int Currentvolume
        {
            get
            {
                return Tvolume;
            }
            set
            {
                Tvolume = value;
            }
        }
        public override string ToString()
        {
            return "TV" + " " + Name + " " + base.ToString() + " " + Tvolume;
        }
    }
}
