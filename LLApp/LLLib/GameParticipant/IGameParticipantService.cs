namespace LLLib
{
    public interface IGameParticipantService
    {
        void AddGameParticipant(GameParticipant participant);
        void UpdateGameParticipant(GameParticipant participant);
        void DeleteGameParticipant(GameParticipant participant);
        List<GameParticipant> GetAllGameParticipantsByGameId(int id);
         
    }
}