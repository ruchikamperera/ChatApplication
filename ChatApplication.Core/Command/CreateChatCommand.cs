using ChatApplication.Domain.Models;
using ChatApplication.Infastructure.Producer;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ChatApplication.Core.Command
{
    public class CreateChatCommand: IRequest<Chat>
    {
        public Chat Chat { get; set; }

        public class CreateChatCommandHandler : IRequestHandler<CreateChatCommand, Chat>
        {
            private readonly IChatSender _chatSender;
            public CreateChatCommandHandler(IChatSender chatSender)
            {
                _chatSender = chatSender;
            }
            public async Task<Chat> Handle(CreateChatCommand request, CancellationToken cancellationToken)
            {
                _chatSender.SendChatId(request.Chat.ConnectionId);
                return request.Chat;
            }
        }
    }
}
