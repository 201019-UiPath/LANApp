using System;
using LLDB.Models;
using LLDB.Repos;
using System.Collections.Generic;

namespace LLLib
{
    public class ParentService : IParentService
    {
        private IParentRepo repo;

        public ParentService(IParentRepo repo) {
            this.repo = repo;
        }

        public void AddParent(Parent parent) {
            repo.AddParent(parent);
        }

        public void UpdateParent(Parent parent) {
             repo.UpdateParent(parent);
         }

         public void DeleteParent(Parent parent) {
             repo.DeleteParent(parent);
         }

         public List<Parent> GetAllParents() {
             List<Parent> parent = repo.GetAllParents();
             return parent;
         }

         public List<Parent> GetAllParentsByChildId(int id) {
             List<Parent> parent = repo.GetAllParentsByChildId(id);
             return parent;
         }

        public Parent GetParentById(int id)
        {
            Parent parent = repo.GetParentById(id);
            return parent;
        }

    }
}