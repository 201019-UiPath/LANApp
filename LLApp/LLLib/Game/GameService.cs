// using System;
// using LLDB.Models;
// using System.Collections.Generic;

// namespace LLLib
// {
//     public class GameService
//     {
//         private IGameRepo repo;

//         public GameService(IGameRepo repo) {
//             this.repo = repo;
//         }

//         public void AddGame(Game game) {
//             repo.AddGame(game);
//         }

//         public void UpdateGame(Game game) {
//              repo.UpdateGame(game);
//          }

//          public void DeleteGame(Game game) {
//              repo.DeleteGame(game);
//          }

//          public List<Game> GetAllGames() {
//              List<Game> game = repo.GetAllGames();
//              return game;
//          }

//          public List<Game> GetAllGamesByTeamId(ints id) {
//              List<Game> game = repo.GetAllGamesByTeamId();
//              return game;
//          }   

//     }
// }
