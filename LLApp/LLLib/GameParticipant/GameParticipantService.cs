namespace LLLib
{
    public class GameParticipant
    {
        private IGameParticipantRepo repo;

        public CoachService(IGameParticipantRepo repo) {
            this.repo = repo;
        }

        void AddGameParticipant(GameParticipant participant) {}

        void UpdateCoach(GameParticipant participant) {}

        void DeleteCoach(GameParticipant participant) {}

        List<GameParticipant> GetAllGameParticipantsByGameId(int id) {}
        
    }
}