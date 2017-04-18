using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _06.PlanckConstant
{
    class Calculation
    {
        public const double PlanckConst = 6.62606896e-34;

        public const double PI = 3.14159;

        public static double ReducePlanckConst()
        {
            double number = Calculation.PlanckConst/(2*Calculation.PI);

            return number;
        }
    }
}
