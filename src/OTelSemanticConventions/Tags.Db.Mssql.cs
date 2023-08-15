namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public static partial class Mssql
        {
            public const string Prefix = "db.mssql";

            /// <summary>
            /// The Microsoft SQL Server [instance name](https://docs.microsoft.com/en-us/sql/connect/jdbc/building-the-connection-url?view=sql-server-ver15) connecting to. This name is used to determine the port of a named instance.
            /// </summary>
            /// <remarks>
            /// If setting a `db.mssql.instance_name`, `server.port` is no longer required (but still
            /// recommended if non-standard).
            /// </remarks>
            public const string InstanceName = $"{Prefix}.instance_name";
        }
    }
}
