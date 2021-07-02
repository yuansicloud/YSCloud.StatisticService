using Localization.Resources.AbpUi;
using YSCloud.StatisticService.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace YSCloud.StatisticService
{
    [DependsOn(
        typeof(StatisticServiceApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class StatisticServiceHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(StatisticServiceHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<StatisticServiceResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
