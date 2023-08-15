namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public static partial class Cassandra
        {
            public static partial class Db
            {
                public const string Prefix = "db.cassandra.db";

                /// <summary>
                /// This attribute is used to report the name of the database being accessed. For commands that switch the database, this should be set to the target database (even if the command fails).
                /// </summary>
                /// <remarks>
                /// In some SQL databases, the database name to be used is called "schema name". In case
                /// there are multiple layers that could be considered for database name (e.g. Oracle
                /// instance name and schema name), the database name to be used is the more specific
                /// layer (e.g. Oracle schema name).
                /// </remarks>
                /// <example>
                /// e.g. <c>customers</c>, <c>main</c>
                /// </example>
                public const string Name = $"{Prefix}.db.name";
            }
        }
    }
}
