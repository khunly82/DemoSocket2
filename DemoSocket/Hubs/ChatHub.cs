using Microsoft.AspNetCore.SignalR;

namespace DemoSocket.Hubs
{
    public class ChatHub : Hub
    {
        public void NewMessage(string message)
        {

        }
    }
}
