using System.Collections.Generic;

namespace _01.KermenExam.Interfaces
{
    public interface IDatabase
    {
        IList<IHousehold> Households { get; }
    }
}
