namespace SemanticConventionLibraryGenerator.Tests;

internal static class Yamls
{
    public const string HttpCommon = @"groups:
  - id: attributes.http.common
    type: attribute_group
    brief: ""Describes HTTP attributes.""
    prefix: http
    attributes:
      - id: request.method
        type:
          allow_custom_values: true
          members:
            - id: connect
              value: ""CONNECT""
              brief: 'CONNECT method.'
            - id: delete
              value: ""DELETE""
              brief: 'DELETE method.'
            - id: get
              value: ""GET""
              brief: 'GET method.'
            - id: head
              value: ""HEAD""
              brief: 'HEAD method.'
            - id: options
              value: ""OPTIONS""
              brief: 'OPTIONS method.'
            - id: patch
              value: ""PATCH""
              brief: 'PATCH method.'
            - id: post
              value: ""POST""
              brief: 'POST method.'
            - id: put
              value: ""PUT""
              brief: 'PUT method.'
            - id: trace
              value: ""TRACE""
              brief: 'TRACE method.'
            - id: other
              value: ""_OTHER""
              brief: 'Any HTTP method that the instrumentation has no prior knowledge of.'
        requirement_level: required
        brief: 'HTTP request method.'
        examples: [""GET"", ""POST"", ""HEAD""]
        note: |
          HTTP request method value SHOULD be ""known"" to the instrumentation.
          By default, this convention defines ""known"" methods as the ones listed in [RFC9110](https://www.rfc-editor.org/rfc/rfc9110.html#name-methods)
          and the PATCH method defined in [RFC5789](https://www.rfc-editor.org/rfc/rfc5789.html).

          If the HTTP request method is not known to instrumentation, it MUST set the `http.request.method` attribute to `_OTHER` and, except if reporting a metric, MUST
          set the exact method received in the request line as value of the `http.request.method_original` attribute.

          If the HTTP instrumentation could end up converting valid HTTP request methods to `_OTHER`, then it MUST provide a way to override
          the list of known HTTP methods. If this override is done via environment variable, then the environment variable MUST be named
          OTEL_INSTRUMENTATION_HTTP_KNOWN_METHODS and support a comma-separated list of case-sensitive known HTTP methods
          (this list MUST be a full override of the default known method, it is not a list of known methods in addition to the defaults).

          HTTP method names are case-sensitive and `http.request.method` attribute value MUST match a known HTTP method name exactly.
          Instrumentations for specific web frameworks that consider HTTP methods to be case insensitive, SHOULD populate a canonical equivalent.
          Tracing instrumentations that do so, MUST also set `http.request.method_original` to the original value.
      - id: response.status_code
        type: int
        requirement_level:
          conditionally_required: If and only if one was received/sent.
        brief: '[HTTP response status code](https://tools.ietf.org/html/rfc7231#section-6).'
        examples: [200]
      - ref: network.protocol.name
        examples: ['http', 'spdy']
        requirement_level:
          recommended: if not default (`http`).
      - ref: network.protocol.version
        examples: ['1.0', '1.1', '2.0']

  - id: attributes.http.client
    prefix: http
    type: attribute_group
    brief: 'HTTP Client attributes'
    attributes:
      - ref: server.address
        requirement_level: required
        brief: >
          Host identifier of the [""URI origin""](https://www.rfc-editor.org/rfc/rfc9110.html#name-uri-origin) HTTP request is sent to.
        note: |
          Determined by using the first of the following that applies

          - Host identifier of the [request target](https://www.rfc-editor.org/rfc/rfc9110.html#target.resource)
            if it's sent in absolute-form
          - Host identifier of the `Host` header

          SHOULD NOT be set if capturing it would require an extra DNS lookup.
      - ref: server.port
        requirement_level:
          conditionally_required: If not default (`80` for `http` scheme, `443` for `https`).
        brief: >
          Port identifier of the [""URI origin""](https://www.rfc-editor.org/rfc/rfc9110.html#name-uri-origin) HTTP request is sent to.
        note: >
          When [request target](https://www.rfc-editor.org/rfc/rfc9110.html#target.resource) is absolute URI, `server.port` MUST match
          URI port identifier, otherwise it MUST match `Host` header port identifier.

  - id: attributes.http.server
    prefix: http
    type: attribute_group
    brief: 'HTTP Server attributes'
    attributes:
      - id: route
        type: string
        requirement_level:
          conditionally_required: If and only if it's available
        brief: >
            The matched route (path template in the format used by the respective server framework). See note below
        examples: ['/users/:userID?', '{controller}/{action}/{id?}']
        note: >
          MUST NOT be populated when this is not supported by the HTTP server framework as the route attribute should have low-cardinality and the URI path can NOT substitute it.

          SHOULD include the [application root](/docs/http/http-spans.md#http-server-definitions) if there is one.
      - ref: server.address
        brief: >
          Name of the local HTTP server that received the request.
        note: |
          Determined by using the first of the following that applies

          - The [primary server name](/docs/http/http-spans.md#http-server-definitions) of the matched virtual host. MUST only
            include host identifier.
          - Host identifier of the [request target](https://www.rfc-editor.org/rfc/rfc9110.html#target.resource)
            if it's sent in absolute-form.
          - Host identifier of the `Host` header

          SHOULD NOT be set if only IP address is available and capturing name would require a reverse DNS lookup.

      - ref: server.port
        brief: >
          Port of the local HTTP server that received the request.
        note: |
          Determined by using the first of the following that applies

          - Port identifier of the [primary server host](/docs/http/http-spans.md#http-server-definitions) of the matched virtual host.
          - Port identifier of the [request target](https://www.rfc-editor.org/rfc/rfc9110.html#target.resource)
            if it's sent in absolute-form.
          - Port identifier of the `Host` header
      - ref: url.scheme
        requirement_level: required
        examples: [""http"", ""https""]";
}