using ChatApplication.Consumer.Helpers;
using ChatApplication.Domain.Models;
using ChatApplication.Infastructure.Persistence;
using Microsoft.AspNetCore.SignalR.Client;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApplication.Consumer.Services
{
    public class AgentService : IAgentService
    {
        private readonly ChatApplicationDbContext _context;

        public AgentService(ChatApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AssignChat(Team team, string connectionId)
        {   
            var agents = team.Agents.Where(x => x.AgentChats.Count < 10).ToList();

            var selectedAgent = agents.SelectAvailableAgent();
            selectedAgent.AgentChats.Add(new AgentChat { ConnectionId = connectionId });

            var result = await _context.SaveChangesAsync();

            var connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:5001/chatHub")
                .Build();
            await connection.StartAsync();

            await connection.InvokeAsync("JoinGroup", connectionId, selectedAgent.Id.ToString());

            return true;
        }
    }
}
