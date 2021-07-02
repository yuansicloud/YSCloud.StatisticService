using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;

namespace YSCloud.StatisticService.Dataviews
{
    public interface IDataview : IHasExtraProperties
    {
        public string ProviderName { get; }


    }
}
