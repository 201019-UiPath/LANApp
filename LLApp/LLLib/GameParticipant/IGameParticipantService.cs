namespace LLLib
{
    public interface IGameParticipantService
    {
        void AddGameParticipant(GameParticipant participant);
        void UpdateCoach(GameParticipant participant);
        void DeleteCoach(GameParticipant participant);
        List<GameParticipant> GetAllGameParticipantsByGameId(int id);
         
    }
}