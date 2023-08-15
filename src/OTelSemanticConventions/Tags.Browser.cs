namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Browser
    {
        public const string Prefix = "browser";

        /// <summary>
        /// Array of brand name and version separated by a space
        /// </summary>
        /// <remarks>
        /// This value is intended to be taken from the [UA client hints API](https://wicg.github.io/ua-client-hints/#interface)
        /// (`navigator.userAgentData.brands`).
        /// </remarks>
        /// <example>
        /// e.g. <c>Not A;Brand 99</c>, <c>Chromium 99</c>, <c>Chrome 99</c>
        /// </example>
        public const string Brands = $"{Prefix}.brands";

        /// <summary>
        /// The platform on which the browser is running
        /// </summary>
        /// <remarks>
        /// This value is intended to be taken from the [UA client hints API](https://wicg.github.io/ua-client-hints/#interface)
        /// (`navigator.userAgentData.platform`). If unavailable, the legacy `navigator.platform`
        /// API SHOULD NOT be used instead and this attribute SHOULD be left unset in order for
        /// the values to be consistent. The list of possible values is defined in the [W3C User-Agent
        /// Client Hints specification](https://wicg.github.io/ua-client-hints/#sec-ch-ua-platform).
        /// Note that some (but not all) of these values can overlap with values in the [`os.type`
        /// and `os.name` attributes](./os.md). However, for consistency, the values in the `browser.platform`
        /// attribute should capture the exact value that the user agent provides.
        /// </remarks>
        /// <example>
        /// e.g. <c>Windows</c>, <c>macOS</c>, <c>Android</c>
        /// </example>
        public const string Platform = $"{Prefix}.platform";

        /// <summary>
        /// A boolean that is true if the browser is running on a mobile device
        /// </summary>
        /// <remarks>
        /// This value is intended to be taken from the [UA client hints API](https://wicg.github.io/ua-client-hints/#interface)
        /// (`navigator.userAgentData.mobile`). If unavailable, this attribute SHOULD be left
        /// unset.
        /// </remarks>
        public const string Mobile = $"{Prefix}.mobile";

        /// <summary>
        /// Preferred language of the user using the browser
        /// </summary>
        /// <remarks>
        /// This value is intended to be taken from the Navigator API `navigator.language`.
        /// </remarks>
        /// <example>
        /// e.g. <c>en</c>, <c>en-US</c>, <c>fr</c>, <c>fr-FR</c>
        /// </example>
        public const string Language = $"{Prefix}.language";

        /// <summary>
        /// Value of the [HTTP User-Agent](https://www.rfc-editor.org/rfc/rfc9110.html#field.user-agent) header sent by the client.
        /// </summary>
        /// <example>
        /// e.g. <c>CERN-LineMode/2.15 libwww/2.17b3</c>
        /// </example>
        public const string Original = $"{Prefix}.user_agent.original";
    }
}
