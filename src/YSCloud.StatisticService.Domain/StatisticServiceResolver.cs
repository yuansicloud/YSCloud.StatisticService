using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Volo.Abp.DependencyInjection;

namespace YSCloud.StatisticService
{
    public class StatisticServiceResolver : IStatisticServiceResolver, ISingletonDependency
    {
        protected readonly Dictionary<string, StatisticServiceInfo> Providers = new();

        private readonly IServiceProvider _serviceProvider;

        public StatisticServiceResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Type GetProviderTypeOrDefault(string providerName)
        {
            return Providers.GetOrDefault(providerName).ProviderType;
        }

        public List<StatisticServiceInfo> GetStatisticProviders()
        {
            return Providers.Values.ToList();
        }

        public bool TryRegisterProvider(string providerName, Type providerType, string groupName = null, string mediaResources = null, string color = null)
        {
            if (Providers.ContainsKey(providerName))
            {
                return false;
            }

            using (var scope = _serviceProvider.CreateScope())
            {
                if (scope.ServiceProvider.GetService(providerType) == null)
                {
                    return false;
                }
            }

            Providers.Add(providerName, new StatisticServiceInfo(providerName, providerType, mediaResources, color));

            return true;
        }
    }
}