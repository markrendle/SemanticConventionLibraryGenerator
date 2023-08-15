namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class K8s
    {
        public static partial class Container
        {
            public const string Prefix = "k8s.container";

            /// <summary>
            /// The name of the Container from Pod specification, must be unique within a Pod. Container runtime usually uses different globally unique name (`container.name`).
            /// </summary>
            /// <example>
            /// e.g. <c>redis</c>
            /// </example>
            public const string Name = $"{Prefix}.name";

            /// <summary>
            /// Number of times the container was restarted. This attribute can be used to identify a particular container (running or stopped) within a container spec.
            /// </summary>
            /// <example>
            /// e.g. <c>0</c>, <c>2</c>
            /// </example>
            public const string RestartCount = $"{Prefix}.restart_count";
        }
    }
}
