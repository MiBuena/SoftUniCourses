using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OnlineRadioDatabase.Exceptions
{
    class InvalidSongException: Exception
    {
        private const string GeneralMessage = "Invalid song.";

        public InvalidSongException():base(GeneralMessage)
        {

        }

        public InvalidSongException(string messsage):base(messsage)
        {

        }

    }
}
