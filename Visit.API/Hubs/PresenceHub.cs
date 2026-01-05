using Microsoft.AspNetCore.SignalR;

namespace Visit.API.Hubs
{
    public class PresenceHub : Hub
    {

        private static Dictionary<string, int> OnlineDoctors = new Dictionary<string, int>();

        public async Task DoctorOnline(int doctorId)
        {
            OnlineDoctors[Context.ConnectionId] = doctorId;
            await Clients.All.SendAsync("UpdateOnlineDoctors", OnlineDoctors.Values.Distinct().ToList());
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            if (OnlineDoctors.ContainsKey(Context.ConnectionId))
            {
                OnlineDoctors.Remove(Context.ConnectionId);
                await Clients.All.SendAsync("UpdateOnlineDoctors", OnlineDoctors.Values.Distinct().ToList());
            }

            await base.OnDisconnectedAsync(exception);
        }

        public async Task DoctorOffline(int doctorId)
        {
            var item = OnlineDoctors.FirstOrDefault(x => x.Value == doctorId);
            if (!string.IsNullOrEmpty(item.Key))
            {
                OnlineDoctors.Remove(item.Key);
                await Clients.All.SendAsync("UpdateOnlineDoctors", OnlineDoctors.Values.Distinct().ToList());
            }
        }
        
    }
}
