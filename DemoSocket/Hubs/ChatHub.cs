using DemoSocket.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.SignalR;

namespace DemoSocket.Hubs
{
    public class ChatHub : Hub
    {
        public void NewMessage(NewMessageDTO message)
        {
            Clients.All.SendAsync("Message", new MessageDTO
            {
                Author = message.Author,
                Content = message.Content,
                Date = DateTime.Now,
            });
        }
    }
}
