using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OnlineRadioDatabase
{
    class PlayList
    {
        public PlayList()
        {
            this.SongCollection = new List<Song>();
        }

        public List<Song> SongCollection { get; set; }

        public List<long> CalculatePlayListLength()
        {
            long totalSeconds = 0;

            foreach (var element in this.SongCollection)
            {
                totalSeconds += element.Seconds;
                totalSeconds += 60*element.Minutes;
            }

            long hours = totalSeconds/60/60;

            long minutes = (totalSeconds/60)%60;

            long seconds = (totalSeconds % 60) % 60;

            List<long> length = new List<long>();

            length.Add(seconds);
            length.Add(minutes);
            length.Add(hours);

            return length;
        } 
    }
}
