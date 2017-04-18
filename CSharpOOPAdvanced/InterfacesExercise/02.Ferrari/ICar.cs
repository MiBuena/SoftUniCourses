using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ferrari
{
    interface ICar
    {
        string Model { get; }
        string Driver { get; set; }

        string UseBrakes();
        string PushGasPedal();
    }
}
