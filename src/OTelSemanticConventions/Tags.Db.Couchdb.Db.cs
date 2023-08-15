namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public static partial class Couchdb
        {
            public static partial class Db
            {
                public const string Prefix = "db.couchdb.db";

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
                public const string Operation = $"{Prefix}.db.operation";
            }
        }
    }
}
