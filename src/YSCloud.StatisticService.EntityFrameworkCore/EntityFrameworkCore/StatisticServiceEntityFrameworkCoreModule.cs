using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace YSCloud.StatisticService.EntityFrameworkCore
{
    [DependsOn(
        typeof(StatisticServiceDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class StatisticServiceEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<StatisticServiceDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}