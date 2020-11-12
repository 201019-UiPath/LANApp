using System;
using LLDB.Models;
using System.Collections.Generic;

namespace LLLib
{
    public interface ITeamService
    {
         void AddTeam(Team team);
         void UpdateTeam(Team team);
         void DeleteTeam(Team team);
         List<Team> GetAllTeams();
    }
}