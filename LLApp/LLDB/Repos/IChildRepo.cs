using System.Collections.Generic;

using LLDB.Models;

namespace LLDB.Repos
{
    public interface IChildRepo
    {
        void AddChild(Child child);
        void UpdateChild(Child child);
        void DeleteChild(Child child);
        List<Child> GetAllChildren();
        Child GetChildByTeamId(int id);
        List<Child> GetAllChildrenByTeamId(int id);
    }
}