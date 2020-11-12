using System.Collections.Generic;
using LLDB.Models;
using LLDB.Repos;

namespace LLLib
{
    public class CoachService : ICoachService
    {
        private ICoachRepo repo;

        public CoachService(ICoachRepo repo) {
            this.repo = repo;
        }

        public void AddCoach(Coach coach)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCoach(Coach coach)
        {
            repo.UpdateCoach(coach);
        }

        public void DeleteCoach(Coach coach)
        {
            repo.DeleteCoach(coach);
        }

        public List<Coach> GetAllCoaches()
        {
            List<Coach> coaches = repo.GetAllCoaches();
            return coaches;
        }
    }
}