using System;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.API.Collections;

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
                    { "request_message","{0} is requesting an admin!" },
                    { "proper_usage","Please enter a reason for requesting an admin." }
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
    }
}