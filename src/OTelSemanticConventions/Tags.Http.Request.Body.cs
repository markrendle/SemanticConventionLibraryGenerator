namespace NewDay.Platform.Telemetry;

public static partial class Tags
{
    public static partial class Http
    {
        public static partial class Request
        {
            public static partial class Body
            {
                public const string Prefix = "http.request.body";

                /// <summary>
                /// The size of the request payload body in bytes. This is the number of bytes transferred excluding headers and is often, but not always, present as the [Content-Length](https://www.rfc-editor.org/rfc/rfc9110.html#field.content-length) header. For requests using transport encoding, this should be the compressed size.
                /// </summary>
                public const string Size = $"{Prefix}.request.body.size";
            }
        }
    }
}
