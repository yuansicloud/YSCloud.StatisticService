using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace YSCloud.StatisticService
{
    [DependsOn(
        typeof(StatisticServiceApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class StatisticServiceHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "StatisticService";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(StatisticServiceApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
