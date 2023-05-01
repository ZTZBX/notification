using System;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace notification.Server
{
    public class ServerMain : BaseScript
    {
        public ServerMain()
        {
            Exports.Add("send", new Action<string, string, string, string>(SendNuiNotification));
        }

         public void SendNuiNotification(string username, string title, string sender, string message)
         {
            string playerHandle = Exports["core-ztzbx"].getPlayerNetworkIdFromUsername(username);  
            TriggerClientEvent(playerHandle, "sendNotification", title, sender, message);
         }
    }
}