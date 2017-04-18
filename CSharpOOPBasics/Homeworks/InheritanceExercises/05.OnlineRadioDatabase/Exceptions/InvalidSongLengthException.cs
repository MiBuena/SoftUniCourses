using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OnlineRadioDatabase.Exceptions
{
    class InvalidSongLengthException:InvalidSongException
    {
        private const string Message = "Invalid song length.";

        public InvalidSongLengthException():base(Message)
        {

        }

        public InvalidSongLengthException(string messsage):base(messsage)
        {

        }
    }
}
