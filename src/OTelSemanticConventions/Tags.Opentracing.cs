namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Opentracing
    {
        public const string Prefix = "opentracing";

        /// <summary>
        /// Parent-child Reference type
        /// </summary>
        /// <remarks>
        /// The causal relationship between a child Span and a parent Span.
        /// </remarks>
        public const string RefType = $"{Prefix}.ref_type";
    }
}
