﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExplicitInterfaces.Interfaces
{
    interface IResident
    {
        string Name { get; set; }
        string Country { get; set; }

        string GetName();
    }
}
