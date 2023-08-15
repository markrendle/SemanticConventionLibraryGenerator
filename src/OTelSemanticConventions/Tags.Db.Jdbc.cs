namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public static partial class Jdbc
        {
            public const string Prefix = "db.jdbc";

            /// <summary>
            /// The fully-qualified class name of the [Java Database Connectivity (JDBC)](https://docs.oracle.com/javase/8/docs/technotes/guides/jdbc/) driver used to connect.
            /// </summary>
            /// <example>
            /// e.g. <c>org.postgresql.Driver</c>, <c>com.microsoft.sqlserver.jdbc.SQLServerDriver</c>
            /// </example>
            public const string DriverClassname = $"{Prefix}.jdbc.driver_classname";
        }
    }
}
