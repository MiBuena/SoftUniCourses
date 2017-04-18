using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.KermenExam.Interfaces;
using _01.KermenExam.UI;

namespace _01.KermenExam.Database
{
    public class Database : IDatabase
    {
        public Database()
        {
            this.Households = new List<IHousehold>();
        }

        public IList<IHousehold> Households { get; }
    }
}
