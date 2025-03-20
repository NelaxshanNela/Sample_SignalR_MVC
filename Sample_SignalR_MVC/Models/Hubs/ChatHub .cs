using Microsoft.AspNetCore.SignalR;

namespace Sample_SignalR_MVC.Models.Hubs
{
    public class ChatHub : Hub
    {
        // Method that clients can call to send messages
        public async Task SendMessage(string user, string message)
        {
            // Sends message to all connected clients
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
