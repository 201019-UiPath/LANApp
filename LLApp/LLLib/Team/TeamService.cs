using System;
using LLDB.Models;
using System.Collections.Generic;

namespace LLLib
{
    public class TeamService
    {
        private ITeamRepo repo;

        public ParentService(ITeamRepo repo) {
            this.repo = repo;
        }

        public void AddTeam(Team team) {
            repo.AddTeam(team);
        }

        public void UpdateTeam(Team team) {
             repo.UpdateTeam(team);
         }

         public void DeleteTeam(Team team) {
             repo.DeleteTeam(team);
         }

         public List<Team> GetAllTeams() {
             List<Team> team = repo.GetAllTeams();
             return team;
         }
    }
}