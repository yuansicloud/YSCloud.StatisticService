using YSCloud.StatisticService.Localization;
using Volo.Abp.Application.Services;

namespace YSCloud.StatisticService
{
    public abstract class StatisticServiceAppService : ApplicationService
    {
        protected StatisticServiceAppService()
        {
            LocalizationResource = typeof(StatisticServiceResource);
            ObjectMapperContext = typeof(StatisticServiceApplicationModule);
        }
    }
}
