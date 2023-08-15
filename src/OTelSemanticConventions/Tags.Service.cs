namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Service
    {
        public const string Prefix = "service";

        /// <summary>
        /// Logical name of the service.
        /// </summary>
        /// <remarks>
        /// MUST be the same for all instances of horizontally scaled services. If the value
        /// was not specified, SDKs MUST fallback to `unknown_service:` concatenated with [`process.executable.name`](process.md#process),
        /// e.g. `unknown_service:bash`. If `process.executable.name` is not available, the value
        /// MUST be set to `unknown_service`.
        /// </remarks>
        /// <example>
        /// e.g. <c>shoppingcart</c>
        /// </example>
        public const string Name = $"{Prefix}.name";

        /// <summary>
        /// The version string of the service API or implementation. The format is not defined by these conventions.
        /// </summary>
        /// <example>
        /// e.g. <c>2.0.0</c>, <c>a01dbef8a</c>
        /// </example>
        public const string Version = $"{Prefix}.version";

        /// <summary>
        /// A namespace for `service.name`.
        /// </summary>
        /// <remarks>
        /// A string value having a meaning that helps to distinguish a group of services, for
        /// example the team name that owns a group of services. `service.name` is expected to
        /// be unique within the same namespace. If `service.namespace` is not specified in the
        /// Resource then `service.name` is expected to be unique for all services that have
        /// no explicit namespace defined (so the empty/unspecified namespace is simply one more
        /// valid namespace). Zero-length namespace string is assumed equal to unspecified namespace.
        /// </remarks>
        /// <example>
        /// e.g. <c>Shop</c>
        /// </example>
        public const string Namespace = $"{Prefix}.namespace";
    }
}
