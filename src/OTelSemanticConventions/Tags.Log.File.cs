namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Log
    {
        public static partial class File
        {
            public const string Prefix = "log.file";

            /// <summary>
            /// The basename of the file.
            /// </summary>
            /// <example>
            /// e.g. <c>audit.log</c>
            /// </example>
            public const string Name = $"{Prefix}.name";

            /// <summary>
            /// The full path to the file.
            /// </summary>
            /// <example>
            /// e.g. <c>/var/log/mysql/audit.log</c>
            /// </example>
            public const string Path = $"{Prefix}.path";

            /// <summary>
            /// The basename of the file, with symlinks resolved.
            /// </summary>
            /// <example>
            /// e.g. <c>uuid.log</c>
            /// </example>
            public const string NameResolved = $"{Prefix}.name_resolved";

            /// <summary>
            /// The full path to the file, with symlinks resolved.
            /// </summary>
            /// <example>
            /// e.g. <c>/var/lib/docker/uuid.log</c>
            /// </example>
            public const string PathResolved = $"{Prefix}.path_resolved";
        }
    }
}
