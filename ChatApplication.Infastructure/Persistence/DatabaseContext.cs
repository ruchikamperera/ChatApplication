using Microsoft.EntityFrameworkCore;

namespace ChatApplication.Infastructure.Persistence
{
    public partial class ChatApplicationDbContext : DbContext
    {
        public ChatApplicationDbContext(DbContextOptions<ChatApplicationDbContext> options) : base(options)
        {
            Teams.AddRange(InMemoryData.GetTeams());
            SaveChanges();
            Agents.AddRange(InMemoryData.GetTeamCAgents());
            Agents.AddRange(InMemoryData.GetTeamOverflowAgents());
            Agents.AddRange(InMemoryData.GetTeamAAgents());
            Agents.AddRange(InMemoryData.GetTeamBAgents()); 
            Agents.AddRange(InMemoryData.GetTeamExampleAgents());
            SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ChatApplicationDbContext).Assembly);
        }
    }
}
