namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Event
    {
        public const string Prefix = "event";

        /// <summary>
        /// The name identifies the event.
        /// </summary>
        /// <example>
        /// e.g. <c>click</c>, <c>exception</c>
        /// </example>
        public const string Name = $"{Prefix}.name";

        /// <summary>
        /// The domain identifies the business context for the events.
        /// </summary>
        /// <remarks>
        /// Events across different domains may have same `event.name`, yet be unrelated events.
        /// </remarks>
        public const string Domain = $"{Prefix}.domain";
    }
}
