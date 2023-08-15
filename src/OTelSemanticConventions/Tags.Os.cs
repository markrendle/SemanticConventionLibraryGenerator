namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Os
    {
        public const string Prefix = "os";

        /// <summary>
        /// The operating system type.
        /// </summary>
        public const string Type = $"{Prefix}.type";

        /// <summary>
        /// Human readable (not intended to be parsed) OS version information, like e.g. reported by `ver` or `lsb_release -a` commands.
        /// </summary>
        /// <example>
        /// e.g. <c>Microsoft Windows [Version 10.0.18363.778]</c>, <c>Ubuntu 18.04.1 LTS</c>
        /// </example>
        public const string Description = $"{Prefix}.description";

        /// <summary>
        /// Human readable operating system name.
        /// </summary>
        /// <example>
        /// e.g. <c>iOS</c>, <c>Android</c>, <c>Ubuntu</c>
        /// </example>
        public const string Name = $"{Prefix}.name";

        /// <summary>
        /// The version string of the operating system as defined in [Version Attributes](/docs/resource/README.md#version-attributes).
        /// </summary>
        /// <example>
        /// e.g. <c>14.2.1</c>, <c>18.04.1</c>
        /// </example>
        public const string Version = $"{Prefix}.version";
    }
}
