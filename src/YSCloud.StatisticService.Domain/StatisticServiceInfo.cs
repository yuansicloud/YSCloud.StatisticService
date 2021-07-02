using System;
using System.Collections.Generic;
using System.Text;

namespace YSCloud.StatisticService
{
    public class StatisticServiceInfo
    {
        public Type ProviderType { get; }

        public string ProviderName { get; }

        public string MediaResources { get;}

        public string Color { get; }

        public StatisticServiceInfo(string providerName, Type providerType, string mediaResources = null, string color = null)
        {
            ProviderType = providerType;

            ProviderName = providerName;

            MediaResources = mediaResources;

            Color = color;
        }
    }
}
