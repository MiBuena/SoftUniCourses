﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KingsGambit.Interfaces
{
    public interface IKillable : IPerson
    {
        void Die();
        bool IsAlive { get; set; }
    }
}
