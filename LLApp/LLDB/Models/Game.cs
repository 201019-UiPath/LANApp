using System;
using System.Collections.Generic;

namespace LLDB.Models
{
    public class Game
    {
        public int GameId { get; set; }

        public int Team1Id { get; set; }

        public Team Team1 { get; set; }

        public int Team2Id { get; set; }

        public Team Team2 { get; set; }

        public DateTime Time { get; set; }

        public List<Child> Participants { get; set; }
    }
}