using System;
using LLDB.Models;
using System.Collections.Generic;

namespace LLLib
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