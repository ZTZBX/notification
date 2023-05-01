using System;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace notification.Client
{
    public class ClientMain : BaseScript
    {
        public ClientMain()
        {
            Exports.Add("send", new Action<string, string, string>(NotificationNui));
            EventHandlers["sendNotification"] += new Action<string, string, string>(NotificationNui);
        }
        static public void NotificationNui(string title, string sender, string message)
        {
            string jsonString = "{\"showNot\": true, \"title\": \"" + title + "\", \"sender\": \"" + sender + "\", \"message\": \"" + message + "\" }";
            SetNuiFocus(false, false);
            SendNuiMessage(jsonString);
        }

    }
}