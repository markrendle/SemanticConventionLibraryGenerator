namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Container
    {
        public const string Prefix = "container";

        /// <summary>
        /// Container name used by container runtime.
        /// </summary>
        /// <example>
        /// e.g. <c>opentelemetry-autoconf</c>
        /// </example>
        public const string Name = $"{Prefix}.name";

        /// <summary>
        /// Container ID. Usually a UUID, as for example used to [identify Docker containers](https://docs.docker.com/engine/reference/run/#container-identification). The UUID might be abbreviated.
        /// </summary>
        /// <example>
        /// e.g. <c>a3bf90e006b2</c>
        /// </example>
        public const string Id = $"{Prefix}.id";

        /// <summary>
        /// The container runtime managing this container.
        /// </summary>
        /// <example>
        /// e.g. <c>docker</c>, <c>containerd</c>, <c>rkt</c>
        /// </example>
        public const string Runtime = $"{Prefix}.runtime";

        /// <summary>
        /// The command used to run the container (i.e. the command name).
        /// </summary>
        /// <remarks>
        /// If using embedded credentials or sensitive data, it is recommended to remove them
        /// to prevent potential leakage.
        /// </remarks>
        /// <example>
        /// e.g. <c>otelcontribcol</c>
        /// </example>
        public const string Command = $"{Prefix}.command";

        /// <summary>
        /// The full command run by the container as a single string representing the full command. [2]
        /// </summary>
        /// <example>
        /// e.g. <c>otelcontribcol --config config.yaml</c>
        /// </example>
        public const string CommandLine = $"{Prefix}.command_line";

        /// <summary>
        /// All the command arguments (including the command/executable itself) run by the container. [2]
        /// </summary>
        /// <example>
        /// e.g. <c>otelcontribcol, --config, config.yaml</c>
        /// </example>
        public const string CommandArgs = $"{Prefix}.command_args";
    }
}
