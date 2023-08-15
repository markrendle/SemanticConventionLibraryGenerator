namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class FeatureFlag
    {
        public const string Prefix = "feature_flag";

        /// <summary>
        /// The unique identifier of the feature flag.
        /// </summary>
        /// <example>
        /// e.g. <c>logo-color</c>
        /// </example>
        public const string Key = $"{Prefix}.key";

        /// <summary>
        /// The name of the service provider that performs the flag evaluation.
        /// </summary>
        /// <example>
        /// e.g. <c>Flag Manager</c>
        /// </example>
        public const string ProviderName = $"{Prefix}.provider_name";

        /// <summary>
        /// SHOULD be a semantic identifier for a value. If one is unavailable, a stringified version of the value can be used.
        /// </summary>
        /// <remarks>
        /// A semantic identifier, commonly referred to as a variant, provides a means for referring
        /// to a value without including the value itself. This can provide additional context
        /// for understanding the meaning behind a value. For example, the variant `red` maybe
        /// be used for the value `#c05543`. A stringified version of the value can be used in
        /// situations where a semantic identifier is unavailable. String representation of the
        /// value should be determined by the implementer.
        /// </remarks>
        /// <example>
        /// e.g. <c>red</c>, <c>true</c>, <c>on</c>
        /// </example>
        public const string Variant = $"{Prefix}.variant";
    }
}
