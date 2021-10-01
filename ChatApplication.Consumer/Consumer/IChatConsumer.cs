using ChatApplication.Domain.Models;

namespace ChatApplication.Consumer
{
    public interface IChatConsumer
    {
        void ConsumeChat(Team team);
    }
}
