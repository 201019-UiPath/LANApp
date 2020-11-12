namespace LLLib
{
    public class CoachService : ICoachService
    {
        private ICoahcRepo repo;

        public CoachService(ICoahcRepo repo) {
            this.repo = repo;
        }

        public void AddCoach(Coach coach) {}

        public void UpdateCoach(Coach coach) {}

        public void DeleteCoach(Coach coach) {}

        public List<Coach> GetAllCoaches() {}
        
    }
}