namespace LLLib.Game
{
    public interface IGameService
    {
         void AddGame(Game game);
         void UpdateGame(Game game);
         void DeleteGame(Game game);
         List<Child> GetAllChildren();
         Child GetChildByTeamId(int id);
         List<Child> GetAllChildrenByTeamId(int id);
    }
}