using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newrefr
{
    public interface ISetTemp
    {
        int Currenttemp { get; set; }
        void SetTemp(int i);
    }
}
