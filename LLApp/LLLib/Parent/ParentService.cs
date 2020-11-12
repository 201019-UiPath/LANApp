using System;
using LLDB.Models;
using System.Collections.Generic;

namespace LLLib
{
    public class ParentService
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

         public List<Parent> GetAllParentsByChildId(ints id) {
             List<Parent> parent = repo.GetAllParentsByChildId();
             return parent;
         }   
   
    }
}