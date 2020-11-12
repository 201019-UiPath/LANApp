using System.Collections.Generic;
using LLDB.Models;

namespace LLDB.Repos
{
    public interface IPracticeRepo
    {
        void AddPractice(Practice practice);
         void UpdatePractice(Practice practice);
         void DeletePractice(Practice practice);
         List<Practice> GetAllPracticesByTeamId(int id);
    }
}