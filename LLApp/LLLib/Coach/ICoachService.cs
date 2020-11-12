using System.Collections.Generic;
using LLDB.Models;

namespace LLLib
{
    public interface ICoachService
    {
        void AddCoach(Coach coach);
        void UpdateCoach(Coach coach);
        void DeleteCoach(Coach coach);
        List<Coach> GetAllCoaches();
    }
}