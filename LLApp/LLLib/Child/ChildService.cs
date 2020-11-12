using System;

namespace LLLib
{
    public class ChildService
    {
        private IChildRepo repo;

        public ChildService(IChildRepo repo) {
            this.repo = repo;
        }

        public void AddChild(Child child) {
            repo.AddBook(child);
        }

        public void UpdateChild(Child child) {
             repo.UpdateBook(child);
         }

         public void DeleteChild(Child child) {
             repo.DeleteBook(child);
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
