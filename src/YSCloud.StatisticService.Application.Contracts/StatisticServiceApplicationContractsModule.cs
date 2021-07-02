using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace YSCloud.StatisticService
{
    [DependsOn(
        typeof(StatisticServiceDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class StatisticServiceApplicationContractsModule : AbpModule
    {

    }
}
