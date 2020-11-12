﻿using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using Microsoft.EntityFrameworkCore;

using LLDB.Models;

namespace LLDB.Repos
{
    public class DBRepo : IChildRepo, IParentRepo, ICoachRepo, ITeamRepo, IPracticeRepo, IGameRepo, IGameParticipantRepo
    {
        private LLContext context;

        public DBRepo(LLContext context)
        {
            this.context = context;
        }

        public void AddChild(Child child)
        {
            context.Children.Add(child);
            context.SaveChanges();
        }

        public void AddCoach(Coach coach)
        {
            context.Coaches.Add(coach);
            context.SaveChanges();
        }

        public void AddGame(Game game)
        {
            context.Games.Add(game);
            context.SaveChanges();
        }

        public void AddGameParticipant(GameParticipant participant)
        {
            context.GameParticipants.Add(participant);
            context.SaveChanges();
        }

        public void AddParent(Parent parent)
        {
            context.Parents.Add(parent);
            context.SaveChanges();
        }

        public void AddPractice(Practice practice)
        {
            context.Practices.Add(practice);
            context.SaveChanges();
        }

        public void AddTeam(Team team)
        {
            context.Teams.Add(team);
            context.SaveChanges();
        }

        public void DeleteChild(Child child)
        {
            context.Children.Remove(child);
            context.SaveChanges();
        }

        public void DeleteCoach(Coach coach)
        {
            context.Coaches.Remove(coach);
            context.SaveChanges();
        }

        public void DeleteGame(Game game)
        {
            context.Games.Remove(game);
            context.SaveChanges();
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
            return context.Children.Select(x => x).ToList();
        }

        public List<Child> GetAllChildrenByTeamId(int id)
        {
            return context.Children.Where(x => x.TeamId == id).ToList();
        }

        public List<Coach> GetAllCoaches()
        {
            return context.Coaches.Select(x => x).ToList();
        }

        public List<GameParticipant> GetAllGameParticipantsByGameId(int id)
        {
            return context.GameParticipants.Where(x => x.GameId == id).ToList();
        }

        public List<Game> GetAllGames()
        {
            return context.Games.Select(x => x).ToList();
        }

        public List<Game> GetAllGamesByTeamId(int id)
        {
            throw new NotImplementedException();
            //return context.Games.Include("GameParticipants").Where(x => x.GameParticipants.GameId == id).ToList();
        }

        public List<Parent> GetAllParents()
        {
            return context.Parents.Select(x => x).ToList();
        }

        public List<Parent> GetAllParentsByChildId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Practice> GetAllPracticesByTeamId(int id)
        {
            return context.Practices.Where(x => x.TeamId == id).ToList();
        }

        public List<Team> GetAllTeams()
        {
            return context.Teams.Select(x => x).ToList();
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
