// using System;
// using LLDB.Models;
// using System.Collections.Generic;

// namespace LLLib
// {
//     public class PracticeService
//     {
//         private IPracticeRepo repo;

//         public ParentService(IPracticeRepo repo) {
//             this.repo = repo;
//         }

//         public void AddPractice(Practice practice) {
//             repo.AddPractice(practice);
//         }

//         public void UpdatePractice(Practice practice) {
//              repo.UpdatePractice(practice);
//          }

//          public void DeletePractice(Practice practice) {
//              repo.DeletePractice(practice);
//          }

//          public List<Practice> GetAllPracticesByTeamId() {
//              List<Practice> practice = repo.GetAllPracticesByTeamId();
//              return practice;
//          }
        
//     }
// }