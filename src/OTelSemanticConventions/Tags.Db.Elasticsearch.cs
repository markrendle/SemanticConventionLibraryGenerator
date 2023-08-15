namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Db
    {
        public static partial class Elasticsearch
        {
            public const string Prefix = "db.elasticsearch";

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

            /// <summary>
            /// Absolute URL describing a network resource according to [RFC3986](https://www.rfc-editor.org/rfc/rfc3986)
            /// </summary>
            /// <remarks>
            /// For network calls, URL usually has `scheme://host[:port][path][?query][#fragment]`
            /// format, where the fragment is not transmitted over HTTP, but if it is known, it should
            /// be included nevertheless. `url.full` MUST NOT contain credentials passed via URL
            /// in form of `https://username:password@www.example.com/`. In such case username and
            /// password should be redacted and attribute's value should be `https://REDACTED:REDACTED@www.example.com/`.
            /// `url.full` SHOULD capture the absolute URL when it is available (or can be reconstructed)
            /// and SHOULD NOT be validated or modified except for sanitizing purposes.
            /// </remarks>
            /// <example>
            /// e.g. <c>https://www.foo.bar/search?q=OpenTelemetry#SemConv</c>, <c>//localhost</c>
            /// </example>
            public const string Full = $"{Prefix}.url.full";

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
