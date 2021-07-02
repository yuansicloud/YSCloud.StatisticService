using YSCloud.StatisticService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace YSCloud.StatisticService.Permissions
{
    public class StatisticServicePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(StatisticServicePermissions.GroupName, L("Permission:StatisticService"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<StatisticServiceResource>(name);
        }
    }
}