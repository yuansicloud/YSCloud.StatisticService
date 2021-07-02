using System;
using System.Collections.Generic;
using System.Text;

namespace YSCloud.StatisticService
{
    public interface IStatisticServiceResolver
    {
        bool TryRegisterProvider(string providerName, Type providerType, string groupName = null, string mediaResources = null, string color = null);

        List<StatisticServiceInfo> GetStatisticProviders();

        Type GetProviderTypeOrDefault(string providerName);
    }
}
