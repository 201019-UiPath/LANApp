using System.Collections.Generic;
using LLDB.Models;

namespace LLDB.Repos
{
    public interface ITeamRepo
    {
        void AddTeam(Team team);
        void UpdateTeam(Team team);
        void DeleteTeam(Team team);
        List<Team> GetAllTeams();
    }
}