using Rocket.API;
using System;

namespace AdminRequests
{
    public class Configuration : IRocketPluginConfiguration
    {
        public string RequestMessageColor;

        public void LoadDefaults()
        {
            RequestMessageColor = "Cyan";
        }
    }
}
