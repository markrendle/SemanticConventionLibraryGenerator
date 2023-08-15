namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public static partial class Sql
        {
            public const string Prefix = "db.sql";

            /// <summary>
            /// The name of the primary table that the operation is acting upon, including the database name (if applicable).
            /// </summary>
            /// <remarks>
            /// It is not recommended to attempt any client-side parsing of `db.statement` just to
            /// get this property, but it should be set if it is provided by the library being instrumented.
            /// If the operation is acting upon an anonymous table, or more than one table, this
            /// value MUST NOT be set.
            /// </remarks>
            /// <example>
            /// e.g. <c>public.users</c>, <c>customers</c>
            /// </example>
            public const string Table = $"{Prefix}.table";
        }
    }
}
