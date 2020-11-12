using System;
using System.Collections.Generic;
using System.Text;
using LLDB.Models;

namespace LLDB.Repos
{
    interface ITeamRepo
    {
        void AddTeam(Team team);
        void UpdateTeam(Team team);
        void DeleteTeam(Team team);
        List<Team> GetAllTeams();
    }
}
