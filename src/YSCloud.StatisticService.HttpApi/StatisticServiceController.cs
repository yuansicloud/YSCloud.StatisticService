using YSCloud.StatisticService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace YSCloud.StatisticService
{
    public abstract class StatisticServiceController : AbpController
    {
        protected StatisticServiceController()
        {
            LocalizationResource = typeof(StatisticServiceResource);
        }
    }
}
