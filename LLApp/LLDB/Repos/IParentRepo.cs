using System.Collections.Generic;
using LLDB.Models;

namespace LLDB.Repos
{
    public interface IParentRepo
    {
        void AddParent(Parent parent);
         void UpdateParent(Parent parent);
         void DeleteParent(Parent parent);
         List<Parent> GetAllParents();
         List<Parent> GetAllParentsByChildId(int id);        
    }
}