namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Device
    {
        public const string Prefix = "device";

        /// <summary>
        /// A unique identifier representing the device
        /// </summary>
        /// <remarks>
        /// The device identifier MUST only be defined using the values outlined below. This
        /// value is not an advertising identifier and MUST NOT be used as such. On iOS (Swift
        /// or Objective-C), this value MUST be equal to the [vendor identifier](https://developer.apple.com/documentation/uikit/uidevice/1620059-identifierforvendor).
        /// On Android (Java or Kotlin), this value MUST be equal to the Firebase Installation
        /// ID or a globally unique UUID which is persisted across sessions in your application.
        /// More information can be found [here](https://developer.android.com/training/articles/user-data-ids)
        /// on best practices and exact implementation details. Caution should be taken when
        /// storing personal data or anything which can identify a user. GDPR and data protection
        /// laws may apply, ensure you do your own due diligence.
        /// </remarks>
        /// <example>
        /// e.g. <c>2ab2916d-a51f-4ac8-80ee-45ac31a28092</c>
        /// </example>
        public const string Id = $"{Prefix}.id";

        /// <summary>
        /// The name of the device manufacturer
        /// </summary>
        /// <remarks>
        /// The Android OS provides this field via [Build](https://developer.android.com/reference/android/os/Build#MANUFACTURER).
        /// iOS apps SHOULD hardcode the value `Apple`.
        /// </remarks>
        /// <example>
        /// e.g. <c>Apple</c>, <c>Samsung</c>
        /// </example>
        public const string Manufacturer = $"{Prefix}.manufacturer";
    }
}
