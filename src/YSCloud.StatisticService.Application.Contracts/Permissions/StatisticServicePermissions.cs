using Volo.Abp.Reflection;

namespace YSCloud.StatisticService.Permissions
{
    public class StatisticServicePermissions
    {
        public const string GroupName = "StatisticService";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(StatisticServicePermissions));
        }
    }
}