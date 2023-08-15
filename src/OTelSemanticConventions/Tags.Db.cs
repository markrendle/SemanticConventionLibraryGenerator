namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public const string Prefix = "db";

        /// <summary>
        /// An identifier for the database management system (DBMS) product being used. See below for a list of well-known identifiers.
        /// </summary>
        public const string System = $"{Prefix}.system";

        /// <summary>
        /// The connection string used to connect to the database. It is recommended to remove embedded credentials.
        /// </summary>
        public const string ConnectionString = $"{Prefix}.connection_string";

        /// <summary>
        /// Username for accessing the database.
        /// </summary>
        /// <example>
        /// e.g. <c>readonly_user</c>, <c>reporting_user</c>
        /// </example>
        public const string User = $"{Prefix}.user";

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
        public const string Name = $"{Prefix}.name";

        /// <summary>
        /// The database statement being executed.
        /// </summary>
        /// <example>
        /// e.g. <c>SELECT * FROM wuser_table</c>, <c>SET mykey "WuValue"</c>
        /// </example>
        public const string Statement = $"{Prefix}.statement";

        /// <summary>
        /// The name of the operation being executed, e.g. the [MongoDB command name](https://docs.mongodb.com/manual/reference/command/#database-operations) such as `findAndModify`, or the SQL keyword.
        /// </summary>
        /// <remarks>
        /// When setting this to an SQL keyword, it is not recommended to attempt any client-side
        /// parsing of `db.statement` just to get this property, but it should be set if the
        /// operation name is provided by the library being instrumented. If the SQL statement
        /// has an ambiguous operation, or performs more than one operation, this value may be
        /// omitted.
        /// </remarks>
        /// <example>
        /// e.g. <c>findAndModify</c>, <c>HMSET</c>, <c>SELECT</c>
        /// </example>
        public const string Operation = $"{Prefix}.operation";

        /// <summary>
        /// [OSI Transport Layer](https://osi-model.com/transport-layer/) or [Inter-process Communication method](https://en.wikipedia.org/wiki/Inter-process_communication). The value SHOULD be normalized to lowercase.
        /// </summary>
        /// <example>
        /// e.g. <c>tcp</c>, <c>udp</c>
        /// </example>
        public const string Transport = $"{Prefix}.network.transport";

        /// <summary>
        /// [OSI Network Layer](https://osi-model.com/network-layer/) or non-OSI equivalent. The value SHOULD be normalized to lowercase.
        /// </summary>
        /// <example>
        /// e.g. <c>ipv4</c>, <c>ipv6</c>
        /// </example>
        public const string Type = $"{Prefix}.network.type";
    }
}
