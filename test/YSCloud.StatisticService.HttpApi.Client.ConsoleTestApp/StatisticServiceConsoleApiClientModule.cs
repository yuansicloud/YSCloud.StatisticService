using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace YSCloud.StatisticService
{
    [DependsOn(
        typeof(StatisticServiceHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class StatisticServiceConsoleApiClientModule : AbpModule
    {
        
    }
}
