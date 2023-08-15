namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Log
    {
        public const string Prefix = "log";

        /// <summary>
        /// The stream associated with the log. See below for a list of well-known values.
        /// </summary>
        public const string Iostream = $"{Prefix}.iostream";
    }
}
