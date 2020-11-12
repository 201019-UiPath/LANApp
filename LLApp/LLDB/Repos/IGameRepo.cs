using System.Collections.Generic;

using LLDB.Models;

namespace LLDB.Repos
{
    public interface IGameRepo
    {
        void AddGame(Game game);
        void UpdateGame(Game game);
        void DeleteGame(Game game);
        List<Game> GetAllGames();
        List<Game> GetAllGamesByTeamId(int id);
    }
}