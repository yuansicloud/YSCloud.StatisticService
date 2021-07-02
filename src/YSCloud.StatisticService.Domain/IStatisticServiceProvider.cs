using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using YSCloud.StatisticService.Dataviews;

namespace YSCloud.StatisticService
{
    public interface IStatisticServiceProvider
    {
        Task OnDataviewStartedAsync(Dataview dataview, ExtraPropertyDictionary configurations);

        Task OnDataviewCancelledAsync(Dataview dataview);
    }
}
