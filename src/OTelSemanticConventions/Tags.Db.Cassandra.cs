namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public static partial class Cassandra
        {
            public const string Prefix = "db.cassandra";

            /// <summary>
            /// The fetch size used for paging, i.e. how many rows will be returned at once.
            /// </summary>
            /// <example>
            /// e.g. <c>5000</c>
            /// </example>
            public const string PageSize = $"{Prefix}.page_size";

            /// <summary>
            /// The consistency level of the query. Based on consistency values from [CQL](https://docs.datastax.com/en/cassandra-oss/3.0/cassandra/dml/dmlConfigConsistency.html).
            /// </summary>
            public const string ConsistencyLevel = $"{Prefix}.consistency_level";

            /// <summary>
            /// The name of the primary table that the operation is acting upon, including the keyspace name (if applicable).
            /// </summary>
            /// <remarks>
            /// This mirrors the db.sql.table attribute but references cassandra rather than sql.
            /// It is not recommended to attempt any client-side parsing of `db.statement` just to
            /// get this property, but it should be set if it is provided by the library being instrumented.
            /// If the operation is acting upon an anonymous table, or more than one table, this
            /// value MUST NOT be set.
            /// </remarks>
            public const string Table = $"{Prefix}.table";

            /// <summary>
            /// Whether or not the query is idempotent.
            /// </summary>
            public const string Idempotence = $"{Prefix}.idempotence";

            /// <summary>
            /// The number of times a query was speculatively executed. Not set or `0` if the query was not executed speculatively.
            /// </summary>
            /// <example>
            /// e.g. <c>0</c>, <c>2</c>
            /// </example>
            public const string SpeculativeExecutionCount = $"{Prefix}.speculative_execution_count";

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
