using System;
using System.Collections.Generic;
using System.Text;
using LLDB.Models;

namespace LLDB.Repos
{
    interface IParentRepo
    {
        void AddParent(Parent parent);
        void UpdateParent(Parent parent);
        void DeleteParent(Parent parent);
        List<Parent> GetAllParents();
        List<Parent> GetParentsByChildId(int id);
    }
}
