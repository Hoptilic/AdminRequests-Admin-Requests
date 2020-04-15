using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System.Collections.Generic;
using UnityEngine;

namespace AdminRequests.Commands
{
    public class AdminRequestsCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller
        {
            get { return AllowedCaller.Player; }
        }

        public string Name
        {
            get { return "arequest"; }
        }

        public string Help
        {
            get { return "Need help? Use this command to request for an administrator"; }
        }

        public string Syntax
        {
            get { return "<player>"; }
        }

        public List<string> Aliases
        {
            get { return new List<string>(); }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;

            string message = string.Join(" ", command);

            if (command.Length == 0)
            {
                UnturnedChat.Say(caller, AdminRequests.Instance.Translate("proper_usage"), UnturnedChat.GetColorFromName("Cyan", Color.cyan));
            }
            else
            {
                foreach (UnturnedPlayer admin in AdminRequests.Instance.Players())
                {
                    if (admin.IsAdmin || admin.HasPermission("arequest.receive"))
                    {
                        UnturnedChat.Say(admin, AdminRequests.Instance.Translate("request_message") + player.CharacterName + " " + "is requesting an admin with message: " + message, UnturnedChat.GetColorFromName("Cyan", Color.cyan));
                    };
                }
                UnturnedChat.Say(player, "Your message was sent to the admins successfully. Please wait for the admins to respond.", UnturnedChat.GetColorFromName("Cyan", Color.cyan));
                
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>
                {
                    "arequest"
                };
            }
        }
    }
}