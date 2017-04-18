using System;

namespace _06.FoodShortage
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
