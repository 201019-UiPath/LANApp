namespace LLLib.Game
{
    public interface IGameService
    {
         void AddGame(Game game);
         void UpdateGame(Game game);
         void DeleteGame(Game game);
         List<Game> GetAllGames();
         List<Game> GetAllGamesByTeamId(int id);
    }
}