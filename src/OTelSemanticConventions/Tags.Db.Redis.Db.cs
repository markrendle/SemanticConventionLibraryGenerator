namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public static partial class Redis
        {
            public static partial class Db
            {
                public const string Prefix = "db.redis.db";

                /// <summary>
                /// The database statement being executed.
                /// </summary>
                /// <example>
                /// e.g. <c>SELECT * FROM wuser_table</c>, <c>SET mykey "WuValue"</c>
                /// </example>
                public const string Statement = $"{Prefix}.db.statement";
            }
        }
    }
}
