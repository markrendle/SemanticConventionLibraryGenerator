namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Device
    {
        public static partial class Model
        {
            public const string Prefix = "device.model";

            /// <summary>
            /// The model identifier for the device
            /// </summary>
            /// <remarks>
            /// It's recommended this value represents a machine readable version of the model identifier
            /// rather than the market or consumer-friendly name of the device.
            /// </remarks>
            /// <example>
            /// e.g. <c>iPhone3,4</c>, <c>SM-G920F</c>
            /// </example>
            public const string Identifier = $"{Prefix}.model.identifier";

            /// <summary>
            /// The marketing name for the device model
            /// </summary>
            /// <remarks>
            /// It's recommended this value represents a human readable version of the device model
            /// rather than a machine readable alternative.
            /// </remarks>
            /// <example>
            /// e.g. <c>iPhone 6s Plus</c>, <c>Samsung Galaxy S6</c>
            /// </example>
            public const string Name = $"{Prefix}.model.name";
        }
    }
}
