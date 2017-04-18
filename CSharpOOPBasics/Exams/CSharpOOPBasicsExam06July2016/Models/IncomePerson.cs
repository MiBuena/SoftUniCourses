using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using _01.KermenExam.Interfaces;

namespace _01.KermenExam.Models
{
    public class IncomePerson : IIncomePerson
    {
        public IncomePerson(decimal income)
        {
            Income = income;
        }

        public decimal Income { get; }
    }
}
