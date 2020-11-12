using LLDB.Models;
using System;
using System.Collections.Generic;

namespace LLLib
{
    public interface IChildService
    {
         void AddChild(Child child);
         void UpdateChild(Child child);
         void DeleteChild(Child child);
         List<Child> GetAllChildren();
         Child GetChildByTeamId(int id);
         List<Child> GetAllChildrenByTeamId(int id);
         List<Child> GetAllChildrenByParentId(int id);
    }
}