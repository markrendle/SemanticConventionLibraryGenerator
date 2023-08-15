namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Process
    {
        public static partial class Runtime
        {
            public const string Prefix = "process.runtime";

            /// <summary>
            /// The name of the runtime of this process. For compiled native binaries, this SHOULD be the name of the compiler.
            /// </summary>
            /// <example>
            /// e.g. <c>OpenJDK Runtime Environment</c>
            /// </example>
            public const string Name = $"{Prefix}.name";

            /// <summary>
            /// The version of the runtime of this process, as returned by the runtime without modification.
            /// </summary>
            public const string Version = $"{Prefix}.version";

            /// <summary>
            /// An additional description about the runtime of the process, for example a specific vendor customization of the runtime environment.
            /// </summary>
            public const string Description = $"{Prefix}.description";
        }
    }
}
