namespace ChatApplication.Infastructure.Producer
{
    public interface IChatSender
    {
        void SendChatId(string connectionId);
    }
}
