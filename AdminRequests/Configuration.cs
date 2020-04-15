using Rocket.API;
using System;

namespace AdminRequests
{
    public class Configuration : IRocketPluginConfiguration
    {
        public string RequestMessageColor;
        public static Configuration Instance;

        public void LoadDefaults()
        {
            RequestMessageColor = "Cyan";
        }
    }
}
