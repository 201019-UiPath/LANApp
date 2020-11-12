using System;
using System.Collections.Generic;
using System.Text;

using LLDB.Models;

namespace LLDB.Repos
{
    interface IGameParticipantRepo
    {
        void AddGameParticipant(GameParticipant participant);
        void UpdateGameParticipant(GameParticipant participant);
        void DeleteGameParticipant(GameParticipant participant);
        List<GameParticipant> GetAllGameParticipantsByGameId(int id);
    }
}
