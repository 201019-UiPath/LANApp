using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using Microsoft.EntityFrameworkCore;

using LLDB.Models;

namespace LLDB.Repos
{
    class DBRepo : IChildRepo, IParentRepo, ICoachRepo, ITeamRepo, IPracticeRepo, IGameRepo, IGameParticipantRepo
    {
        public void AddChild(Child child)
        {
            throw new NotImplementedException();
        }

        public void AddCoach(Coach coach)
        {
            throw new NotImplementedException();
        }

        public void AddGame(Game game)
        {
            throw new NotImplementedException();
        }

        public void AddGameParticipant(GameParticipant participant)
        {
            throw new NotImplementedException();
        }

        public void AddParent(Parent parent)
        {
            throw new NotImplementedException();
        }

        public void AddPractice(Practice practice)
        {
            throw new NotImplementedException();
        }

        public void AddTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public void DeleteChild(Child child)
        {
            throw new NotImplementedException();
        }

        public void DeleteCoach(Coach coach)
        {
            throw new NotImplementedException();
        }

        public void DeleteGame(Game game)
        {
            throw new NotImplementedException();
        }

        public void DeleteGameParticipant(GameParticipant participant)
        {
            throw new NotImplementedException();
        }

        public void DeleteParent(Parent parent)
        {
            throw new NotImplementedException();
        }

        public void DeletePractice(Practice practice)
        {
            throw new NotImplementedException();
        }

        public void DeleteTeam(Team team)
        {
            throw new NotImplementedException();
        }

        public List<Child> GetAllChildren()
        {
            throw new NotImplementedException();
        }

        public List<Child> GetAllChildrenByTeamId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Coach> GetAllCoaches()
        {
            throw new NotImplementedException();
        }

        public List<GameParticipant> GetAllGameParticipantsByGameId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetAllGames()
        {
            throw new NotImplementedException();
        }

        public List<Game> GetAllGamesByTeamId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Parent> GetAllParents()
        {
            throw new NotImplementedException();
        }

        public List<Parent> GetAllParentsByChildId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Practice> GetAllPracticesByTeamId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetAllTeams()
        {
            throw new NotImplementedException();
        }

        public Child GetChildByTeamId(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateChild(Child child)
        {
            throw new NotImplementedException();
        }

        public void UpdateCoach(Coach coach)
        {
            throw new NotImplementedException();
        }

        public void UpdateGame(Game game)
        {
            throw new NotImplementedException();
        }

        public void UpdateGameParticipant(GameParticipant participant)
        {
            throw new NotImplementedException();
        }

        public void UpdateParent(Parent parent)
        {
            throw new NotImplementedException();
        }

        public void UpdatePractice(Practice practice)
        {
            throw new NotImplementedException();
        }

        public void UpdateTeam(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
