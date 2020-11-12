using System;
using System.Collections.Generic;
using System.Text;

namespace LLDB.Repos
{
    interface IGame
    {
        void AddGame(Game game);
        void UpdateGame(Game game);
        void DeleteGame(Game game);
        List<Game> GetAllGames();
        List<Game> GetAllGamesByTeamId(int id);
    }
}
