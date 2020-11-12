using System;
using System.Collections.Generic;
using System.Text;

using LLDB.Models;

namespace LLDB.Repos
{
    interface IPracticeRepo
    {
        void AddPractice(Practice practice);
        void UpdatePractice(Practice practice);
        void DeletePractice(Practice practice);
        List<Practice> GetAllPracticesByTeamId(int id);
    }
}
