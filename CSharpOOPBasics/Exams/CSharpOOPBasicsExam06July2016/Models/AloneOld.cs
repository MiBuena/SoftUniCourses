using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.KermenExam.Interfaces;

namespace _01.KermenExam.Models
{
    public class AloneOld: BasicHousehold
    {
        private const decimal AloneOldRoomConsumption = 15;
        private const int AloneOldRoomNumber = 1;


        public AloneOld(params IIncomePerson[] incomePersons) : base(AloneOldRoomNumber, AloneOldRoomConsumption, incomePersons)
        {
        }


    }
}
