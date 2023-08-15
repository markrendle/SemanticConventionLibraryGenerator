namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Http
    {
        public static partial class UserAgent
        {
            public const string Prefix = "http.user_agent";

            /// <summary>
            /// Value of the [HTTP User-Agent](https://www.rfc-editor.org/rfc/rfc9110.html#field.user-agent) header sent by the client.
            /// </summary>
            /// <example>
            /// e.g. <c>CERN-LineMode/2.15 libwww/2.17b3</c>
            /// </example>
            public const string Original = $"{Prefix}.user_agent.original";
        }
    }
}
