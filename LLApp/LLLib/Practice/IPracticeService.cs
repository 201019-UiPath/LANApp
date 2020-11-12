using System;
using LLDB.Models;
using System.Collections.Generic;

namespace LLLib
{
    public interface IPracticeService
    {
         void AddPractice(Practice practice);
         void UpdatePractice(Practice practice);
         void DeletePractice(Practice practice);
         List<Practice> GetAllPracticesByTeamId(int id);
    }
}