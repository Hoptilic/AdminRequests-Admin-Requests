using System;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.API.Collections;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System.Collections.Generic;

namespace AdminRequests
{
    public class AdminRequests : RocketPlugin
    {
        public static AdminRequests Instance;

        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList()
                {
                    { "request_message","AdminRequests: " },
                    { "proper_usage","Please enter a reason for requesting an admin." },
                };
            }
        }

        protected override void Load()
        {
            Instance = this;

            Logger.Log("AdminRequests by Hoptilic has been loaded!", ConsoleColor.Yellow);
        }

        protected override void Unload()
        {
            Instance = null;

            Logger.Log("AdminRequests by Hoptilic has been unloaded!", ConsoleColor.Yellow);
        }

        public List<UnturnedPlayer> Players()
        {
            List<UnturnedPlayer> list = new List<UnturnedPlayer>();

            foreach (SteamPlayer sp in Provider.clients)
            {
                UnturnedPlayer p = UnturnedPlayer.FromSteamPlayer(sp);
                list.Add(p);
            }

            return list;
        }
    }
}