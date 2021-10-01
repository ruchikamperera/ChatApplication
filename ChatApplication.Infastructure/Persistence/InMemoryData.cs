using ChatApplication.Domain.Constant;
using ChatApplication.Domain.Enums;
using ChatApplication.Domain.Models;
using System.Collections.Generic;

namespace ChatApplication.Infastructure.Persistence
{
    public static class InMemoryData
    {
        public static List<Team> GetTeams()
        {
            return new List<Team>
            {
                new Team
                {
                    Id = 1,
                    TeamName = "Team-A"
                },
                new Team
                {
                    Id = 2,
                    TeamName = "Team-B"
                },
                new Team
                {
                    Id = 3,
                    TeamName = "Team-C"
                },
                new Team
                {
                    Id = 4,
                    TeamName = "Team-Overflow"
                },
                new Team
                {
                    Id = 5,
                    TeamName = "Team-Example"
                }
            };
        }

        public static List<Agent> GetTeamAAgents()
        {
            return new List<Agent>
            {
                new Agent
                {
                   Id = 1,
                   Seniority = Seniority.Lead,
                   WorkShift = WorkShift.Day,
                   TeamId = 1
                },
                new Agent
                {
                   Id = 2,
                   Seniority = Seniority.Mid,
                   WorkShift = WorkShift.Day,
                   TeamId = 1
                },
                new Agent
                {
                   Id = 3,
                   Seniority = Seniority.Mid,
                   WorkShift = WorkShift.Day,
                   TeamId = 1
                },
                new Agent
                {
                   Id = 4,
                   Seniority = Seniority.Junior,
                   WorkShift = WorkShift.Day,
                   TeamId = 1
                },

            };
        }

        public static List<Agent> GetTeamBAgents()
        {
            return new List<Agent>
            {
                new Agent
                {
                   Id = 5,
                   Seniority = Seniority.Lead,
                   WorkShift = WorkShift.Day,
                   TeamId = 2
                },
                new Agent
                {
                   Id = 6,
                   Seniority = Seniority.Mid,
                   WorkShift = WorkShift.Day,
                   TeamId = 2
                },
                new Agent
                {
                   Id = 7,
                   Seniority = Seniority.Junior,
                   WorkShift = WorkShift.Day,
                   TeamId = 2
                },
                new Agent
                {
                   Id = 8,
                   Seniority = Seniority.Junior,
                   WorkShift = WorkShift.Day,
                   TeamId = 2
                },

            };
        }

        public static List<Agent> GetTeamCAgents()
        {
            return new List<Agent>
            {
                new Agent
                {
                   Id = 9,
                   Seniority = Seniority.Mid,
                   WorkShift = WorkShift.Night,
                   TeamId = 3
                },
                new Agent
                {
                   Id = 10,
                   Seniority = Seniority.Mid,
                   WorkShift = WorkShift.Night,
                   TeamId = 3
                },
            };
        }

        public static List<Agent> GetTeamOverflowAgents()
        {
            return new List<Agent>
            {
                new Agent
                {
                   Id = 11,
                   Seniority = Seniority.Junior,
                   WorkShift = WorkShift.Day,
                   TeamId = 4
                },
                new Agent
                {
                   Id = 12,
                   Seniority = Seniority.Junior,
                   WorkShift = WorkShift.Day,
                   TeamId = 4
                },
                 new Agent
                {
                   Id = 13,
                   Seniority = Seniority.Junior,
                   WorkShift = WorkShift.Day,
                   TeamId = 4
                },
                  new Agent
                {
                   Id = 14,
                   Seniority = Seniority.Junior,
                   WorkShift = WorkShift.Day,
                   TeamId = 4
                },
                   new Agent
                {
                   Id = 15,
                   Seniority = Seniority.Junior,
                   WorkShift = WorkShift.Day,
                   TeamId = 4
                },
                    new Agent
                {
                   Id = 16,
                   Seniority = Seniority.Junior,
                   WorkShift = WorkShift.Day,
                   TeamId = 4
                },
            };
        }

        public static List<Agent> GetTeamExampleAgents()
        {
            return new List<Agent>
            {
                new Agent
                {
                   Id = 17,
                   Seniority = Seniority.Senior,
                   WorkShift= WorkShift.Day,
                   TeamId = 5
                },
                new Agent
                {
                   Id = 18,
                   Seniority = Seniority.Junior,
                   WorkShift = WorkShift.Day,
                   TeamId = 5
                }
            };
        }
    }
}
