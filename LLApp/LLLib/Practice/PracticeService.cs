using System;
using LLDB.Models;
using LLDB.Repos;
using System.Collections.Generic;

namespace LLLib
{
    public class PracticeService : IPracticeService
    {
        private IPracticeRepo repo;

        public PracticeService(IPracticeRepo repo) {
            this.repo = repo;
        }

        public void AddPractice(Practice practice) {
            repo.AddPractice(practice);
        }

        public void UpdatePractice(Practice practice) {
             repo.UpdatePractice(practice);
         }

         public void DeletePractice(Practice practice) {
             repo.DeletePractice(practice);
         }

         public List<Practice> GetAllPracticesByTeamId(int id) {
             List<Practice> practice = repo.GetAllPracticesByTeamId();
             return practice;
         }
        
    }
}