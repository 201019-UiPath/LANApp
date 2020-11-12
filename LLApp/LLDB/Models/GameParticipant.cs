using System;

namespace LLDB.Models
{
    public class GameParticipant
    {
        public int GameParticipantId { get; set; }

        public int GameId { get; set; }
        
        public int TeamId { get; set; }
        
    }
}