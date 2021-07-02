using System.Threading.Tasks;
using Volo.Abp.Data;
using YSCloud.StatisticService.Dataviews;

namespace YSCloud.StatisticService
{
    public class StatisticServiceProvider : IStatisticServiceProvider
    {
        public virtual Task OnDataviewCancelledAsync(Dataview dataview)
        {
            return Task.CompletedTask;
        }

        public virtual Task OnDataviewStartedAsync(Dataview dataview, ExtraPropertyDictionary configurations)
        {
            return Task.CompletedTask;
        }
    }
}