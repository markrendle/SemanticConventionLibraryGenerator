namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Process
    {
        public static partial class Executable
        {
            public const string Prefix = "process.executable";

            /// <summary>
            /// The name of the process executable. On Linux based systems, can be set to the `Name` in `proc/[pid]/status`. On Windows, can be set to the base name of `GetProcessImageFileNameW`.
            /// </summary>
            /// <example>
            /// e.g. <c>otelcol</c>
            /// </example>
            public const string Name = $"{Prefix}.executable.name";

            /// <summary>
            /// The full path to the process executable. On Linux based systems, can be set to the target of `proc/[pid]/exe`. On Windows, can be set to the result of `GetProcessImageFileNameW`.
            /// </summary>
            /// <example>
            /// e.g. <c>/usr/bin/cmd/otelcol</c>
            /// </example>
            public const string Path = $"{Prefix}.executable.path";
        }
    }
}
