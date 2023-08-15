namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Enduser
    {
        public const string Prefix = "enduser";

        /// <summary>
        /// Username or client_id extracted from the access token or [Authorization](https://tools.ietf.org/html/rfc7235#section-4.2) header in the inbound request from outside the system.
        /// </summary>
        public const string Id = $"{Prefix}.id";

        /// <summary>
        /// Actual/assumed role the client is making the request under extracted from token or application security context.
        /// </summary>
        public const string Role = $"{Prefix}.role";

        /// <summary>
        /// Scopes or granted authorities the client currently possesses extracted from token or application security context. The value would come from the scope associated with an [OAuth 2.0 Access Token](https://tools.ietf.org/html/rfc6749#section-3.3) or an attribute value in a [SAML 2.0 Assertion](http://docs.oasis-open.org/security/saml/Post2.0/sstc-saml-tech-overview-2.0.html).
        /// </summary>
        public const string Scope = $"{Prefix}.scope";
    }
}
