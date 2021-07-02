using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace YSCloud.StatisticService.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(StatisticServiceBlazorModule)
        )]
    public class StatisticServiceBlazorServerModule : AbpModule
    {
        
    }
}