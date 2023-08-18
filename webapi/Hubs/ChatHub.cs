using Microsoft.AspNetCore.SignalR;
using webapi.Hubs.Clients;

namespace webapi.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
    }
}
