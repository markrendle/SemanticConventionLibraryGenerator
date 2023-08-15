namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Log
    {
        public static partial class Record
        {
            public const string Prefix = "log.record";

            /// <summary>
            /// A unique identifier for the Log Record.
            /// </summary>
            /// <remarks>
            /// If an id is provided, other log records with the same id will be considered duplicates
            /// and can be removed safely. This means, that two distinguishable log records MUST
            /// have different values. The id MAY be an [Universally Unique Lexicographically Sortable
            /// Identifier (ULID)](https://github.com/ulid/spec), but other identifiers (e.g. UUID)
            /// may be used as needed.
            /// </remarks>
            /// <example>
            /// e.g. <c>01ARZ3NDEKTSV4RRFFQ69G5FAV</c>
            /// </example>
            public const string Uid = $"{Prefix}.uid";
        }
    }
}
