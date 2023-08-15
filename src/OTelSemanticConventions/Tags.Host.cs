namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Host
    {
        public const string Prefix = "host";

        /// <summary>
        /// Unique host ID. For Cloud, this must be the instance_id assigned by the cloud provider. For non-containerized systems, this should be the `machine-id`. See the table below for the sources to use to determine the `machine-id` based on operating system.
        /// </summary>
        /// <example>
        /// e.g. <c>fdbf79e8af94cb7f9e8df36789187052</c>
        /// </example>
        public const string Id = $"{Prefix}.id";

        /// <summary>
        /// Name of the host. On Unix systems, it may contain what the hostname command returns, or the fully qualified hostname, or another name specified by the user.
        /// </summary>
        /// <example>
        /// e.g. <c>opentelemetry-test</c>
        /// </example>
        public const string Name = $"{Prefix}.name";

        /// <summary>
        /// Type of host. For Cloud, this must be the machine type.
        /// </summary>
        /// <example>
        /// e.g. <c>n1-standard-1</c>
        /// </example>
        public const string Type = $"{Prefix}.type";

        /// <summary>
        /// The CPU architecture the host system is running on.
        /// </summary>
        public const string Arch = $"{Prefix}.arch";
    }
}
