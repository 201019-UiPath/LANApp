using System;
using System.Collections.Generic;
using System.Text;

using LLDB.Models;

namespace LLDB.Repos
{
    interface ICoachRepo
    {
        void AddCoach(Coach coach);
        void UpdateCoach(Coach coach);
        void DeleteCoach(Coach coach);
        List<Coach> GetAllCoaches();
    }
}
