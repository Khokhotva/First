using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newrefr
{
    public class Music : Device, IVolume
    {
        public int MusVolume { get; set; }
        public Music(string Name, bool Onoff, int Volume)
            : base(Onoff, Name)
        {
            this.Onoff = Onoff;
            this.MusVolume = Volume;
            this.Name = Name;
        }
        
        public void SetVolume(int vol)
        {
            this.MusVolume = vol;
        }
        public int Currentvolume
        {
            get
            {
                return MusVolume;
            }
            set
            {
                MusVolume = value;
            }
        }
        public override string ToString()
        {
            
            return "Music " + Name + " " + base.ToString() + " " + MusVolume;
        }
    }
}
