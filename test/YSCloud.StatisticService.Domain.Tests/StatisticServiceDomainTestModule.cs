using YSCloud.StatisticService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace YSCloud.StatisticService
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(StatisticServiceEntityFrameworkCoreTestModule)
        )]
    public class StatisticServiceDomainTestModule : AbpModule
    {
        
    }
}
