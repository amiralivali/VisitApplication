using Microsoft.AspNetCore.SignalR;

namespace Visit.API.Hubs
{
    public class PresenceHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            Console.WriteLine("Connect");
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            Console.WriteLine("disconnect");
            return base.OnDisconnectedAsync(exception);
        }
    }
}
