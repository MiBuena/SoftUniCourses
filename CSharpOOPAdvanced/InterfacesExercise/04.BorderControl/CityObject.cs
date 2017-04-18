using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BorderControl
{
    class CityObject : IObject
    {
        public CityObject(string id)
        {
            this.Id = id;
        }

        public string Id { get; set; }

    }
}
