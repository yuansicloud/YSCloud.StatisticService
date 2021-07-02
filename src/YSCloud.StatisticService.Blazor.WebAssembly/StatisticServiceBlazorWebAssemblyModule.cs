using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace YSCloud.StatisticService.Blazor.WebAssembly
{
    [DependsOn(
        typeof(StatisticServiceBlazorModule),
        typeof(StatisticServiceHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class StatisticServiceBlazorWebAssemblyModule : AbpModule
    {
        
    }
}