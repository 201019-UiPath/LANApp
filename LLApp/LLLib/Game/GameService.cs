using System;

namespace LLLib
{
    public class GameService
    {
        private IGameRepo repo;

        public GameService(IGameRepo repo) {
            this.repo = repo;
        }

        public void AddGame(Game game) {
            repo.AddBook(game);
        }

        public void UpdateGame(Game game) {
             repo.UpdateGame(game);
         }

         public void DeleteGame(Game game) {
             repo.DeleteGame(child);
         }

         public List<Child> GetAllChildren() {
             List<Child> child = repo.GetAllChildren();
             return child;
         }

        public Child GetChildByTeamId(int id) {
             Child child = repo.GetChildByTeamId(id);
             return child;
         }    

         public List<Child> GetAllChildrenByTeamId(ints id) {
             List<Child> child = repo.GetAllChildrenByTeamId();
             return child;
         }   

    }
}
