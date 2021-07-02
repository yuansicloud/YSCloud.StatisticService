namespace YSCloud.StatisticService
{
    public static class StatisticServiceDbProperties
    {
        public static string DbTablePrefix { get; set; } = "StatisticService";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "StatisticService";
    }
}
