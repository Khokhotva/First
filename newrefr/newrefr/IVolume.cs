using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newrefr
{
    public interface IVolume
    {
        int Currentvolume { get; set; }
        void SetVolume(int v);
    }
}
