using System;

namespace _05.BirthdayCelebrations
{
    class CityObject : IObject
    {
        public CityObject(DateTime birthday)
        {
            this.Birthday = birthday;
        }

        public DateTime Birthday { get; set; }
    }
}
