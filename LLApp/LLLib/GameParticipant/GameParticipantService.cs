namespace LLLib
{
    public class GameParticipant : IGameParticipantService
    {
        private IGameParticipantRepo repo;

        public GameParticipant(IGameParticipantRepo repo) {
            this.repo = repo;
        }

        void AddGameParticipant(GameParticipant participant) {
            repo.AddGameParticipant(participant);
        }

        void UpdateGameParticipant(GameParticipant participant) {
            repo.UpdateGameParticipant(participant);
        }

        void DeleteGameParticipant(GameParticipant participant) {
            repo.DeleteGameParticipant(participant);
        }

        List<GameParticipant> GetAllGameParticipantsByGameId(int id) {
            List<GameParticipant> participants = repo.GetAllGameParticipantsByGameId();
             return participants;
        }
        
    }
}