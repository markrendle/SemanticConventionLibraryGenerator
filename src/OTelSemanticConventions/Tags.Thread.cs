namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Thread
    {
        public const string Prefix = "thread";

        /// <summary>
        /// Current "managed" thread ID (as opposed to OS thread ID).
        /// </summary>
        public const string Id = $"{Prefix}.id";

        /// <summary>
        /// Current thread name.
        /// </summary>
        public const string Name = $"{Prefix}.name";
    }
}
