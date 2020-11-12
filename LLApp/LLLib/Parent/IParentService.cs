using System;
using LLDB.Models;
using System.Collections.Generic;

namespace LLLib
{
    public interface IParentService
    {
         void AddParent(Parent parent);
         void UpdateParent(Parent parent);
         void DeleteParent(Parent parent);
         List<Parent> GetAllParents();
         List<Parent> GetParentsByChildId(int id);
    }
}