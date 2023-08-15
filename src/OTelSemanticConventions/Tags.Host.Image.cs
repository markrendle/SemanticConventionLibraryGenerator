namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Host
    {
        public static partial class Image
        {
            public const string Prefix = "host.image";

            /// <summary>
            /// Name of the VM image or OS install the host was instantiated from.
            /// </summary>
            /// <example>
            /// e.g. <c>infra-ami-eks-worker-node-7d4ec78312</c>, <c>CentOS-8-x86_64-1905</c>
            /// </example>
            public const string Name = $"{Prefix}.image.name";

            /// <summary>
            /// VM image ID or host OS image ID. For Cloud, this value is from the provider.
            /// </summary>
            /// <example>
            /// e.g. <c>ami-07b06b442921831e5</c>
            /// </example>
            public const string Id = $"{Prefix}.image.id";

            /// <summary>
            /// The version string of the VM image or host OS as defined in [Version Attributes](README.md#version-attributes).
            /// </summary>
            /// <example>
            /// e.g. <c>0.1</c>
            /// </example>
            public const string Version = $"{Prefix}.image.version";
        }
    }
}
