using ChatApplication.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatApplication.Infastructure.Persistence
{
    public partial class ChatApplicationDbContext : DbContext
    {
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<AgentChat> AgentChats { get; set; }
    }
}
