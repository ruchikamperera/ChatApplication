using ChatApplication.Domain.Models;
using System.Threading.Tasks;

namespace ChatApplication.Consumer.Services
{
    public interface IAgentService
    {
        Task<bool> AssignChat(Team team, string connectionId);
    }
}
