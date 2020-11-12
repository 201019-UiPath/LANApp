using LLDB.Models;
using LLDB.Repos;
using System.Collections.Generic;

namespace LLLib
{
    public class GameParticipantService : IGameParticipantService
    {
        private IGameParticipantRepo repo;

        public GameParticipantService(IGameParticipantRepo repo) {
            this.repo = repo;
        }

        public void AddGameParticipant(GameParticipant participant)
        {
            repo.AddGameParticipant(participant);
        }

        public void UpdateGameParticipant(GameParticipant participant)
        {
            repo.UpdateGameParticipant(participant);
        }

        public void DeleteGameParticipant(GameParticipant participant)
        {
            repo.DeleteGameParticipant(participant);
        }

        public List<GameParticipant> GetAllGameParticipantsByGameId(int id)
        {
            List<GameParticipant> participants = repo.GetAllGameParticipantsByGameId(id);
             return participants;
        }
    }
}