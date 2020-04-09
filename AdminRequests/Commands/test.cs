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
            if (caller != null)
            {
                UnturnedPlayer player = (UnturnedPlayer)caller;
                if (command.Length == 0)
                {
                    UnturnedChat.Say(caller, AdminRequests.Instance.Translate("proper_usage"), UnturnedChat.GetColorFromName("Cyan", Color.cyan));
                }
                else
                {
                    UnturnedChat.Say(AdminRequests.Instance.Translate("request_message", player.DisplayName, command[0]), UnturnedChat.GetColorFromName("Cyan", Color.cyan));
                }
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