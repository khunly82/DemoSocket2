using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.SignalR;

namespace DemoSocket.Hubs
{
    public class ChatHub : Hub
    {
        public void NewMessage(string message)
        {
            Clients.All.SendAsync("Message", message);
        }
    }
}
