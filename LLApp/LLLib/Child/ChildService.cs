using System;
using LLDB.Models;
using System.Collections.Generic;
using LLDB.Repos;

namespace LLLib
{
    public class ChildService : IChildService
    {
        private IChildRepo repo;

        public ChildService(IChildRepo repo) {
            this.repo = repo;
        }

        public void AddChild(Child child) {
            repo.AddChild(child);
        }

        public void UpdateChild(Child child) {
             repo.UpdateChild(child);
         }

         public void DeleteChild(Child child) {
             repo.DeleteChild(child);
         }

         public List<Child> GetAllChildren() {
             List<Child> child = repo.GetAllChildren();
             return child;
         }

        public Child GetChildByTeamId(int id) {
             Child child = repo.GetChildByTeamId(id);
             return child;
         }    

         public List<Child> GetAllChildrenByTeamId(int id) {
             List<Child> child = repo.GetAllChildrenByTeamId(id);
             return child;
         }

         public List<Child> GetAllChildrenByParentId(int id) {
             List<Child> child = repo.GetAllChildrenByParentId(id);
             return child;
         }

    }
}
