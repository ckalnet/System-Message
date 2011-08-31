using SignalR.Hubs;

namespace SystemMessage
{
    public class Notification : Hub
    {
        public void Send(string message)
        {
            Clients.addMessage(message);
        }

        public void ApplicationMaintenance()
        {
            Clients.alertApplicationMaintenance();
        }
    }
}