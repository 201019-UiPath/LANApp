using System;
using System.Collections.Generic;

namespace LLDB.Models
{
    public class Game
    {
        public int GameId { get; set; }

        public List<GameParticipant> GameParticipants { get; set; }

        public DateTime Time { get; set; }
    }
}