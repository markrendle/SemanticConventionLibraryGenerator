namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public static partial class Redis
        {
            public const string Prefix = "db.redis";

            /// <summary>
            /// The index of the database being accessed as used in the [`SELECT` command](https://redis.io/commands/select), provided as an integer. To be used instead of the generic `db.name` attribute.
            /// </summary>
            /// <example>
            /// e.g. <c>0</c>, <c>1</c>, <c>15</c>
            /// </example>
            public const string DatabaseIndex = $"{Prefix}.database_index";

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
