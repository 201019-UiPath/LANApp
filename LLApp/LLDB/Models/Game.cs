using System;
using System.Collections.Generic;

namespace LLDB.Models
{
    public class Game
    {
        public int GameId { get; set; }

        public int Team1 { get; set; }

        public int Team2 { get; set; }

        public DateTime Time { get; set; }

        public List<Child> Participants { get; set; }
    }
}