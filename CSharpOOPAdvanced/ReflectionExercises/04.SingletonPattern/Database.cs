using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SingletonPattern
{
    public class Database
    {
        private Database()
        {

        }

        private static Database instance;

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (instance)
                    {
                        if (instance == null)
                        {
                            instance = new Database();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
